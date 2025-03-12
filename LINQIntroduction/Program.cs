using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;
using CsvHelper;
using CsvHelper.Configuration;

namespace LINQIntroduction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string csvPath = @"C:\Users\piotr\Desktop\Practice - C#\LINQIntroduction\googleplaystore1.csv";
            var googleApps = LoadGoogleAps(csvPath);

            // Display(googleApps);
            //GetData(googleApps);
            //ProjectData(googleApps);
            //DivideData(googleApps);
            //OrderData(googleApps);
            //DataSetOperation(googleApps);
            //DataVerification(googleApps);
            //GroupData(googleApps);
            //GroupDataOperations(googleApps);
        }
                
        private static void GroupDataOperations(IEnumerable<GoogleApp> googleApps)
        {
            var categoryGroup = googleApps
                .GroupBy(g => g.Category)
                .Where(g => g.Min(a => a.Reviews) >= 10);


            foreach (var group in categoryGroup)
            {
                var averageReviews = group.Average(g => g.Reviews);
                var lowestReview = group.Min(g => g.Reviews);
                var highestReview = group.Max(g => g.Reviews);

                var reviewsCount = group.Sum(g => g.Reviews);

               var allAppsWithRatingOf3 = group.All(a => a.Rating > 3.0);

                Console.WriteLine($"Category: {group.Key}");
                Console.WriteLine($"averageReviews: {averageReviews}");
                Console.WriteLine($"lowestReview: {lowestReview}");
                Console.WriteLine($"highestReview: {highestReview}");
                Console.WriteLine($"reviewsCount: {reviewsCount}");
                Console.WriteLine($"allAppsWithRatingOf3: {allAppsWithRatingOf3}");
                Console.WriteLine();
            }
        }

        private static void GroupData(IEnumerable<GoogleApp> googleApps)
        {
            var categoryGroup = googleApps.GroupBy(g => new {g.Category, g.Type});

            foreach (var group in categoryGroup) 
            {
                var key = group.Key;
                //var apps = artAndDesignGroup.Select(e => e);
                var apps = group.ToList();

                Console.WriteLine($"Displaying elements for group {group.Key.Category}, {group.Key.Type}");
                Display(apps);
            }

           
        }

        private static void DataVerification(IEnumerable<GoogleApp> googleApps)
        {
            var allOperatorResult = googleApps.Where(a => a.Category == Category.WEATHER)
                .All(a => a.Reviews > 20);

            Console.WriteLine($"allOperatorResult: {allOperatorResult}");

            var anyOperatorResult = googleApps.Where(a => a.Category == Category.WEATHER)
                .Any(a => a.Reviews > 3_000_000);

            Console.WriteLine($"anyOperatorResult: {anyOperatorResult}");
        }

        private static void DataSetOperation(IEnumerable<GoogleApp> googleApps)
        {
            //var paidAppsCategories = googleApps.Where(a => a.Type == Type.Paid)
            //    .Select(a => a.Category)
            //    .Distinct();

            //Console.WriteLine($"Paid apps categories: {string.Join(", ", paidAppsCategories)}");

            var setA = googleApps.Where(a => a.Rating > 4.7 && a.Type == Type.Paid && a.Reviews > 1000);

            var setB = googleApps.Where(a => a.Name.Contains("Pro") && a.Rating > 4.6 && a.Reviews > 10000);

            //Display(setA);

            //Console.WriteLine("************");

            //Display(setB);

            var appsUnion = setA.Union(setB);
            //Console.WriteLine("Apps union:");
            //Display(appsUnion);

            var appsIntersect = setA.Intersect(setB);
            //Console.WriteLine("Apps intersect:");
            //Display(appsIntersect);

            var appsExcept = setA.Except(setB);
            Console.WriteLine("Apps expect:");
            Display(appsExcept);
        }

        private static void OrderData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.4 && app.Category == Category.BEAUTY);
            //Display(highRatedBeautyApps);

            var sortedResults = highRatedBeautyApps
                .OrderByDescending(app => app.Rating)
                .ThenBy(app => app.Name)
                .Take(5);

            Display(sortedResults);
        }

        private static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.4 && app.Category == Category.BEAUTY);

            //var first5HighRatedBeautyApps = highRatedBeautyApps.TakeWhile(app => app.Reviews > 1000);

            //Display(first5HighRatedBeautyApps);

            var skippedResults = highRatedBeautyApps.Skip(5);

            Display(skippedResults);
        }

        private static void ProjectData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            var highRatedBeautyAppsNames = highRatedBeautyApps.Select(app => app.Name);

            var dtos = highRatedBeautyApps.Select(app => new GoogleAppDto()
            {
                Reviews = app.Reviews,
                Name = app.Name
            });

            var anonymousDtos = highRatedBeautyApps.Select(app => new
            {
                Reviews = app.Reviews,
                Name = app.Name,
                Category = app.Category
            });

            //Console.WriteLine(string.Join(", ", highRatedBeautyAppsNames));

            foreach (var dto in anonymousDtos)
            {
                Console.WriteLine($"{dto.Name}: {dto.Reviews}");
            }

            //var genres = highRatedBeautyApps.SelectMany(app => app.Genres);
            //Console.WriteLine(string.Join(":", genres));
        }

        private static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedApps = googleApps.Where(app => app.Rating > 4.6);
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            Display(highRatedBeautyApps);

            var firstHighRatedBeautyApp = highRatedBeautyApps.FirstOrDefault(app => app.Reviews < 50);
            Console.WriteLine("firstHighRatedBeautyApp: ");
            Console.WriteLine(firstHighRatedBeautyApp);
        }

        private static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }
        }

        private static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        private static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }
        }
    }
}