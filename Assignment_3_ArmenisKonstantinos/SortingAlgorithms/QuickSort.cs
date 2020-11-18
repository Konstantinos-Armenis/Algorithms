using Assignment_3_ArmenisKonstantinos.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_ArmenisKonstantinos.SortingAlgorithms
{
    class QuickSort
    {

        public static void SortShirtsAscS(List<Shirt> shirts)
        {
            QuicksortS(shirts, 0, shirts.Count - 1);
            
        }

        private static void QuicksortS(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Size;

            while (i <= j)
            {
                while (shirts[i].Size < pivot)
                    i++;
                while (shirts[j].Size > pivot)
                    j--;

                if (i <= j)
                {
                    // swap
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortS(shirts, left, j);
            if (i < right)
                QuicksortS(shirts, i, right);
        }



        public static void SortShirtsDescscS(List<Shirt> shirts)
        {
            QuicksortDescS(shirts, 0, shirts.Count - 1);
           
        }
        private static void QuicksortDescS(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Size;

            while (i <= j)
            {
                while (shirts[i].Size > pivot)
                    i++;
                while (shirts[j].Size < pivot)
                    j--;

                if (i <= j)
                {
                    // swap
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortDescS(shirts, left, j);
            if (i < right)
                QuicksortDescS(shirts, i, right);
        }
    }
}

