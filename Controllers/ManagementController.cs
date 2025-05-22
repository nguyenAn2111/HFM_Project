using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using Hospital_Test.Models;
using Hospital_Test.DAO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using System.Reflection.Metadata;
using System.Collections;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace Hospital_Test.Controllers
{
    public class ManagementController : Controller
    {
        public IActionResult Index()
        {
            return View("Trangchu");
        }
        public IActionResult Trangchu() {

            return View("~/Views/Shared/Trangchu.cshtml");
        }
        public IActionResult Thietbi() {

            return View("~/Views/Shared/Thietbi.cshtml");
        }
        public IActionResult Baotri_Suachua() {
            return View("~/Views/Shared/Baotri_Suachua.cshtml");
        }
        public IActionResult Baotri()
        {
            return View("~/Views/Shared/Baotri.cshtml");
        }
        public IActionResult Suachua()
        {
            return View("~/Views/Shared/Suachua.cshtml");
        }
        public IActionResult Kho()
        {
            return View("~/Views/Shared/Kho.cshtml");
        }
        public IActionResult Taichinh_Hopdong()
        {
            return View("~/Views/Shared/Taichinh_Hopdong.cshtml");
        }
    }

}
