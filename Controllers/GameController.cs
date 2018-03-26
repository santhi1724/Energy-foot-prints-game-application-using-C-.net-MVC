using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game_Web_App.Controllers
{
    public class GameController : Controller
    {
        GameDBEntities2 db = new GameDBEntities2();
        // GET: Game
        public static class Score
        {
            public static int UserScore = 0;
            public static int TimeUsed = 0;
            public static int HintsUsed = 0;
            public static int ObjectsCollected = 0;
            public static int CoinsUsed = 0;
            public static string Level = "InComplete";
            public static string userName = "XXX";
        }
        public ActionResult Page1()
        {
            return View();
        }
        public ActionResult Page2()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
       /*public ActionResult Registration(Table_Housing User)
          {
              db.Table_Housing.Add(User);
              db.SaveChanges();
              return View();
          }*/
        public ActionResult Page4(Table_Housing User)
        {
            //db.Table_Housing.Add(User);
            //db.SaveChanges();
            var username = User.User_name;
            Score.userName = username;
            return View();
        }
        public ActionResult Heating(int room_temp, bool windowCheckbox, bool acCheckbox)
        {
           var heat = new Heat();
            heat.AC_status = acCheckbox;
            heat.Window_status = windowCheckbox;
            heat.Room_temp_Page4 = room_temp;
            db.Heats.Add(heat);
            db.SaveChanges();
            return View();
        }
      
       
        public ActionResult Heat()
        {    
           // db.Table_2.Add(heat);
           // db.SaveChanges();
            return View();
        }

        public ActionResult HeatValues(int room_temp, bool windowCheckbox, bool acCheckbox, bool blindCheckbox, bool fanCheckbox)
        {
            var values = new Table_5();
            values.AC_status_heat = acCheckbox;
             values.Window_status_heat = windowCheckbox;
             values.Room_temp_Heat = room_temp;
             values.Blinds_status_heat = blindCheckbox;
             values.Fan_status_heat = fanCheckbox;
            // values.Tab2_ID = id;
             db.Table_5.Add(values);
             db.SaveChanges();
            return View();
        }

        public ActionResult Page6()
        {

            return View();
        }

        //public ActionResult Page7()
        //{


        //    return View();
        //}

        //public ActionResult Page7values(int room_temperature)
        //{
        //    var page7_values = new Table_7();

        //  //  values.Tab2_ID = id;
        //  page7_values.room_temp_7 = room_temperature;
        //     db.Table_7.Add(page7_values);
        //     db.SaveChanges();
        //    return View();
        //}
        public ActionResult september()
        {
            return View();
        }
        public ActionResult SeptemberValues(int room_temp, bool HeatCheckbox, bool win_insCheckbox, bool ductCheckbox, bool caulkCheckbox)
        {
            //var sepvalues = new Table_Cold();
            //sepvalues.Heat_status_cold = HeatCheckbox;
            //coldvalues.Win_ins_status_cold = win_insCheckbox;
            //coldvalues.Room_temp_cold = room_temp;
            //coldvalues.duct_status_cold = ductCheckbox;
            //coldvalues.caulk_status_cold = caulkCheckbox;
            //// values.Tab2_ID = id;
            //db.Table_Cold.Add(coldvalues);
            //db.SaveChanges();
            return View();
        }
        public ActionResult page8_5()
        {
            return View();
        }
        public ActionResult cold()
        {
            return View();
        }
        public ActionResult ColdValues(int room_temp, bool HeatCheckbox, bool win_insCheckbox, bool ductCheckbox, bool caulkCheckbox)
        {
             var coldvalues = new Table_Cold();
            coldvalues.Heat_status_cold = HeatCheckbox;
             coldvalues.Win_ins_status_cold = win_insCheckbox;
             coldvalues.Room_temp_cold = room_temp;
             coldvalues.duct_status_cold = ductCheckbox;
             coldvalues.caulk_status_cold = caulkCheckbox;
            // values.Tab2_ID = id;
             db.Table_Cold.Add(coldvalues);
             db.SaveChanges();
            return View();
        }
        public ActionResult wisdom()
        {
            return View();
        }        

        public ActionResult ScoreValues(int time, int hint_counter, int object_counter, int score)
        {
            var scorevalues = new Table_wisdom();
            scorevalues.time =  time;
            scorevalues.hint_counter = hint_counter;
            scorevalues.object_counter = object_counter;
            scorevalues.score = score;
            Score.UserScore = score;
            Score.TimeUsed = (120 - time);
            Score.ObjectsCollected = object_counter;
            Score.HintsUsed = hint_counter;
            //Score.CoinsUsed = (hint_counter-2);
            if ((hint_counter - 2) <= 0)
                Score.CoinsUsed = (-1) * (hint_counter - 2);
            else
                Score.CoinsUsed = (hint_counter - 2);

            if (Score.UserScore <= 550)
                Score.Level = "INCOMPLETE";
            else
                Score.Level = "COMPLETE!";
            // values.Tab2_ID = id;
            db.Table_wisdom.Add(scorevalues);
            db.SaveChanges();
            return View();
        }
        public ActionResult score()
        {
            var FinalScore = Score.UserScore;
            ViewData["finalscore"] = FinalScore;
            var FinalLevel = Score.Level;
            ViewData["finallevel"] = FinalLevel;
            var FinalHints = Score.HintsUsed;
            ViewData["finalhints"] = FinalHints;
            var FinalObjects = Score.ObjectsCollected;
            ViewData["finalobjects"] = FinalObjects;
            var FinalCoins = Score.CoinsUsed;
            ViewData["finalcoins"] = FinalCoins;
            var FinalTime = Score.TimeUsed;
            ViewData["finaltime"] = FinalTime;
            
            return View();
        }
        public ActionResult Page9()
        {
            return View();
        }
        public ActionResult Page10()
        {
            return View();
        }
        public ActionResult Page12a()
        {
            return View();
        }
        public ActionResult Page12()
        {
            var FScore = Score.UserScore;
            ViewData["fscore"] = FScore;
            var UserName = Score.userName;
            ViewData["username"] = UserName;
            return View();
        }
        public ActionResult Page13()
        {
            
            return View();
        }
        public ActionResult BillValues(int room_temp, bool heatCheckbox, bool windowCheckbox, bool ductsCheckbox, bool caulkingCheckbox)
        {
            var billvalues = new Table_9();
            billvalues.Room_temp_bill = room_temp;
            billvalues.heat_status_bill = heatCheckbox;
            billvalues.Window_status_bill = windowCheckbox;

            billvalues.ducts_status_bill = ductsCheckbox;
            billvalues.caulking_status_bill = caulkingCheckbox;
            // values.Tab2_ID = id;
            db.Table_9.Add(billvalues);
            db.SaveChanges();
            return View();
        }
        public ActionResult Page14()
        {
            return View();
        }
    }
}