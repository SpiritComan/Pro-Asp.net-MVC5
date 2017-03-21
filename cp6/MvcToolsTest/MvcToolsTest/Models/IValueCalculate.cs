using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToolsTest.Models
{
    public interface IValueCalculate
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}
