using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Poslovi;
using System.Xml;
using System.Globalization;

namespace ConsoleAppTester
{
    class Program
    {

        static void Main(string[] args)
        {
            string url = "http://burzarada.hzz.hr/rss/rsskat1003.xml";

            CategoryRepository catrep = new CategoryRepository();

            List<Job> Prije = catrep.GetDbJobs();


            foreach(Job job in Prije)
            {
                Console.WriteLine(job.sJobPubDate);
            }

            string iDate = Prije[3].sJobPubDate;
            DateTime oDate = Convert.ToDateTime(iDate);
            Console.WriteLine(oDate.Day + "    " + oDate.Month + "     " + oDate.Year);

            Console.ReadLine();
        }
    }
}