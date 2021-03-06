﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Events
    {
        public int ID { get; set; }
        public string NameOfEvent { get; set; }
        public string PlaceOfEvent { get; set; }
        [DataType(DataType.Date)]
        public DateOfEvent dateOfEvent = new DateOfEvent();
        public int Lasting { get; set; }
        public int NumberOfVolunteersNeeded { get; set; }
        public string TipeOfActyvities { get; set; }
        public string TipeOfEvent { get; set; }
    }

    public class DateOfEvent
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}
