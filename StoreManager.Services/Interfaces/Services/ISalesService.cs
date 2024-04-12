using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Service.Interfaces.Services
{
    public interface ISalesService
    {
        int GetTotalProducts();
        List<(int productId, decimal unitPrice)> GetProductDetails();
        decimal GetTotalPrice();
    }

}
