using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_final
{
    internal class Room_information
    {
    }
}
/*
 using System;
using System.Collections.Generic;

public abstract class Room
{
    public string RoomNumber { get; private set; }
    public double BasePrice { get; protected set; }
    public List<string> Amenities { get; private set; }

    public Room(string roomNumber, double basePrice, List<string> amenities = null)
    {
        RoomNumber = roomNumber;
        BasePrice = basePrice;
        Amenities = amenities ?? new List<string>();
    }

    public abstract double CalculateNightlyRate();
    public abstract string GetRoomType();
}

public class StandardRoom : Room
{
    public StandardRoom(string roomNumber, double basePrice, List<string> amenities = null)
        : base(roomNumber, basePrice, amenities ?? new List<string> { "WiFi", "TV", "Air Conditioner" })
    {
    }

    public override double CalculateNightlyRate()
    {
        return BasePrice;
    }

    public override string GetRoomType()
    {
        return "Standard";
    }
}

public class VipRoom : Room
{
    public double VipServiceFeeRatio { get; private set; }

    public VipRoom(string roomNumber, double basePrice, double vipServiceFeeRatio = 0.2, List<string> amenities = null)
        : base(roomNumber, basePrice, amenities ?? new List<string> { "High-speed WiFi", "Smart TV 4K", "Air Conditioner", "Air Conditioner", "Bathtub", "Mini Bar", "Ocean View" })
    {
        VipServiceFeeRatio = vipServiceFeeRatio;
    }

    public override double CalculateNightlyRate()
    {
        return BasePrice * (1 + VipServiceFeeRatio);
    }

    public override string GetRoomType()
    {
        return "VIP";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Room r1 = new StandardRoom("101", 100);
        Room r2 = new VipRoom("201", 100, 0.2); 

        Console.WriteLine($"Phòng {r1.RoomNumber} ({r1.GetRoomType()}): ${r1.CalculateNightlyRate()}/đêm");
        Console.WriteLine($"Phòng {r2.RoomNumber} ({r2.GetRoomType()}): ${r2.CalculateNightlyRate()}/đêm");
    }
}*/