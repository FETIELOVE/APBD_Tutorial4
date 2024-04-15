namespace VetClinicAPi;

public interface IVisitRepository
{
    List<Visit> GetVisitsByAnimalId(int animalId);
    void AddVisit(Visit visit);

}

