using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBLET.BusinessLogics;
using WEBLET.Models;
using WEBLET.ViewModels;

namespace WEBLET.Controllers
{
    public class ConsultantController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
 
        public ConsultantController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        
        }
        public async Task<IActionResult> LoadUserChat(IsSentMsgUser info)
        {

            var user = await _userManager.GetUserAsync(User);
            ChatProccess.Msg_Reade_States(info.Id, 1);
            var data = ChatProccess.GetChat(info.Id.ToString(),user.Id);
            return PartialView("~/Views/Consultant/LoadUserChat.cshtml" ,data);
        }
        public IActionResult SentMsgUserList()
        {
            return PartialView("~/Views/Consultant/msgSentUserListView.cshtml");
        }
        //[HttpPost]
        //public void ChangeMsgStates(string msg_sender_id, int states)
        //{
        //    ChatProccess.Msg_Reade_States( msg_sender_id,  states);


        //}
    }
}
