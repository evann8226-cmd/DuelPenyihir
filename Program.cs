
wizard wizardA= new wizard("Harry potter", 20);
wizard wizardB = new wizard("jefta", 30);

Console.WriteLine("Permainan di mulai........\n");
wizardA.ShowStats();
wizardB.ShowStats();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.heal();
//wizardA.Attack(wizardB);
string pilihan;
while (wizardA.Energy > 0 && wizardB.Energy > 0)
{
    Console.WriteLine($"1.  {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2.  {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3.  {wizardA.Name} melakukan heal");
    Console.WriteLine($"4.  {wizardB.Name} melakukan heal");

    Console.Write("\nmasukan pilihanmu (1/2/3/4/):  ");
    pilihan = Console.ReadLine();

    if ( pilihan == "1")
    {
        wizardA.Attack( wizardB );  
    }
    else if ( pilihan == "2")
    {
        wizardB.Attack( wizardA );
    }
    else if( pilihan == "3")
    {
        wizardA.heal();
    }
    else if (pilihan == "4")
    {
        wizardB.heal();
    }
    else
    {
        Console.WriteLine("pilihan tidak valid");
    }

        
}

Console.WriteLine("Permainan berakhir.....\n");
Console.WriteLine("statistik akhir");
wizardA.ShowStats();
wizardB.ShowStats();

if(wizardA.Energy < wizardB.Energy)
{
    Console.WriteLine($"{wizardA.Name} memenangkan duel!!");
}
else
{
    Console.WriteLine($"{wizardB.Name} memenangkan duel!!");
}

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
        Energy = 50;
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
        if(Energy < 50)
        {
            Energy += 5;
            Console.WriteLine($"{Name} melakukan heal energi meningkatkan menjadi {Energy}");
        }
        else
        {
            Energy = 50;
            Console.WriteLine("Energi sudah penuh");
        }

    }
}




