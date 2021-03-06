﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TablaPeriodica.Models;

namespace TablaPeriodica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       /* public IActionResult Elementos()
        {
            List<ElementosT> elementos = new List<ElementosT>() //{ new Elementos()
            {
              new ElementosT{ Name = "H 1", Clasificacion = "No Metales", Elements ="" },
              new ElementosT {Name = "He 2", Clasificacion = "Gases Nobles", Elements ="" },
              new ElementosT { Name = "Li 3", Clasificacion = "Alcalino", Elements ="" },
              new ElementosT { Name = "Be 4", Clasificacion = "Alcalinoterreos", Elements ="" },

              new ElementosT { Name = "B 5", Clasificacion = "Metaloide", Elements ="" },
              new ElementosT { Name = "C 6", Clasificacion = "Otro Metales", Elements ="" },
              new ElementosT { Name = "N 7", Clasificacion = "Otro Metales", Elements ="" },
              new ElementosT { Name = "O 8", Clasificacion = "Alogeno", Elements ="" },
              new ElementosT { Name = "F 9", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Ne 10", Clasificacion = "Gases Nobles", Elements ="" },
              new ElementosT { Name = "Na 11", Clasificacion = "Alcaloides", Elements ="" },
              new ElementosT { Name = "Mg 12", Clasificacion = "Alcalinoterreos", Elements ="" },
              new ElementosT { Name = "Al 13", Clasificacion = "Otros Metaltes", Elements ="" },
              new ElementosT { Name = "Si 14", Clasificacion = "Metaloides", Elements ="" },
              new ElementosT { Name = "P 15", Clasificacion = "Otros Metales", Elements ="" },
              new ElementosT { Name = "S 16", Clasificacion = "Otros Metales", Elements ="" },
              new ElementosT { Name = "Cl 17", Clasificacion = "Halogeno", Elements ="" },
              new ElementosT { Name = "Ar 18", Clasificacion = "Gases Nobles", Elements ="" },
              new ElementosT { Name = "K 19", Clasificacion = "Alcalinos", Elements ="" },
              new ElementosT { Name = "Ca 20", Clasificacion = "Alcalinoterreos", Elements ="" },
              new ElementosT { Name = "Sc 21", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Ti 22", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "V 23", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Cr 24", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Mn 25", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Fe 26", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Co 72", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Ni 28", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Cu 29", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Zn 30", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Ga 31", Clasificacion = "Otros Metales", Elements ="" },
              new ElementosT { Name = "Ge 32", Clasificacion = "Metaloides", Elements ="" },
              new ElementosT { Name = "As 33", Clasificacion = "Metaloides", Elements ="" },
              new ElementosT { Name = "Se 34", Clasificacion = "Halogenos", Elements ="" },
              new ElementosT { Name = "Br 35", Clasificacion = "Gases Nobles", Elements ="" },
              new ElementosT { Name = "Kr 36", Clasificacion = "Gases NObles", Elements ="" },
              new ElementosT { Name = "Rb 37", Clasificacion = "Alcaloides", Elements ="" },
              new ElementosT { Name = "Sr 38", Clasificacion = "Alcalinoterreos", Elements ="" },
              new ElementosT { Name = "Y 39", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Zr 40", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Nb 41", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Mo 42", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Tc 43", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Ru 44", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Rh 45", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Pd 46", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Ag 47", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Cd 48", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "In", Clasificacion = "Otros Metales", Elements ="" },
              new ElementosT { Name = "Sn 50", Clasificacion = "Otros Metales", Elements ="" },
              new ElementosT { Name = "Sb 51", Clasificacion = "Metaloides", Elements ="" },
              new ElementosT { Name = "Te 52", Clasificacion = "Metaloides", Elements ="" },
              new ElementosT { Name = "I 53", Clasificacion = "Halogeno", Elements ="" },
              new ElementosT { Name = "Xe 54", Clasificacion = "Gases Nobles", Elements ="" },
              new ElementosT { Name = "Cs 55", Clasificacion = "Alcaloides", Elements ="" },
              new ElementosT { Name = "Ba 56", Clasificacion = "Alcalinoterreos", Elements ="" },
              new ElementosT { Name = "La-Lu 57-71", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Hf 72", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Ta 73", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "W 74", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Re 75", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Os 76", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Ir 77", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Pt 78", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Au 79", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Hg 80", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "TI 81", Clasificacion = "Otros Metales", Elements ="" },
              new ElementosT { Name = "Pb 82", Clasificacion = "Otros Metales", Elements ="" },
              new ElementosT { Name = "Bi 83", Clasificacion = "Otros Metales", Elements ="" },
              new ElementosT { Name = "Po 84", Clasificacion = "Metaloides", Elements ="" },
              new ElementosT { Name = "At 85", Clasificacion = "Halogenos", Elements ="" },
              new ElementosT { Name = "Rn 86", Clasificacion = "Gases Nobles", Elements ="" },
              new ElementosT { Name = "Fr 87", Clasificacion = "Alcaloides", Elements ="" },
              new ElementosT { Name = "Ra 88", Clasificacion = "Alcalinoterreos", Elements ="" },
              new ElementosT { Name = "Ac-Lr 89-103", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Rf 104", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Db 105", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Sg 106", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Bh 107", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Hs 108", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Mt 109", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Ds 110", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Rg 111", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Cn 112", Clasificacion = "Metales de Transiccion / Bloque D", Elements ="" },
              new ElementosT { Name = "Nh 113", Clasificacion = "Otros Elementos", Elements ="" },
              new ElementosT { Name = "FI 114", Clasificacion = "Otros Elementos", Elements ="" },
              new ElementosT { Name = "Mc 115", Clasificacion = "Otros Elementos", Elements ="" },
              new ElementosT { Name = "Lv 116", Clasificacion = "Otros Elementos", Elements ="" },
              new ElementosT { Name = "Ts 117", Clasificacion = "Halogenos", Elements ="" },
              new ElementosT { Name = "Og 118", Clasificacion = "Gases Nobles", Elements ="" },
              new ElementosT { Name = "La 57", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Ce 58", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Pr 59", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Nd 60", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Pm 61", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Sm 62", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Eu 63", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Gd 64", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Tb 65", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Dy 66", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Ho 67", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Er 68", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Tm 69", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Yb 70", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Lu 71", Clasificacion = "Lantanidos", Elements ="" },
              new ElementosT { Name = "Ac 89", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Th 90", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Pa 91", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "U 92", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Np 93", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Pu 94", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Am 95", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Cm 96", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Bk 97", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Cf 98", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Es 99", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Fm 100", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Md 101", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "No 102", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Lr 103", Clasificacion = "Actinidos", Elements ="" },
              new ElementosT { Name = "Metales", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Alcalinos", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Alcalinoterreos", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Metales de Transicion / Bloque D", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Lantanidos", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Actinidos", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Otros Metales", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Metaloides", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "No Metales", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Otros Metales", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Halogenos", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "Gases Nobles", Clasificacion = "", Elements ="" },
              new ElementosT { Name = "", Clasificacion = "", Elements ="" }


            };


            ViewBag.Elementos = elementos;
            return View();
        }*/
    }
}
