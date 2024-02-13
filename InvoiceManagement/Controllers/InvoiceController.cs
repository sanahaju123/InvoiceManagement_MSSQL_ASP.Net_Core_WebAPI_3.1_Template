using InvoiceManagement.BusinessLayer.Interfaces;
using InvoiceManagement.BusinessLayer.ViewModels;
using InvoiceManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceManagement.Controllers
{
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _InvoiceService;
        public InvoiceController(IInvoiceService InvoiceService)
        {
            _InvoiceService = InvoiceService;
        }

        [HttpPost]
        [Route("create-Invoice")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice model)
        {
            //Write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-Invoice")]
        public async Task<IActionResult> UpdateInvoice([FromBody] InvoiceViewModel model)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("delete-Invoice")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            //Write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-Invoice-by-id")]
        public async Task<IActionResult> GetInvoiceById(int id)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-Invoices")]
        public async Task<IEnumerable<Invoice>> GetAllInvoices()
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}