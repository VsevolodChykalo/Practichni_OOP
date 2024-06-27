namespace CSharpLabs2024.Spells
{
    public class WaterGun : ISpell
    {
        public int Damage { get; } = 25;
        public int ManaCost { get; } = 8;

        public void CastSpell(IDamageble target, Mage caster)
        {
            target.TakeDamage(Damage);
        }
    }
}
