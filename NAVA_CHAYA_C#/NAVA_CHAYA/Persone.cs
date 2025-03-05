using NAVA_CHAYA.Controllers;
using System;

public class Persone
{
	public int  id{ get; set; }

    public string name{ get; set; }
   
    public int age{ get; set; }

    public string type { get; set; }

 
    public Persone(int id, string name, int age, string type)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.type = type;
            
    }


}
