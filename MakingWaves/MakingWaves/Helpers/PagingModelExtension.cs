using MakingWaves.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakingWaves.Helpers
{
    public static class PagingModelExtension
    {
        public static List<int> GetPages(this PagingModel model) {



            var pageStart = ((model.Current / 10)*10) +1; //first digit in the next group of devisions of 10



            List<int> pages = new List<int>();
            for (int i = pageStart; i < pageStart + 10 && i <= model.PageCount; i++) {
                pages.Add(i);
            }
            return pages;
        }

        public static int? Next(this PagingModel model) {
           
            if (model.Current < model.PageCount)
            {
                return model.Current + 1;
            }
            else {
                return null;
            }
        }

        public static int? Previous(this PagingModel model)
        {
            if (model.Current > 1)
            {
                return model.Current - 1;
            }
            else
            {
                return null;
            }
        }

    }
}
