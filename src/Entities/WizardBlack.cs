namespace JogoRPG.src.Entities
{
    public class WizardBlack : Hero
    {
        public WizardBlack(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6){
                return this.Name + " lançou magia super efetiva com bônus de " + Bonus;
            } else {
                return this.Name + " lançou uma magia com força fraca com bônus de " + Bonus;
            }
            
        }
    }
}