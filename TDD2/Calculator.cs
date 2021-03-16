using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD2
{
    public class Calculator
    {
        private static int? GetNum(string input)
        {
            int result;
            if (Int32.TryParse(input, out result))
            {
                if (result > 1000)
                {
                    return 0;
                }
                if (result < 0)
                {
                    throw new ArgumentException();
                }
                return result;
            }
            return null;
        }

        private static int? TwoNumSum(string[] input)
        {
            if (input.Length == 2)
            {
                var first = GetNum(input[0]);
                var second = GetNum(input[1]);
                if ((first != null) && (second != null))
                {
                    return first + second;
                }
            }
            return null;
        }

        private static int? ThreeNumSum(string[] input)
        {
            if (input.Length == 3)
            {
                string[] pair = new string[] { input[0], input[1] };
                var first = TwoNumSum(pair);
                var thirdnum = GetNum(input[2]);
                if ((first != null) && (thirdnum != null))
                {
                    return first + thirdnum;
                }
            }
            return null;
        }

        public static int? Calculate(string input)
            {
                if (input == "")
                {
                    return 0;
                }

                //delete leading # signs
                input = input.TrimStart('#');
                var num = GetNum(input);

                if (num != null)
                {
                    return num;
                }

                //split in respect to \n
                var pair = input.Split('\n');
                var sum = TwoNumSum(pair);

                if (sum != null)
                {
                    return sum;
                }

                //split in respect to ,
                var pair2 = input.Split(',');
                var sum2 = TwoNumSum(pair2);
                if (sum2 != null)
                {
                    return sum2;
                }

                //split in respect to , and #
                var pair3 = input.Split('\n', ',');
                var sum3 = ThreeNumSum(pair3);
                if (sum3 != null)
                    return sum3;

                return 0;
            }

         

        }
    }


