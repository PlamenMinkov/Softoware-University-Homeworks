import java.util.Scanner;


public class CountBeer {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		int stacCount=0,beerCount=0;
		boolean tr=true;
		while(tr){
			String tx=input.nextLine();
			if(tx.equals("End"))tr=false;
			else{
				
				String[] arr=tx.split(" ");

				if(arr[1].equals("stacks")){
					stacCount+=Integer.parseInt(arr[0]);
					//System.out.println(arr[0]+" "+arr[1]);
				}
				else{
					beerCount+=Integer.parseInt(arr[0]);
					if(beerCount>=20){
						int mask=beerCount/20;
						stacCount+=mask;
						beerCount-=mask*20;
					}
				}
			}
		}
			System.out.println(stacCount+" stacks + "+beerCount+" beers");
		}

	}

