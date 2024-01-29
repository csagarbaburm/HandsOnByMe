using Microsoft.AspNetCore.SignalR;
using StaffAPI.Interface;
using StaffAPI.Model;

namespace StaffAPI.Repository
{
    public class StaffRepository : IStaffRepository
    {
        public readonly List<Staff> staffs=new List<Staff>();
        public void AddStaff(Staff staff)
        {
            staffs.Add(staff);
        }

        public void DeleteStaff(string id)
        {
            Staff? st= (from s in staffs
                      where s.StaffID == id
                      select s).SingleOrDefault();
            if(st!=null )
            {
                staffs.Remove(st);
            }
            
            
        }

        public List<Staff> GetAll()
        {
            return staffs;
        }

        public Staff GetStaffByID(string id)
        {
            Staff ?staff = (from s in staffs
                           where s.StaffID == id
                           select s).SingleOrDefault();


            return staff;

        }

        public List<Staff> GetStaffByStd(string std)
        {
            List<Staff> Selected_staffs = (from s in staffs
                                           where s.Stds.Contains(std)
                                           //from sub1 in s.Subjects
                                           //where sub1 == sub
                                           select s).ToList();

            return Selected_staffs;

        }

        public List<Staff> GetStaffBySubject(string sub)
        {
            List<Staff> Selected_staffs = (from s in staffs
                                           where s.Subjects.Contains(sub)
                                           //from sub1 in s.Subjects
                                           //where sub1 == sub
                                           select s).ToList();

            return Selected_staffs;
        }

        public void UpdateStaff(Staff staff)
        {
            foreach (Staff st in staffs)
            {
                if (st.StaffID == staff.StaffID)
                {
                    st.StaffName = staff.StaffName;
                    st.Stds= staff.Stds;
                    st.Subjects=staff.Subjects;
                } 
                    
            }
        }
    }
}
