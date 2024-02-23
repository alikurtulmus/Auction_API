using BusinessLayer.Dtos;
using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstraction
{
    public interface IPaymentHistoryService
    {
        Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDTO model);
        Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId);
    }
}
