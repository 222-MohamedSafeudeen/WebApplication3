using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AccountDetails : Controller
    {
        public IActionResult Index()
        {
            IList<Account> accounts = new List<Account>();
            accounts.Add(new Account() { AccountID = 123, AccHolderName = "Mohamed Safeudeen", AccHolderAddress = "TamilNadu" });
            accounts.Add(new Account() { AccountID = 123, AccHolderName = "Mohamed Saif", AccHolderAddress = "TamilNadu" });
            accounts.Add(new Account() { AccountID = 123, AccHolderName = "Thousif", AccHolderAddress = "TamilNadu" });

            ViewData["Account"] = accounts;
            return View();

        }   
    }
}
