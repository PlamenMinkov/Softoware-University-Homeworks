import java.util.Scanner;
public class _02_SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String line=input.nextLine();
		String[] arr=line.split(" ");
		System.out.print(arr[0]+" ");
		for (int i = 1; i <arr.length; i++) {
				if(arr[i].equals(arr[i-1]) ){
					System.out.print(arr[i]+" ");
				}
					else{
						System.out.println();
						System.out.print(arr[i]+" ");
					}
			}
	}

}
