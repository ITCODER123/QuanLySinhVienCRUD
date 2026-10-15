using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVienCRUD
{
    public class StudentDAL
    {
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students.ToListAsync();
            }
        }

        public async Task AddStudentAsync(Student student)
        {
            using (var context = new AppDbContext())
            {
                context.Students.Add(student);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateStudentAsync(Student student)
        {
            using (var context = new AppDbContext())
            {
                var existing = await context.Students.FindAsync(student.Id);
                if (existing != null)
                {
                    existing.FullName = student.FullName;
                    existing.Grade = student.Grade;
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteStudentAsync(int id)
        {
            using (var context = new AppDbContext())
            {
                var existing = await context.Students.FindAsync(id);
                if (existing != null)
                {
                    context.Students.Remove(existing);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<List<Student>> GetPassedStudentsAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students
                    .Where(sv => sv.Grade >= 5)
                    .OrderByDescending(sv => sv.Grade)
                    .ToListAsync();
            }
        }
    }
}