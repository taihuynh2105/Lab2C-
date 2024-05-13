using System;
using System.Collections.Generic;

public class UserData
{
    public int ID;
    public string UserName;
    public List<double> scoreList;

    public UserData()
    {
        ID = 0;
        UserName = "null";
        scoreList = new List<double>();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        UserData userData = new UserData();
        Console.WriteLine("Nhập ID: ");
        string ID = Console.ReadLine();
        userData.ID = Convert.ToInt32(ID);
        Console.WriteLine("UserData ID: " + userData.ID);

        Console.WriteLine("Nhap ds diem: ");
        Console.WriteLine("So luong diem can nhap: ");
        int soluongDiem = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < soluongDiem; i++)
        {
            Console.WriteLine("Nhap diem:");
            string diem = Console.ReadLine();
            userData.scoreList.Add(Convert.ToDouble(diem));
        }
    }
}