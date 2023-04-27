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
    private string sername = "";
    private string name = "";
    private string patronymic = "";
    private int groupNumber = 0;

    private int[] marks = { };

    private int pointer = 0;

    private bool isIterate = true;

    public Student getNext()
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

    public void print()
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
        Console.WriteLine("calling");
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

        foreach (Student item in student)
        {
            item.print();
            Console.WriteLine();
        }
    }
}
