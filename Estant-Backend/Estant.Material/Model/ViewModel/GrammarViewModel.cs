using Estant.Material.Model.EnumModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.ViewModel
{
    public class GrammarViewModel
    {
        public string title { get; set; }
        public List<Lesson> lessons { get; set; }
        public class Lesson
        {
            public string name { get; set; }
            public string html { get; set; }
        }
    }
    // public class GrammarViewModel
    // {
    //     public int id { get; set; }
    //     public string section { get; set; }
    //     public List<object> lessions { get; set; }

    //     public GrammarViewModel()
    //     {
    //         lessions = new List<object>();
    //     }
    // }

    // public class Lesson
    // {
    //     public int type { get; set; }
    //     public string name { get; set; }
    // }

    // #region Tenses in English
    // public class Tenses : Lesson
    // {
    //     public List <Form> form { get; set; }
    //     public string signalWords { get; set; }

    //     public class Form
    //     {
    //         public string title { get; set; }
    //         public List<Content> contents { get; set; }

    //         public class Content
    //         {
    //             public string content { get; set; }
    //             public string example { get; set; }
    //         }
    //     }
    // }
    // #endregion

    // #region Basic English grammar
    // public class IrregularVerb : Lesson
    // {
    //     public List<Content> contents { get; set; }

    //     public class Content
    //     {
    //         public string title { get; set; }
    //         public List<Verb> verbs { get; set; }
    //         public class Verb
    //         {
    //             public string Base { get; set; }
    //             public string PastSimple { get; set; }
    //             public string PastParticiple { get; set; }
    //         }
    //     }
    // }

    // public class ModalVerb : Lesson
    // {
    //     public string description { get; set; }
    //     public List<Verb> verbs { get; set; }

    //     public class Verb
    //     {
    //         public string verb { get; set; }
    //         public List<Usage> usages { get; set; }

    //         public class Usage
    //         {
    //             public string usage { get; set; }
    //             public string example { get; set; }
    //         }
    //     }
    // }
    // #endregion
}
