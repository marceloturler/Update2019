﻿using System.Linq;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller objSeller)
        {
            _context.Add(objSeller);
            _context.SaveChanges();
        }
    }
}
