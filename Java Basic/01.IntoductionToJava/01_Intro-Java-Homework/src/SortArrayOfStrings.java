import java.util.Scanner;
import java.util.Arrays;
public class SortArrayOfStrings {
 
        public static void main(String[] args) {
                Scanner scan = new Scanner(System.in);
                int n = scan.nextInt();
                String[] Words = new String[n];
                for(int i=0;i<n;i++)
                {
                        Words[i] = scan.next();
                }
                Arrays.sort(Words);
                for(int i=0;i<n;i++)
                {
                        System.out.println(Words[i]);
                }
        }
}