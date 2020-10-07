using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Xml;
using System.Data.Common;
using System.Data.SqlClient;

namespace Poslovi
{
    public class CategoryRepository
    {

        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        public List<string> GetTowns()
        {
            string url = "https://tehcon.com.hr/api/CroatiaTownAPI/list.php";
            string sJson = CallRestMethod(url);
            string sTown = "";
            JObject oJson = JObject.Parse(sJson);
            var oTowns = oJson["towns"].ToList();
            List<string> lTowns = new List<string>();
            for (int i = 0; i < oTowns.Count; i++)
            {
                lTowns.Add(sTown = (string)oTowns[i]["name"]);
            }
            return lTowns;
        }
        public List<Category> GetCategories()
        {
            string url = "https://data.gov.hr/api/2/rest/package/slobodna-radna-mjesta-po-zanimanju";
            string sJson = CallRestMethod(url);
            JObject oJson = JObject.Parse(sJson);
            var oCategories = oJson["resources"].ToList();
            List<Category> lCategories = new List<Category>();
            for (int i = 0; i < oCategories.Count; i++)
            {
                lCategories.Add(new Category
                {
                    sDescription = (string)oCategories[i]["description"],
                    sUrl = (string)oCategories[i]["url"],
                    nPosition = (int)oCategories[i]["position"]
                });
            }
            return lCategories;
        }
        public List<Category> GetDbCategories()
        {
            string sSqlConnectionString = "Data Source=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            {
                var lCategories = new List<Category>();
                using (DbConnection connection = new SqlConnection(sSqlConnectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Sabolicek_JobCategories";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lCategories.Add(new Category()
                            {
                                sDescription = (string)reader["DESCRIPTION"],
                                sUrl = (string)reader["URL"],
                                nPosition = (int)reader["POSITION"]
                            });
                        }
                    }
                }
                return lCategories;
            }
        }
        public void DeleteAllCategories()
        {
            string sSqlConnectionString = "Data Source=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";

            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Sabolicek_JobCategories";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void CreateCategory()
        {
            string sSqlConnectionString = "Data Source=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            CategoryRepository Kategorija = new CategoryRepository();
            List<Category> lCategories = Kategorija.GetCategories();

            Kategorija.DeleteAllCategories();

            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oConnection.Open();
                for (int i = 0; i < lCategories.Count(); i++)
                {
                    oCommand.CommandText = "INSERT INTO Sabolicek_JobCategories (DESCRIPTION, URL, POSITION) VALUES ('" + lCategories[i].sDescription + "', '" + lCategories[i].sUrl + "', '" + lCategories[i].nPosition + "')";
                    GetSteps(i);
                    using (DbDataReader oReader = oCommand.ExecuteReader())
                    {

                    }
                }
            }
        }

        private int GetSteps(int i)
        {
            return i;
        }

        public void DeleteAllJobs()
        {
            string sSqlConnectionString = "Data Source=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";

            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Sabolicek_Jobs";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public string GiveTown(string jobTown)
        {
            string sTown = "";
            List<string> sTowns = GetTowns();
            jobTown = jobTown.ToLower();
            foreach (var town in sTowns)
            {
                string grad = town;
                if (jobTown.Contains(grad.ToLower()))
                {
                    sTown = town;
                }
            }
            return sTown;
        }

        public List<Job> GetJobs(string Url)
        {
            Random random = new Random();
            int catPos = 0;
            List<Category> kategorije = GetCategories();
            foreach (Category kat in kategorije)
            {
                string katego = kat.sUrl;
                if (Url.Contains(katego))
                {
                    catPos = kat.nPosition;
                }
            }

            int ccc = catPos;

            DeleteAllJobs();

            string sXmlString;
            using (var oWebClient = new WebClient())
            {
                sXmlString = oWebClient.DownloadString(Url);
            }
            XmlDocument oXmlDocument = new XmlDocument();
            oXmlDocument.LoadXml(sXmlString);

            XmlNodeList oJobs = oXmlDocument.DocumentElement.SelectNodes("channel/item");
            List<Job> lJobs = new List<Job>();
            foreach (XmlNode oJob in oJobs)
            {             
                lJobs.Add(new Job
                {
                    sJobNaziv = (oJob.SelectSingleNode("title").InnerText),
                    sJobOpis = (oJob.SelectSingleNode("description").InnerText),
                    sJobUrl = (oJob.SelectSingleNode("link").InnerText),
                    sJobPubDate = (oJob.SelectSingleNode("pubDate").InnerText),
                    iJobCatId = catPos,
                    sJobGrad = GiveTown(oJob.SelectSingleNode("description").InnerText)
                });
            }
            return lJobs;
        }
        public List<Job> GetDbJobs()
        {
            List<Job> lJobs = new List<Job>();
            string sSqlConnectionString = "Data Source=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";

            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Sabolicek_Jobs";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lJobs.Add(new Job()
                        {
                            sJobNaziv = (string)reader["NAZIV"],
                            sJobOpis = (string)reader["OPIS"],
                            sJobUrl = (string)reader["URL"],
                            sJobGrad = (string)reader["GRAD"],
                            sJobPubDate = (string)reader["PUB_DATE"],
                            iJobCatId = (int)reader["CAT_ID"]
                        });
                    }
                }
            }
            return lJobs;
        }

        public List<Job> GetDbJobs(int catPos)
        {
            List<Job> lPoslovi = new List<Job>();

            return lPoslovi;
        }

        public void CreateJobs(Job CatJob)
        {

            string sSqlConnectionString = "Data Source=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";

            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oConnection.Open();
                try
                {
                    oCommand.CommandText = "INSERT INTO Sabolicek_Jobs VALUES ('" + CatJob.sJobNaziv + "', '" + CatJob.sJobOpis + "', '" + CatJob.sJobUrl + "', '" + CatJob.sJobGrad + "', '" + CatJob.sJobPubDate + "', '" + CatJob.iJobCatId + "') ";
                    using (DbDataReader oReader = oCommand.ExecuteReader())
                    {

                    }
                }
                catch (Exception e)
                {
                    var a = e.Message;
                }
            }
        }

    }
}
