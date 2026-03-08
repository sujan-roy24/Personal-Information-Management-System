using Personal_Info_Management_System.Data;
using Personal_Info_Management_System.Interfaces;
using Personal_Info_Management_System.Models;

namespace Personal_Info_Management_System.Services
{
    public class PersonalInfoService : IPersonalInfoService
    {
        private readonly AppDbContext _context;

        public PersonalInfoService(AppDbContext context)
        {
            _context = context;
        }
        public List<PersonalInfo> GetAll()
        {
            return _context.PersonalInfos.ToList();
        }
        public PersonalInfo GetById(int id)
        {
            return _context.PersonalInfos.Find(id);
        }
        public void Add(PersonalInfo model)
        {
            _context.PersonalInfos.Add(model);
            _context.SaveChanges();
        }
        public void Update(PersonalInfo model)
        {
            model.UpdatedDate = DateTime.Now;
            _context.PersonalInfos.Update(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.PersonalInfos.Find(id);
            if (data != null)
            {
                _context.PersonalInfos.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
