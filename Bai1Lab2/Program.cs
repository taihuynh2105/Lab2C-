using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserData
{
    public int ID;
    public string UserName;
    public int Level;
    public UserData(int ID, string UserName, int Level)
    {
        this.ID = ID;
        this.UserName = UserName;
        this.Level = Level;
    }
    public void ShowData()
    {
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("UserName: " + UserName);
        Console.WriteLine("Level: " + Level);
    }
}
public class Program
{
    static void Main(string[] args)
    {
        var x = 10;
        void bai1a()
        {
            Console.WriteLine("X: " + x);
        }
        bai1a();



        void getDetail(dynamic value)
        {
            Console.WriteLine("Value: " + value);
        }
        void bai1b()
        {
            getDetail(10);
            getDetail("Game");
            getDetail(true);
            getDetail(9.5);
        }
        bai1b();

        UserData userdata = new UserData(210503, "LeTai", 21);
        userdata.ShowData();
    }
}