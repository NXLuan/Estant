﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.FormUI.VocabularyUI
{
    public partial class VocabularyForm : Form
    {
        public VocabularyForm()
        {
            InitializeComponent();
            stNavigate.AddTab("Vocabulary");
        }
    }
}
