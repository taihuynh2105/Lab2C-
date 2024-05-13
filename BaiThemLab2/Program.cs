class Program
{
    public static Boolean Check(int num)
    {
        if(num < 1) return false;
        if(num == 2) return true;
        Boolean check = true;
        for (int i = 2; i<Math.Sqrt(num) +1 ; i++)
        {
            if (num  % i == 0) 
            {
                return false;
            }
        }
        return true;

    }

    static void Main()
    {

        

        List<int> numberList = new List<int>();

        int tong = 0;
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        Console.WriteLine("Số lượng phần tử: " +numberList.Count);

        foreach (int number in numberList)
        {
            Console.WriteLine("Danh sách số nguyên: "+ number);
            tong += number;
        }
        Console.WriteLine("Tổng các số nguyên có trong danh sách là: "+ tong);

        

        Console.WriteLine("Kiem tra so nguyen to: "+ Check(42));
    }

}