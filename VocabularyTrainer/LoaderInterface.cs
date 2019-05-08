using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    interface LoaderInterface
    {
        void loadAllDataFromDirectionary(String directionary);

        void loadDataFromFile(String location);

        //List<T> getData();



    }
}
