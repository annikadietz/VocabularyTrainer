using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    class Vocabulary
    {
        internal String dutch { get; set; }
        internal String german { get; set; }
        internal int correct { get; set; }
        internal int wrong { get; set; }

        public Vocabulary(String dWord, String gWord, int c, int w)
        {
            dutch = dWord;
            german = gWord;
            correct = c;
            wrong = w;
        }
    }
}
