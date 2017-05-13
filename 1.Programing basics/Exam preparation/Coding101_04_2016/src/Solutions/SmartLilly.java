package Solutions;

import java.util.Scanner;

public class SmartLilly {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		float years = Float.parseFloat(input.nextLine());
		float washmachinePrice = Float.parseFloat(input.nextLine());
		float toyPrice = Float.parseFloat(input.nextLine());
		
		int moneyAmount = 0;
		int toysAmount = 0;
		
		for (int i = 1; i <= years; i++) {
			if (i % 2 == 1) {
				toysAmount += 1;
			}
			else {
				moneyAmount = moneyAmount + ((5*i) - 1);
			}
		}
		
		float totalMoneyAmount = moneyAmount + (toysAmount * toyPrice);
		
		if (washmachinePrice <= totalMoneyAmount) {
			float difference = totalMoneyAmount - washmachinePrice;
			System.out.print("Yes! ");
			System.out.printf("%.2f",difference);
		}
		else {
			float difference = washmachinePrice - totalMoneyAmount;
			System.out.print("No! ");
			System.out.printf("%.2f", difference);
		}

	}

}
