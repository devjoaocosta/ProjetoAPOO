﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Apoo.Models
{
    public class Item
    {
        public long ItemId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}