import java.util.HashMap;
import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeMap;
import java.util.TreeSet;


public class Orders {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n=input.nextInt();
		input.nextLine();
		String[] arrP=new String[n],arrPr=new String[n];
		int[] arrC=new int[n];
		Set<String> set = new HashSet<String>();
		
		for (int i = 0; i <n; i++) {
			String[] maskArr=input.nextLine().split(" ");
			set.add(maskArr[2]);
			arrP[i]=maskArr[0];
			arrC[i]=Integer.parseInt(maskArr[1]);
			arrPr[i]=maskArr[2];
		}
		for (int i = 0; i < arrC.length-1; i++) {
			for (int j = i+1; j < arrC.length; j++) {
				if(arrP[i].equals(arrP[j])&&arrPr[i].equals(arrPr[j])){
					arrC[i]+=arrC[j];
					arrC[j]=0;
					arrP[j]="";
					arrPr[j]="";
				}
			}
		}
		String[] fin=new String[n];
		int count=-1;
		for (String string : set) {
			
			String coma=" ";
			count++;
			fin[count]=string+":";
			TreeMap<String,Integer> pr=new TreeMap<>();
			for (int i = 0; i < arrC.length; i++) {
				if(arrPr[i].equals(string)){
					pr.put(arrP[i],arrC[i]);
				}
			}
			
			for (String key : pr.keySet()) {
				fin[count]+=coma+""+key+" "+pr.get(key);
				coma=", ";
			}
		}
		for (int i = count; i >=0 ; i--) {
			System.out.println(fin[i]);
		}

	}

}
