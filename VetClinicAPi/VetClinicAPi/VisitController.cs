using Microsoft.AspNetCore.Mvc;
namespace VetClinicAPi;

[ApiController]
[Route("visit")]

public class VisitController : ControllerBase
{
    private readonly IVisitRepository _visitRepository;

    public VisitController()
    {
        _visitRepository = new VisitRepository();
    }

    [HttpGet("{id}")]
    public ActionResult<List<Visit>> GetByAnimalId(int animalId)
    {
        return _visitRepository.GetVisitsByAnimalId(animalId);
    }

    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        _visitRepository.AddVisit(visit);
        return CreatedAtAction(nameof(GetByAnimalId), new { animalId = visit.AnimalId }, visit);
    }
}

