using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class JosephusPermutation
    {
        //public static int[] JosephusPerm(int cant, int espacios)//          Keeps track of victims and returns the list of everyone involved
        //{
        //    //Private Global variables 
        //    int[] listaInicial = new int[cant];
        //    List<int> listaCopia = new List<int>();
        //    int cantNum = 0, cantInd_sum = 0, contList = 1;

        //    for (int i = 0; i < listaInicial.Length; i++)//                 Fill the array with the correct numbers
        //    {   listaInicial[i] = contList;contList += 1;    }

        //    cantInd_sum = espacios;//                                      Equal the cuantity of numbers/ counter of the index that we need to move to find the next victim
        //    cantNum = cant;//                                               Keeps track of the amout of numbers left in the array

        //    //while (cant <= cantInd_sum)//                                 In case the amount of k is superior to our n, take the total of n out of k until k is less than n
        //    //{
        //    //    cantInd_sum -= cant;
        //    //}

        //    while (cantNum>1)//                                             While we have more than 1 n keep the joseph's permutation
        //    {
        //        for(int i = 1; i <= cantNum; i++)//                         This is the main body of the algorithm where we star the loop in 1 because k != 0 so we win 1 loop/ is also a flag that keeps memory of the index when i remove a space 
        //        {
        //            if(cantInd_sum <= cantNum)//                            In case the amount of k is superior to our n, take the total of n out of k until k is less than n
        //            {
        //                if (i == cantInd_sum)//                             If the loop finds the index of k
        //                {
        //                    listaCopia.Add(listaInicial[i-1]);//            Add to the record of the joseph's permutation victims
        //                    cantInd_sum +=espacios;//                       Add the amount of spaces to our counter so we keep track of the places that we need to modify under the law of k !> n
        //                    cantNum -= 1;//                                 Keeps track of the amount of number's left in the array
        //                    for (int b = i-1; b <= cantNum; b++)//          Here we move all the numbers next to the victim so we can make the amount of memory in the array equal to the amount of numbers left in the delete process
        //                    {
        //                        if (b == cantNum)//                         If we are at the end of the array, delete that space because we moved the data to concur with the numbers left after the victims death
        //                        {
        //                            Array.Resize(ref listaInicial, cantNum);
        //                            cantInd_sum -= 1;
        //                        }
        //                        else//                                      If not, move the content of the next space to the current space without loosing track of i wich lets us delete all the numbers whithin the range of n
        //                        {
        //                            listaInicial[b] = listaInicial[b + 1];
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                cantInd_sum -= cantNum;//                           Take the total of n out of k until k is less than n             
        //                if (i == cantInd_sum)//                             If for any reason when the new k happends to concur with the position we are in, don't lose the chance of deleting the space because it can cause an information bias as we jumped a space to confirm and delete the values of k
        //                {
        //                    listaCopia.Add(listaInicial[i - 1]);
        //                    cantInd_sum += espacios;
        //                    cantNum -= 1;
        //                    for (int b = i - 1; b <= cantNum; b++)
        //                    {
        //                        if (b == cantNum)
        //                        {
        //                            Array.Resize(ref listaInicial, cantNum);
        //                            cantInd_sum -= 1;
        //                        }
        //                        else
        //                        {
        //                            listaInicial[b] = listaInicial[b + 1];
        //                        }
        //                    }
        //                }
        //            }

        //        }

        //    }
        //    listaCopia.Add(listaInicial[0]);//                              Don't forget to add the remaining data of the array
        //    return listaCopia.ToArray();

        //}
        //public static int JosephusPerm(int n, int k) //                     just last number
        //{
        //    int[] listaInicial = new int[n];
        //    int cantNum = 0, cantInd_sum = 0, contList = 1;

        //    for (int i = 0; i<listaInicial.Length; i++)
        //    { listaInicial[i] = contList; contList += 1; }

        //    cantInd_sum = k;
        //    cantNum = n;



        //    while (cantNum > 1)
        //    {
        //        for (int i = 1; i <= cantNum; i++)
        //        {
        //            if (cantInd_sum <= cantNum)
        //            {
        //                if (i == cantInd_sum)
        //                {
        //                    cantInd_sum += k;
        //                    cantNum -= 1;
        //                    for (int b = i - 1; b <= cantNum; b++)
        //                    {
        //                        if (b == cantNum)
        //                        {
        //                            Array.Resize(ref listaInicial, cantNum);
        //                            cantInd_sum -= 1;
        //                        }
        //                        else
        //                        {
        //                            listaInicial[b] = listaInicial[b + 1];
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                cantInd_sum -= cantNum;
        //                if (i == cantInd_sum)
        //                {
        //                    cantInd_sum += k;
        //                    cantNum -= 1;
        //                    for (int b = i - 1; b <= cantNum; b++)
        //                    {
        //                        if (b == cantNum)
        //                        {
        //                            Array.Resize(ref listaInicial, cantNum);
        //                            cantInd_sum -= 1;
        //                        }
        //                        else
        //                        {
        //                            listaInicial[b] = listaInicial[b + 1];
        //                        }
        //                    }
        //                }
        //            }

        //        }

        //    }
        //    return listaInicial[0];
        //}
        public static int JosephusPerm(int n, int k)
        {
            //int[] listaInicial = new int[n];
            int cantNum = 0, cantInd_sum = 0, contList = 1;

            //for (int i = 0; i<listaInicial.Length; i++)
            //{ listaInicial[i] = contList; contList += 1; }

            cantInd_sum = k;
            cantNum = n;



            while (cantNum > 1)
            {
                for (int i = 1; i <= cantNum; i++)
                {
                    if (cantInd_sum <= cantNum)
                    {
                        if (i == cantInd_sum)
                        {
                            cantInd_sum += k;
                            cantNum -= 1;
                            contList = i;
                            //for (int b = i - 1; b <= cantNum; b++)
                            //{
                            //    if (b == cantNum)
                            //    {
                            //        //Array.Resize(ref listaInicial, cantNum);
                            cantInd_sum -= 1;
                            //    }
                            //    else
                            //    {
                            //        //listaInicial[b] = listaInicial[b + 1];
                            //    }
                            //}
                        }
                    }
                    else
                    {
                        cantInd_sum -= cantNum;
                        if (i == cantInd_sum)
                        {
                            cantInd_sum += k;
                            cantNum -= 1;
                            contList = i;
                            //for (int b = i - 1; b <= cantNum; b++)
                            //{
                            //    if (b == cantNum)
                            //    {
                            //        //Array.Resize(ref listaInicial, cantNum);
                            cantInd_sum -= 1;
                            //    }
                            //    else
                            //    {
                            //        //listaInicial[b] = listaInicial[b + 1];
                            //    }
                            //}
                        }
                    }

                }

            }
            return cantInd_sum;
        }
    }
}
