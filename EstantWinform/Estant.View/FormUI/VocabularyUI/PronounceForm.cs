using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estant.View.Extensions;
using EstantNF.Core.Handlers;
using EstantWF.Material.Model;
using NAudio.Wave;

namespace Estant.View.FormUI.VocabularyUI
{
    public partial class PronounceForm : Form
    {
        private enum RecordState { START, STOP, PLAY }

        private RecordState currentRecordState;
        private Vocabulary vocabulary;
        private WaveFileWriter writer;
        private WaveInEvent waveIn;
        private bool isRecorded;
        private SoundPlayer yourRecord;
        private Timer timer;
        public PronounceForm(Vocabulary vocabularyParam)
        {
            InitializeComponent();
            vocabulary = vocabularyParam;
            InitHandle();
            EventHandle();
        }

        private void InitHandle()
        {
            yourRecord = new SoundPlayer("record.wav");
            timer = new Timer();
            timer.Interval = 3000;
            waveIn = new WaveInEvent();
            lbWord.Text = vocabulary.word;
            SetRecordState(RecordState.START);
        }

        private void EventHandle()
        {
            waveIn.DataAvailable += (s, a) =>
            {
                writer.Write(a.Buffer, 0, a.BytesRecorded);
                if (writer.Position > waveIn.WaveFormat.AverageBytesPerSecond * 2)
                {
                    Stop();
                }
            };

            waveIn.RecordingStopped += (s, a) =>
            {
                writer?.Dispose();
                writer = null;
                PronunciationAssessmentResult();
                waveIn.Dispose();
            };

            timer.Tick += (s, e) =>
            {
                Stop();
                timer.Dispose();
            };
        }

        private void SetRecordState(RecordState state)
        {
            currentRecordState = state;
            switch (state)
            {
                case RecordState.START:
                    pbRecord.Image = global::Estant.View.Properties.Resources.voice;
                    break;
                case RecordState.STOP:
                    pbRecord.Image = global::Estant.View.Properties.Resources.stop_button;
                    break;
                case RecordState.PLAY:
                    pbRecord.Image = global::Estant.View.Properties.Resources.play;
                    break;
            }
        }

        public void StartRecord()
        {
            var outputFilePath = "record.wav";
            writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
            waveIn.StartRecording();
            SetRecordState(RecordState.STOP);
        }

        public void Stop()
        {
            if (isRecorded == false)
            {
                isRecorded = true;
                waveIn.StopRecording();
            }
            else
            {
                timer.Enabled = false;
                yourRecord.Stop();
                yourRecord.Dispose();
            }
            SetRecordState(RecordState.PLAY);
        }

        public async void PronunciationAssessmentResult()
        {
            Loading.ShowPopup();

            Byte[] bytes = File.ReadAllBytes("record.wav");
            var data = Convert.ToBase64String(bytes);
            var response = await VocabularyHandler.PronunciationAssessment(data, "wav", vocabulary.word);

            if (response.IsSuccess())
            {
                var result = response.data;
                lbScore.Text = result.score.ToString();

                lbUS.Text = result.accent_predictions.en_US.ToString() + "%";
                lbUK.Text = result.accent_predictions.en_UK.ToString() + "%";
                lbAU.Text = result.accent_predictions.en_AU.ToString() + "%";

                lbIeltes.Text = result.score_estimates.ielts;
                lbToefl.Text = result.score_estimates.toefl;
                lbCefr.Text = result.score_estimates.cefr;
                lbPte.Text = result.score_estimates.pte_general;

                Loading.EndPopup();
            }
            else
            {
                Loading.EndPopup();
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo");
            }
        }

        public void PlayRecord()
        {
            yourRecord.Play();
            timer.Enabled = true;
            SetRecordState(RecordState.STOP);
        }

        private void pbRecord_Click(object sender, EventArgs e)
        {
            switch (currentRecordState)
            {
                case RecordState.START:
                    StartRecord();
                    break;
                case RecordState.STOP:
                    Stop();
                    break;
                case RecordState.PLAY:
                    PlayRecord();
                    break;
            }
        }

        private void pbVolume_Click(object sender, EventArgs e)
        {
            MediaExtension.PlayMP3ByURL(vocabulary.audio);
        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            SetRecordState(RecordState.START);
            isRecorded = false;
        }
    }
}
