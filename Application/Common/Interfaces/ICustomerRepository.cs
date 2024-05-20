using Application.Common.Models;
using Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ICustomerRepository
    {
        public Task<Response<CustomerDto>> GetCustomerById(int id);
        public Task<Response<CustomerDto>> GetCustomerByEmail(string email);
        public Task<Response<CustomerDto>> CreateCustomer(CustomerDto customer);
    }
}
