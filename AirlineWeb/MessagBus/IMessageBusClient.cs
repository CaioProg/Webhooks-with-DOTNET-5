using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineWeb.Dtos;

namespace AirlineWeb.MessagBus
{
    public interface IMessageBusClient
    {
        void SendMessage(NotificationMessageDto notificationMessageDto);
    }
}