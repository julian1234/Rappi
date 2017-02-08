using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rappisolution
{
    class CubeSummation
    {

        public long CubeSummationx(int dta1, string A, long sum)
        {


            for (int l = 0; l < dta1; l++)
            {

                int[] a = Array.ConvertAll(A.Split(' '), int.Parse);
                int N = a[0] + 1;
                int M = a[1];

                int[, ,] cube = new int[N, N, N];

                for (int m = 0; m < M; m++)
                {


                    string querydata = this.QueryorUpadate("", m);

                    string[] query = querydata.Split(' ');
                    switch (query[0])
                    {
                        case "UPDATE":

                            cube[int.Parse(query[1]), int.Parse(query[2]), int.Parse(query[3])] = int.Parse(query[4]);
                            break;

                        case "QUERY":
                            sum = 0;
                            for (int i = int.Parse(query[1]); i <= int.Parse(query[4]); i++)
                            {
                                for (int j = int.Parse(query[2]); j <= int.Parse(query[5]); j++)
                                {
                                    for (int k = int.Parse(query[3]); k <= int.Parse(query[6]); k++)
                                    {
                                        sum += cube[i, j, k];
                                    }
                                }
                            }

                            Console.WriteLine(sum.ToString());
                            break;

                    }

                }
            }



            return sum;

        }


        public string QueryorUpadate(string result, int num)
        {

            int range = num;
            switch (range)
            {
                case 0:
                    result = "UPDATE 2 2 2 4";
                    break;
                case 1:
                    result = "QUERY 1 1 1 3 3 3";
                    break;
                case 2:
                    result = "UPDATE 1 1 1 23";
                    break;
                case 3:
                    result = "QUERY 2 2 2 4 4 4";
                    break;
                case 4:
                    result = "QUERY 1 1 1 3 3 3";
                    break;


            }




            return result;

        }


    }
}
