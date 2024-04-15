namespace VetClinicAPi;

public interface IAnimalRepository
{
    List<Animal> GetAll(); 
    Animal GetById(int id);
    void Add(Animal animal);

    void Edit(Animal animal);
    void Delete(int id);
}

