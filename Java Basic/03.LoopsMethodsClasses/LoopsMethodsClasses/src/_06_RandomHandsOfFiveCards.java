import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Random;


public class _06_RandomHandsOfFiveCards {

	public static void main(String[] args) throws NumberFormatException, IOException {
		Random rand = new Random();
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int n=Integer.parseInt(br.readLine());
		String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K","A"};
        String[] faces = { "♠", "♥","♦","♣"};
	    for (int j = 0; j <n; j++) {
	        for (int i = 0; i < 5; i++) {
	        	int randomCard = rand.nextInt((12 - 0) + 1) + 0,
	        	    randomFaces=rand.nextInt((3 - 0) + 1) + 0;
	        	System.out.print(cards[randomCard]+""+faces[randomFaces]+" ");
			}
	        System.out.println();
		}
	}

}
