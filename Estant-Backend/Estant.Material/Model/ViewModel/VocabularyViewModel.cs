using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.ViewModel
{
    public class TopicViewModel
    {
        public string title { get; set; }
        public List<VocabularyViewModel> vocabularies { get; set; }
        public string imageUrl { get; set; }
        public TopicViewModel()
        {
            vocabularies = new List<VocabularyViewModel>();
        }
    }
    public class VocabularyViewModel
    {
        public string word { get; set; }
        public string phonetic { get; set; }
        public string audio { get; set; }
        public List<Dictionary<string, object>> meanings { get; set; }
    }

}
