using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_1463
    {
        public void Main()
        {
            Dictionary<float, int> calcCountData = new(1000);

            float sourceValue = float.Parse(Console.ReadLine());
            SplitCalc(calcCountData, sourceValue, 0);

            Console.WriteLine(calcCountData[1]);
        }

                            // 값 , 횟수               진행 값
        static void SplitCalc(Dictionary<float, int> calcCountData, float sourceValue, short counting)
        {
            if (calcCountData.TryGetValue(1, out int count)) //탈출 조건 // 마지막 계산이 존재
            {
                if (count <= counting) // 이미 도착횟수보다 더 많은 연산
                {
                    return;
                }
            }

            if (calcCountData.TryGetValue(sourceValue, out count))// 이미 해당 값을 연산한 기록이 있을경우
            {
                if (count <= counting) //해당 기록보다 오랜 연산을 진행
                {
                    return; //분기 종료
                }
                else
                {
                    calcCountData[sourceValue] = counting; //더 짧았기때문에 새로 기록
                }
            }
            else
            {
                calcCountData.Add(sourceValue, counting); //해당 값을  최초로 연산 시도하기 때문에 기록
            }

            if(sourceValue == 1)
            {
                return;
            }

            ++counting;
            
            if (sourceValue % 3 == 0)
            {
                SplitCalc(calcCountData, sourceValue / 3, counting);
            }
            if(sourceValue % 2 == 0)
            {
                SplitCalc(calcCountData, sourceValue / 2, counting);
            }
            SplitCalc(calcCountData, sourceValue - 1, counting);
        }
    }
}
