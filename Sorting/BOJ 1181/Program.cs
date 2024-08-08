using System.Text;

namespace BOJ_1181
{
    // 2024 08 05
    // 문제 : 백준 1181 단어 정렬
    // url : https://www.acmicpc.net/problem/1181

    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] strs = new string[count];

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                if(strs.Contains(input))
                {
                    count--;
                    i--;
                    continue;
                }

                strs[i] = input;
            }

            #region 버블정렬 - 시간초과 발생
            //for (int k = 0; k < count - 1; k++)
            //{
            //    for (int i = 0; i < count - 1; i++)
            //    {
            //        if (strs[i].Length > strs[i + 1].Length)
            //        {
            //            string temp = strs[i];
            //            strs[i] = strs[i + 1];
            //            strs[i + 1] = temp;
            //        }
            //        else if (strs[i].Length == strs[i + 1].Length)
            //        {
            //            for (int j = 0; j < strs[i].Length; j++)
            //            {
            //                if (strs[i][j] > strs[i + 1][j])
            //                {
            //                    string temp = strs[i];
            //                    strs[i] = strs[i + 1];
            //                    strs[i + 1] = temp;

            //                    break;
            //                }

            //            }
            //        }
            //    }
            //}
            #endregion

            QuickSort(strs, 0, count-1);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(strs[i]);
            }
        }

        static void QuickSort(string[] m_strs,int m_leftIdx, int m_rightIdx)
        {
            if(m_leftIdx < m_rightIdx)
            {
                int pivot = Partition(m_strs, m_leftIdx, m_rightIdx);
                QuickSort(m_strs, m_leftIdx, pivot - 1);
                QuickSort(m_strs, pivot + 1, m_rightIdx);
            }
        }

        static int Partition(string[] m_strs, int m_leftIdx, int m_rightIdx)
        {
            string pivot = m_strs[m_leftIdx];
            int start = m_leftIdx+1;
            int end = m_rightIdx;

            while (true)
            {
                if (start > end)
                    break;

                while (true)
                {
                    // start 인덱스가 right 값보다 작으며
                    // start 포인터가 가리키는 문자열 요소가 피벗의 문자열과 교환해야할
                    // 상황이 벌어지지 않는다면
                    // start 를 계속 증가시킴
                    if (start > m_rightIdx)
                        break;
                    else if (CompareStr(m_strs[start], pivot) > 0)
                        break;

                    start++;
                }

                while (true)
                {
                    // end 포인터가 가리키는 문자열과 피벗의 문자열과 교환해야할 상황이
                    // 상황이 벌어지지 않는다면
                    // end 를 계속 감소시킴
                    if (end <= m_leftIdx)
                        break;
                    else if (CompareStr(m_strs[end], pivot) < 0)
                        break;

                    end--;
                }

                // 위 반복문들이 어느 시점에 걸리게 되면 교체 진행
                if (start < end)
                    Swap(m_strs, start, end);
            }

            // 피벗 포인터 문자열과 교차지점의 문자열을 교체 후 교차지점 포인터 인덱스 반환
            Swap(m_strs, m_leftIdx, end);
            return end;
        }

        static void Swap(string[] m_strs, int m_leftIdx, int m_rightIdx)
        {
            string temp = m_strs[m_leftIdx];
            m_strs[m_leftIdx] = m_strs[m_rightIdx];
            m_strs[m_rightIdx] = temp;
        }

        /// <summary>
        /// 각 문자열의 우선순위를 측정합니다.
        /// </summary>
        /// <returns>
        /// 전자가 작다면 -1 이하의 값을 반환,
        /// 같다면 0을 반환
        /// 후자가 작다면 1 이상의 값을 반환
        /// </returns>
        static int CompareStr(string m_str1, string m_str2)
        {
            if (m_str1.Length == m_str2.Length)
            {
                return CompareDictionary(m_str1, m_str2);
            }
            else
            {
                return m_str1.Length - m_str2.Length;
            }
        }

        /// <summary>
        /// 두개의 문자열을 받아 각 문자별 사전순 오름차순을 판별하는 메서드
        /// </summary>
        /// /// <returns>
        /// 전자가 작다면 -1 이하의 값을 반환
        /// 아니라면 0 이상의 값을 반환
        /// </returns>
        static int CompareDictionary(string m_str1, string m_str2)
        {
            int minLength = Math.Min(m_str1.Length, m_str2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (m_str1[i] != m_str2[i])
                {
                    return m_str1[i] - m_str2[i];
                }
            }
            return m_str1.Length - m_str2.Length;

        }
    }
}
