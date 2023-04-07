public class FifthTask {
  private string[,] matrix;
  private string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

    public FifthTask()
    {
        this.matrix = new string[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Random random = new Random();
                Random rand = new Random();
                int num = rand.Next(0, this.chars.Length);
                matrix[i, j] = this.chars[num] + "";
            }
        }
    }

    public void remove(int row, int column) {
        for (int i = 0; i < this.matrix.GetLength(0); i++) {
            for (int j = 0; j < this.matrix.GetLength(1); j++) {
                if (i == row && j == column) {
                    this.matrix[i, j] = "";
                }
            }
        }
    }

    public void appendStrings() {
        string[,] tempMatrix = new string[20, 20];
        int a = 0;
        int b = 0;
        for (int i = 0; i < tempMatrix.GetLength(0); i++) {
            for (int j = 0; j < tempMatrix.GetLength(1); j++) {
                if ((i + j) % 2 == 1) {
                    Random random = new Random();
                    tempMatrix[i, j] = this.chars[random.Next(this.chars.Length)] + "";
                } else {
                    tempMatrix[i, j] = this.matrix[a, b];
                    b++;
                }
            }
            b = 0;
            a++;
            if (a >= 10) {
                this.matrix = tempMatrix;
                return;
            }
        }

        this.matrix = tempMatrix;
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
    }
};
