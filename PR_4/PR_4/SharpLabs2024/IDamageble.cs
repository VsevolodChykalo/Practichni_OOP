using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs2024
{
    public interface IDamageble
    {
        string Name { get; set; } 
        void TakeDamage(int damage);
        void Defend();
    }
}
