namespace School
{

    public class Room
    {
        public string Id { get; set; }
        public List<Person> People { get; set; }

        public int Capacity { get; set; }

        public Room(string id, int capacity)
        {
            Id = id;
            People = new List<Person>();
            Capacity = capacity;
        }

        public virtual bool Enter(Person person)
        {
            return false;
        }
    }

    public class ClassRoom : Room
    {
        public ClassRoom(string id, int capacity) : base(id, capacity)
        {

        }

        public override bool Enter(Person person)
        {
            People.Add(person);
            return true;
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

    }

    public class Tutor : Person
    {
        public Tutor(string name) : base(name)
        {

        }
        public override string ToString()
        {
            return $"(student:{Name})";
        }
    }

    public class Student : Person
    {
        public Student(string name) : base(name)
        {

        }

        public override string ToString()
        {
            return $"(student:{Name})";
        }

    }

}