package Solutions;

import java.util.Scanner;

public class SleepyTomCat {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		int freeDays = Integer.parseInt(input.nextLine());
		int workingDays = 365 - freeDays;
		int playTimeOnFreeDays = 127;
		int playTimeOnWorkingDays = 63;
		int tomsNeededMinutes = 30000;
		
		int actualPlayTime = ((freeDays * playTimeOnFreeDays) + (workingDays * playTimeOnWorkingDays));
		
		
		if (tomsNeededMinutes > actualPlayTime) {	
			int minutesLess = tomsNeededMinutes - actualPlayTime;
			int hours = minutesLess / 60;
			int minutes = minutesLess % 60;
			System.out.println("Tom sleeps well");
			System.out.println(hours + " hours and " + minutes + " minutes less for play");
		}
		else {
			int minutesLess = actualPlayTime - tomsNeededMinutes;
			int hours = minutesLess / 60;
			int minutes = minutesLess % 60;
			System.out.println("Tom will run away");
			System.out.println(hours + " hours and " + minutes + " minutes more for play");
		}
		

	}

}
