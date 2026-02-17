import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

class Result {

    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static String gridChallenge(List<String> grid) {
        int rows = grid.size();
        int cols = grid.get(0).length();

        for (int i = 0; i < rows; i++) {
            char[] chars = grid.get(i).toCharArray();
            Arrays.sort(chars);
            grid.set(i, new String(chars));
        }

        for (int col = 0; col < cols; col++) {
            char prev = grid.get(0).charAt(col);

            for (int row = 1; row < rows; row++) {
                char current = grid.get(row).charAt(col);
                if (current < prev)
                    return "NO";

                prev = current;
            }
        }

        return "YES";
    }
}

