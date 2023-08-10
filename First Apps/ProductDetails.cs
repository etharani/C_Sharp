using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Apps
{
    internal class ProductDetails
    {
        Int32 id;
        String name;
        Int32 price;
        Int32 quantity;
        public ProductDetails(Int32 id,String name,Int32 price,Int32 quantity)
        {
            this.id = id;
            this.name=name;
            this.price=price;
            this.quantity=quantity;
        }

        public string GetData()
        {
            return "Product Id: " +this.id + "\nProduct Name:" + this.name + "\nProduct Price:" +this.price+"\nProduct Quantity:"+this.quantity;

        }
        
    }
}
