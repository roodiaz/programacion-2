﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperArena : Trooper
    {
        public override string Tipo
        {
            get { return "Soldados de asalto de terrenos desérticos"; }
        }

        public TrooperArena(Blaster armamento)
            : base(armamento)
        {

        }
    }
}
