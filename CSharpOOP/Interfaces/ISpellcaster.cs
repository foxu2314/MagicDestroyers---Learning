﻿using Characters.Warriors;
using CSharpOOP.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Interfaces
{
    public interface ISpellcaster
    {
        int Mana { get; set; }

        void CastSpell(Character character);
    }
}
