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
                new Opleiding
                {
                    Naam = "Techniek Wetenschappen",
                    Instituut = "Heilig Graf Turnhout",
                    Image = "HeiligGraf.jpg",
                    Beschrijving = "",
                    StartDatum = DateTime.Parse("01/09/2012", System.Globalization.CultureInfo.GetCultureInfo("nl-NL")),
                    EindDatum = DateTime.Parse("30/06/2015", System.Globalization.CultureInfo.GetCultureInfo("nl-NL"))
                },
                new Opleiding
                {
                    Naam = "Toegepaste Informatica",
                    Instituut = "Karel De Grote Hogeschool campus Groenplaats",
                    Image = "KDG.png",
                    Beschrijving = "",
                    StartDatum = DateTime.Parse("15/09/2016", System.Globalization.CultureInfo.GetCultureInfo("nl-NL")),
                    EindDatum = DateTime.Parse("01/05/2017", System.Globalization.CultureInfo.GetCultureInfo("nl-NL"))
                },
                new Opleiding
                {
                Naam = "Toegepaste Informatica afstandsonderwijs",
                Instituut = "Vives Hogeschool campus Kortrijk",
                Image = "Vives.png",
                Beschrijving = "",
                StartDatum = DateTime.Parse("01/09/2018", System.Globalization.CultureInfo.GetCultureInfo("nl-NL")),
                EindDatum = DateTime.Parse("30/06/2022", System.Globalization.CultureInfo.GetCultureInfo("nl-NL"))
                }
            };
            Ervaringen = new List<Ervaring>
            {
                new Ervaring
                {
                    Name = "Technisch laborant",
                    BedrijfName = "Lavetan",
                    Beschrijving = "De laborant microbiologie behandeld de stalen zodat deze op voedingsbodems geënt kunnen worden.",
                    StartDatum = DateTime.Parse("01/07/2015", System.Globalization.CultureInfo.GetCultureInfo("nl-NL")),
                    EindDatum = DateTime.Parse("01/09/2016", System.Globalization.CultureInfo.GetCultureInfo("nl-NL")),
                    Image = "Lavetan.png"
                },
                new Ervaring
                {
                    Name = "Machine operator",
                    BedrijfName = "Soudal",
                    Beschrijving = "De operator zorgt ervoor dat het machine kan blijven produceren, dit gaat van storingen oplossen tot ervoor zorgen dat alles aanwezig is dat nodig is om orders af te werken.",
                    StartDatum = DateTime.Parse("01/05/2017", System.Globalization.CultureInfo.GetCultureInfo("nl-NL")),
                    EindDatum = default,
                    Image = "Soudal.png"
                }
            };
            Projecten = new List<Project>
            {
                new Project
                {
                    Name = "Curriculum Vitae",
                    Url = "https://github.com/micheljr/CurriculumVitae",
                    Beschrijving = "CV gemaakt in C#.NET Core Web",
                    Image ="CV.png"
                },
                new Project
                {
                    Name = "Supermarket.API",
                    Url = "https://dev.azure.com/r0762289/_git/Supermarket.API",
                    Beschrijving = "Project om het maken van een CRUD REST API in C#.NET te testen",
                    Image = "Supermarket.png"
                },
                new Project
                {
                    Name = "Pet-Clinic",
                    Url = "https://github.com/micheljr/sfg-pet-clinic",
                    Beschrijving = "Project in Java om het Spring-framework te leren gebruiken.",
                    Image = "PetClinic.png"
                },
                new Project
                {
                    Name = "Giflib",
                    Url = "https://github.com/micheljr/giflib",
                    Beschrijving = "Project in Java om met Spring te leren werken",
                    Image = "giflib.png"
                }
            };
        }
    }
}