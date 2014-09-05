import java.util.Arrays;
import java.util.HashMap;
import java.util.Scanner;


public class _11_MostFrequentWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String line=input.nextLine();
		String[] arr=line.toLowerCase().replaceAll("\\d", "").split("\\W+");
		HashMap<String,Integer> all=new HashMap<>();
		int momentCount=1,count=0;
		String momentWord=null,finalWord=null;
		for (int i = 0; i < arr.length; i++) {
			momentWord=arr[i];
			for (int j = i+1; j < arr.length; j++) {
				if(arr[j].equals(arr[i])){
					momentCount++;
				}
			}
			if(momentCount>=count){
				count=momentCount;
				finalWord=momentWord;
				all.put(momentWord,momentCount);
				momentCount=1;
				
			}
			else momentCount=1;
		}
		
		for (String key : all.keySet()) {
			if(all.get(key)==count){
			System.out.println(key+" -> "+all.get(key)+" times");
			}
		}
		
	}

}
