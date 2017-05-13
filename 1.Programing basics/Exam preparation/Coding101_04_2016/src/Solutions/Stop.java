package Solutions;

import java.util.Scanner;

public class Stop {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = Integer.parseInt(input.nextLine());
		int dots = n + 1;
		int underscore = 5;

	}
	
	public static void draw(char symbol, int count) {
		for (int i = 0; i < count; i++) {
			System.out.print(symbol);
		}
	}

}
