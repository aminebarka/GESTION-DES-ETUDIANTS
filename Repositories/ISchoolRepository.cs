using GESTION_DES_ETUDIANTS.Models;

namespace GESTION_DES_ETUDIANTS.Repositories
{
    public interface ISchoolRepository
    {
        IList<School> GetAll();
        School GetById(int id);
        void Add(School s);
        void Edit(School s);
        void Delete(School s);
        double StudentAgeAverage(int schoolId);
        int StudentCount(int schoolId);
    }
}
