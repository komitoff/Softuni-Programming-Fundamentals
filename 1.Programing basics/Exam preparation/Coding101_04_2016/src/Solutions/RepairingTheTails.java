package Solutions;

import java.text.NumberFormat;
import java.util.Scanner;

public class RepairingTheTails {
	
	public static void main(String[] args ) {
		Scanner input = new Scanner(System.in);
		
		double n = Double.parseDouble(input.nextLine());
		double w = Double.parseDouble(input.nextLine());
		double l = Double.parseDouble(input.nextLine());
		double m = Double.parseDouble(input.nextLine());
		double o = Double.parseDouble(input.nextLine());
		
		double sPlaza = n*n;
		double sTile = w * l;
		double sBench = m * o;
		
		double benchCount = (sPlaza - sBench) / sTile;
		double totalTimeInSeconds = benchCount * 0.2;
		
		System.out.println(benchCount	);
		System.out.println(totalTimeInSeconds);
		
	}
	
	
	
}
