﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreGiris.Interfaces;

namespace MVCCoreGiris.Controllers
{
    public class HavaDurumuController : Controller
    {
        private readonly IWeatherService _weatherService;

        public HavaDurumuController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SicaklikGetir(string sehirAd)
        {
            try
            {
                return Json(new { sicaklik = _weatherService.Temperature(sehirAd) });
            }
            catch (Exception)
            {
                return StatusCode(503);
            }
        }
    }
}
