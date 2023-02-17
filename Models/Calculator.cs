using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Licenses;
using NuGet.Protocol.Plugins;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using Xceed.Wpf.Toolkit;

namespace WebCalculator.Models
{
    public class Calculator
    {

        [Key]
        [Required]
        public int ID { get; set; }

        [Display(Name = "1. číslo")]
        public float PrvniCislo { get; set; }
        [Display(Name = "2. číslo")]
        public float DruheCislo { get; set; }
        public float Vysledek { get; private set; }
        public int Result { get; set; }
        [Display(Name = "Operace")]
        public string Operace { get; set; }
        //public string Chyba { get; set; }


        //[NotMapped]
        //public ICollection<SelectListItem> MozneOperace { get; set; } = null!;
        //public Calculator()
        //{
        //    Operace = "+";
        //    MozneOperace = new List<SelectListItem>
        //    {
        //        new SelectListItem { Text = "Sečti", Value = "+", Selected = true },
        //        new SelectListItem { Text = "Odečti", Value = "-" },
        //        new SelectListItem { Text = "Vynásob", Value = "*" },
        //        new SelectListItem { Text = "Vyděl", Value = "/" }
        //    };

        //}

        public void VypocitejVysledek()
        {
            
                Vysledek = Operace switch

                {
                    "+" => PrvniCislo + DruheCislo,
                    "-" => PrvniCislo - DruheCislo,
                    "*" => PrvniCislo * DruheCislo,
                    "/" => PrvniCislo / DruheCislo,
                    _ => 0
                };

                Result = (int)Math.Round(Vysledek);


            if ((Operace == "/" && DruheCislo == 0))
            {
            }
        }

        public void SendError(Action action) 
        {
            //var logger = NLog.LogManager.GetLogger("MyLogger");
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info($"App Starter");


            try
            {
                
                action();
                

            }
            catch (Exception exception)
            {
                //Chyba = "Nelze delit 0!";
                Console.WriteLine($"Something went wrong: {exception}");
                //Result = 0;

            }


            //catch(DbUpdateException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Nelze delit 0!: {ex}");

            //}

            //finally
            //{
            //    //log ExceptionLogger a nebo pomoci Nlog
            //}

        }
    }
}


    

