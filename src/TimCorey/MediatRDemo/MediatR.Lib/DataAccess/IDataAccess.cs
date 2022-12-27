using MediatR.Lib.Models;

namespace MediatR.Lib.DataAccess;

public interface IDataAccess
{
    List<PersonModel> People { get; }
    PersonModel InsertPerson(string firstName, string lastName);
}