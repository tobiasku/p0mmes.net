
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes
{
    public class FoodUserControlEventArgs
    {
        public FoodUserControlEventArgs(Article article)
        {
            this.article = article;
        }

        private Article article;
        public Article Article
        {
            get { return article; }
            set { article = value; }
        }
    }
}
