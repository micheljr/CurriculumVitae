using System;
using System.Collections.Generic;
using Models;

namespace CurriculumVitae.Core
{
    public class Database: IDatabase
    {
        public IList<Opleiding> Opleidingen { get; set; }
        public IList<Ervaring> Ervaringen { get; set; }
        
        
        public void Initialize()
        {
            Opleidingen = new List<Opleiding>
            {
                new Opleiding
                {
                    Naam = "Techniek Wetenschappen",
                    Instituut = "Heilig Graf Turnhout",
                    Image = "images/HeiligGraf.jpg",
                    Beschrijving = "",
                    StartDatum = DateTime.Parse("01/09/2012"),
                    EindDatum = DateTime.Parse("30/06/2015")
                },
                new Opleiding
                {
                    Naam = "Toegepaste Informatica",
                    Instituut = "Karel De Grote Hogeschool campus Groenplaats",
                    Image = "images/KDG.jpg",
                    Beschrijving = "",
                    StartDatum = DateTime.Parse("01/09/2016"),
                    EindDatum = DateTime.Parse("01/05/2017")
                },
                new Opleiding
                {
                Naam = "Toegepaste Informatica afstandsonderwijs",
                Instituut = "Vives Hogeschool campus Kortrijk",
                Image = "images/Vives.png",
                Beschrijving = "",
                StartDatum = DateTime.Parse("01/09/2018"),
                EindDatum = DateTime.Parse("30/06/2022")
            }
            };
        }
    }
}