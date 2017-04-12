using Cinema.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.CLI {
    class Program {
        private static List<ScreeningRoom> screeningRoom;
        private static int[] timeRanges = new int[] { 19, 22, 24 };
        private const int DELAY_TIME = 30;
        static void Main(string[] args) 
        {
            loadScreeningRoom();
            loadSchedules();
        }


        private static void loadScreeningRoom() {
            screeningRoom = new List<ScreeningRoom>();
            ScreeningRoom screeningRoom1 = new ScreeningRoom();
            screeningRoom1.Name = "1";
            screeningRoom1.NumberOfSeats =156;
            ScreeningRoom screeningRoom2 = new ScreeningRoom();
            screeningRoom2.Name = "2";
            screeningRoom2.NumberOfSeats = 750;


            ScreeningRoom screeningRoom3 = new ScreeningRoom();
            screeningRoom3.Name = "3";
            screeningRoom3.NumberOfSeats = 289;

        }

        private static void loadSchedules() {
            Film PowerRangerFilm = new Film();
            PowerRangerFilm.Title = "Power Rangers";
            PowerRangerFilm.Genre = FilmGenre.Action;
            PowerRangerFilm.Duration = 125;
            PowerRangerFilm.is3d = false;
            Schedule PowerRangerSchedule = new Schedule();
            PowerRangerSchedule.Film = PowerRangerFilm;
            PowerRangerSchedule.ScreeningRoom = getScreeningRoomByName("3");
            PowerRangerSchedule.setHour(timeRanges[0], 0);
            PowerRangerSchedule.NumberOfAvailableSeats = PowerRangerSchedule.ScreeningRoom.NumberOfSeats;
            int startTime=timeRanges[0];
            for (int i = 0; i < timeRanges.Length; i++) 
            {

             }
            }

        private static ScreeningRoom getScreeningRoomByName(string name) 
       {
            return screeningRoom.Find(sr => sr.Name.Equals(name));
            



        }
            
        
    }
}
