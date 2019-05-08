using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    interface CheckerInterface
    {
        Boolean checkVocabulary(String answerUser, String correctAnswer);
    }
}
