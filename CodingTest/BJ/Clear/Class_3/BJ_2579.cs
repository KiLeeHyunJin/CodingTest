using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingTest.BJ
{
    internal class BJ_2579
    {
        //계단은 한 번에 한 계단씩 또는 두 계단씩 오를 수 있다.
        //즉, 한 계단을 밟으면서 이어서 다음 계단이나, 다음 다음 계단으로 오를 수 있다.
        //연속된 세 개의 계단을 모두 밟아서는 안 된다.단, 시작점은 계단에 포함되지 않는다.
        //마지막 도착 계단은 반드시 밟아야 한다.

        static List<int> scoreList = new(301);
        static Dictionary<int, int> dataContainer = new(301);
        static int resultScore = 0;

        public void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());

            scoreList.Add(0);

            for (int i = 0; i < inputCount; i++)
            {
                int score = int.Parse(Console.ReadLine());
                scoreList.Add(score);
            }
            resultScore = 0;
            // CalcSplit(0, 0, 0);
            if (inputCount == 2)
            {
                Console.WriteLine(scoreList[1] + scoreList[2]);
            }
            else
            {
                CalcSplit(0, 0, 0);
                Console.WriteLine(resultScore);
            }

        }

        static void CalcSplit(short step, short pos, int curretScore)
        {

            if (pos + 1 == scoreList.Count) //마지막 발판
            {
                if (step != 3) //3번연속 밟은경우가 아닐때만 
                {
                    curretScore += scoreList[pos];//현재 발판 점수를 추가
                    if (curretScore > resultScore) //기입된 최종 점수보다 높다면 새로 기입
                    {
                        resultScore = curretScore;
                    }
                }
                return;
            }

            {
                int checkData = step;
                checkData <<= 16;
                checkData |= (int)pos;

                if (dataContainer.TryGetValue(checkData, out int score))
                {
                    if (score >= curretScore) //이미 똑같은 조건으로 지나갔지만 점수가 같거나 더 낮은 상황
                    {
                        return;
                    }
                    dataContainer[checkData] = curretScore; //기존보다 더 높은 점수로 방문
                }
                else
                {
                    dataContainer.Add(checkData, curretScore); //새로운 조건으로 방문
                }
            }


            curretScore += scoreList[pos];//현재 발판 점수를 추가

            if (step < 2) //연속해서 밟을 수 있다면
            {
                CalcSplit(
                    (short)(1 + step),
                    (short)(1 + pos),
                    curretScore);
            }

            if (pos + 2 < scoreList.Count) //최종 발판을 넘지 않는다면
            {
                CalcSplit(
                    1, //스텝 초기화
                    (short)(2 + pos),
                    curretScore);
            }
        }
    }
}
