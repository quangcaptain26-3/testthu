//Mảng 1 chiều
//<kiểu dữ liệu> [] <tên mảng>
/*int[] a;
int[] b = {10, 20, 50, 100, 8};
for(int i = 0;  i < 5; i++)
{
    Console.WriteLine("Gia tri a[{0}] la: {1}", i, b[i]);
}*/
//Bai 1: Nhap vao 1 mang a gồm n phần tử:
//a In ra giá trị các phần tử của mảng
//b Tính tổng các giá trị có trong mảng
//c Kiếm tra xem trong mảng có số nào là số nguyên tố
//d giải PT với tham số là 3 giá trị đầu tiên của mảng ax^2 + bx + c = 0
//e Sắp xếp mảng theo thu tu tang dan va tich gia tri trung binh cong cua mang
//f Hien thi va tinh tong cac so chan cua mang
//g cho 1 khoá k bất kỳ. Kiểm tra số lần xuất hiện của k trong day
//h tinh tong gia tri giai thua cua mang
//n = 3
//a[0] = 2;
//a[1] = 4;
//a[2] = 5;
// => s = 2! + 4! + 5!

void main()
{
    Console.Write("Nhap so phan tu cua mang: ");
    int n = int.Parse(Console.ReadLine());

    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Nhap phan tu thu {0}: ", i + 1);
        a[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Cac phan tu cua mang: ");
    PrintArray(a);

    int sum = SumArray(a);
    Console.WriteLine("Tong cac phan tu trong mang: {0}", sum);

    CheckPrime(a);
    if (n >= 3)
    {
        GiaiPTbac2(a[0], a[1], a[2]);
    }

    Console.WriteLine("Sap xep mang theo thu tu tang dan: ");
    SortAscending(a);
    PrintArray(a);

    DisplayAndSumEvenNumbers(a);
    Console.Write("Nhap khoa k: ");
    int k = int.Parse(Console.ReadLine());
    int frequency = CountOccurrences(a, k);
    Console.WriteLine("So lan xuat hien cua {0} trong mang: {1}", k, frequency);

    Console.ReadKey();
}
void PrintArray(int[] arr)
{
    foreach (int element in arr)
    {
        Console.WriteLine(element + " ");
    }
    Console.WriteLine();
}

int SumArray(int[] arr)
{
    int sum = 0;
    foreach (int element in arr)
    {
        sum += element;
    }
    return sum;
}

bool IsPrime(int num)
{
    if (num <= 1)
        return false;
    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

void CheckPrime(int[] arr)
{
    Console.WriteLine("Cac so nguyen to trong mang: ");
    foreach (int element in arr)
    {
        if (IsPrime(element))
            Console.WriteLine(element + " ");
    }
    Console.WriteLine();
}

void GiaiPTbac2(int a, int b, int c)
{
    if (a == 0)
    {
        Console.WriteLine("Day khong phai phuong trinh bac 2");
        return;
    }
    double delta = b * b - 4 * a * c;
    if (delta < 0)
    {
        Console.WriteLine("Phuong trinh vo nghiem");
    }
    else if (delta == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine("Phuong trinh co nghiem kep x = {0}", x);
    }
    else
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Phuong trinh co 2 nghiem: x1 = {0}, x2 = {1}", x1, x2);
    }
}

void SortAscending(int[] arr)
{
    Array.Sort(arr);
}

void DisplayAndSumEvenNumbers(int[] arr)
{
    int sumEven = 0;
    Console.WriteLine("Cac so chan trong mang: ");
    foreach(int element in arr)
    {
        if(element % 2 == 0)
        {
            Console.WriteLine(element + " ");
            sumEven += element;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Tong cac so chan trong mang: {0}", sumEven);
}

int CountOccurrences(int[] arr, int k)
{
    int count = 0;
    foreach(int element in arr)
    {
        if(element == k)
        {
            count++;
        }
    }
    return count;
}

main();
