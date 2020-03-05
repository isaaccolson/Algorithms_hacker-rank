using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {



  static void Main(string[] args) {
    int n = Convert.ToInt32(Console.ReadLine());

    string binaryN = Convert.ToString(n,2);

    var consecutiveOnes = 0;
    var currentconsecutiveOnesCount = 0;

    foreach(char digit in binaryN)
    {
      if(digit == '1')
      {
        currentconsecutiveOnesCount++;

        if(currentconsecutiveOnesCount > consecutiveOnes)
        {
          consecutiveOnes = currentconsecutiveOnesCount;
        }
      }
      else
      {
        currentconsecutiveOnesCount = 0;
      }
    }

    Console.WriteLine(consecutiveOnes);

  }
}
