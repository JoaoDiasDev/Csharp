﻿using System;
using System.Globalization;

namespace CourseDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //DateTime d1 = new DateTime(2018, 11, 25);
            //DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            //DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            //DateTime d4 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);

            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            //DateTime d3 = DateTime.Parse("15/08/2000");
            //DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            //DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);

            //DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();

            //string s5 = d.ToString();

            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");


            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            //DateTime d = DateTime.Now;


            //DateTime d2 = d.AddDays(7);


            //Console.WriteLine(d);
            //Console.WriteLine(d2);

            //DateTime d1 = new DateTime(2000, 10, 15);

            //DateTime d2 = new DateTime(2000, 10, 18);

            //TimeSpan t = d2.Subtract(d1);

            //Console.WriteLine(t);

            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 Kind: " + d3.Kind);
            //Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            //Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado, esta errado desta forma!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
