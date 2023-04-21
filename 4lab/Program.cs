using System.Text.RegularExpressions;

public class NaNException : Exception {
  public NaNException() {}

  public NaNException(string message) : base(message) {}

  public NaNException(string message, Exception inner) : base(message, inner) {}
}

static public class TaskOne {
  public static void doTask() {
    try {
      List<int> list = new List<int>();
      list.AddRange(Enumerable.Range(1, 100));
      double result;
      foreach (var x in list) {
        result = 1 / Math.Pow((x + 1), 2);
        if (result == double.NaN) {
          throw new NaNException(
              "NaN out of divinition range of this function");
        }
        Console.WriteLine(result);
      }
    } catch (DivideByZeroException e) {
      Console.WriteLine($"that is custom exception {e.Message}");
    } catch (NaNException e) {
      Console.WriteLine($"oh no wrong hole! {e.Message}");
    }
  }
}

public static class TaskSecond {
  private static int countUniqueCharacters(String input) {
    String unique = Regex.Replace(input, "(.)(?=.*?\\1)", "");
    return unique.Length;
  }

  public static void doTask(string str) {
    Console.WriteLine(TaskSecond.countUniqueCharacters(str));
    string tempString = Regex.Replace(str, "[^0-9a-zA-Z| |-]+", "");
    List<string> tempList = tempString.Split(" ").ToList();
    tempList.Sort((a, b) => a.Length.CompareTo(b.Length));
    foreach (string item in tempList) {
      Console.WriteLine(item);
    }
  }
}

public static class TaskThird {
  public static void doTask(string str, int hours) {
     if(Regex.IsMatch(str, "([0-1]?[0-9]|2[0-3]):[0-5][0-9]")) {
       Console.WriteLine(Regex.Replace(str, "([0-1]?[0-9]|2[0-3])+:", hours + ":"));
       return;
     }
     Console.WriteLine("Looks like ther is nothing to change");
  }
}

public static class FourhTask {
  public static void doTask(string str) {
    string[] words = str.Split(" ");
    string lastWord = words[words.GetLength(0) - 1];
    Console.WriteLine("Last word est: " + lastWord);
    List<string> result = new List<string>();
    foreach (string word in words) {
      if (word[0] == lastWord[0]) {
        result.Add(word);
      }
    } 
    Console.WriteLine("Accepted word estne : " + String.Join(" ", result.ToArray()));
  }
}

public static class FifthTask {
  public static string changeString(string str) {
    string newString = "";

    for (int i = 0; i < str.Length; i++) {
      if (i % 2 != 0) {
        newString += str[i];
      }
    }

    return newString;
  }

  public static void overrideFile(string str, string fileName = "./theFuck2.txt") {
    File.WriteAllText(fileName, str); 
  }
}

public class Program {
  public static void Main() {
    // TaskOne.doTask();
    // TaskSecond.doTask("In consequat dolor in dapibus vitae nascetur diam mus, quisque dignissim dignissim id ullamcorper, etiam sapien id lectus turpis imperdiet.");
    // TaskThird.doTask("hello there 22:00 11:55", 12);
    // FourhTask.doTask(File.ReadAllText("./theFuck.txt"));
    // string str = FifthTask.changeString(File.ReadAllText("./theFuck2.txt"));
    // FifthTask.overrideFile(str);
  }
}
