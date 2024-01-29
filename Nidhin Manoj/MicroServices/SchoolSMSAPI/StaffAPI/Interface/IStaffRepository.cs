using StaffAPI.Model;

namespace StaffAPI.Interface
{
    public interface IStaffRepository
    {
        void AddStaff(Staff staff);
        void UpdateStaff(Staff staff);
        void DeleteStaff(string id);
        List<Staff> GetAll();
        List<Staff> GetStaffByStd(string std);
        List<Staff> GetStaffBySubject(string sub);
        Staff GetStaffByID(string id);
    }
}
