using MediatR.Lib.Models;

namespace MediatR.Lib.DataAccess;

public class DataAccess : IDataAccess
{
    private List<PersonModel> _people = new();

    public DataAccess()
    {
        _people.Add(new PersonModel {Id = 1, FirstName = "Johnny", LastName = "Cage"});
        _people.Add(new PersonModel {Id = 2, FirstName = "Rachel", LastName = "Green"});
        _people.Add(new PersonModel {Id = 3, FirstName = "Monica", LastName = "Geller"});
        _people.Add(new PersonModel {Id = 4, FirstName = "Ross", LastName = "Geller"});
    }
    
    public List<PersonModel> People
    {
        get => _people;
    }

    public PersonModel InsertPerson(string firstName, string lastName)
    {
        PersonModel personModel = new()
        {
            FirstName = firstName, LastName = lastName,
            Id = _people.Max(p => p.Id) + 1
        };
        _people.Add(personModel);
        return personModel;
    }
}