using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public enum ScreenForm
    {
        VOCABULARY, GRAMMAR, NEWS, ACCOUNT, LISTEN
    }

    public enum VocabForm
    {
        TOPIC = 1, WORD = 2, FLASHCARD = 3, PRACTICE = 4,
    }

    public enum GrammarPageForm
    {
        LESSON = 1, PRACTICE = 2,
    }
    public enum NewsPageForm
    {
        ARTICLE = 1
    }

    public enum AuthPageForm
    {
        SIGNIN = 0, SIGNUP = 1, FORGOTPASSWORD = 2
    }

    public enum ListenPageForm
    {
        PODCAST = 1
    }
}
