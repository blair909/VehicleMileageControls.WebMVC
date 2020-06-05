﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Data
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [Required]
        public Guid MessageOwnerId { get; set; }
        public string NewMessage { get; set; }
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
        public string MessageOne
        {
            get => a;
            set { a = "Every 3,000 miles. It's probably time to change your oil and oil filter (regular oil). \n"; }
        }
        public string MessageTwo
        {
            get => b;
            set { b = "Every 6,000 miles. It's probably time for a tire rotation. \n"; }
        }
        public string MessageThree
        {
            get => c;
            set { c = "Every 7,000 miles. Consider changing your oil and oil filter (synthetic oil). \n"; }
        }
        public string MessageFour
        {
            get => d;
            set { d = "Every 9,000 miles. Based on your mileage it could be time for a tire aligment. \n"; }
        }
        public string MessageFive
        {
            get => e;
            set { e = "Every 15,000 miles. It's time for a complete vehicle inspection. \n"; }
        }
        public string MessageSix
        {
            get => f;
            set { f = "Every 20,000 miles. It's possible you need to change out your engine air filter. \n"; }
        }
        public string MessageSeven
        {
            get => g;
            set { g = "Every 20,000 miles. It's possible you need to change out your cabin air filter. \n"; }
        }
        public string MessageEight
        {
            get => h;
            set { h = "Every 20,000 miles. It's probably time to get your spark plugs changed (copper). \n"; }
        }
        public string MessageNine
        {
            get => i;
            set { i = "Every 30,000 miles. Based on your mileage you should consider getting your fuel filter changed out. \n"; }
        }
        public string MessageTen
        {
            get => j;
            set { j = "Every 35,000 miles. It's about time to change your brake fluid. \n"; }
        }
        public string MessageEleven
        {
            get => k;
            set { k = "Every 40,000 miles. Around this mileage people normally change their transmission fluid and transmission filter. You could inspect your transmission systems as well. \n"; }
        }
        public string MessageTwelve
        {
            get => l;
            set { l = "Every 45,000 miles. It's time to get your brake pads looked at and get a full brake systems inspection. \n"; }
        }
        public string MessageThirteen
        {
            get => m;
            set { m = "Every 50,000 miles. At your current mileage your battery may need to be replaced. You could also get an electrical/lighting systems inspection. \n"; }
        }
        public string MessageFourteen
        {
            get => n;
            set { n = "Every 55,000 miles. You could get your engine coolant levels assesed and/or changed. You could also get a cooling systems inspection. \n"; }
        }
        public string MessageFifteen
        {
            get => o;
            set { o = "Every 60,000 miles. It's probably time for a complete HVAC inspection. \n"; }
        }
        public string MessageSixteen
        {
            get => p;
            set { p = "Every 60,000 miles. At your mileage people often get a complete suspension component inspection and complete steering systems inspection. \n"; }
        }
        public string MessageSeventeen
        {
            get => q;
            set { q = "Every 60,000 miles. You should consider getting your brake rotors assesed and changed. \n"; }
        }
        public string MessageEighteen
        {
            get => r;
            set { r = "Every 60,000 miles. It's probably time for a radiatior hose inspection and/or change. \n"; }
        }
        public string MessageNineteen
        {
            get => s;
            set { s = "Every 70,000 miles. You should consider getting your timing belt checked out for signs of wear and tear. While you're at it you could get a full engine inspection/tune-up. \n"; }
        }
        public string MessageTwenty
        {
            get => t;
            set { t = "Every 70,000 miles. It could be about time to change/flush your power steering fluid. \n"; }
        }
        public string MessageTwentyone
        {
            get => u;
            set { u = "Every 80,000 miles. It's most likely time to get your spark plugs changed (platinum or iridium). \n"; }
        }
        public string MessageTwentytwo
        {
            get => v;
            set { v = "Every 100,000 miles. At this high mileage people can check their rubber hoses and fixtures for signs of cracking and damage. You could also get your drive-train systems inspected. \n"; }
        }
        public string MessageTwentythree
        {
            get => w;
            set { w = "Every 40,000 miles. If you have a front-wheel drive train (FWD) it may be time to get new front tires. If you have a rear-wheel drive train (RWD) it is time to get new rear tires. \n"; }
        }
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
        public string MessageTwentysix
        {
            get => z;
            set { z = "Every 125,000 miles. Your alternator may need to be changed soon. \n"; }
        }
        public string MessageTwentyseven
        {
            get => aa;
            set { aa = "Every 50,000 miles. If you have an all-wheel drive train (AWD) it may be time to get a complete set of new tires. \n"; }
        }
        public string MessageTwentyeight
        {
            get => ab;
            set { ab = "Every 70,000 miles. You should get an exhaust/emissions systems inspection. "; }
        }
    }
}
