using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBLET.BusinessLogics;
using WEBLET.Models;


namespace WEBLET.Hubs
{
    public class ChatHub :Hub
    {
        private UserManager<ApplicationUser> _userManager;
        public ChatHub(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
           
        }
        public override  Task OnConnectedAsync()
        {
            AspNetUserConnection data = new AspNetUserConnection();
            data.CONNECTION_ID = Context.ConnectionId;
            data.USER_ID = Context.UserIdentifier;
            data.IS_ONLINE = "ONLINE";
            ChatProccess.SaveUserConnection(data);
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            AspNetUserConnection data = new AspNetUserConnection();
            data.CONNECTION_ID = Context.ConnectionId;
            data.USER_ID = Context.UserIdentifier;
            data.IS_ONLINE = "OFFLINE";
            ChatProccess.SaveUserConnection(data);
            return base.OnDisconnectedAsync(exception);
        }
        public async Task SendMessage(string message)
        {
            
            ApplicationUser user = await _userManager.GetUserAsync(Context.User);
            ChatProccess.Msg_Reade_States(user.Id, 0);
            var list= ChatProccess.ConsultantList();
            foreach(var item in list)
            {
                AspNetMesg MsgInvelop = new AspNetMesg();
                var connectionModel = ChatProccess.AspNetUserConnectionData(item);
                MsgInvelop.MSG = message;
                MsgInvelop.FROM_USER = user.Id;
                MsgInvelop.TO_USER = item;
                MsgInvelop.MSG_DATETIME = DateTime.Now;
                MsgInvelop.ISACTIVE = "1";
                ChatProccess.AddChat(MsgInvelop);
                if (connectionModel != null)
                {
                    if (connectionModel.IS_ONLINE == "ONLINE")
                    {
                        await Clients.Client(connectionModel.CONNECTION_ID).SendAsync("ReceiveMessage", message, user.Name, DateTime.Now.ToString("dd/MM/yyyy h:mm tt"), user.Email,"PanelUser");
                    }
                }
            }
          
        }

        public async Task ConsultantSendMessage(string message,string UsersetId)
        {

            ApplicationUser user = await _userManager.GetUserAsync(Context.User);

            var list = ChatProccess.ConsultantList();
            list.Add(UsersetId);
            foreach (var item in list)
            {
                AspNetMesg MsgInvelop = new AspNetMesg();
                var connectionModel = ChatProccess.AspNetUserConnectionData(item);
                MsgInvelop.MSG = message;
                MsgInvelop.FROM_USER = user.Id;
                MsgInvelop.TO_USER = item;
                MsgInvelop.MSG_DATETIME = DateTime.Now;
                MsgInvelop.ISACTIVE = "1";
                ChatProccess.AddChat(MsgInvelop);
                if (connectionModel != null) { 
                if (connectionModel.IS_ONLINE == "ONLINE" && item!= user.Id)
                {
                    await Clients.Client(connectionModel.CONNECTION_ID).SendAsync("ReceiveMessage", message, user.Name, DateTime.Now.ToString("dd/MM/yyyy h:mm tt"), user.Email,"Consultant");
                }
                }
            }

        }
    }
}
