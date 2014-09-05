import java.math.BigDecimal;
import java.util.Scanner;


public class BitShooter {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		long a = input.nextInt();
		long mask = 1;
		input.nextLine();
        byte[] centers = new byte[3];
        byte[] size = new byte[3];
        for (int i = 0; i < 3; i++)
        {
            String line = input.nextLine();
            String[] arr = line.split(" ");
            centers[i] = Byte.parseByte(arr[0]);
            size[i] = Byte.parseByte(arr[1]);
            int maxPoz = centers[i] + (size[i] / 2);
            for (int j = 0; j < size[i]; j++)
            {
                mask=1;
                mask <<= maxPoz;
                mask = a & mask;
                if (mask >> maxPoz == 1)
                {
                    a = a ^ mask;
                }
                maxPoz--;
            }
        }
        int countLeft = 0,countRight=0,n=32;
        for (int i = 0; i < 64; i++)
        {
            mask = 1;
            mask<<=i;
            mask = a & mask;
            if (mask >> i == 1)
            {
                if (i < 32) { countRight++; }
                else countLeft++;
            }
        }
        
        
        System.out.println("left: "+countLeft);
        System.out.println("right: " + countRight);

	}

}
