using System;
using System.Net.Http.Json;
using MAUI_IoRT.Models;

namespace MAUI_IoRT.Services
{
    public class RobotService : IRobotService
    {
        private string _baseUrl = "http://192.168.1.25:5000";
        public async Task Forward(DistanceModel distance)
        {
            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}/Robot/Forward";
                await client.PostAsJsonAsync<DistanceModel>(url, distance);
            }
        }

        public async Task Reverse(DistanceModel distance)
        {
            throw new NotImplementedException();
        }

        public async Task ReverseLeft(DistanceModel distance)
        {
            throw new NotImplementedException();
        }

        public async Task ReverseRight(DistanceModel distance)
        {
            throw new NotImplementedException();
        }

        public async Task TurnLeft(DistanceModel distance)
        {
            throw new NotImplementedException();
        }

        public async Task TurnRight(DistanceModel distance)
        {
            throw new NotImplementedException();
        }
    }
}
