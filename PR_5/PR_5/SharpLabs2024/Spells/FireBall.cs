namespace CSharpLabs2024.Spells
{
    public class FireBall : ISpell
    {
        public int Damage { get; } = 30;
        public int ManaCost { get; } = 10;

        public void CastSpell(IDamageble target, Mage caster)
        {
            target.TakeDamage(Damage);
        }
    }
}
