namespace CSharpLabs2024.Spells
{
    public class WaterPulse : ISpell
    {
        public int Damage { get; } = 35;
        public int ManaCost { get; } = 12;

        public void CastSpell(IDamageble target, Mage caster)
        {
            target.TakeDamage(Damage);
        }
    }
}
