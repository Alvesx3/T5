using BarData.Models;
using BarData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvcBar.Controllers
{
    public class CervejaController : BaseController<Cerveja, CervejaRepository>
    {
        public CervejaController()
        {

        }
    }
}