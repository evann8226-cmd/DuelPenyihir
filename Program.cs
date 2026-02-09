
wizard wizardA= new wizard("Harry potter", 20);
wizard wizardB = new wizard("jefta", 30);

Console.WriteLine("Permainan di mulai........\n");
wizardA.ShowStats();
wizardB.ShowStats();    

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.heal();
wizardA.Attack(wizardB);

Console.WriteLine("Permainan berakhir.....\n");
wizardA.ShowStats();
wizardB.ShowStats();


public class wizard
{
    //deklarasi field
    public string Name;
    public int Energy;
    public int damage;

    //deklarasi constructor
    public wizard (string name, int damage)
    {
        Name = name;
        Energy = 100;
        damage = damage;

    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energy} \n");

    }
    public void Attack(wizard wizardlawanObj)
    {
        //mengurangi energi wizardlawanObj sebesar damage
        wizardlawanObj.Energy -= damage;
        Console.WriteLine($"{Name} menyerang {wizardlawanObj.Name}");
        Console.WriteLine($"sisa energi {wizardlawanObj.Name} adalah {wizardlawanObj.Energy}");
    }
    
    public void heal()
    {
        Energy += 5;
        if(Energy < 100)
        {
            Energy += 5;
            Console.WriteLine($"{Name} melakukan heal energi meningkatkan menjadi {Energy}");
        }
        else
        {
            Energy = 100;
            Console.WriteLine("Energi sudah penuh");
        }

    }
}




