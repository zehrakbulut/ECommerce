﻿using ECommerce.WebUI.Services.Interfaces;
using ECommerce.WebUI.Services.OrderServices.OrderOrderingServices;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Areas.User.Controllers
{
    [Area("User")]

    public class MyOrderController : Controller
    {
        private readonly IOrderOrderingService _orderOrderingService;
        private readonly IUserService _userService;

        public MyOrderController(IOrderOrderingService orderOrderingService, IUserService userService)
        {
            _orderOrderingService = orderOrderingService;
            _userService = userService;
        }

        public async Task<IActionResult> MyOrderList()
        {
            var user = await _userService.GetUserInfo();
            var values =await _orderOrderingService.GetOrderingByUserId(user.Id);
            return View(values);
        }
    }
}
