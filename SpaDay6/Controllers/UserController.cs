﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
using SpaDay6.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                /*BONUS SOLUTION:
                If students code the bonus mission, they will not need the internal if/else block
                instead, they will instantiate a new user object, and return the View("Index", newUser)
                */
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    User user = new User
                    {
                        Username = addUserViewModel.Username,
                        Password = addUserViewModel.Password,
                        Email = addUserViewModel.Email
                    };

                    return View("Index", user);
                }
                else
                {
                    ViewBag.error = "Passwords don't match!";
                    return View("Add", addUserViewModel);
                }
            }

            return View("Add", addUserViewModel);
        }
    }
}


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using SpaDay6.Models;
// using SpaDay6.ViewModels;

// // For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// namespace SpaDay6.Controllers
// {
//     public class UserController : Controller
//     {
//         // GET: /<controller>/
//         public IActionResult Index()
//         {
//             return View();
//         }

//         [HttpGet]
//         public IActionResult Add()
//         {
//             AddUserViewModel addUserViewModel = new();
//             return View(addUserViewModel);
//         }

//         [HttpPost("add")]
//         public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
//         {
//             if (ModelState.IsValid)
//             {
//                 if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
//                 {
//                     User newUser =
//                         new()
//                         {
//                             Username = addUserViewModel.Username,
//                             Email = addUserViewModel.Email,
//                             Password = addUserViewModel.Password
//                         };

//                     return View("Index", newUser);
//                 }
//                 else
//                 {
//                     ViewBag.error = "Passwords do not match! Try again!";
//                     return View(addUserViewModel);
//                 }
//             }
//             return View("Add", addUserViewModel);
//         }
//     }
// }
