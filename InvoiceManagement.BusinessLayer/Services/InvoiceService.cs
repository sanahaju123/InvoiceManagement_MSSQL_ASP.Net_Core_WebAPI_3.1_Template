using InvoiceManagement.BusinessLayer.Interfaces;
using InvoiceManagement.BusinessLayer.Services.Repository;
using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.BusinessLayer.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _InvoiceRepository;

        public InvoiceService(IInvoiceRepository InvoiceRepository)
        {
            _InvoiceRepository = InvoiceRepository;
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