public class FourthTask
{
    private string[,] matrix;

    private string vowels = "AOEiAYUoeayu";

    private List<string> list = new List<string>{"hello", "there" , "is", "no", "emotion", "ther", "is"};

    public FourthTask()
    {
        this.matrix = new string[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Random random = new Random();
                string chars =
                    "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
                Random rand = new Random();
                int num = rand.Next(0, chars.Length);
                matrix[i, j] = chars[num] + "";
            }
        }
    }

    public void doTask()
    {
        string[,] tempMatrix = new string[10, 5];
        int a = 0;
        int b = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if ((i + j) % 2 != 0)
                {
                    tempMatrix[a, b] = this.matrix[i, j];
                    b++;
                }
            }
            b = 0;
            a++;
        }
        this.matrix = tempMatrix;

        List<string> tempList = new List<string>{};
        foreach(string item in this.list)
        {
            bool isContains = false;
            foreach(var ch in this.vowels) {
                if (item[0] == ch) {
                    isContains = true; 
                }
            }
            if (!isContains) {
                tempList.Add(item);
            }
        }

        this.list = tempList;
    }

    public void print()
    {
        Console.WriteLine();
        for (int i = 0; i < this.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < this.matrix.GetLength(1); j++)
            {
                Console.Write(this.matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        foreach(string item in this.list)  {
            Console.WriteLine(item);
        }
    }
}
