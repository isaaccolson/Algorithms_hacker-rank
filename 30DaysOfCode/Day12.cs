using System;
using System.Linq;

class Person{
  protected string firstName;
  protected string lastName;
  protected int id;

  public Person(){}
  public Person(string firstName, string lastName, int identification){
    this.firstName = firstName;
    this.lastName = lastName;
    this.id = identification;
  }
  public void printPerson(){
    Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
  }
}

class Student : Person{
  private int[] testScores;

  public Student(string _firstName, string _lastName, int _id, int[] _scores)
  {
    firstName = _firstName;
    lastName = _lastName;
    id = _id;
    testScores = _scores;
  }

  public char Calculate()
  {

    var scoreAvg = 0;
    var numOfScores = testScores.Length;

    for (var i = 0; i < numOfScores; i++)
    {
      scoreAvg += testScores[i];
    }

    scoreAvg /= numOfScores;

    if(scoreAvg >= 40 && scoreAvg < 55){
      return 'D';
    }
    if(scoreAvg >= 55 && scoreAvg < 70){
      return 'P';
    }
    if(scoreAvg >= 70 && scoreAvg < 80){
      return 'A';
    }
    if(scoreAvg >= 80 && scoreAvg < 90){
      return 'E';
    }
    if(scoreAvg >= 90 && scoreAvg <= 100){
      return 'O';
    }

    return 'T';
  }

}

class Solution {
  static void Main() {
    string[] inputs = Console.ReadLine().Split();
    string firstName = inputs[0];
    string lastName = inputs[1];
    int id = Convert.ToInt32(inputs[2]);
    int numScores = Convert.ToInt32(Console.ReadLine());
    inputs = Console.ReadLine().Split();
    int[] scores = new int[numScores];
    for(int i = 0; i < numScores; i++){
      scores[i]= Convert.ToInt32(inputs[i]);
    }

    Student s = new Student(firstName, lastName, id, scores);
    s.printPerson();
    Console.WriteLine("Grade: " + s.Calculate() + "\n");
  }
}
