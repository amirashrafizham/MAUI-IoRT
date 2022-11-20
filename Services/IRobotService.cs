using System;
using MAUI_IoRT.Models;

namespace MAUI_IoRT.Services
{
    public interface IRobotService
    {
        Task Forward(DistanceModel distance);
        Task TurnRight(DistanceModel distance);
        Task TurnLeft(DistanceModel distance);
        Task Reverse(DistanceModel distance);
        Task ReverseRight(DistanceModel distance);
        Task ReverseLeft(DistanceModel distance);
    }
}
