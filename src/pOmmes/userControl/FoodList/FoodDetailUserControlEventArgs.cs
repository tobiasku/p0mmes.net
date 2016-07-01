
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes
{
    public class FoodDetailUserControlEventArgs
    {
        public FoodDetailUserControlEventArgs(Article article, OrderPosition orderPosition)
        {
            this.article = article;
            this.orderPosition = orderPosition;
        }

        private Article article;
        public Article Article
        {
            get { return article; }
            set { article = value; }
        }

        private OrderPosition orderPosition;
        public OrderPosition OrderPosition
        {
            get { return orderPosition; }
            set { orderPosition = value; }
        }
    }
}
