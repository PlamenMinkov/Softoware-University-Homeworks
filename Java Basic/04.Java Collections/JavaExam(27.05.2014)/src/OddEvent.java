import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.lang.*;


public class OddEvent {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] arrS=input.nextLine().replaceAll("[\\(\\)]", " ").split(" ");		

		int[] arr=new int[arrS.length];
		int count=0,maskCount=0,br=0;
		String num="";
		for (int i = 0; i < arrS.length; i++) {
			if(!arrS[i].equals("")){
			arr[br]=Integer.parseInt(arrS[i]);
			br++;
			}
			//System.out.printf(arrS[i]+",");
		}
		for (int i = 0; i < br-1; i++) {
			if(arr[i]%2==0){
				num="e";maskCount=1;
			}
			else if(arr[i]%2==1){
				num="o";maskCount=1;
			}
			for (int j = i+1; j < br; j++) {
				if(arr[j]%2==0&&num.equals("o")){
					num="e";maskCount++;
				}
				else if(arr[i]%2==1&&num.equals("e")){
					num="o";maskCount++;
				}
				else j=arr.length;
			}
			if(maskCount>count){
				count=maskCount;
			}
		}
System.out.println(count);
	}

}
