﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Validators : ValidationAttribute
    {
     
            public override bool IsValid(object value)
            {
                DateTime dateTime = Convert.ToDateTime(value);
                return dateTime <= DateTime.Now;
            }
        
    }
}
