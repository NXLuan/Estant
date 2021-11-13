﻿using EstantWF.Material.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.CustomControl
{
    public partial class VocabularyItem : UserControl
    {
        public Vocabulary Vocabulary { get; set; }
        public VocabularyItem(Vocabulary vocabulary)
        {
            InitializeComponent();
            InitHandle(vocabulary);
        }

        private void InitHandle(Vocabulary vocabulary)
        {
            Vocabulary = vocabulary;
            lbWord.Text = vocabulary.word;
            lbPhonetic.Text = "/ " + vocabulary.phonetic + " /";
            lbDefinition.Text = vocabulary.meanings[0]?.definitions[0]?.definition;
        }

        private void pbVolume_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = Vocabulary.audio;
            wplayer.controls.play();
        }
    }
}
