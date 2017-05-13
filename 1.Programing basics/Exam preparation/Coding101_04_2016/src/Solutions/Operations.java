package Solutions;

import java.util.Scanner;

public class Operations {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		int n1 = Integer.parseInt(input.nextLine());
		int n2 = Integer.parseInt(input.nextLine());
		String operationSymbol = input.nextLine();
		int result = 0;
		operationSymbol.toCharArray();
		
		switch (operationSymbol) {
		case "+":
			result = n1 + n2;
			if (result % 2 == 0) {
				System.out.println(n1 + " + " + n2 + " = " + result + " - even");
			}
			else {
				System.out.println(n1 + " + " + n2 + " = " + result + " - odd");
			}
			break;
			
		case "-":
			result = n1 - n2;
			if (result % 2 == 0) {
				System.out.println(n1 + " - " + n2 + " = " + result + " - even");
			}
			else {
				System.out.println(n1 + " - " + n2 + " = " + result + " - odd");
			}
			break;
			
		case "*":
			result = n1 * n2;
			if (result % 2 == 0) {
				System.out.println(n1 + " * " + n2 + " = " + result + " - even");
			}
			else {
				System.out.println(n1 + " * " + n2 + " = " + result + " - odd");
			}
			break;
			
		case "/":
			
			if (n2 == 0) {
				System.out.println("Cannot divide " + n1 + " by zero");
			}
			else {
				double devideResult = (double)n1 / (double)n2;
				System.out.println(n1 + " / " + n2 + " = " + devideResult);
			}
			break;
			
		case "%":
			
			if (n2 == 0) {
				System.out.println("Cannot divide " + n1 + " by zero");
			}
			else {
				result = n1 % n2;
				System.out.println(n1 + " % " + n2 + " = " + result);				
			}
			break;
 
		default:
			break;
		}
		
	}

}
