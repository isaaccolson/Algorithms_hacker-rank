public class Solution {
    public int OddCells(int n, int m, int[][] indices) {

        var array = new int[n,m];


        for(var i = 0; i < indices.Length; i++){

            var rowToChange = indices[i][0];

            var columnToChange = indices[i][1];

            for(var rowIndex = 0; rowIndex < m; rowIndex++){
            array[indices[i][0],rowIndex] += 1;
            }
             for(var colIndex = 0; colIndex < n; colIndex++){
              array[colIndex,indices[i][1]] += 1;
            }
            }

        var oddNumbers = 0;

        for(var row = 0; row < n; row++){
            for(var col = 0; col < m; col++){
                if(array[row,col] > 0 && array[row,col] % 2 != 0){
                    oddNumbers++;
                }
            }
        }

         return oddNumbers;
        }

    }
