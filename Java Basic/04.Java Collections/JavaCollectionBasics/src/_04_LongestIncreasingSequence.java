import java.util.ArrayList;
import java.util.Scanner;


public class _04_LongestIncreasingSequence {

	static void Print(ArrayList<String> nums){
		for (String str : nums) {
			System.out.print(str+" ");
		}
		System.out.println();
	}
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String line=input.nextLine();
		String[] arr=line.split(" ");

		ArrayList<String> numbers = new ArrayList<String>();
		ArrayList<String> longestSequence = new ArrayList<String>();
		int count=0,momentCount=1;
		
		numbers.add(arr[0]);
		for (int i = 1; i <arr.length; i++) {
				if(Integer.parseInt(arr[i])>Integer.parseInt(arr[i-1]) ){
					momentCount++;
					numbers.add(arr[i]);
					if(i==arr.length-1&&momentCount>count){
						count=momentCount;
						longestSequence=numbers;
					}
				}
				else	if(momentCount>count){
						Print(numbers);
							count=momentCount;
							longestSequence=numbers;
							numbers=new ArrayList<String>(); 
							numbers.add(arr[i]);
							momentCount=1;
						}
				else{
					Print(numbers);
					momentCount=1;
					numbers=new ArrayList<String>(); 
					numbers.add(arr[i]);
				}
					
			}
		Print(numbers);
		System.out.print("Longest: ");
		Print(longestSequence);
	}
}