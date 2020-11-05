using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SVSur.UI.Commons
{
   
        public class Pager
        {

            public int TotalItems { get; private set; }

            public int CurrentPage { get; private set; }

            public int PageSize { get; private set; }

            public int TotalPages { get; private set; }

            public int StartPage { get; private set; }

            public int EndPage { get; private set; }

            public int PreviousPage { get; private set; }

            public int NextPage { get; private set; }


            public Pager(int pTotalItems, int? pCurrentPage, int pPageSize = 5)
            {

                int totalPages = (int)Math.Ceiling((decimal)pTotalItems / (decimal)pPageSize);
                int currentPage = pCurrentPage != null ? (int)pCurrentPage : 1;
                int startPage = currentPage - 5;
                int endPage = currentPage + 4;
                if (startPage <= 0)
                {
                    endPage = endPage - (startPage - 1);
                    startPage = 1;
                }

                if (endPage > totalPages)
                {
                    endPage = totalPages;
                    if (endPage > 10)
                    {
                        startPage = endPage - 9; ;
                    }
                }


                this.TotalItems = pTotalItems;
                this.CurrentPage = currentPage;
                this.PageSize = pPageSize;
                this.TotalPages = totalPages;
                this.StartPage = startPage;
                this.EndPage = endPage;
                this.PreviousPage = currentPage == 1 ? 1 : currentPage - 1;
                this.NextPage = currentPage == totalPages ? totalPages : currentPage + 1;

        
    }
}
}