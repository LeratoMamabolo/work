﻿using Microsoft.AspNetCore.Mvc;
using OnlineBookingFacility.Data;

namespace OnlineBookingFacility.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IRepositoryWrapper _repository;
        public NavigationMenuViewComponent(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_repository.Category.FindAll());
        }
    }
}
