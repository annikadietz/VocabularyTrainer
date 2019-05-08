using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    class VocabTrainerProgram
    {
        private VocabChecker vocabChecker;
        private StatsChecker statsChecker;
        private int correctThisTime;
        private int wrongThisTime;

        public VocabTrainerProgram()
        {
            vocabChecker = new VocabChecker();
            statsChecker = new StatsChecker();
        }
        
        public Boolean checkVocabulary(String question, String answer)
        {
            Boolean isCorrect = vocabChecker.check(question, answer);
            if(isCorrect)
            {
                correctThisTime++;
            }
            else
            {
                wrongThisTime++;
            }
            return isCorrect;
        }

        public List<String> getAnswers()
        {
            return vocabChecker.getAnswers();
        }

        public List<String> getVocab()
        {
            return vocabChecker.getCurrentWord();
        }

        public void newWord()
        {
            vocabChecker.getNextWord();
        }

        internal void endProgram()
        {
            vocabChecker.saveVocabulary();
        }

        internal void updateStatistics()
        {

        }

        internal int getTotalCorrect()
        {
            return vocabChecker.getAmountTotalCorrect();
        }

        internal int getTotalWrong()
        {
            return vocabChecker.getAmountTotalWrong();
        }

        internal int getTotalDays()
        {
            return statsChecker.getTotalDays();
        }

        internal int getAmountCurrentKnowledge()
        {
            return vocabChecker.getAmountCurrentKnowing();
        }

        internal int getAmountWords()
        {
            return vocabChecker.getAmountWords();
        }
    }
}
