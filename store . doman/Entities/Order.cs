using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }

        public ICollection<OrderItem> Items { get; set; }


    }
}
