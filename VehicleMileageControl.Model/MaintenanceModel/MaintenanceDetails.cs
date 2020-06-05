﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model
{
    public class MaintenanceDetails
    {
        [Display(Name = "Maintenance Id")]
        public int MaintenanceId { get; set; }
        [Display(Name = "Odometer Mileage")]
        public int OdomoterMileage { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
        [Display(Name = "Message Id")]
        public int MessageId { get; set; }
        [Display(Name = "Message")]
        public string MessageStr { get; set; }
        [Display(Name = "Vehicle Information Id")]
        public int VehicleInformationId { get; set; }
        [Display(Name = "Vehicle Information")]
        public string VehicleInformationStr { get; set; }
        [Display(Name = "Note Id")]
        public int NoteId { get; set; }
    }
}
