using Estant.View.Extensions;
using EstantNF.Core.Handlers;
using EstantWF.Material.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.FormUI.VocabularyUI
{
    public partial class PracticeForm : Form
    {
        List<Exercise> lstExercise;
        string topic;
        int currentIndex;
        bool isFinish;
        bool isGrammar;
        public PracticeForm(string _topic, bool _isGrammar = false)
        {
            InitializeComponent();
            topic = _topic;
            currentIndex = 0;
            isGrammar = _isGrammar;
            LoadDataExercise();
            pbPrevQuestion.Visible = false;
            lblQuestionCount.TextAlign = ContentAlignment.TopLeft;
            isFinish = false;
        }
        private async void LoadDataExercise()
        {
            Loading.Show(); // show load

            if (!isGrammar)
            {
                lstExercise = await ExerciseHandler.GetExerciseByTopic(topic);
            }
            else
            {
                lstExercise = await ExerciseHandler.GetExerciseByGrammar(topic);
            }
            //
            Loading.End(); // end load
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            lblQuestionCount.Text = "Question " + (currentIndex + 1).ToString() + "/10";
            lblQuestion.Text = lstExercise[currentIndex].question;
            switch (lstExercise[currentIndex].type)
            {
                case 1:
                case 6:
                    ShowFillInBlank();
                    break;
                case 2:
                case 3:
                case 5:
                    ShowMultipleChoice();
                    break;
                case 4:
                    ShowAudioTest();
                    break;
            }
        }
        private void ShowFillInBlank()
        {
            pnMissingWord.Location = new Point(17, 125);
            pnListenTest.Visible = false;
            pnMultipleChoice.Visible = false;
            pnMissingWord.Visible = true;
            pnResult.Visible = false;
            if (lstExercise[currentIndex].type == 1)
            {
                lblMissingWord.Text = String.Join(" ", lstExercise[currentIndex].missingWord.ToCharArray());
                lblMissingWord.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            }
            else
            {
                lblMissingWord.Text = lstExercise[currentIndex].sentence;
                lblMissingWord.Font = new Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            }
            lblMWAnswer.Text = lstExercise[currentIndex].correctAnswer;
            lblMWDefinition.Text = lstExercise[currentIndex].definition;
            
            lblMWAnswer.Visible = isFinish;
            txtMWAnswer.Enabled = !isFinish;

            txtMWAnswer.Text = isFinish ? lstExercise[currentIndex].userAnswer : "";

        }

        private void ShowAudioTest()
        {
            pnListenTest.Location = new Point(17, 125);
            pnListenTest.Visible = true;
            pnMultipleChoice.Visible = false;
            pnMissingWord.Visible = false;
            pnResult.Visible = false;

            lblLTAnswer.Text = lstExercise[currentIndex].correctAnswer;

            lblLTAnswer.Visible = isFinish;

            txtLTAnswer.Text = isFinish ? lstExercise[currentIndex].userAnswer : "";
            txtLTAnswer.Enabled = !isFinish;
        }
        private void ShowMultipleChoice()
        {
            pnMultipleChoice.Location = new Point(17, 125);
            pnListenTest.Visible = false;
            pnMultipleChoice.Visible = true;
            pnMissingWord.Visible = false;
            pnResult.Visible = false;
            SetFontSize(lstExercise[currentIndex].type);
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = false;
            for(int i = 0; i < lstExercise[currentIndex].choices.Count; i++)
            { 
                switch(i)
                {
                    case 0:
                        btnA.Text = lstExercise[currentIndex].choices[0];
                        btnA.Visible = true;
                        break;
                    case 1:
                        btnB.Text = lstExercise[currentIndex].choices[1];
                        btnB.Visible = true;
                        break;
                    case 2:
                        btnC.Text = lstExercise[currentIndex].choices[2];
                        btnC.Visible = true;
                        break;
                    case 3:
                        btnD.Text = lstExercise[currentIndex].choices[3];
                        btnD.Visible = true;
                        break;
                }
            }
            //btnA.Text = lstExercise[currentIndex].choices[0];
            //btnB.Text = lstExercise[currentIndex].choices[1];
            //btnC.Text = lstExercise[currentIndex].choices[2];
            //btnD.Text = lstExercise[currentIndex].choices[3];

            btnA.BackColor = btnB.BackColor = btnC.BackColor = btnD.BackColor = Color.LightSalmon;

            if (isFinish)
            {
                btnA.BackColor = btnB.BackColor = btnC.BackColor = btnD.BackColor = Color.LightSalmon;
                switch (Convert.ToInt32(lstExercise[currentIndex].correctAnswer))
                {
                    case 0:
                        btnA.BackColor = Color.Green;
                        break;
                    case 1:
                        btnB.BackColor = Color.Green;
                        break;
                    case 2:
                        btnC.BackColor = Color.Green;
                        break;
                    case 3:
                        btnD.BackColor = Color.Green;
                        break;
                }
                if (lstExercise[currentIndex].userAnswer != null && lstExercise[currentIndex].userAnswer != lstExercise[currentIndex].correctAnswer)
                {
                    switch (Convert.ToInt32(lstExercise[currentIndex].userAnswer))
                    {
                        case 0:
                            btnA.BackColor = Color.Red;
                            break;
                        case 1:
                            btnB.BackColor = Color.Red;
                            break;
                        case 2:
                            btnC.BackColor = Color.Red;
                            break;
                        case 3:
                            btnD.BackColor = Color.Red;
                            break;
                    }
                }
            }
        }
        private void ShowResult()
        {
            pnResult.Location = new Point(17, 125);
            pnListenTest.Visible = false;
            pnMultipleChoice.Visible = false;
            pnMissingWord.Visible = false;
            pnResult.Visible = true;

            int totalCorrect = 0;

            for (int i = 0; i < 10; i++)
            {
                bool isCorrect = lstExercise[i].userAnswer == lstExercise[i].correctAnswer;
                if (isCorrect)
                {
                    totalCorrect++;            
                }
                switch (i)
                {
                    case 0:
                        lbl1.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 1:
                        lbl2.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 2:
                        lbl3.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 3:
                        lbl4.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 4:
                        lbl5.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 5:
                        lbl6.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 6:
                        lbl7.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 7:
                        lbl8.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 8:
                        lbl9.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;
                    case 9:
                        lbl10.BackColor = isCorrect ? Color.Green : Color.Red;
                        break;

                }
            }
            lblQuestionCount.Text = "Result";
            lblQuestion.Text = "Your score is " + totalCorrect.ToString() + "/10";
        }

        private void SetFontSize(int type)
        {
            if (type == 2 || type == 5)
            {
                btnA.Font = btnB.Font = btnC.Font = btnD.Font = new Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
                lblMCQuestion.Font = new Font("Segoe UI", 13F);
                lblMCQuestion.ForeColor = Color.Black;
                lblMCQuestion.Text = type == 2 ? lstExercise[currentIndex].example : lstExercise[currentIndex].sentence;
            }
            else if (type == 3)
            {
                btnA.Font = btnB.Font = btnC.Font = btnD.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                lblMCQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
                lblMCQuestion.ForeColor = Color.FromArgb(3, 71, 173);
                lblMCQuestion.Text = lstExercise[currentIndex].word;
            }
        }


        private void pbNextQuestion_Click(object sender, EventArgs e)
        {
            if (currentIndex < 9)
            {
                currentIndex++;
                ShowQuestion();
            }
            else
            {
                if (!isFinish)
                {
                    ShowResult();
                    isFinish = true;
                }
                else
                {
                    pbPrevQuestion.Visible = true;
                    lblQuestionCount.TextAlign = ContentAlignment.TopCenter;
                    currentIndex = 0;
                    ShowQuestion();
                }
            }
        }

        private void pbAudio_Click(object sender, EventArgs e)
        {
            MediaExtension.PlayMP3ByURL(lstExercise[currentIndex].audio);
        }
        #region Save User answer
        private void txtMWAnswer_TextChanged(object sender, EventArgs e)
        {
            lstExercise[currentIndex].userAnswer = txtMWAnswer.Text;
        }

        private void txtLTAnswer_TextChanged(object sender, EventArgs e)
        {
            lstExercise[currentIndex].userAnswer = txtLTAnswer.Text;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (isFinish) return;
            btnA.BackColor = btnB.BackColor = btnC.BackColor = btnD.BackColor = Color.LightSalmon;
            btnA.BackColor = Color.FromArgb(245, 106, 77);
            lstExercise[currentIndex].userAnswer = "0";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (isFinish) return;
            btnA.BackColor = btnB.BackColor = btnC.BackColor = btnD.BackColor = Color.LightSalmon;
            btnB.BackColor = Color.FromArgb(245, 106, 77);
            lstExercise[currentIndex].userAnswer = "1";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (isFinish) return;
            btnA.BackColor = btnB.BackColor = btnC.BackColor = btnD.BackColor = Color.LightSalmon;
            btnC.BackColor = Color.FromArgb(245, 106, 77);
            lstExercise[currentIndex].userAnswer = "2";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (isFinish) return;
            btnA.BackColor = btnB.BackColor = btnC.BackColor = btnD.BackColor = Color.LightSalmon;
            btnD.BackColor = Color.FromArgb(245, 106, 77);
            lstExercise[currentIndex].userAnswer = "3";
        }
        #endregion

        private void pbPrevQuestion_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = 9;
            ShowQuestion();
        }

        private void btnShareFaceBook_UserClick(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(MainForm.Instance.Size.Width, MainForm.Instance.Size.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(MainForm.Instance.Location.X + 30, MainForm.Instance.Location.Y + 30, 0, 0, bitmap.Size);
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(dialog.FileName, ImageFormat.Png);
                VocabularyForm.Instance.ShowNewTab(VocabForm.FACEBOOKSHARE, "Share Facebook");
            }
        }
    }
}
