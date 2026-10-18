using System;

public abstract class Vehicle
{
    public string MaXe { get; set; }
    public string BienSoXe { get; set; }

    public Vehicle(string maXe, string bienSoXe)
    {
        MaXe = maXe;
        BienSoXe = bienSoXe;
    }

    public abstract string ChonLoaiCho();

    public abstract long TinhPhi(double soGio);
}

class Car : Vehicle
{
    private long cost;

    public Car(string maXe, string bienSoXe, long cost)
        : base(maXe, bienSoXe)
    {
        this.cost = cost;
    }

    public override string ChonLoaiCho()
    {
        return "Car";
    }

    public override long TinhPhi(double soGio)
    {
        
    }
}

class Motorcycle : Vehicle
{
    private long cost;

    public Motorcycle(string maXe, string bienSoXe, long cost)
        : base(maXe, bienSoXe)
    {
        this.cost = cost;
    }

    public override string ChonLoaiCho()
    {
        return "Motorcycle";
    }

    public override long TinhPhi(double soGio)
    {
        
    }
}

class ElectricMotorcycle : Vehicle
{
    private long cost;

    public ElectricMotorcycle(string maXe, string bienSoXe, long cost)
        : base(maXe, bienSoXe)
    {
        this.cost = cost;
    }

    public override string ChonLoaiCho()
    {
        return "ElectricMotorcycle";
    }

    public override long TinhPhi(double soGio)
    {
        
    }
}

class Bicycle : Vehicle
{
    private long cost;

    public Bicycle(string maXe, string bienSoXe, long cost)
        : base(maXe, bienSoXe)
    {
        this.cost = cost;
    }

    public override string ChonLoaiCho()
    {
        return "Bicycle";
    }

    public override long TinhPhi(double soGio)
    {
        
    }
}

class ParkingSpot
{
    public string MaSlot { get; private set; }
    public string LoaiCho { get; private set; }
    public int SucChua { get; private set; }

    private List<Vehicle> danhSachXe = new List<Vehicle>();

    public ParkingSpot(string maSlot, string loaiCho, int sucChua)
    {
        MaSlot = maSlot;
        LoaiCho = loaiCho;
        SucChua = sucChua;
    }

    public bool ConTrong()
    {
        
    }

    public bool CoTheNhanXe(Vehicle xe)
    {
        
    }

    public void NhanXe(Vehicle xe)
    {
        
    }

    public void GiaiPhongXe(Vehicle xe)
    {
        
    }
}
class ParkingLevel
{
    public int SoTang { get; private set; }

    private List<ParkingSpot> danhSachCho = new List<ParkingSpot>();

    public ParkingLevel(int soTang)
    {
        SoTang = soTang;
    }

    public void ThemCho(ParkingSpot slot)
    {
        
    }

    public ParkingSpot TimChoTrong(Vehicle xe)
    {
        
    }

    public int SumAllSlot()
    {
        
    }

    public int SumSlotTrong()
    {
        
    }

    public int SumSlotDangDung()
    {
        
    }
}

class Ticket
{
    public string MaVe { get; private set; }
    public Vehicle Xe { get; private set; }
    public ParkingLevel Tang { get; private set; }
    public ParkingSpot ChoDo { get; private set; }

    public DateTime GioVao { get; private set; }
    public DateTime? GioRa { get; private set; }

    public long PhiGuiXe { get; private set; }

    public Ticket(string maVe, Vehicle xe, ParkingLevel tang, ParkingSpot choDo)
    {
        MaVe = maVe;
        Xe = xe;
        Tang = tang;
        ChoDo = choDo;

        GioVao = DateTime.Now;
        GioRa = null;
    }

    public bool GiaTriHieuLuc()
    {
        
    }

    public void KetThucVe()
    {
        
    }

    public long TinhTien()
    {
        
    }
}

class ParkingLot
{
    private List<ParkingLevel> danhSachTang =new List<ParkingLevel>();

    private Dictionary<string, Ticket> danhSachVe =new Dictionary<string, Ticket>();

    public ParkingLot()
    {
    }

    public void ThemTang(ParkingLevel tang)
    {
        
    }

    public Ticket GuiXe(Vehicle xe)
    {
        
    }

    public long LayXe(string maVe)
    {
        
    }

    public int SumAllSlot()
    {
        
    }

    public int SumSlotTrong()
    {
        
    }

    public int SumSlotDangDung()
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        ParkingLot parkingLot = new ParkingLot();

        ParkingLevel tang1 = new ParkingLevel(1);
        ParkingLevel tang2 = new ParkingLevel(2);


        /*ParkingSpot slot1 = new ParkingSpot("A01", "Car", 1);
        ParkingSpot slot2 = new ParkingSpot("A02", "Motorcycle", 3);
        ParkingSpot slot3 = new ParkingSpot("B01", "ElectricMotorcycle", 2);
        ParkingSpot slot4 = new ParkingSpot("B02", "Bicycle", 5);

        -----

        Car car = new Car("XE001", "59A-12345", 20000);

        Motorcycle motorcycle = new Motorcycle("XE002", "59B1-12345", 5000);

        ElectricMotorcycle electric = new ElectricMotorcycle("XE003", "59M1-12345", 3000);

        Bicycle bicycle = new Bicycle("XE004", "XE-DAP-001", 2000);*/

    }
}

