import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class AdjecentNumbers {
    public static void main(String [] args) throws IOException {
        //3 3 6 1 || 12 1
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String[] input = reader.readLine().split("\\s+");
        List<Double> numbers = new ArrayList<Double>();
        for (int i = 0; i < input.length; i++) {
            numbers.add(Double.parseDouble(input[i]));
        }
        boolean flag = true;

        while(flag) {
            flag = false;
            for (int i = 0; i < numbers.size(); i++) {
                for (int j = i + 1; j < numbers.size() - 1; j++) {
                    if (numbers.get(i) == numbers.get(j)) {
                        numbers.set(i, numbers.get(i) + numbers.get(j));
                        numbers.remove(j);
                        flag = true;
                        break;
                    }
                }
            }
        }

        for (double number : numbers) {
            System.out.print(number + " ");
        }

    }
}
