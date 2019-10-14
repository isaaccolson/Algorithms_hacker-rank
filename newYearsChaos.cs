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

    static void minimumBribes(int[] q) {

        var totalSwaps = 0;

        for(var value = q.Length; value > 0; value--){

            var currentValueIndex = -1;
            var originalValueIndex = value -1;

            for(var position = 0; position < 3; position++){
                if(q[originalValueIndex - position] == value){
                    currentValueIndex = originalValueIndex - position;
                    break;
                }
            }

            if(currentValueIndex == -1){
                Console.WriteLine("Too chaotic");
                return;
            }

            var diff = originalValueIndex - currentValueIndex;

            totalSwaps += diff;

            //shifting array
            var valueToShift = value;

            for(int j = 0; j < diff + 1; j++){
                var valueToBeReplaced = q[originalValueIndex-j];
                q[originalValueIndex-j] = valueToShift;
                valueToShift = valueToBeReplaced;
            }

        }

        Console.WriteLine(totalSwaps);

    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
