using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newapp.Data;
using Newapp.Models;

namespace Newapp.Controllers
{
    public class ClientController : Controller
    {
        ClientDbContext ClientDbContext;

        public ClientController(ClientDbContext _ClientDbContext)
        {
            ClientDbContext = _ClientDbContext;
        }

        public IActionResult Index()
        {
            var Client = ClientDbContext.Clients;
            return View(Client);
        }

        [HttpGet]
        public IActionResult Search(string search)
        {
            return View(ClientDbContext.Clients.Where(x => x.Name.StartsWith(search) || search == null).ToList());

           
            
        }

        [HttpGet]
        public IActionResult SearchName(string search)
        {
            return PartialView(ClientDbContext.Clients.Where(x => x.Name.StartsWith(search) || search == null).ToList());



        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var Client = ClientDbContext.Clients.Find(id);
            return PartialView(Client);
        }
       
        public IActionResult AjaxDelete(int id)
        {
            var Client = ClientDbContext.Clients.Find(id);
            ClientDbContext.Remove(Client);
            ClientDbContext.SaveChanges();
            var Clients = ClientDbContext.Clients;
            return PartialView("ClientView",Clients);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id !=0)
            {
                var Client = ClientDbContext.Clients.Find(id);
                return PartialView(Client);
            }
            return PartialView(new Client());
        }

        [HttpPost]
        public IActionResult Edit(Client Client)
        {
            if(ModelState.IsValid)
            { 
                if(Client.ClientId==0)
                {
                    ClientDbContext.Add(Client);
                }
                else
                {
                    ClientDbContext.Update(Client);
                }
           
            ClientDbContext.SaveChanges();
            var Clients = ClientDbContext.Clients;
            return PartialView("ClientView",Clients);

            }
            return View();
        }

    }
}