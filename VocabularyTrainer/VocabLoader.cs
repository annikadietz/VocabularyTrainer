using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    class VocabLoader : LoaderInterface
    {
        private List<Vocabulary> vocabs;
        

        public VocabLoader()
        {
            vocabs = new List<Vocabulary>();
        }

        public List<Vocabulary> getData()
        {
            return vocabs;
        }

        public void loadAllDataFromDirectionary(string directionary)
        {
            foreach(String file in Directory.EnumerateFiles(directionary, "*.txt"))
            {
                loadDataFromFile(file);
            }
        }

        public void loadDataFromFile(string location)
        {
            handleVocabFileString(File.ReadAllText(location));
        }

        private void handleVocabFileString(String text)
        {
            using (StringReader reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    String[] splitted = line.Split('-');
                    String dutchWord;
                    String germanWord;
                    int correct = 0;
                    int wrong = 0;
                    try
                    {
                        dutchWord = splitted[0];
                        germanWord = splitted[1];
                    }
                    catch
                    {
                        germanWord = "-";
                        dutchWord = "-";
                    }

                    try
                    {
                        int.TryParse(splitted[2], out correct);
                        int.TryParse(splitted[3], out wrong);
                    }
                    catch { }

                    if(!wordOnList(dutchWord.Trim(), germanWord.Trim()) && !dutchWord.Trim().Equals("") && !germanWord.Trim().Equals(""))
                    {
                        Vocabulary vocab = new Vocabulary(dutchWord, germanWord, correct, wrong);
                        vocabs.Add(vocab);
                    }
                    
                }
            }
        }

        private Boolean wordOnList(String dutchWord, String germanWord)
        {
            foreach(Vocabulary vocab in vocabs)
            {
                if(vocab.dutch.Trim().Equals(dutchWord) && vocab.german.Trim().Equals(germanWord))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
