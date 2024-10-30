﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public class Gans : Vogel
    {
        public int Steuerkurs { get; set; }

        public override void EiLegen()
        {
            if (this.Gewicht > 2000)
            {
                Ei ei = new Ei(this);
                this.Gewicht -= ei.Gewicht;
                this.Eier.Add(ei);
            }
        }

        public override void Fressen()
        {
            if (this.Gewicht < 5000)
                this.Gewicht += 250;
        }
    }
}