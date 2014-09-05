import java.util.Scanner;


public class _02_TriangleArea {
static double SideLength(int x1, int y1, int x2, int y2){
				return Math.sqrt((double)((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)));
				
			}
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int Xone = input.nextInt();
		int Yone = input.nextInt();	
		int Xtwo = input.nextInt();
		int Ytwo = input.nextInt();	
		int Xthree = input.nextInt();
		int Ythree = input.nextInt();	
		
		double a=SideLength(Xone,Yone,Xtwo,Ytwo);
		double b=SideLength(Xone,Yone,Xthree,Ythree);
		double c=SideLength(Xthree,Ythree,Xtwo,Ytwo);
		double p=(a+b+c)/2;
		System.out.println((int)(Math.sqrt(p*(p-a)*(p-b)*(p-c))));
		
	}

}
