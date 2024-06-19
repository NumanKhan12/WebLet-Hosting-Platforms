using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WEBLET.DataAccess;
using WEBLET.Models;
using WEBLET.BusinessLogics;
using Newtonsoft.Json;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using WEBLET.ViewModels;
using Microsoft.AspNetCore.Http;

namespace WEBLET.Controllers
{

    public class PanelController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        //private readonly IHostingEnvironment hostingEnvironment;
        private readonly IWebHostEnvironment webHostEnvironment;
        public PanelController(IWebHostEnvironment hostEnvironment, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.webHostEnvironment = hostEnvironment;
            //this.hostingEnvironment = hostingEnvironment;

        }
        public IActionResult Panels()
        {
            return View();
        }
        public IActionResult  PanelList()
        {
             var   data = PanelProcessor.PanelList();
            return PartialView("~/Views/Panel/PanelList.cshtml", data);
        }
        
        public IActionResult PanelDetailsModel()
        {
            var data = PanelProcessor.PanelDetailsList();
            return PartialView("~/Views/Panel/PanelModel.cshtml", data);
        }
        public IActionResult SavePanel(ASP_SM_PANEL obj)
        {
            var res = PanelProcessor.AddPanel(obj);
            if (res == 1)
            {
                return Json("Success");
            }
            else
            {
                return Json("Failed");
            }

        }
        public IActionResult UpdatePanel(ASP_SM_PANEL obj)
        {
            var res=   PanelProcessor.UpdatePanel(obj);
            if (res == 1)
            {
                return Json("Success");
            }
            else
            {
                return Json("Failed");
            }

        }
        public IActionResult DelPanel(Guid ID)
        {
          var res =  PanelProcessor.DeletePanel(ID);
            if (res == 1)
            {
                return Json("Success");
            }
            else
            {
                return Json("Failed");
            }
      

        }

        public IActionResult PanelDetailsView()
        {
            return View("~/Views/Panel/PanelDetails.cshtml");
        }

        public IActionResult AddPanelDetails(string data)
        {
            PanelViewModel obj = JsonConvert.DeserializeObject<PanelViewModel>(data);
            var savedetails = PanelProcessor.AddPanelDetails(obj).ToString();
            string uniquefilename = null;
            var res = 1;
            if (Request.Form.Files.Count > 0)
            {
                foreach (var item in Request.Form.Files)
                {
                    string folder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    uniquefilename = "Attch" + Guid.NewGuid().ToString() + "_" + item.FileName;
                    string filepath = Path.Combine(folder, uniquefilename);
                    item.CopyTo(new FileStream(filepath, FileMode.Create));
                    res = PanelProcessor.AddPicPanels(uniquefilename, item.Name, savedetails);

                }
            }


            if (res == 1)
            {
                return Json("Success");
            }
            else
            {
                return Json("Failed");
            }
        }


        public IActionResult UpdatePanelDetails(string data)
        {
            PanelViewModel obj = JsonConvert.DeserializeObject<PanelViewModel>(data);
            var updateetails = PanelProcessor.UpdatePanelDetails(obj);
            
            string uniquefilename = null;
            var res = 0;
            if (Request.Form.Files.Count > 0)
            {
                foreach (var item in Request.Form.Files)
                {

                    string folder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    uniquefilename = "Attch" + Guid.NewGuid().ToString() + "_" + item.FileName;
                    string filepath = Path.Combine(folder, uniquefilename);
                    item.CopyTo(new FileStream(filepath, FileMode.Create));
                    res = PanelProcessor.AddPicPanels(uniquefilename, item.Name, obj.ID);

                }
            }


            if (updateetails == 1)
            {
                return Json("Success");
            }
            else
            {
                return Json("Failed");
            }
        }
        public IActionResult DeletePanelDetails(Guid ID)
        {
         var resd =   PanelProcessor.DelectePanelDetails(ID);
            if (resd == 1)
            {
                return Json("Success");
            }
            else
            {
                return Json("Failed");
            }

        }
        public IActionResult AdminPanelImages(PanelDetailImagesViewModel obj)
        {
            return PartialView("~/Views/Panel/Panelimages.cshtml",obj);
        }


        
    }
}
