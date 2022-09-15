using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //readonly previne que essa dependencia não possa ser alterada.
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); //ToList converte para uma lista.
        }
         public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }   

    }
}
