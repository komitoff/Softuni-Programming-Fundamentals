import java.awt.List;
import java.util.ArrayList;
import java.util.Scanner;

public class BiggestTriple {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);	
		String inputData = input.nextLine();
		
		
		int tmpSum = 0;
		
		ArrayList<Integer> tmpNumbers = new ArrayList<Integer>();
		ArrayList<Integer> finalNumbers = new ArrayList<Integer>();

		int length = 0;
		
		String[] inputNumbers = inputData.split("\\s");
		length = inputNumbers.length;
		int[] numbers = new int[length];
		int ij = 0;
		for (int i = length - 1 ; i >= 0; i--) {
			numbers[ij] = Integer.parseInt(inputNumbers[i]);
			//System.out.println(numbers[ij]);
			ij++;
		}
		
		int maximalSum = numbers[0];
		if(length == 1 ) {
			System.out.println(numbers[0]);
		}
		else if(length == 2) {
			System.out.println(numbers[1] + " " + numbers[0]);
		}
		else {
			int counter = length % 3;
			int index = 0;
			if (counter == 0) {
				counter = 3;
			}
			while(counter <= length) {
				for (int i = index; i < counter; i++) {
					tmpSum += numbers[i];
					tmpNumbers.add(numbers[i]);
					
				}
				
				if (tmpSum >= maximalSum) {
					maximalSum = tmpSum;
					finalNumbers.clear();
					finalNumbers.addAll(tmpNumbers);
					
				}
				tmpNumbers.clear();
				index = counter;
				counter += 3;
				tmpSum = 0;
			}
			
		
		}

		for (int i = finalNumbers.size() - 1; i >= 0; i--) {
			System.out.print(finalNumbers.get(i) + " ");
			//System.out.println(length);
		}
		input.close();
	}

}
