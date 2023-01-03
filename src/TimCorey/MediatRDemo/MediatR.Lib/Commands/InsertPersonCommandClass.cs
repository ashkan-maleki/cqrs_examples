using MediatR.Lib.Models;

namespace MediatR.Lib.Commands;

public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;

// public class InsertPersonCommand
// {
//     public InsertPersonCommand(string? firstName, string? lastName)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//     }
//
//     public string? FirstName { get; set; }
//     public string? LastName { get; set; }
// }