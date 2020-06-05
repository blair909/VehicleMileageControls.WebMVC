﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.MessageModel
{
    public class MessageDetails
    {
        [Display(Name = "Message Id")]
        public int MessageId { get; set; }
        public string a;
        public string b;
        public string c;
        public string d;
        public string e;
        public string f;
        public string g;
        public string h;
        public string i;
        public string j;
        public string k;
        public string l;
        public string m;
        public string n;
        public string o;
        public string p;
        public string q;
        public string r;
        public string s;
        public string t;
        public string u;
        public string v;
        public string w;
        public string x;
        public string y;
        public string z;
        public string aa;
        public string ab;
        [Display(Name = "Regular Oil")]
        public string MessageOne
        {
            get => a;
            set { a = "Every 3,000 miles. It's probably time to change your oil and oil filter (regular oil). \n"; }
        }
        [Display(Name = "Tire Rotation")]
        public string MessageTwo
        {
            get => b;
            set { b = "Every 6,000 miles. It's probably time for a tire rotation. \n"; }
        }
        [Display(Name = "Synthetic Oil")]
        public string MessageThree
        {
            get => c;
            set { c = "Every 7,000 miles. Consider changing your oil and oil filter (synthetic oil). \n"; }
        }
        [Display(Name = "Tire Alignment")]
        public string MessageFour
        {
            get => d;
            set { d = "Every 9,000 miles. Based on your mileage it could be time for a tire aligment. \n"; }
        }
        [Display(Name = "Complete Vehicle Inspection")]
        public string MessageFive
        {
            get => e;
            set { e = "Every 15,000 miles. It's time for a complete vehicle inspection. \n"; }
        }
        [Display(Name = "Engine Air Filter")]
        public string MessageSix
        {
            get => f;
            set { f = "Every 20,000 miles. It's possible you need to change out your engine air filter. \n"; }
        }
        [Display(Name = "Cabin Air Filter")]
        public string MessageSeven
        {
            get => g;
            set { g = "Every 20,000 miles. It's possible you need to change out your cabin air filter. \n"; }
        }
        [Display(Name = "Copper Spark Plugs")]
        public string MessageEight
        {
            get => h;
            set { h = "Every 20,000 miles. It's probably time to get your spark plugs changed (copper). \n"; }
        }
        [Display(Name = "Fuel Filter")]
        public string MessageNine
        {
            get => i;
            set { i = "Every 30,000 miles. Based on your mileage you should consider getting your fuel filter changed out. \n"; }
        }
        [Display(Name = "Brake Fluid")]
        public string MessageTen
        {
            get => j;
            set { j = "Every 35,000 miles. It's about time to change your brake fluid. \n"; }
        }
        [Display(Name = "Transmission Components")]
        public string MessageEleven
        {
            get => k;
            set { k = "Every 40,000 miles. Around this mileage people normally change their transmission fluid and transmission filter. You could inspect your transmission systems as well. \n"; }
        }
        [Display(Name = "Brake Pads")]
        public string MessageTwelve
        {
            get => l;
            set { l = "Every 45,000 miles. It's time to get your brake pads looked at and get a full brake systems inspection. \n"; }
        }
        [Display(Name = "Battery")]
        public string MessageThirteen
        {
            get => m;
            set { m = "Every 50,000 miles. At your current mileage your battery may need to be replaced. You could also get an electrical/lighting systems inspection. \n"; }
        }
        [Display(Name = "Engine Coolant")]
        public string MessageFourteen
        {
            get => n;
            set { n = "Every 55,000 miles. You could get your engine coolant levels assesed and/or changed. You could also get a cooling systems inspection. \n"; }
        }
        [Display(Name = "HVAC Inspection")]
        public string MessageFifteen
        {
            get => o;
            set { o = "Every 60,000 miles. It's probably time for a complete HVAC inspection. \n"; }
        }
        [Display(Name = "Suspension Components And Steering systems")]
        public string MessageSixteen
        {
            get => p;
            set { p = "Every 60,000 miles. At your mileage people often get a complete suspension component inspection and complete steering systems inspection. \n"; }
        }
        [Display(Name = "Brake Rotors")]
        public string MessageSeventeen
        {
            get => q;
            set { q = "Every 60,000 miles. You should consider getting your brake rotors assesed and changed. \n"; }
        }
        [Display(Name = "Radiator Hoses")]
        public string MessageEighteen
        {
            get => r;
            set { r = "Every 60,000 miles. It's probably time for a radiator hose inspection and/or change. \n"; }
        }
        [Display(Name = "Timing Belt")]
        public string MessageNineteen
        {
            get => s;
            set { s = "Every 70,000 miles. You should consider getting your timing belt checked out for signs of wear and tear. While you're at it you could get a full engine inspection/tune-up. \n"; }
        }
        [Display(Name = "Power Steering Fluid")]
        public string MessageTwenty
        {
            get => t;
            set { t = "Every 70,000 miles. It could be about time to change/flush your power steering fluid. \n"; }
        }
        [Display(Name = "Platinum/Iridium Spark Plugs")]
        public string MessageTwentyone
        {
            get => u;
            set { u = "Every 80,000 miles. It's most likely time to get your spark plugs changed (platinum or iridium). \n"; }
        }
        [Display(Name = "Rubber Hoses/Fixtures")]
        public string MessageTwentytwo
        {
            get => v;
            set { v = "Every 100,000 miles. At this high mileage people can check their rubber hoses and fixtures for signs of cracking and damage. You could also get your drive-train systems inspected. \n"; }
        }
        [Display(Name = "Tires")]
        public string MessageTwentythree
        {
            get => w;
            set { w = "Every 40,000 miles. If you have a front-wheel drive train (FWD) it may be time to get new front tires. If you have a rear-wheel drive train (RWD) it is time to get new rear tires. \n"; }
        }
        [Display(Name = "Tires")]
        public string MessageTwentyfour
        {
            get => x;
            set { x = "Every 60,000 miles. If you have a front-wheel drive train (FWD) it may be time to get new rear tires. If you have a rear-wheel drive train (RWD) it is time to get new front tires. \n"; }
        }
        public string MessageTwentyfive
        {
            get => y;
            set { y = "Sorry, that input is invalid. \n"; }
        }
        [Display(Name = "Alternator")]
        public string MessageTwentysix
        {
            get => z;
            set { z = "Every 125,000 miles. Your alternator may need to be changed soon. \n"; }
        }
        [Display(Name = "Tires")]
        public string MessageTwentyseven
        {
            get => aa;
            set { aa = "Every 50,000 miles. If you have an all-wheel drive train (AWD) it may be time to get a complete set of new tires. "; }
        }
        [Display(Name = "Exhuast and Emissions")]
        public string MessageTwentyeight
        {
            get => ab;
            set { ab = "Every 70,000 miles. You should get an exhaust/emissions systems inspection. "; }
        }
    }
}
