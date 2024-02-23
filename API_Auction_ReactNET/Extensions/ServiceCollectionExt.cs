﻿using API_Auction_ReactNET.Hubs.ConnectionManagement;
using BusinessLayer.Abstraction;
using BusinessLayer.Concrete;
using CoreLayer.MailHelper;
using CoreLayer.Models;


namespace API_Auction_ReactNET.Extensions
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IBidService, BidService>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IPaymentHistoryService, PaymentHistoryService>();
            services.AddScoped<IConnectionManager, ConnectionManager>();
            services.AddScoped(typeof(ApiResponse));
            #endregion
            return services;
        }
    }
}
