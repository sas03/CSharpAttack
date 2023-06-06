namespace gameAttack;

public class Character
{
    public string nom;
    public int pv;
    public int force;
    public int defense;
    public bool IsAlive(){
        if(this.pv <= 0){
            return false;
        }
        return true;
    }
    public int Attack(Character chk){
        chk.pv = chk.pv - (this.force - chk.defense);
        if(!chk.IsAlive()){
            Console.WriteLine("Game Over");
            return 0;
        }
        return chk.pv;
    }
    public static void Main(string[] args){
        Character c1 = new Character();
        c1.nom = "Steph";
        c1.pv = 10;
        c1.force = 6;
        c1.defense = 3;
        
        Character c2 = new Character() {
            nom = "Olive",
            pv = 10,
            force = 5,
            defense = 2
        };
        
        c1.Attack(c2);
        Console.WriteLine(c2.IsAlive());
        c1.Attack(c2);
        Console.WriteLine(c2.IsAlive());
        c1.Attack(c2);
        Console.WriteLine(c2.IsAlive());
    }
}
