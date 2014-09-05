import java.math.BigDecimal;
import java.util.Scanner;


public class _02_Tribonachi {

	public static void main(String[] args) {

			Scanner input=new Scanner(System.in);
			BigDecimal  trib1 =new BigDecimal(input.nextInt());
			BigDecimal  trib2 = new BigDecimal(input.nextInt());
			BigDecimal  trib3 = new BigDecimal(input.nextInt());
			int  n = input.nextInt();

	        // Solve the task
	        if (n == 1)
	            System.out.println(trib1);
	        else if (n == 2)
	        	System.out.println(trib2);
	        else if (n == 3)
	        	System.out.println(trib3);
	        else
	        {
	            for (int i = 4; i <= n; i++)
	            {
	            	BigDecimal  tribNew = trib1.add(trib2).add(trib3);
	                trib1 = trib2;
	                trib2 = trib3;
	                trib3 = tribNew;
	            }
	            System.out.println(trib3);
	        }

	}

}
