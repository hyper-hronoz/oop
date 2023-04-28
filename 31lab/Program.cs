using System.Collections;
using System.Collections.Generic;

class InfixToPrefix
{
    Stack<char> stack = new Stack<char>();

    public InfixToPrefix(string str)
    {
        foreach (char ch in str)
        {
            stack.Push(ch);
        }
    }

    public Stack<char> convert()
    {
        Stack<char> tempStack = new Stack<char>();

        string operators = "*/+-%";

        foreach (char ch in stack)
        {
            if (!operators.Contains(ch))
            {
                tempStack.Push(ch);
            }
        }

        foreach (char ch in stack)
        {
            if (operators.Contains(ch))
            {
                tempStack.Push(' ');
                tempStack.Push(ch);
                tempStack.Push(' ');
            }
        }

        return tempStack;
    }

    static public void printStack(Stack<char> stack)
    {
        foreach (char ch in stack)
        {
            Console.Write(ch);
        }
        Console.WriteLine();
    }
}

class Student
{
    protected string sername = "";
    protected string name = "";
    protected string patronymic = "";
    protected int groupNumber = 0;

    protected int[] marks = { };

    protected int pointer = 0;

    protected bool isIterate = true;

    public virtual Student getNext()
    {
        try
        {
            string text = File.ReadAllText("./db.txt");

            string[] studentTexts = text.Split("\n\n");

            if (this.pointer >= studentTexts.Length)
            {
                Console.WriteLine("No next student");
                this.isIterate = false;
                return this;
            }

            string[] items = studentTexts[this.pointer].Split("\n");

            this.sername = items[0];
            this.name = items[1];
            this.patronymic = items[2];
            this.groupNumber = int.Parse(items[3]);

            this.marks = items[4].Split(" ").Select(v => int.Parse(v)).ToArray();

            this.pointer++;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        return this;
    }

    public void resetPointer()
    {
        this.pointer = 0;
        this.isIterate = true;
    }

    public int getPointer()
    {
        return this.pointer;
    }

    public int[] getMarks()
    {
        return this.marks;
    }

    virtual public void print()
    {
        Console.WriteLine("Sername: " + this.sername);
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Patronymic: " + this.patronymic);
        Console.WriteLine("Group: " + this.groupNumber);

        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Mark " + i + ": " + marks[i]);
        }
    }

    public IEnumerator<Student> GetEnumerator()
    {
        while (this.isIterate)
        {
            Student student = this.getNext();
            if (this.isIterate)
            {
                yield return student;
            }
        }
    }
}

class UpgradedStudent : Student
{
    ArrayList fields = new ArrayList();

    public override Student getNext()
    {
        try
        {
            this.fields = new ArrayList();

            string text = File.ReadAllText("./db.txt");

            string[] studentTexts = text.Split("\n\n");

            if (this.pointer >= studentTexts.Length)
            {
                Console.WriteLine("No next student");
                this.isIterate = false;
                return this;
            }

            string[] items = studentTexts[this.pointer].Split("\n");

            foreach (var item in items)
            {
                this.fields.Add(item);
            }

            this.pointer++;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        return this;
    }

    public override void print()
    {
        foreach (var item in this.fields)
        {
            Console.WriteLine(item);
        }
    }
}

class Disk
{
    string name;
    int price;

    public Disk(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public string getName()
    {
        return name;
    }

    public int getPrice()
    {
        return price;
    }
}

class Album
{
    private List<Disk> list = new List<Disk>();
    private string name;

    public Album(string name)
    {
        this.name = name;
        this.list = new List<Disk>();
    }

    public string getName()
    {
        return this.name;
    }

    public void appendDisk(Disk disk)
    {
        this.list.Add(disk);
    }

    public void removeDisk(string name)
    {
        for (int i = 0; i < this.list.Count; i++)
        {
            Disk disk = this.list[i];
            if (disk.getName() == name)
            {
                this.list.RemoveAt(i);
                break;
            }
        }
    }

    public List<Disk> getRecords() {
        return this.list;
    }
}

class SexShop
{
    private Hashtable storage = new Hashtable();

    public void addDisk(string albumName, Disk disk)
    {
        foreach (string tableRecordName in this.storage.Keys)
        {
            if (tableRecordName == albumName)
            {
                Album album = (Album)this.storage[tableRecordName];
                if (album == null)
                {
                    Console.WriteLine("No this entity does not excists");
                    return;
                }
                album.appendDisk(disk);
                if (this.storage.Contains(tableRecordName)) {
                    this.storage.Remove(tableRecordName);
                }
                this.storage.Add(tableRecordName, album);
                break;
            }
        }
    }

    public void deleteDisk(string albumName, string diskName)
    {
        foreach (string tableRecordName in this.storage.Keys)
        {
            if (albumName == tableRecordName)
            {
                Album album = (Album)this.storage[tableRecordName];
                album.removeDisk(diskName);
                this.storage.Remove(tableRecordName);
                this.storage.Add(tableRecordName, album);
                break;
            }
        }
    }

    public void addAlbum(Album album)
    {
        this.storage.Add(album.getName(), album);
    }

    public void deleteAlbum(string name)
    {
        this.storage.Remove(name);
    }

    public void printAll()
    {
        foreach (string name in this.storage.Keys)
        {
            Album album = (Album)this.storage[name];
            Console.WriteLine("Album: " + album.getName());
            foreach (Disk disk in album.getRecords()) {
                Console.Write("Disk: " + disk.getName() + " " + disk.getPrice() + "\n");
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        InfixToPrefix converter = new InfixToPrefix("f + u * c * k");
        InfixToPrefix.printStack(converter.convert());

        Student student = new Student();

        Console.WriteLine("\nОтличники:\n");

        foreach (Student item in student)
        {
            if (item.getMarks().Contains(4) || item.getMarks().Contains(5))
            {
                item.print();
            }
            Console.WriteLine();
        }

        student.resetPointer();

        Console.WriteLine("\nЛохи педальные:\n");

        ArrayList allStudents = new ArrayList();
        foreach (Student item in student)
        {
            item.print();
            Console.WriteLine();
        }

        Console.WriteLine("\nПреределано под Array list наследованием\n");

        UpgradedStudent newStudent = new UpgradedStudent();

        foreach (Student item in newStudent)
        {
            item.print();
            Console.WriteLine();
        }

        SexShop shop = new SexShop();

        shop.addAlbum(new Album("Powerwolf"));
        shop.addDisk("Powerwolf", new Disk("Sancitified with dinomite", 12));
        shop.addDisk("Powerwolf", new Disk("Sainted by the storm", 11));
        shop.addDisk("Powerwolf", new Disk("Undress to confess", 14));

        shop.addAlbum(new Album("Lord of the lost"));
        shop.addDisk("Lord of the lost", new Disk("In the field of blood", 12));
        shop.addDisk("Lord of the lost", new Disk("13th", 11));
        shop.addDisk("Lord of the lost", new Disk("Satans fall", 14));
        shop.deleteDisk("Lord of the lost", "13th");

        shop.printAll();
    }
}
