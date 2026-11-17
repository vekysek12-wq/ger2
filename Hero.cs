public class Hero
{
    public string Name;
    public int Heal;
    public int Lvl;
    public int Exp;

    public Hero(string name, int heal)
    {

        
        Name = name;
        Heal = heal;
        Lvl = 1;
        Exp = 0;
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            return;
        }

        Heal -= damage;

        if (Heal < 0)
        {
            Heal = 0;
        }

    }
    public void Heall(int amount)
    {
        if (amount <= 0)
        {
            return;
        }
        Heal += amount;
    }
    public void GainExp(int amount)
    {
        if (amount <= 0)
        {
            return;
        }
        Exp += amount;
    }
    public bool IsAlive() {
         return Heal > 0;
    }
    public string GetInfo() {
    return $">>> {Name} <<<\n" +
           $"Здоровье: {Heal}\n" +
           $"Уровень: {Lvl}\n" +
           $"Опыт: {Exp}";
}



}