import java.util.Locale;
import java.util.Scanner;
public class _03_PointsInsideAFigure {

	static boolean InnerRectangle(double x, double y){
		
		if((x>17.5&&x<20)&&(y>8.5&&y<13.5))return false;
		else return true;
	}
	
	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT); 
		Scanner in = new Scanner(System.in);
        double x = in.nextDouble();
        double y = in.nextDouble();
		if((x>=12.5&&x<=22.5)&&(y>=6&&y<=13.5)){
			if(InnerRectangle(x,y))
				System.out.println("Inside");
			else System.out.println("Outside");
		}
		else System.out.println("Outside");
	}

}
