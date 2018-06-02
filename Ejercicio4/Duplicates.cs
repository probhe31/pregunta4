using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Duplicates
    {
        public ResultDto DuplicateValues(int[] numbers)
        {
            ResultDto resultDto = new ResultDto();
            long steps = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    steps++;
                    if (i != 1 && numbers[i] == numbers[j])
                    {
                        resultDto.SetHasDuplicates(true);
                        resultDto.SetSteps(steps);
                        return resultDto;
                    }
                }
            }



            resultDto.SetHasDuplicates(false);
            resultDto.SetSteps(steps);
            return resultDto;
        }


        public ResultDto DuplicateValues_Better(int[] numbers)
        {
            ResultDto resultDto = new ResultDto();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            long steps = 0;
            int val;
            for (int i = 0; i < numbers.Length; i++)
            {
                steps++;

                

                if (dictionary.TryGetValue(numbers[i]))
                {
                    if (dictionary[numbers[i]] == numbers[i])
                    {
                        resultDto.SetHasDuplicates(true);
                        resultDto.SetSteps(steps);
                        {
                            return resultDto;
                        }
                    }
                }
                    

                dictionary.Add(numbers[i], numbers[i]);

                
            }

            resultDto.SetHasDuplicates(false);
            resultDto.SetSteps(steps);
            return resultDto;
        }
    }
}
