using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_1
{
    class SyllableMaker
    {

        private static  char[] liters = { 'у', 'е', 'ё', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю' };
        private static  char spase = ' ';

        public static string MakeSyllable(string sumple)
        {
            for (int i = 0; i < sumple.Length; i++)
            {
                bool check = false;
                if (CharCheck(sumple[i], liters) == true)
                {
                    check = true;
                }

                if (sumple[i] == spase)
                {
                    check = false;
                }

                if(i + 1 < sumple.Length)
                {
                    if(CharCheck(sumple[i +1],liters) == true && check == true && sumple[i] != '-' && sumple[i + 1] != '-' && sumple[i] != ' ')
                    {
                            sumple = sumple.Insert(i + 1, "-");
                    }
                    if (i + 2 < sumple.Length)
                    {

                        if (CharCheck(sumple[i + 1], liters) == false && check == true && CharCheck(sumple[i + 2], liters) == true && sumple[i + 1] != '-' && sumple[i + 2] != '-' && sumple[i] != '-' && sumple[i + 1] != ' ' && sumple[i + 2] != ' ' && sumple[i] != ' ')
                        {
                            sumple = sumple.Insert(i + 1, "-");
                        }

                        if (CharCheck(sumple[i + 1], liters) == false && check == true && CharCheck(sumple[i + 2], liters) == true && sumple[i + 1] != '-' && sumple[i + 2] != '-' && sumple[i] != '-' && i + 3 < sumple.Length && sumple[i + 1] != ' ' && sumple[i + 2] != ' ' && sumple[i] != ' ')
                        {
                            sumple = sumple.Insert(i + 2, "-");
                        }

                    }

                    if(i + 3 < sumple.Length)
                    {
                        if (CharCheck(sumple[i + 1], liters) == false && check == true && CharCheck(sumple[i + 2], liters) == false && sumple[i + 1] != '-' && sumple[i + 2] != '-' && sumple[i] != '-' && CharCheck(sumple[i + 3], liters) == true && sumple[i + 1] != ' ' && sumple[i + 2] != ' ' && sumple[i] != ' ')
                        {
                            sumple = sumple.Insert(i + 2, "-");
                        }
                    }


                }

            }
            return sumple;
        }

        public static bool CharCheck(char sump, char[] lit)
        {
            bool res = false;
            for (int i = 0; i < lit.Count(); i++)
            {
                if (sump == lit[i])
                {
                    if (sump != ' ' && sump != '-')
                    {
                        res = true;
                        return res;
                    }
                }
            }
            return res;
        }
    }
}
