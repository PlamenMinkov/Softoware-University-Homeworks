import java.util.Scanner;
public class _01_SortArray {

	public static void main(String[] args){
		Scanner input = new Scanner(System.in);
		int n=input.nextInt();
		int[] arr=new int[n];
		for (int i = 0; i < n; i++) {
			arr[i]=input.nextInt();
		}
		for (int i = 0; i <n; i++) {
			for (int j = i; j < n; j++) {
				if(arr[i]>arr[j]){
					int mask=arr[i];
					arr[i]=arr[j];
					arr[j]=mask;
				}
			}
		}
		
		for (int i = 0; i < n; i++) {
			System.out.print(arr[i]+" ");
		}

	}

}
