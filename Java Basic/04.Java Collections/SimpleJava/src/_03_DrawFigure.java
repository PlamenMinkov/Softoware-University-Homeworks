import java.util.Scanner;


public class _03_DrawFigure {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		byte n = input.nextByte(),count=0;
        for (byte i = n; i >0 ; i-=2)
        {
            byte br=count;
            while (br > 0)
            {
                System.out.print(".");
                br--;
            }
            br=i;
            while (br > 0)
            {
            	System.out.print("*");
                br--;
            }
            br = count;
            while (br > 0)
            {
            	System.out.print(".");
                br--;
            }
            count += 1;
            System.out.println();
        }
        count--;
        for (byte i = 3; i <= n; i += 2)
        {
            count--;
            byte br = count;
            while (br > 0)
            {
            	System.out.print(".");
                br--;
            }
            br = i;
            while (br > 0)
            {
            	System.out.print("*");
                br--;
            }
            br = count;
            while (br > 0)
            {
            	System.out.print(".");
                br--;
            }
            System.out.println();
        }
    }
}
