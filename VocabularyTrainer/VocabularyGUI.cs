using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyTrainer
{
    public partial class VocabularyGUI : Form
    {
        private VocabTrainerProgram analyzer;

        public VocabularyGUI()
        {
            InitializeComponent();
            analyzer = new VocabTrainerProgram();
            setNewVocabulary(createWordString(analyzer.getVocab()));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            vocabEntered(); 
        }
        
        private void answer_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                vocabEntered();
            }
        }

        private void setNewVocabulary(String newWord)
        {
            vocabulary.Text = newWord;
        }

        private void vocabEntered()
        {
            Boolean isCorrect = analyzer.checkVocabulary(vocabulary.Text, answer.Text);
            setColors(isCorrect);
            givenAnswer.Text = answer.Text;
            answer.Text = "";
            correctAnswer.Text = createAnswerString(analyzer.getAnswers());
            correctAnswer.Text += isCorrect;
            analyzer.newWord();
            setNewVocabulary(createWordString(analyzer.getVocab()));
        }

        private void setColors(Boolean isCorrect)
        {
            if(isCorrect)
            {
                givenAnswer.ForeColor = Color.Green;
                correctAnswer.ForeColor = Color.Green;
            }
            else
            {
                givenAnswer.ForeColor = Color.Red;
                correctAnswer.ForeColor = Color.Red;
            }
        }

        private String createAnswerString(List<string> answers)
        {
            String answerString = "";
            foreach(String answer in answers)
            {
                answerString += answer + "\n";
            }
            return answerString;
        }

        private string createWordString(List<string> words)
        {
            String wordString = "";
            for(int i = 0; i < words.Count; i ++)
            {
                wordString += words.ElementAt(i);
                if (i < words.Count - 1)
                {
                    wordString += ", ";
                }
            }
            return wordString;
        }

        private void VocabularyGUI_Load(object sender, EventArgs e)
        {

        }

        private void VocabularyGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            analyzer.endProgram();
        }
        

        private void statisticsTab_Enter(object sender, EventArgs e)
        {
            analyzer.updateStatistics();
            printStatistics();
        }

        private void printStatistics()
        {
            amountCorrect.Text = analyzer.getTotalCorrect().ToString();
            amountWrong.Text = analyzer.getTotalWrong().ToString();
            amountDays.Text = analyzer.getTotalDays().ToString();
            amountWords.Text = analyzer.getAmountWords().ToString();
            
            progress.Value = analyzer.getAmountCurrentKnowledge();
            progressLabel.Text = progress.Value + "/" + progress.Maximum;
        }
    }
}
