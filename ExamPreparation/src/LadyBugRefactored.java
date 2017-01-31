import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class LadyBugRefactored {
    public static void main(String [] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int length = Integer.parseInt(reader.readLine());
        String [] field = reader.readLine().split("\\s+");
        long [] fieldCells = new long[length];
        for (int i = 0; i < length; i++) {
            fieldCells[i] = 0;
        }
        for (int i = 0; i < field.length; i++) {
            int index = Integer.parseInt(field[i]);
            fieldCells[index] = 1;
        }

        String InputCommand = reader.readLine();
        while (!InputCommand.equals("end")) {
            String [] command = InputCommand.split(("\\s+"));
            int startPosition = Integer.parseInt(command[0]);
            String moveCommand = command[1].toLowerCase();
            int count = Integer.parseInt(command[2]);

            if (moveCommand.equals("right")) {
                fieldCells = moveRight(startPosition, count, fieldCells);
            }
            else if (moveCommand.equals("left")) {
                moveLeft(startPosition, count, fieldCells);
            }
            InputCommand = reader.readLine();
        }

        for (long cell : fieldCells) {
            System.out.print(cell + " ");
        }
    }

    private static long [] moveRight(int startPosition, int count, long [] fieldCells) {
        boolean flag = true;
        if (startPosition >= fieldCells.length) {
            return fieldCells;
        }
        if (startPosition + count >= fieldCells.length) {
            fieldCells[startPosition] = 0;
            return fieldCells;
        }
        if (startPosition <= 0 && fieldCells[startPosition] == 0) {
            return fieldCells;
        }
        fieldCells[startPosition] = 0;
        for (int i = startPosition + count; i < fieldCells.length; i+=count) {
            if (fieldCells[i] == 0) {
                fieldCells[i] = 1;
                break;
            }
        }

        return fieldCells;
    }

    private static long[] moveLeft(int startPosition, int count, long [] fieldCells) {
        boolean flag = true;
        if (startPosition >= fieldCells.length) {
            return fieldCells;
        }
        if (startPosition - count < 0) {
            fieldCells[startPosition] = 0;
            return fieldCells;
        }
        if (startPosition <= 0 && fieldCells[startPosition] == 0) {
            return fieldCells;
        }
        fieldCells[startPosition] = 0;
        for (int i = startPosition - count; i >= 0; i--) {
            if (fieldCells[i] == 0) {
                fieldCells[i] = 1;
                break;
            }
        }
        return fieldCells;
    }
}