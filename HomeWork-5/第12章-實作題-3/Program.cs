using System;

class Program
{
    // 宣告委派：接收一個 double，回傳 double
    delegate double ConvertToInches(double value);

    // 方法：英尺轉英吋
    static double FeetToInches(double feet)
    {
        return feet * 12;
    }

    // 方法：碼轉英吋
    static double YardsToInches(double yards)
    {
        return yards * 36;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("請輸入數值：");
        double input = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("請選擇單位 (1 = 英尺, 2 = 碼)：");
        string choice = Console.ReadLine();

        ConvertToInches converter;

        if (choice == "1")
        {
            converter = FeetToInches;
        }
        else if (choice == "2")
        {
            converter = YardsToInches;
        }
        else
        {
            Console.WriteLine("輸入錯誤，請輸入 1 或 2");
            return;
        }

        double result = converter(input);
        Console.WriteLine($"轉換後的英吋為：{result}");
    }
}
