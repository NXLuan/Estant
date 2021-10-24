using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Core.Mappings
{
    public static class GrammarMapping
    {
        public static List<GrammarViewModel> ConvertToGrammarView(this string json)
        {
            List<GrammarViewModel> data = new List<GrammarViewModel>();

            JArray arrJson = JArray.Parse(json);
            foreach (var objJson in arrJson)
            {
                var viewModel = objJson.ToObject<GrammarViewModel>();
                if (viewModel != null)
                    data.Add(viewModel);
            }

            return data;
        }

        public static List<SpellAndGrammarViewModel> DeserializeSpellAndGrammar(this string json)
        {
            var data = new List<SpellAndGrammarViewModel>();
            JObject objJson = JObject.Parse(json);
            if (objJson != null)
            {
                var arrMatch = JArray.Parse(objJson["matches"].ToString());
                if (arrMatch != null && arrMatch.Count > 0)
                {

                    foreach (var match in arrMatch)
                    { 
                        var viewmodel = new SpellAndGrammarViewModel()
                        {
                            message = match["message"].ToString(),
                            replacement = match["replacements"][0]["value"].ToString(),
                            offset = int.Parse(match["offset"].ToString()),
                            length = int.Parse(match["length"].ToString())
                        };

                        data.Add(viewmodel);
                    }
                }
            }

            return data;
        }
        // public static List<GrammarViewModel> ConvertToGrammarView(this string json)
        // {
        //     List<GrammarViewModel> data = new List<GrammarViewModel>();
        //     JArray arrSection = JArray.Parse(json);
        //     foreach (var objSection in arrSection)
        //     {
        //         #region handle convert
        //         var grammar = objSection.ToObject<Dictionary<string, object>>();

        //         GrammarViewModel viewModel = new GrammarViewModel()
        //         {
        //             id = int.Parse(grammar["id"].ToString()),
        //             section = grammar["section"].ToString()
        //         };

        //         var arrLesson = grammar["lessons"] as JArray;
        //         switch (viewModel.id)
        //         {
        //             case (int)Section.Tenses:
        //                 foreach (var objLesson in arrLesson)
        //                 {
        //                     viewModel.lessions.Add(objLesson.ToObject<Tenses>());
        //                 }
        //                 break;
        //             case (int)Section.BasicGrammar:
        //                 foreach (var objLesson in arrLesson)
        //                 {
        //                     viewModel.lessions.Add(objLesson.ConvertToBasicGrammar());
        //                 }
        //                 break;

        //         }

        //         #endregion

        //         data.Add(viewModel);
        //     }

        //     return data;
        // }

        // public static Lesson ConvertToBasicGrammar(this JToken jToken)
        // {
        //     Lesson basicGrammar = null;
        //     var lesson = jToken.ToObject<Lesson>();
        //     switch (lesson.type)
        //     {
        //         case (int)LessonBasicGrammar.IrregularVerb:
        //             basicGrammar = jToken.ToObject<IrregularVerb>();
        //             break;
        //         case (int)LessonBasicGrammar.ModalVerb:
        //             basicGrammar = jToken.ToObject<ModalVerb>();
        //             break;
        //     }

        //     return basicGrammar;
        // }
    }
}
