using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_1_v2
{
    public class History
    {
        private List<KeyValuePair<KeyValuePair<double, int>, KeyValuePair<double, int>>> HistoryList;

        public void AddCalculation(double input, int inputSystem, double output, int outputSystem)
        {
            if(HistoryList == null)
            {
                HistoryList = new List<KeyValuePair<KeyValuePair<double, int>, KeyValuePair<double, int>>>();
            }

            KeyValuePair<double, int> historyInput = new KeyValuePair<double, int>(input, inputSystem);
            KeyValuePair<double, int> historyOutput = new KeyValuePair<double, int>(output, outputSystem);

            HistoryList.Add(new KeyValuePair<KeyValuePair<double, int>, KeyValuePair<double, int>>(historyInput, historyOutput));
        }

        public string GetAllHistory()
        {
            string result = "";
            foreach(var item in HistoryList)
            {
                result += item.Key.Key + "\t" + item.Key.Value + "\t" + item.Value.Key + "\t" + item.Value.Value + "\n";
            }
            return result;
        }
    }
}
