using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiComponents.Data;

namespace UiComponents.Interfaces
{
    public interface IDataRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
