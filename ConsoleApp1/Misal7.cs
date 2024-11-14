using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Misal7
    {

        public void Print()
        {
            Dictionary<int, Person> _dicInfo = new Dictionary<int, Person>();
            Person per1 = new Person(1, "Altun", "Seyyafzade");
            Person per2 = new Person(2, "Cahid", "Seyyafzade");
            _dicInfo.Add(1,per1);
            _dicInfo.Add(2,per2);

            foreach(var item in _dicInfo)
            {
                Console.WriteLine($"{item.Value} {item.Value.ID} {item.Value.Name} {item.Value.Surname}");
            }
        }



    }
}
public class Person
{
    public int ID;
    public string Name;
    public string Surname;

    public Person(int Id, string Name, string Surname)
    {
        this.ID = Id;
        this.Name = Name;
        this.Surname = Surname;
    }
}