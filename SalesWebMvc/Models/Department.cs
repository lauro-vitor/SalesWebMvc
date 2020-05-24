using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        List<Seller> Sellers { get; set; }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
            Sellers = new List<Seller>();
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSeles(DateTime intial, DateTime final)
        {
            return 0;
        }
       
    }
}
