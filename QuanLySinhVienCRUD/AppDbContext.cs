using Microsoft.EntityFrameworkCore;
using QuanLySinhVienCRUD;
using System.Collections.Generic;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Thay đổi Chuỗi kết nối SQL Server tương ứng với máy của bạn
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-VL7UGOA\SQLEXPRESS;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}