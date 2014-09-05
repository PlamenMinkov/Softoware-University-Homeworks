import java.util.Scanner;
public class _07_CountsOfBitsOne {

	public static void main(String[] args) {
		 Scanner input = new Scanner(System.in);
         int n = input.nextInt();
         int counter = 0;
        
         for (int i = 0; i < 32; i++) {
                 if (((n>>i) & 1)==1) {
                         counter++;
                 }
         }
         System.out.println(counter);

	}

}
