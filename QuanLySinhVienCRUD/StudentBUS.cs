using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanLySinhVienCRUD
{
    public class StudentBUS
    {
        private readonly StudentDAL _studentDAL = new StudentDAL();

        public async Task<List<Student>> GetListStudentsAsync()
        {
            return await _studentDAL.GetAllStudentsAsync();
        }

        public async Task AddStudentAsync(Student student)
        {
            await _studentDAL.AddStudentAsync(student);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            await _studentDAL.UpdateStudentAsync(student);
        }

        public async Task DeleteStudentAsync(int id)
        {
            await _studentDAL.DeleteStudentAsync(id);
        }

        public async Task<List<Student>> GetPassedStudentsAsync()
        {
            return await _studentDAL.GetPassedStudentsAsync();
        }
    }
}