using System;

class PriceChangeAlert
{
    static void Main()
    {
        int prices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double currentPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < prices - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double difference = CalulateDifference(currentPrice, nextPrice);
            bool significantDifference = SignificantDifference(threshold, difference);
            string outputMessage = GetOutputMessage(nextPrice, currentPrice, difference, significantDifference);
            Console.WriteLine(outputMessage);
            currentPrice = nextPrice;
        }
    }

    /// <summary>
    /// Returns the correct output message in case of how big is the 
    /// difference
    /// </summary>
    /// <param name="nextPrice">Double number</param>
    /// <param name="currentPrice">Double number</param>
    /// <param name="difference">Double number</param>
    /// <param name="etherTrueOrFalse">Boolean parameter</param>
    /// <returns></returns>
    private static string GetOutputMessage(double nextPrice, double currentPrice, double difference, bool significantDifference)
    {
        string outputMessage = "";
        if (difference == 0)
        {
            outputMessage = string.Format("NO CHANGE: {0}", nextPrice);
        }
        else if (!significantDifference)
        {
            outputMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", currentPrice, nextPrice, difference * 100);
        }
        else if (significantDifference && (difference > 0))
        {
            outputMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", currentPrice, nextPrice, difference * 100);
        }
        else if (significantDifference && (difference < 0))
            outputMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", currentPrice, nextPrice, difference * 100);
        return outputMessage;
    }

    /// <summary>
    /// Returns true if there is significant difference
    /// </summary>
    /// <param name="threshold"></param>
    /// <param name="isDiff"></param>
    /// <returns></returns>
    private static bool SignificantDifference (double threshold, double difference)
    {
        if (Math.Abs(threshold) > Math.Abs(difference))
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// Returns the difference of two numbers
    /// </summary>
    /// <param name="currentPrice">Double number</param>
    /// <param name="nextPrice">Double number</param>
    /// <returns></returns>
    private static double CalulateDifference (double currentPrice, double nextPrice)
    {
        double difference = (nextPrice - currentPrice) / currentPrice;
        return difference;
    }
}
