﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace meraRESU.ME.Models
{
    public class EmployeePublication
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public string Publication { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}