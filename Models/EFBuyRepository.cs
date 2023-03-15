using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_cpearce3.Models
{
    public class EFBuyRepository : IBuyRepository
    {
        private BookstoreContext context;
        public EFBuyRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Buy> Buy => context.Buy.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SaveBuy(Buy buy)
        {
            context.AttachRange(buy.Lines.Select(x => x.Book));

            if (buy.BuyId == 0)
            {
                context.SaveChanges();
            }
        }
    }
}
