using System;
using System.Xml.Linq;

public abstract class Vehicle //done
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
    //giá set mặc định được thay đổi theo từng loại xe
    private const long GiaMacDinh = 50000;

    private long cost;

    //constructor 2 tham số -> truyền đến constructor 3 tham số
    public Car(string maXe, string bienSoXe) 
        : this(maXe, bienSoXe, GiaMacDinh)
    { 
    }

    //constructor 3 tham số
    public Car(string maXe, string bienSoXe, long cost)
        : base(maXe, bienSoXe)
    {
        if (cost < 0)
            throw new ArgumentException("Giờ không được âm.");
        this.cost = cost;
    }

    public override string ChonLoaiCho()
    {
        return "Car";
    }

    public override long TinhPhi(double soGio)
    {
        if (soGio < 0)
            throw new ArgumentException("Số giờ không được bé hơn 0.");

        if (double.IsInfinity(soGio))
            throw new ArgumentException("Số giờ không được vô hạn.");

        if (double.IsNaN(soGio))
            throw new ArgumentException("Số giờ không hợp lệ.");

        //làm tròn lên các số sau dấu phẩy trên từ 0,5
        double gioLamTron = Math.Ceiling(soGio);

        //giờ tối thiểu, làm tròn 1 nếu thời gian gửi nhỏ hơn 1 giờ
        if (gioLamTron < 1)
            gioLamTron = 1;

        //chuyển số giờ đã làm tròn sang long
        long soGioTinhPhi = checked((long)gioLamTron);

        //nhân giờ với đơn giá
        long thanhtien = checked(soGioTinhPhi * cost);

        return thanhtien;
    }
}

class Motorcycle : Vehicle
{
    private const long GiaMacDinh = 4000;

    private long cost;

    //constructor 2 tham số
    public Motorcycle(string maXe, string bienSoXe)
        : this(maXe, bienSoXe, GiaMacDinh) { }

    //constructor 3 tham số
    public Motorcycle(string maXe, string bienSoXe, long cost)
        : base(maXe, bienSoXe)
    {
        if (cost < 0)
            throw new ArgumentException("Giá không được âm.");
        this.cost = cost;
    }

    public override string ChonLoaiCho()
    {
        return "Motorcycle";
    }

    public override long TinhPhi(double soGio)
    {
        if (soGio < 0)
            throw new ArgumentException("Số giờ không được bé hơn 0.");

        if (double.IsInfinity(soGio))
            throw new ArgumentException("Số giờ không được vô hạn.");

        if (double.IsNaN(soGio))
            throw new ArgumentException("Số giờ không hợp lệ.");

        //làm tròn lên các số sau dấu phẩy trên từ 0,5
        double gioLamTron = Math.Ceiling(soGio);

        //giờ tối thiểu, làm tròn 1 nếu thời gian gửi nhỏ hơn 1 giờ
        if (gioLamTron < 1)
            gioLamTron = 1;

        //chuyển số giờ đã làm tròn sang long
        long soGioTinhPhi = checked((long)gioLamTron);

        //nhân giờ với đơn giá
        long thanhtien = checked(soGioTinhPhi * cost);

        return thanhtien;
    }
}

class ElectricMotorcycle : Vehicle
{
    private const long GiaMacDinh = 4000;

    private long cost;

    public ElectricMotorcycle(string maXe, string bienSoXe)
        : this(maXe, bienSoXe, GiaMacDinh) { }

    public ElectricMotorcycle(string maXe, string bienSoXe, long cost)
        : base(maXe, bienSoXe)
    {
        if (cost < 0)
            throw new ArgumentException("Giá không được âm.");
        this.cost = cost;
    }

    public override string ChonLoaiCho()
    {
        return "ElectricMotorcycle";
    }

    public override long TinhPhi(double soGio)
    {
        if (soGio < 0)
            throw new ArgumentException("Số giờ không được bé hơn 0.");

        if (double.IsInfinity(soGio))
            throw new ArgumentException("Số giờ không được vô hạn.");

        if (double.IsNaN(soGio))
            throw new ArgumentException("Số giờ không hợp lệ.");

        //làm tròn lên các số sau dấu phẩy trên từ 0,5
        double gioLamTron = Math.Ceiling(soGio);

        //giờ tối thiểu, làm tròn 1 nếu thời gian gửi nhỏ hơn 1 giờ
        if (gioLamTron < 1)
            gioLamTron = 1;

        //chuyển số giờ đã làm tròn sang long
        long soGioTinhPhi = checked((long)gioLamTron);

        //nhân giờ với đơn giá
        long thanhtien = checked(soGioTinhPhi * cost);

        return thanhtien;
    }
}

class Bicycle : Vehicle
{
    private const long GiaMacDinh = 2000;

    private long cost;

    public Bicycle(string maXe, string bienSoXe)
        : this(maXe, bienSoXe, GiaMacDinh) { }

    public Bicycle(string maXe, string bienSoXe, long cost)
        : base(maXe, bienSoXe)
    {
        if (cost < 0)
            throw new ArgumentException("Giá không được âm.");

        this.cost = cost;
    }

    public override string ChonLoaiCho()
    {
        return "Bicycle";
    }

    public override long TinhPhi(double soGio)
    {
        if (soGio < 0)
            throw new ArgumentException("Số giờ không được bé hơn 0.");

        if (double.IsInfinity(soGio))
            throw new ArgumentException("Số giờ không được vô hạn.");

        if (double.IsNaN(soGio))
            throw new ArgumentException("Số giờ không hợp lệ.");

        //làm tròn lên các số sau dấu phẩy trên từ 0,5
        double gioLamTron = Math.Ceiling(soGio);

        //giờ tối thiểu, làm tròn 1 nếu thời gian gửi nhỏ hơn 1 giờ
        if (gioLamTron < 1)
            gioLamTron = 1;

        //chuyển số giờ đã làm tròn sang long
        long soGioTinhPhi = checked((long)gioLamTron);

        //nhân giờ với đơn giá
        long thanhtien = checked(soGioTinhPhi * cost);

        return thanhtien;
    }
}

class ParkingSpot //khu đỗ xe dành cho một loại xe, nằm bên trong 1 tầng cụ thể
{
    public string MaSlot { get; private set; }
    public string LoaiCho { get; private set; }
    public int SucChua { get; private set; }

    //danh sách xe của mỗi khu đỗ xe
    private List<Vehicle> danhSachXe = new List<Vehicle>();

    public ParkingSpot(string maSlot, string loaiCho, int sucChua)
    {
        MaSlot = maSlot;
        LoaiCho = loaiCho;
        SucChua = sucChua;
    }

    //kiểm tra vị trí còn trống trong bãi xe
    public bool ConTrong()
    {
        return danhSachXe.Count < SucChua;
    }

    //lọc đầu vào, chỉ có thể nhận các loại xe được chấp thuận trong bãi giữ xe
    public bool CoTheNhanXe(Vehicle xe)
    {
        if (xe == null) return false;
        if (ConTrong() == false) return false;
        if (xe.ChonLoaiCho() != LoaiCho) return false;
        return true;
    }

    //nhận xe vào bãi giữ xe và -1 vị trí trong sức chứa
    public void NhanXe(Vehicle xe)
    {
        if (CoTheNhanXe(xe) == false)
            throw new InvalidOperationException("Không thể nhận xe: xe không hợp lệ, sai loại hoặc hết chỗ.");
        
        //tránh ghi nhận cùng mã xe hai lần trong 1 khu (tránh lỗi thao tác)
        foreach(Vehicle xeDangDo in danhSachXe)
        {
            if (xeDangDo.MaXe == xe.MaXe)
                throw new InvalidOperationException("Xe đã có trong khu đỗ này."); 
        }
        danhSachXe.Add(xe);
    }

    //cộng lại vị trí mà xe đã ra khỏi bãi vào sức chứa
    public void GiaiPhongXe(Vehicle xe)
    {
        if (xe == null)
            throw new ArgumentNullException(nameof(xe));

        for (int i = 0; i < danhSachXe.Count; i++)
        {
            Vehicle xeDangDo = danhSachXe[i];
            if (xeDangDo.MaXe == xe.MaXe)
            {
                danhSachXe.RemoveAt(i);
                return;
            }
        }
        throw new InvalidOperationException("Không tìm thấy xe trong khu đỗ này.");
    }

    //property
    public int SoXeDangDo { get { return danhSachXe.Count; } }
}
class ParkingLevel //một tầng, chứa nhiều ParkingSpot, nó sẽ phải hoạt động trước ParkingSpot, tìm 1 ParkingSpot có 1 vị trí với loại xe phù hợp
{
    public int SoTang { get; private set; }

    //danh sách chứa các ParkingSpot trong 1 tầng
    private List<ParkingSpot> danhSachParkingSpot = new List<ParkingSpot>();

    public ParkingLevel(int soTang)
    {
        SoTang = soTang;
    }

    public void ThemCho(ParkingSpot slot)
    {
        //kiểm tra đầu vào
        if (slot == null)
            throw new ArgumentNullException(nameof(slot));
        
        //kiểm tra mã khu đó đã được thêm vào trong tầng chưa
        foreach(ParkingSpot spot in danhSachParkingSpot)
        {
            if (spot.MaSlot == slot.MaSlot)
                throw new InvalidOperationException("Mã khu đỗ đã tồn tại trong tầng");
        }

        //thêm khu
        danhSachParkingSpot.Add(slot);
    }

    //tìm ra một khu ParkingSpot còn sức chứa và đúng loại xe
    public ParkingSpot TimChoTrong(Vehicle xe)
    {
        foreach (ParkingSpot slot in danhSachParkingSpot)
        {
            if (slot.CoTheNhanXe(xe))
            {
                return slot;
            }
        }
        return null;
    }

    //tổng slot trong 1 tầng
    public int SumAllSlot()
    {
        int tong = 0;
        foreach (ParkingSpot cho in danhSachParkingSpot)
        {
            tong = tong + cho.SucChua;
        }
        return tong;
            
    }

    //tổng slot còn trống trong 1 tầng
    public int SumSlotTrong()
    {
        return SumAllSlot() - SumSlotDangDung();
    }

    public int SumSlotDangDung()
    {
        int tong = 0;
        foreach(ParkingSpot cho in danhSachParkingSpot)
        {
            tong = tong + cho.SoXeDangDo;
        }
        return tong;
    }

    //chọn khu phù hợp trong tầng để nhận xe
    //trung gian kiểm tra khu đậu xe và đưa xe vào NhanXe
    public void nhanxe(Vehicle xe)
    {
        ParkingSpot choPhuHop = TimChoTrong(xe);
        if (choPhuHop == null)
            throw new InvalidOperationException("Tầng không còn chỗ phù hợp cho xe này.");
        choPhuHop.NhanXe(xe);
    }

    //trả lại sức chứa khi xe rời khỏi tầng
    public void traCho(Vehicle xe, ParkingSpot choDo)
    {
        if (xe == null)
            throw new ArgumentNullException(nameof(xe));

        if (choDo == null)
            throw new ArgumentNullException(nameof(choDo));

        //kiểm tra xem khu đỗ đó có thuộc tầng đó hay không
        if (danhSachParkingSpot.Contains(choDo) == false)
            throw new InvalidOperationException("Khu đỗ không thuộc tầng này.");

        //gọi lại GiaiPhongXe trong ParkingSpot
        choDo.GiaiPhongXe(xe);
    }
}

class Ticket //vé xe
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
        if (GioRa == null) return true; //chưa có giờ ra, vé vẫn còn hiệu lực
        return false;
    }

    //chốt giờ ra và phí của lượt gửi xe
    public void KetThucVe()
    {
        if (GiaTriHieuLuc() == false)
            throw new InvalidOperationException("Vé đã kết thúc trước đó.");

        DateTime gioRa = DateTime.Now;

        if (gioRa < GioVao)
            throw new InvalidOperationException("Giờ ra không được trước giờ vào.");

        double soGio = (gioRa - GioVao).TotalHours;

        long phi = Xe.TinhPhi(soGio);
        PhiGuiXe = phi;
        GioRa = gioRa;
    }

    public long TinhTien()
    {
        if (GiaTriHieuLuc() == false) return PhiGuiXe;

        DateTime thoiDiemTinh = DateTime.Now;

        if (thoiDiemTinh < GioVao)
            throw new InvalidOperationException("Giờ ra không được trước giờ vào.");

        double soGio = (thoiDiemTinh - GioVao).TotalHours;

        return Xe.TinhPhi(soGio);
    }
}

/*class ParkingLot //toàn bộ bãi xe, bao gồm các tầng xe
    //gọi tầng xe, để tầng xe tìm khu xe phù hợp, khu xe đó sẽ thực hiện nhận xe
{
    private List<ParkingLevel> danhSachTang =new List<ParkingLevel>();

    private Dictionary<string, Ticket> danhSachVe =new Dictionary<string, Ticket>();

    public ParkingLot()
    {
    }

    //thêm tầng cho bãi đỗ xe
    public void ThemTang(ParkingLevel tang)
    {
        if (tang == null) 
            throw new ArgumentNullException(nameof(tang));

        foreach ()
    }

    public Ticket GuiXe(Vehicle xe)
    {
        
    }

    public long LayXe(string maVe)
    {
        
    }

    public int SumAllSlot()
    {
        int tong = 0;
        foreach ()
    }

    public int SumSlotTrong()
    {
        
    }

    public int SumSlotDangDung()
    {
        
    }
} */

class Program
{
    static void Main(string[] args)
    {

        //khởi tạo bãi xe
        //ParkingLot parkingLot = new ParkingLot();

        //khởi tạo tầng xe thuộc bãi xe
        ParkingLevel tang1 = new ParkingLevel(1);
        ParkingLevel tang2 = new ParkingLevel(2);

        //khởi tạo các khu xe thuộc tầng xe
        ParkingSpot SpotCar = new ParkingSpot("A01", "Car", 1);
        ParkingSpot SpotMotorcycle = new ParkingSpot("A02", "Motorcycle", 1);
        ParkingSpot SpotElectricMotorcycle = new ParkingSpot("A03", "ElectricMotorcycle", 1);
        ParkingSpot SpotBicycle = new ParkingSpot("B01", "Bicycle", 1);

        //tầng 1 (Car, Motorcycle, ElectricMotorcycle)
        tang1.ThemCho(SpotCar);
        tang1.ThemCho(SpotMotorcycle);
        tang1.ThemCho(SpotElectricMotorcycle);

        //tầng 2 (Bycicle)
        tang2.ThemCho(SpotBicycle);

        //khởi tạo xe thuộc khu xe
        Car oto1 = new Car("XE001", "59A-12345");
        Car oto2 = new Car("XE002", "60B-4556");
        Motorcycle moto1 = new Motorcycle("XE003", "59B1-12345");
        ElectricMotorcycle motodien1 = new ElectricMotorcycle("XE004", "59M1-12345");
        Bicycle xedap1 = new Bicycle("XE005", "XE-DAP-001");


        //test đỗ xe phù hợp/ không phù hợp loại xe/ không có chỗ
        tang1.nhanxe(oto1);
        Console.WriteLine("Ô tô 1 đã vào khu A01.");

        try
        {
            tang1.nhanxe(xedap1);
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine("Kkhông nhận xe đạp: " + ex.Message);
        }

        try
        {
            tang1.nhanxe(oto2);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Kkhông nhận ô tô 2: " + ex.Message);
        }
    }
}

