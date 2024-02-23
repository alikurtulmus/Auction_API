﻿using API_Auction_ReactNET.Hubs.ConnectionManagement;
using BusinessLayer.Dtos;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace API_Auction_ReactNET.Hubs
{
    public class BidUpdateHub : Hub
    {
        private readonly IConnectionManager _connectionManager;
        private readonly ApplicationDbContext _context;
        public BidUpdateHub(IConnectionManager connectionManager, ApplicationDbContext context)
        {
            _context = context;
            _connectionManager = connectionManager;
        }

        public override async Task OnConnectedAsync()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            var connectionId = Context.ConnectionId;
            var userId = randomNumber.ToString();
            _connectionManager.AddConnection(userId, connectionId);
            await base.OnConnectedAsync();
        }

        public async Task NewBid(int vehicleId)
        {
            if (vehicleId != null)
            {
                var result = await _context.Bids.Where(x => x.VehicleId == vehicleId).ToListAsync();
                Random random = new Random();
                int randomNumber = random.Next(1, 101);
                var connectionId = _connectionManager.GetAllConnections();
                await Clients.Clients(connectionId).SendAsync("messageReceived", result);
            }
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var connectionId = Context.ConnectionId;
            _connectionManager.RemoveConnection(connectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
