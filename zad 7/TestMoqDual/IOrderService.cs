using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMoqDual
{
    public interface IOrderService
    {
        void PlaceOrder(string product, int quantity);

    }
}
