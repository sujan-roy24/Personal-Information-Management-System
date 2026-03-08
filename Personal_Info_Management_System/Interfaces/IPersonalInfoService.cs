using Microsoft.EntityFrameworkCore.Update.Internal;
using Personal_Info_Management_System.Models;

namespace Personal_Info_Management_System.Interfaces
{
    public interface IPersonalInfoService
    {
        List<PersonalInfo> GetAll();
        PersonalInfo GetById(int id);
        void Add(PersonalInfo model);
        void Update(PersonalInfo model);
        void Delete(int id);
    }
}
