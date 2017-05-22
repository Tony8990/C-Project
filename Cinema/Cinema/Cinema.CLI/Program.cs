using Cinema.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Cinema.CLI {

    
    class Program
    {
        
        private static List<ScreeningRoom> screeningRoom;
        //private static int[] timeRanges = new int[] { 1140, 1320, 1440 };
        private const int preferStart = 1440;
        private const int DELAY_TIME = 30;
        private const int openingTime = 1080;
        private const int LastTime = 1470;
        static void Main(string[] args)
        {
            
            loadScreeningRoom();
            loadSchedules();
        }


        private static void loadScreeningRoom()
        {
            screeningRoom = new List<ScreeningRoom>();
            ScreeningRoom screeningRoom1 = new ScreeningRoom();
            screeningRoom1.Name = "1";
            screeningRoom1.NumberOfSeats = 156;
            ScreeningRoom screeningRoom2 = new ScreeningRoom();
            screeningRoom2.Name = "2";
            screeningRoom2.NumberOfSeats = 750;


            ScreeningRoom screeningRoom3 = new ScreeningRoom();
            screeningRoom3.Name = "3";
            screeningRoom3.NumberOfSeats = 289;

        }

        private static void loadSchedules()
        {
            FilmCollection requestResult = makeRequest(createReaquest());
            //makeRequest(createReaquest());
            requestResult.RequiestWikipediaUrl();
            Film PowerRangerFilm = new Film();
            PowerRangerFilm.Title = "Power Rangers";
            PowerRangerFilm.Genre = FilmGenre.Action;
            PowerRangerFilm.Duration = 125;
            //PowerRangerFilm.Is3D = false;
            Schedule PowerRangerSchedule = new Schedule();
            PowerRangerSchedule.Film = PowerRangerFilm;

            //PowerRangerSchedule.ScreeningRoom = getScreeningRoomByName("3");
            PowerRangerSchedule.setHour(preferStart, 0);
            PowerRangerSchedule.NumberOfAvailableSeats = PowerRangerSchedule.ScreeningRoom.NumberOfSeats;
            Film BallacoiLupi = new Film();
            BallacoiLupi.Title = "Balla coi lupi";
            BallacoiLupi.Genre = FilmGenre.Action;
            BallacoiLupi.Duration = 125;
            //BallacoiLupi.Is3D = false;
            Schedule BallacoiLupiSchedule = new Schedule();
            BallacoiLupiSchedule.Film = BallacoiLupi;
            int maxLeght = LastTime - openingTime;
            if (maxLeght / (BallacoiLupi.Duration + 30) + 1 >= 3)
            {
                if (openingTime + (BallacoiLupi.Duration + 30) * 2 > LastTime)
                {
                }
            }
            /*
            PowerRangerSchedule.ScreeningRoom = getScreeningRoomByName("3");
            PowerRangerSchedule.setHour(timeRanges[timeRanges.Length], 0);
            PowerRangerSchedule.NumberOfAvailableSeats = PowerRangerSchedule.ScreeningRoom.NumberOfSeats;*/
            int startTime;
            /*for (int i =0; i <timeRanges.Length; i++)
            {
               // startTime=timeRanges[i];
                
                int endTime=timeRanges[i-1]+DELAY_TIME+PowerRangerFilm.Duration;
            }
            }

        private static ScreeningRoom getScreeningRoomByName(string name) 
       {
            return screeningRoom.Find(sr => sr.Name.Equals(name));
            



        }
            */

        }
        private static string createReaquest(string queryString=null)
        {
            //string urlRequest = "http://www.cinetecadibologna.it/api/GetSchedule/" + queryString;
            string urlRequest = "http://api-public.guidebox.com/v2/movies?api_key=7cc3c17336de0377ab4eac370071e01e552d4eef&region=IT" + queryString;
            return urlRequest;
        }
        private static FilmCollection makeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                /* as ci permette di fare un cast al volo http web request*/

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                string responseString = string.Empty;
                DataContractJsonSerializer serialized = new DataContractJsonSerializer(typeof(FilmCollection));
                /*using (Stream stram = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stram, Encoding.UTF8);
                    responseString = reader.ReadToEnd();
                }*/
                return serialized.ReadObject(response.GetResponseStream()) as FilmCollection ;
             /*   JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
                  return jsSerializer.Deserialize<FilmCollection>(responseString);
                  */
                    //XmlDocument xmldoc = new XmlDocument();
                    //xmldoc.Load(response.GetResponseStream());

                    
      
            }catch(HttpListenerException e)
            { return null; }
            catch(InvalidOperationException ex)
            { return null; }
        }
    }
}
