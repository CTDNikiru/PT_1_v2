using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_1_v2
{
    public class History
    {
        private List<KeyValuePair<KeyValuePair<string, string>, KeyValuePair<string, string>>> HistoryList;

        public void AddCalculation(string input, string inputSystem, string output, string outputSystem)
        {
            if(HistoryList == null)
            {
                HistoryList = new List<KeyValuePair<KeyValuePair<string, string>, KeyValuePair<string, string>>>();
            }

            KeyValuePair<string, string> historyInput = new KeyValuePair<string, string>(input, inputSystem);
            KeyValuePair<string, string> historyOutput = new KeyValuePair<string, string>(output, outputSystem);

            HistoryList.Add(new KeyValuePair<KeyValuePair<string, string>, KeyValuePair<string, string>>(historyInput, historyOutput));
        }

        public string GetAllInput()
        {
            string result = "";
            if (HistoryList != null)
            {
                foreach (var item in HistoryList)
                {
                    result += item.Key.Key + "\n";
                }
            }
            return result;
        }

        public string GetAllInputCC()
        {
            string result = "";
            if (HistoryList != null)
            {
                foreach (var item in HistoryList)
                {
                    result += item.Key.Value + "\n";
                }
            }
            return result;
        }

        public string GetAllOut()
        {
            string result = "";
            if (HistoryList != null)
            {
                foreach (var item in HistoryList)
                {
                    result += item.Value.Key + "\n";
                }
            }
            return result;
        }

        public string GetAllOutCC()
        {
            string result = "";
            if (HistoryList != null)
            {
                foreach (var item in HistoryList)
                {
                    result += item.Value.Value + "\n";
                }
            }
            return result;
        }
    }
}
