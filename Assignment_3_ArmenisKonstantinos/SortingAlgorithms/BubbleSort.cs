using Assignment_3_ArmenisKonstantinos.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_ArmenisKonstantinos.SortingAlgorithms
{
    class BubbleSort
    {

        private static bool less(int value1, int value2)
        {
            return value1 < value2;
        }

        private static bool more(int value1, int value2)
        {
            return value1 > value2;
        }

        public static void SortShirtsAsc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (more((int)shirts[j].Size, (int)shirts[j + 1].Size))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }
        public static void SortShirtsDesc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (less((int)shirts[j].Size, (int)shirts[j + 1].Size))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortShirtsclAsc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (more((int)shirts[j].Color, (int)shirts[j + 1].Color))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortShirtsclDesc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (less((int)shirts[j].Color, (int)shirts[j + 1].Color))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }


        public static void SortShirtsfbAsc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (more((int)shirts[j].Fabric, (int)shirts[j + 1].Fabric))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortShirtsfbDesc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (less((int)shirts[j].Fabric, (int)shirts[j + 1].Fabric))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }


        public static void SortShirtsAscLast(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (more((int)shirts[j].Color, (int)shirts[j + 1].Color))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                    if (more((int)shirts[j].Size, (int)shirts[j + 1].Size))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                    if (more((int)shirts[j].Fabric, (int)shirts[j + 1].Fabric))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }


        public static void SortShirtsAscLastDesc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (less((int)shirts[j].Color, (int)shirts[j + 1].Color))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                    if (less((int)shirts[j].Size, (int)shirts[j + 1].Size))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                    if (less((int)shirts[j].Fabric, (int)shirts[j + 1].Fabric))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }
    }
}
