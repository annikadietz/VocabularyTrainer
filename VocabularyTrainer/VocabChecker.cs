using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    class VocabChecker
    {
        List<Vocabulary> vocabList;
        private VocabLoader loader;
        private List<String> currentWords;
        private List<String> currentAnswers;
        private Random rnd;

        public VocabChecker()
        {
            vocabList = new List<Vocabulary>();
            currentWords = new List<String>();
            currentAnswers = new List<String>();
            rnd = new Random();
            loader = new VocabLoader();
            loader.loadAllDataFromDirectionary("vocabs/allEverLearned");
            loader.loadAllDataFromDirectionary("vocabs");
            vocabList = loader.getData();
            getNextWord();
        }

        internal List<String> getCurrentWord()
        {
            return currentWords;
        }

        internal void saveVocabulary()
        {
            List<String> vocabStringLines = new List<string>();
            foreach (Vocabulary vocab in vocabList)
            {
                vocabStringLines.Add(vocab.dutch.Trim() + " - " + vocab.german.Trim() + " - " + vocab.correct + " - " + vocab.wrong);
            }
            

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"vocabs\allEverLearned\allVocabs.txt"))
            {
                foreach (string line in vocabStringLines)
                {
                    file.WriteLine(line);
                }
            }
        }

        internal int getAmountTotalWrong()
        {
            int sum = 0;
            foreach (Vocabulary vocab in vocabList)
            {
                sum += vocab.wrong;
            }
            return sum;
        }

        internal int getAmountTotalCorrect()
        {
            int sum = 0;
            foreach (Vocabulary vocab in vocabList)
            {
                sum += vocab.correct;
            }
            return sum;
        }

        internal int getAmountWords()
        {
            return vocabList.Count;
        }

        internal int getAmountCurrentKnowing()
        {
            int sum = 0;
            foreach(Vocabulary vocab in vocabList)
            {
                if(vocab.correct > vocab.wrong)
                {
                    sum++;
                }
            }
            return sum;
        }

        internal List<String> getAnswers()
        {
            return currentAnswers;
        }

        internal bool check(string question, String answer)
        {
            foreach(Vocabulary vocab in vocabList)
            {
                if (vocab.german.Trim().Equals(question.Trim()))
                {
                    if (vocab.dutch.Trim().Split(',').Contains(answer.Trim()))
                    {
                        vocab.correct++;
                        return true;
                    }
                    else
                    {
                        vocab.wrong++;
                        return false;
                    }
                }
            }
            return false;
            
        }

        internal void getNextWord()
        {
            currentWords.Clear();
            currentAnswers.Clear();
            int randomIndex = rnd.Next(0, vocabList.Count - 1);
            Vocabulary vocab = vocabList.ElementAt(randomIndex);
            while((vocab.correct > getAverageCorrect() && vocab.wrong < getAverrageWrong()))
            {
                randomIndex = rnd.Next(0, vocabList.Count - 1);
                vocab = vocabList.ElementAt(randomIndex);
            }
            foreach(String dWord in vocab.dutch.Split(','))
            {
                currentAnswers.Add(dWord.Trim());
            }
            foreach(String gWord in vocab.german.Split(','))
            {
                currentWords.Add(gWord.Trim());
            }
        }

        private int getAverrageWrong()
        {
            int amount = vocabList.Count;
            int sum = 0;
            foreach (Vocabulary vocab in vocabList)
            {
                sum += vocab.wrong;
            }
            return (int)(sum / amount);
        }

        private int getAverageCorrect()
        {
            int amount = vocabList.Count;
            int sum = 0;
            foreach(Vocabulary vocab in vocabList)
            {
                sum += vocab.correct;
            }
            return (int)(sum / amount);
        }
    }
}
