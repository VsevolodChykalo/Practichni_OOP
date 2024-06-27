using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024
{
    public interface ISpell
    {
        int Damage { get; }
        int ManaCost { get; }
        void CastSpell(IDamageble target, Mage caster);
    }
}

