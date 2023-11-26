﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppointmentManagementApp.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string Title { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}