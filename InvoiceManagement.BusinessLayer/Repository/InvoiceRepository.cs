using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.DataLayer;
using InvoiceManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.BusinessLayer.Services.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly InvoiceDbContext _dbContext;
        public InvoiceRepository(InvoiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Invoice> CreateInvoice(Invoice Invoice)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteInvoiceById(int id)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public List<Invoice> GetAllInvoices()
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<Invoice> UpdateInvoice(InvoiceViewModel model)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}