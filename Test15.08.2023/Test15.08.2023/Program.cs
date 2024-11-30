
//Bai 1:
/*public class Program
{
    public static void Main(string[] args)
    {
        int choice, n = 0, x = 0;
        do
        {
            Console.WriteLine("+------------------------------Menu------------------------------+");
            Console.WriteLine("| 1. Nhap so nguyen duong n, so nguyen x bat ky                  |");
            Console.WriteLine("| 2. Tinh tong: 1 + x + x^2/2! + x^3/3! + ... + x^n / n!         |");
            Console.WriteLine("| 3. Tinh tong: 1 +x – x^2/2! + x^3/3! +...+ (-1)^n-1 * x^n / n! |");
            Console.WriteLine("| 4. Thoat                                                       |");
            Console.WriteLine("+----------------------------------------------------------------+");
            Console.Write("Chon: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhap vao so nguyen duong n: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Nhap vao so nguyen x: ");
                    x = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Tong: " + Sum(n, x));
                    break;
                case 3:
                    Console.WriteLine("Tong: " + Sum2(n, x));
                    break;
                case 4:
                    Console.WriteLine("Thoat");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le !");
                    break;

            }
        } while (choice != 4);
    }

    public static double Sum(int n, int x)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += Math.Pow(x, i) / Factorial(i);
        }
        return sum;
    }

    public static double Sum2(int n, int x)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += Math.Pow(x, i) / Factorial(i) * Math.Pow(-1, i - 1);
        }
        return sum;
    }

    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
*/
//Bai 2:



/*namespace QuanLyCongNhan
{
    struct CongNhan
    {
        public string HoTen;
        public int MaSo;
        public double HSL;
        public double PC;
        public string ChucVu;
        public double Luong;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong cong nhan: ");
            int n = int.Parse(Console.ReadLine());

            CongNhan[] dsCN = new CongNhan[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin cho cong nhan thu {i + 1}: ");
                Console.Write("Ho ten: ");
                dsCN[i].HoTen = Console.ReadLine();

                Console.Write("Ma so: ");
                dsCN[i].MaSo = int.Parse(Console.ReadLine());

                Console.Write("He so luong: ");
                dsCN[i].HSL = double.Parse(Console.ReadLine());

                Console.Write("PhuCap: ");
                dsCN[i].PC = double.Parse(Console.ReadLine());

                Console.Write("Chuc vu: ");
                dsCN[i].ChucVu = Console.ReadLine();
            }


            Console.WriteLine(" Danh sach cong nhan vua nhap:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Cong nhan {0}:", i + 1);
                Console.WriteLine("Ho ten: {0}", dsCN[i].HoTen);
                Console.WriteLine("Ma so: {0}", dsCN[i].MaSo);
                Console.WriteLine("He so luong: {0}", dsCN[i].HSL);
                Console.WriteLine("Phu cap: {0}", dsCN[i].PC);
                Console.WriteLine("Chuc vu: {0}", dsCN[i].ChucVu);
           

            }


            Console.WriteLine(" Danh sach cong nhan sau khi tinh luong:");
            for (int i = 0; i < n; i++)
            {
                dsCN[i].Luong = 3.14 * dsCN[i].HSL + dsCN[i].PC;
                Console.WriteLine("Cong nhan {0}:", i + 1);
                Console.WriteLine("Ho ten: {0}", dsCN[i].HoTen);
                Console.WriteLine("Ma so: {0}", dsCN[i].MaSo);
                Console.WriteLine("He so luong: {0}", dsCN[i].HSL);
                Console.WriteLine("Phu cap: {0}", dsCN[i].PC);
                Console.WriteLine("Chuc vu: {0}", dsCN[i].ChucVu);
                Console.WriteLine("Luong: {0}", dsCN[i].Luong);

            }

  
            Console.WriteLine(" Danh sach 2 cong nhan co luong cao nhat:");
            Array.Sort(dsCN, (x, y) => y.Luong.CompareTo(x.Luong));
            for (int i = 0; i < Math.Min(2, n); i++)
            {
                Console.WriteLine("Cong nhan {0}:", i + 1);
                Console.WriteLine("Ho ten: {0}", dsCN[i].HoTen);
                Console.WriteLine("Ma so: {0}", dsCN[i].MaSo);
                Console.WriteLine("He so luong: {0}", dsCN[i].HSL);
                Console.WriteLine("Phu cap: {0}", dsCN[i].PC);
                Console.WriteLine("Chuc vu: {0}", dsCN[i].ChucVu);
                Console.WriteLine("Luong: {0}", dsCN[i].Luong);

            }

          
            Console.WriteLine(" Danh sach cong nhan sau khi sap xep luong tang dan:");
            Array.Sort(dsCN, (x, y) => x.Luong.CompareTo(y.Luong));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Cong nhan {0}:", i+1);
                Console.WriteLine("Ho ten: {0}" , dsCN[i].HoTen);
                Console.WriteLine("Ma so: {0}", dsCN[i].MaSo);
                Console.WriteLine("He so luong: {0}", dsCN[i].HSL);
                Console.WriteLine("Phu cap: {0}", dsCN[i].PC);
                Console.WriteLine("Chuc vu: {0}", dsCN[i].ChucVu);
                Console.WriteLine("Luong: {0}", dsCN[i].Luong);

            }
            Console.ReadKey();
        }
    }
}*/



