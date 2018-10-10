using System;

namespace EPAM_TK_2
{
     class BigNumbers
     {
        public int[] NumberOne { get; private set; }
        public int[] NumberTwo { get; private set; }

        public BigNumbers(int num)
        {
            NumberOne = GetIntArray(num);
        }

        public BigNumbers(int num1, int num2)
        {
            NumberOne = GetIntArray(num1);
            NumberTwo = GetIntArray(num2);
        }

        public BigNumbers(byte num)
        {
            NumberOne = GetIntArray(num);
        }

        public BigNumbers(byte num1, byte num2)
        {
            NumberOne = GetIntArray(num1);
            NumberTwo = GetIntArray(num2);
        }

        public BigNumbers(long num)
        {
            NumberOne = GetLongArray(num);
        }

        public BigNumbers(long num1, long num2)
        {
            NumberOne = GetLongArray(num1);
            NumberTwo = GetLongArray(num2);
        }

        public BigNumbers(string num)
        {
            NumberOne = GetStringArray(num);
        }

        public BigNumbers(string num1, string num2)
        {
            NumberOne = GetStringArray(num1);
            NumberTwo = GetStringArray(num2);
        }

        public BigNumbers(BigNumbers num)
        {
            NumberOne = num.NumberOne;
        }

        public BigNumbers(BigNumbers num1, BigNumbers num2)
        {
            NumberOne = num1.NumberOne;
            NumberTwo = num2.NumberTwo;
        }

        public int[] GetMult()
        {
            return ArrayMultion(NumberOne, NumberTwo);
        }

        public int[] GetSum()
        {
            return ArrayIntSum(NumberOne, NumberTwo);
        }

        public int[] GetDiff()
        {
            return ArrayIntDiff(NumberOne, NumberTwo);
        }

        public static int[] GetIntArray(int n)
        {
                string nConv = Convert.ToString(n);

                int[] Conv = new int[nConv.Length];

                for (int i = 0; i < Conv.Length; i++)
                {
                    Conv[i] = (int)Char.GetNumericValue(nConv[i]);
                }

                return Conv;
        }

        public static int[] GetLongArray(long n)
        {
            string nConv = Convert.ToString(n);

            int[] Conv = new int[nConv.Length];

            for (int i = 0; i < Conv.Length; i++)
            {
                Conv[i] = (int)Char.GetNumericValue(nConv[i]);
            }

            return Conv;
        }

        public static int[] GetStringArray(string n)
        {
            string nConv = n;

            int[] Conv = new int[nConv.Length];

            for (int i = 0; i < Conv.Length; i++)
            {
                Conv[i] = (int)Char.GetNumericValue(nConv[i]);
            }

            return Conv;
        }

        public static int[] ArrayNumMult(int[] arr, int n)
        {
                int tmp = 0;
                int[] helper = ArrayIntMod(arr);
                for (int i = helper.Length - 1; i >= 0; i--)
                {
                    int mult = (helper[i] * n) + tmp;
                    tmp = mult / 10;
                    helper[i] = mult % 10;
                }
                return helper;
        }

        public static int[] ArrayMultion(int[] arr1, int[] arr2)
        {
            bool g1 = GetIntSign(arr1);
            bool g2 = GetIntSign(arr2);
            if (GetIntSign(arr1) == true && GetIntSign(arr2) == true)
            {
                arr1 = ArrayIntMod(UnSignInt(arr1));
                arr2 = ArrayIntMod(UnSignInt(arr2));
            }
            else
            {
                if (GetIntSign(arr1) == true)
                {
                    arr1 = ArrayIntMod(UnSignInt(arr1));
                    arr2 = ArrayIntMod(arr2);
                }
                else if (GetIntSign(arr2) == true)
                {
                    arr2 = ArrayIntMod(UnSignInt(arr2));
                    arr1 = ArrayIntMod(arr1);
                }
                else
                {
                    arr1 = ArrayIntMod(arr1);
                    arr2 = ArrayIntMod(arr2);
                }
            }

            arr1 = ArrayIntMod(arr1);
            arr2 = ArrayIntMod(arr2);

            int[] helper = new int[10000];
            int[] helper2 = new int[10000];
            int tmp = 0;
            int k = 0;
            for (int i = 10000 - 1; i >= 0; i--)
            {
                for (int j = 10000 - 1; j >= 0; j--)
                {
                    int hl = arr1[j] * arr2[i];
                    int mult = hl + tmp;
                    tmp = mult / 10;
                    if (j - k >= 0)
                    {
                        helper[j - k] = mult % 10;
                    }
                }
                helper2 = ArrayShortSum(helper2, helper);
                helper[10000 - k - 1] = 0;
                k++;
            }

            if (g1 == true && g2 == false || g2 == true && g1 == false)
            {
                helper2 = SingInt(helper2);
            }

            return helper2;
        }

        public static int[] ArrayIntSum(int[] arr1, int[] arr2)
        {
            int c = Comparison(arr1, arr2);

            bool s1 = GetIntSign(arr1);
            bool s2 = GetIntSign(arr2);
            int[] res = new int[1];

            if (c == 0)
            {
                if(s1 == false && s2 == false)
                {
                    res = ArrayShortSum(arr1, arr2);
                    return res;
                }
                else
                {
                    res = SingInt(ArrayShortSum(UnSignInt(arr1), UnSignInt(arr2)));
                    return res;
                }
            }
            else
            {
                if (s1 == false && s2 == false)
                {
                    res = ArrayShortSum(arr1, arr2);
                    return res;
                }
            }

            if(s1 == true && s2 == true)
            {
                res = SingInt(ArrayShortSum(UnSignInt(arr1), UnSignInt(arr2)));
                return res;
            }

            if(s1 == true && s2 == false)
            {
                res = ArrayIntDiff(arr2, UnSignInt(arr1));
                return res;
            }

            if (s1 == false && s2 == true)
            {
                res = ArrayIntDiff(arr1, UnSignInt(arr2));
                return res;
            }

                return res;
        }

        public static int[] ArrayShortSum(int[] arr1, int[] arr2)
        {
            int[] res = new int[1];
            int[] addon = new int[1];
            if (arr1.Length >= arr2.Length)
            {
                res = ArrayIntMod(arr1);
                addon = ArrayIntMod(arr2);
            }
            else
            {
                res = ArrayIntMod(arr2);
                addon = ArrayIntMod(arr1);
            }

            int tmp = 0;
            for (int i = res.Length - 1; i >= 0; i--)
            {
                int sum = (res[i] + addon[i]) + tmp;
                tmp = sum / 10;
                res[i] = sum % 10;
            }

            return res;
        }

        public static int[] ArrayIntDiff(int[] arr1, int[] arr2)
        {
            int c = Comparison(arr1, arr2);

            bool s1 = GetIntSign(arr1);
            bool s2 = GetIntSign(arr2);

            int[] res = new int[1];

            if(c == 0)
            {
                if (s1 == false && s2 == false)
                {
                    return res;
                }
                else
                {
                    return res;
                }
            }

            if(c == 1)
            {
                if(s1 == false && s2 == false)
                {
                    res = ArrayShortDiff(arr1, arr2);
                    return res;
                }

                if(s1 == false && s2 == true)
                {
                    res = ArrayIntSum(arr1, UnSignInt(arr2));
                    return res;
                }

                if (s1 == true && s2 == true)
                {
                    if(Comparison(UnSignInt(arr1),arr2) == 0)
                    {
                        return res;
                    }

                    if (UnSignComparison(UnSignInt(arr1), arr2) == 1)
                    {
                        res = ArrayShortDiff(UnSignInt(arr1), UnSignInt(arr2));
                        res = SingInt(res);
                        return res;
                    }

                    if (UnSignComparison(UnSignInt(arr1), arr2) == -1)
                    {
                        res = ArrayShortDiff(UnSignInt(arr2), UnSignInt(arr1));
                        return res;
                    }
                }
            }

            if (c == -1)
            {
                if (s2 == false && s1 == false)
                {
                    res = ArrayShortDiff(arr2, arr1);
                    res = SingInt(res);
                    return res;
                }

                if (s2 == false && s1 == true)
                {
                    res = ArrayIntSum(arr2, UnSignInt(arr1));
                    res = SingInt(res);
                    return res;
                }

                if (s2 == true && s1 == true)
                {
                    if (Comparison(UnSignInt(arr2), arr1) == 0)
                    {
                        return res;
                    }

                    if (UnSignComparison(UnSignInt(arr2), arr1) == 1)
                    {
                        res = ArrayShortDiff(UnSignInt(arr2), UnSignInt(arr1));
                        res = SingInt(res);
                        return res;
                    }

                    if (UnSignComparison(UnSignInt(arr2), arr1) == -1)
                    {
                        res = ArrayShortDiff(UnSignInt(arr1), UnSignInt(arr2));
                        res = SingInt(res);
                        return res;
                    }
                }
            }

            return res;
        }

        public static int[] ArrayShortDiff(int[] arr1, int[] arr2)
        {
            int[] res = new int[1];
            int[] addon = new int[1];
            if (arr1.Length >= arr2.Length)
            {
                res = ArrayIntDifMod(arr1, arr1.Length);
                addon = ArrayIntDifMod(arr2, arr1.Length);
            }
            else
            {
                res = ArrayIntDifMod(arr2, arr2.Length);
                addon = ArrayIntDifMod(arr1, arr2.Length);
            }

            for (int i = res.Length - 1; i >= 0; i--)
            {
                int diff = (res[i] - addon[i]);
                if (diff >= 0)
                {
                    res[i] = diff;
                }
                else
                {
                    if (i - 1 >= 0)
                    {
                        if (res[i - 1] != 0)
                        {
                            res[i - 1] -= 1;
                        }
                        else
                        {
                            int k = 1;
                            while (res[i - k] == 0)
                            {
                                res[i - k] = 9;
                                k++;
                            }
                            res[i - k] -= 1;
                        }
                        res[i] = 10 + diff;
                    }
                    else
                    {
                        break;
                    }
                }

            }

            return res;
        }

        private static int[] ArrayIntMod(int[] arr)
        {
            int[] helper = new int[10000];
            int heLen = helper.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                helper[heLen] = arr[i];
                heLen--;
            }
            return helper;
        }

        private static int[] ArrayIntDifMod(int[] arr, int leng)
        {
            int[] helper = new int[leng];
            int heLen = helper.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                helper[heLen] = arr[i];
                heLen--;
            }
            return helper;
        }

        private static bool GetIntSign(int[] arr)
        {
            bool sign = false;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i] < 0)
                {
                    sign = true;
                }
            }
            return sign;
        }

        private static int[] UnSignInt(int[] arr)
        {
            int[] ret = new int[arr.Length - 1];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    for (int j = i + 1; j < ret.Length + 1; j++)
                    {
                        ret[j - 1] = arr[j];
                    }
                }
            }
            return ret;
        }

        private static int[] SingInt(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    continue;
                }
                else
                {
                    arr[i] *= -1;
                    break;
                }

            }

            return arr;
        }

        public static int Comparison(int[] arrL, int[] arrR)
        {
            int res = 0;
            int count = 0;
            int[] arr1 = arrL;
            int[] arr2 = arrR;

            if(arr1[0] == -1 && arr2[0] != -1)
            {
                return -1;
            }
            else if(arr2[0] == -1 && arr1[0] != -1)
            {
                return 1;
            }


            if (arr1.Length == arr2.Length)
            {
                count = arr1.Length;
            }
            else
            {
                if (arr1.Length > arr2.Length)
                {
                    if (GetIntSign(arr1) == false)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (GetIntSign(arr2) == false)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }

            for(int i = 0; i < count; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    if(i == count - 1)
                    {
                        return 0;
                    }
                }
                else
                {
                    if (arr1[i] > arr2[i])
                    {
                        if(arr1[0] == -1 && arr2[0] == -1)
                        {
                            return -1;
                        }

                        return 1;
                    }
                    else
                    {
                        if (arr1[0] == -1 && arr2[0] == -1)
                        {
                            return 1;
                        }

                        return -1;
                    }
                }
            }
            return res;
        }

        public static int UnSignComparison(int[] arrL, int[] arrR)
        {
            int res = 0;
            int count = 0;
            int[] arr1 = arrL;
            int[] arr2 = arrR;

            if (arr1.Length == arr2.Length)
            {
                count = arr1.Length;
            }
            else
            {
                if (arr1.Length > arr2.Length)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            for (int i = 0; i < count; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    if (i == count - 1)
                    {
                        return 0;
                    }
                }
                else
                {
                    if (arr1[i] > arr2[i])
                    {
                        if (arr1[0] == -1 && arr2[0] == -1)
                        {
                            return -1;
                        }

                        return 1;
                    }
                    else
                    {
                        if (arr1[0] == -1 && arr2[0] == -1)
                        {
                            return 1;
                        }

                        return -1;
                    }
                }
            }
            return res;
        }

        public static int[] ArrayLengUp(int[] arr)
        {
            int[] sub = new int[arr.Length + 1];
            for(int i = arr.Length -1; i >= 0; i--)
            {
                sub[i + 1] = arr[i];
            }
            arr = sub;
            return arr;
        }       
     }
}
