import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;


public class FruitMarket {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		//input.useDelimiter("\\n");
		// Simple price list with filled with the pricess
		Map<String, Float> priceList = new HashMap<String, Float>();
		priceList.put("banana", 1.8f);
		priceList.put("cucumber", 2.75f);
		priceList.put("tomato", 3.2f);
		priceList.put("orange", 1.6f);
		priceList.put("apple", 0.86f);
		
		//Simple discount list 
		Map<String, Float> discounts = new HashMap<String, Float>();
		discounts.put("Friday", 0.1f);
		discounts.put("Sunday", 0.05f);
		discounts.put("Tuesday", 0.2f);
		discounts.put("Wednesday", 0.1f);
		discounts.put("Thursday", 0.3f);
		
		
		//Reading the input values
		String dayOfWeek = input.nextLine();
		String amount1 = input.nextLine();
		String fruit1 = input.nextLine();
		String amount2 = input.nextLine();
		String fruit2 = input.nextLine();
		String amount3 = input.nextLine();
		String fruit3 = input.nextLine();
	

		//cast amounts to float
		float famount1 = Float.parseFloat(amount1);
		float famount2 = Float.parseFloat(amount2);
		float famount3 = Float.parseFloat(amount3);
		float finalDiscount = 0;
		
		if (discounts.containsKey(dayOfWeek)) {
			finalDiscount = discounts.get(dayOfWeek);
		}
		
		float finalPrice = (priceList.get(fruit1) * famount1) + (priceList.get(fruit2) * famount2) +
							(priceList.get(fruit3) * famount3);
		
		finalPrice = finalPrice - (finalPrice * finalDiscount);
		input.close();
		System.out.printf("%.2f", finalPrice);
	}

}
