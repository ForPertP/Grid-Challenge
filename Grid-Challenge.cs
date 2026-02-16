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

class Result
{

    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        int rows = grid.Count;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++)
        {
            char[] chars = grid[i].ToCharArray();
            Array.Sort(chars);
            grid[i] = new string(chars);
        }

        for (int col = 0; col < cols; col++)
        {
            char prev = grid[0][col];

            for (int row = 1; row < rows; row++)
            {
                char current = grid[row][col];
                if (current < prev)
                    return "NO";

                prev = current;
            }
        }

        return "YES";
    }    
}



