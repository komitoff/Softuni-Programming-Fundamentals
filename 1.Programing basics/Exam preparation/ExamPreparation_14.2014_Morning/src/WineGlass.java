import java.util.Scanner;


public class WineGlass {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		String text = input.nextLine();
		int n = Integer.parseInt(text);
		int asterix = n-2;
		int dots = 0;
		int count = 0;
		if (n > 11) {
			count = (n/2) - 2;
		}
		else {
			count = (n/2) - 1;
		}
		
		do {
			printSymb('.', dots);
			printSymb('\\', 1);
			printSymb('*', asterix);
			printSymb('/', 1);
			printSymb('.', dots);
			asterix -= 2;
			dots ++;
			System.out.println();
		} while (asterix > -2);
		
		for (int i = 0; i < count; i++) {
			printSymb('.', dots - 1);
			printSymb('|', 2);
			printSymb('.', dots - 1);
			System.out.println();
			
		}
		
		if (n > 11) {
			printSymb('-', n);
			System.out.println();
			printSymb('-', n);
		}
		else {
			printSymb('-', n);
		}
		

	}

	public static void printSymb (char symbol, int count) {
		for (int i = 0; i < count; i++) {
			System.out.print(symbol);
		}
	}
	
}
