﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.Entity;

namespace GamesCharacters
{
    public class ComputerGame
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public int ESRBRating { get; set; }
        public virtual List<Character> Characters { get; set; }
    }
}
