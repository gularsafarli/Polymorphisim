using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Polymorphism__casting
{
    internal class Store : IStore
    {
        public Product[] _products = new Product[0];
        public Product[] Products { get => _products; set => value = _products; }
        private int _alcoholPercentLimit = 100;
        private int _dairyProductTotalCount;
        public int AlcoholPercentLimit
        {
            get => _alcoholPercentLimit;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _alcoholPercentLimit = value;
                }
                else { throw new AlcoPercentException(); }
            }
        }
        private int _dairyProductCountLimit = 1000;
        public int DairyProductCountLimit
        {
            get => _dairyProductCountLimit;
            set
            {
                if (value >= 0&&value<=1000)
                {
                    _dairyProductCountLimit = value;
                }
                else
                {
                    throw new Exception($"limit asilmisdir");
                }
            }
        }

        public Product GetproductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            throw new ProductnotFound();
        }

        public bool HasProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveProduct(int no)
        {
            for (int i = no; i < _products.Length; i++)
            {
                var swap = _products[i];
                _products[i] = _products[i + 1];
                _products[i + 1]= swap;
            }
            Array.Resize(ref _products, _products.Length-1);

        }

        public void Add(Product product)
        {

            if (product is Dairy)
            {
                _dairyProductTotalCount++;
                if (_dairyProductTotalCount <= _dairyProductCountLimit)
                {
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
                else if (_dairyProductTotalCount > _dairyProductCountLimit)
                {
                    throw new Exception("Limit asilir");
                }

            }
            else if (product is Drink)
            {
                Drink drink = (Drink)product;
                if (drink.AlcoholPercent <= _alcoholPercentLimit)
                {
                    Array.Resize(ref _products, _products.Length + 1);
                    _products[_products.Length - 1] = product;
                }
                else if (drink.AlcoholPercent > _alcoholPercentLimit)
                {
                    throw new AlcoPercentException();
                }
            }
        }
        public Dairy[] GetDairyProducts(Product[] products)
        {
            Dairy[] dairies = new Dairy[0];
            foreach (var item in _products)
            {
                if (item is Dairy)
                {
                    Dairy dairy = (Dairy)item;
                    Array.Resize(ref dairies, dairies.Length + 1);
                    dairies[dairies.Length - 1] = dairy;
                }
            }
            return dairies;
        }
        public Drink[] GetDrinkProducts(Product[] products)
        {
            Drink[] drinks = new Drink[0];
            foreach (var item in _products)
            {
                if (item is Drink)
                {
                    Drink drink = (Drink)item;
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = drink;
                }
            }
            return drinks;
        }

    }
}
