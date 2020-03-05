using System;
using System.Collections.Generic;
using System.IO;
class Solution {
  static void Main(String[] args) {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

    int stringNumber = int.Parse(Console.ReadLine());

    for(var i = 0; i < stringNumber; i++)
    {

      string input = Console.ReadLine();

      string evenOutput = "";
      string oddOutput = "";

      for(var j = 0; j < input.Length; j++)
      {
        if(j%2 == 0)
        {
          evenOutput += input[j];
        }
        else
        {
          oddOutput += input[j];
        }
      }

      Console.WriteLine(evenOutput + " " + oddOutput);
    }
  }
}
