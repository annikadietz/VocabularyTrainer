using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    class StatsLoader : LoaderInterface
    {
        private Dictionary<string, List<String>> statistics;

        public StatsLoader ()
        {
            statistics = new Dictionary<string, List<string>>();
        }
        public Dictionary<string, string> getData()
        {
            throw new NotImplementedException();
        }

        public void loadAllDataFromDirectionary(string directionary)
        {
            foreach (String file in Directory.EnumerateFiles(directionary, "*.txt"))
            {
                loadDataFromFile(file);
            }
        }

        public void loadDataFromFile(string location)
        {
            handleStatisticFileString(File.ReadAllText(location));
        }

        private void handleStatisticFileString(String fileData)
        {

        }
    }
}
