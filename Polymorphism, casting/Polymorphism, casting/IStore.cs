using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__casting
{
    internal interface IStore
    {
        public Product[] Products { get; set; }
        public void Add(Product product);
        public bool HasProductByNo(int no);
        public Product GetproductByNo(int no);
        public void RemoveProduct(int no);
    }
}
