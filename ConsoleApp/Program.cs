using System;
using System.Collections.Generic;
using System.IO.Compression;
using ExampleLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make the survey hours object.
            var surveyHours = new SurveyHours();
            
            // Make some visit types.
            VisitType grassVisit = new VisitType() {Name = "Grass", Freq = 20};
            VisitType pestVisit = new VisitType() {Name = "Pest", Freq = 10};
            VisitType treesVisit = new VisitType() {Name = "Trees", Freq = 15};
            VisitType shrubsVisit = new VisitType() {Name = "shrubs", Freq = 18};
            
            // Make some sites.
            Site site1 = new Site() {Name = "Site 1", Address = "Address 1", Postcode = "Postcode1"};
            Site site2 = new Site() {Name = "Site 2", Address = "Address 2", Postcode = "Postcode2"};
            
            // Add some visits to the sites.
            site1.AddVisit(grassVisit, 5.5);
            site1.AddVisit(pestVisit, 4.25);
            site1.AddVisit(shrubsVisit, 2.5);
            
            site2.AddVisit(grassVisit, 3);
            site2.AddVisit(treesVisit, 10.5);
            site2.AddVisit(shrubsVisit, 6.75);

            // Add the sites to the survey hours.
            surveyHours.AddSite(site1);
            surveyHours.AddSite(site2);
            
            // Print the result.
            surveyHours.Print();

            Console.ReadLine();
        }
    }
}