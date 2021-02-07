using System;
using System.Collections.Generic;
using System.Linq;
using WebApiWithEFCore.Infrastructure;
using WebApiWithEFCore.Model;

namespace WebApiWithEFCore.Services
{
    public class UniversityService
    {
        private readonly StudentContext studentContext;

        public UniversityService(StudentContext studentContext)
        {
            this.studentContext = studentContext;
        }


        public bool SaveUniversity(University university)
        {
            try
            {
                studentContext.Universities.Add(university);
                if (studentContext.SaveChanges() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
                return false;
            }
        }
        public bool DeleteUniversity(University university)
        {
            try
            {
                studentContext.Universities.Remove(university);
                if (studentContext.SaveChanges() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
                throw;
            }
        }

        public bool UpdateUniversity(University university)
        {
            try
            {
                studentContext.Universities.Update(university);
                if (studentContext.SaveChanges() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
                throw;
            }
        }


        public List<University> GetUniversities()
        {
            try
            {
                return studentContext.Universities.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public University GetUniversityById(int Id)
        {
            try
            {
                var Data = studentContext.Universities.Where(x => x.Id == Id).FirstOrDefault();
                return Data;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
