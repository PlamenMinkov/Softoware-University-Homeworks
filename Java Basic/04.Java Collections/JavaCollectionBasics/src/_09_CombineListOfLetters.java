import java.util.ArrayList;
import java.util.Scanner;


public class _09_CombineListOfLetters {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		ArrayList<Character> arrFL = new ArrayList<Character>();
		ArrayList<Character> arrSL = new ArrayList<Character>();
		ArrayList<Character> arrPrint = new ArrayList<Character>();

		for (char ch : in.nextLine().toCharArray()) {
			arrFL.add(ch);
		}
		for (char ch : in.nextLine().toCharArray()) {
			arrSL.add(ch);
		}
		arrPrint.addAll(arrFL);

		for (int i = 0; i < arrSL.size(); i++) {
			if (!arrFL.contains(arrSL.get(i))) {
				arrPrint.add(' ');
				arrPrint.add(arrSL.get(i));
			}
		}

		for (int i = 0; i < arrPrint.size(); i++) {
			System.out.print(arrPrint.get(i));
		}
	}

}
