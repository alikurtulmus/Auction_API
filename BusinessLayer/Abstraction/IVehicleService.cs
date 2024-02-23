using BusinessLayer.Dtos;
using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstraction
{
    public interface IVehicleService
    {
        Task<ApiResponse> CreateVehicle(CreateVehicleDTO model);
        Task<ApiResponse> GetVehicles();
        Task<ApiResponse> UpdateVehicleResponse(int vehicleId, UpdateVehicleDTO model);
        Task<ApiResponse> DeleteVehicle(int vehicleId);
        Task<ApiResponse> GetVehicleById(int vehicleId);
        Task<ApiResponse> ChangeVehicleStatus(int vehicleId);
    }
}
