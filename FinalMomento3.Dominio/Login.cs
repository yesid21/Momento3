﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMomento3.Dominio
{
    [Table("Login")]
    public class Login
    {

        public string Usuario { get; set; }

        public string Password { get; set; }
    }
}