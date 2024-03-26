// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string hoTen;
float diemToan;
float diemVan;

Console.WriteLine("Nhap vao ho ten");
hoTen = Console.ReadLine(); // gia tri nay co kieu du lieu la string

Console.WriteLine("Nhap vao diem toan");
diemToan = float.Parse(Console.ReadLine()); // ep kieu du lieu tu string sang float

Console.WriteLine("Nhap vao diem van");
diemVan = float.Parse(Console.ReadLine());

Console.WriteLine("Hoc sinh {0} co diem toan la {1}, diem van la {2}", hoTen, diemToan, diemVan); 
Console.ReadKey();