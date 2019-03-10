using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_hw1
{
    class MistakeSeeker
    {
        public int[] GetConvertedNumbers(string NumbersSumple, int mode)
        {
            if (mode > 0 && NumbersSumple.Length % mode == 0)
            {
                int[] result = new int[NumbersSumple.Length / mode];
                string[] tmp = new string[NumbersSumple.Length / mode];
                int k = 0;
                for (int i = 0; i < NumbersSumple.Length / mode; i++)
                {
                    int counter = 0;
                    while(counter < mode)
                    {
                        tmp[i] += NumbersSumple[k];
                        k++;
                        counter++;
                    }
                    result[i] = Convert.ToInt32(tmp[i]);
                }
                return result;
            }
            else
            {
                return null;
            }
        }

        public string FindSequenceError(string NumbersSumple, int mode)
        {
                int[] ConvertedNumbers = GetConvertedNumbers(NumbersSumple, mode);
                List<int> NumberResidual = new List<int>();
                List<int> ListOfCountingErroros = new List<int>();
                if (ConvertedNumbers != null)
                {
                    for (int i = 0; i < ConvertedNumbers.Length && i + 1 < ConvertedNumbers.Length; i++)
                    {
                        NumberResidual.Add(Math.Abs(ConvertedNumbers[i] - ConvertedNumbers[i + 1]));
                    }

                    for (int i = 0; i < NumberResidual.Count && i + 1 < NumberResidual.Count; i++)
                    {
                        if (NumberResidual[i] != NumberResidual[i + 1])
                        {
                            ListOfCountingErroros.Add(1);
                        }
                        else
                        {
                            ListOfCountingErroros.Add(0);
                        }
                    }

                        int errorCounter = 0;
                        int errorIndex = 0;
                        foreach (int c in ListOfCountingErroros)
                        {
                            if (c == 1)
                            {
                                errorCounter++;
                            }

                            if (errorCounter > 1)
                            {
                                return "Found more than 1 error";
                            }

                            if (errorCounter == 0)
                            {
                                errorIndex++;
                            }
                        }

                        if (errorCounter == 1)
                        {
                            string res = "Error found betwin " + ConvertedNumbers[errorIndex] + " and " + ConvertedNumbers[errorIndex + 1] + " True result:" + (ConvertedNumbers[errorIndex] + NumberResidual[errorIndex + 1]);
                            return res;
                        }

                        if (errorCounter == 0)
                        {
                            return "No errors found";
                        }

                        if (mode == NumbersSumple.Length)
                        {
                            return "No errors found";
                        }
                    
                   
                }
                else
                {
                return "Cannot find the answer on this mode";
                }
            

            return "No errors found";
        }
    }
}
