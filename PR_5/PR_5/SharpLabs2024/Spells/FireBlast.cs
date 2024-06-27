namespace CSharpLabs2024.Spells
{
    public class FireBlast : ISpell
    {
        public int Damage { get; } = 40;
        public int ManaCost { get; } = 15;

        public void CastSpell(IDamageble target, Mage caster)
        {
            target.TakeDamage(Damage);
        }
    }
}
