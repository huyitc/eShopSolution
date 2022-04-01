using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products.Dtos
{
    public class GetProductPagingRequest: PagingRequestBase
    {
        public string Keyword { get; set; }

        public int? CategoryId { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
