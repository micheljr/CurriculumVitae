using System;
using System.Collections.Generic;
using CurriculumVitae2.Domain.Models;

namespace CurriculumVitae2.Core
{
    public class Database: IDatabase
    {
        public IList<Opleiding> Opleidingen { get; set; }
        public IList<Ervaring> Ervaringen { get; set; }
        public IList<Project> Projecten { get; set; }


        public void Initialize()
        {
            Opleidingen = new List<Opleiding>
            {
                new()
                {
                    Naam = "Techniek Wetenschappen",
                    Instituut = "Heilig Graf Turnhout",
                    Image = "HeiligGraf.jpg",
                    Beschrijving = "",
                    StartDatum = DateTime.Parse("01/09/2012"),
                    EindDatum = DateTime.Parse("30/06/2015")
                },
                new()
                {
                    Naam = "Toegepaste Informatica",
                    Instituut = "Karel De Grote Hogeschool campus Groenplaats",
                    Image = "KDG.png",
                    Beschrijving = "",
                    StartDatum = DateTime.Parse("15/09/2016"),
                    EindDatum = DateTime.Parse("01/05/2017")
                },
                new()
                {
                Naam = "Toegepaste Informatica afstandsonderwijs",
                Instituut = "Vives Hogeschool campus Kortrijk",
                Image = "Vives.png",
                Beschrijving = "",
                StartDatum = DateTime.Parse("01/09/2018"),
                EindDatum = DateTime.Parse("30/06/2022")
                }
            };
            Ervaringen = new List<Ervaring>
            {
                new()
                {
                    Name = "Technisch laborant",
                    BedrijfName = "Lavetan",
                    Beschrijving = "De laborant microbiologie behandeld de stalen zodat deze op voedingsbodems geënt kunnen worden.",
                    StartDatum = DateTime.Parse("01/07/2015"),
                    EindDatum = DateTime.Parse("01/09/2016"),
                    Image = "Lavetan.png"
                },
                new()
                {
                    Name = "Machine operator",
                    BedrijfName = "Soudal",
                    Beschrijving = "De operator zorgt ervoor dat het machine kan blijven produceren, dit gaat van storingen oplossen tot ervoor zorgen dat alles aanwezig is dat nodig is om orders af te werken.",
                    StartDatum = DateTime.Parse("01/05/2017"),
                    EindDatum = default,
                    Image = "Soudal.png"
                }
            };
            Projecten = new List<Project>
            {
                new()
                {
                    Name = "Curriculum Vitae",
                    Url = "https://github.com/micheljr/CurriculumVitae",
                    Beschrijving = "CV gemaakt in C#.NET Core Web",
                    Image ="CV.png"
                },
                new ()
                {
                    Name = "Supermarket.API",
                    Url = "https://dev.azure.com/r0762289/_git/Supermarket.API",
                    Beschrijving = "Project om het maken van een CRUD REST API in C#.NET te testen",
                    Image = "Supermarket.png"
                }
            };
        }
    }
}