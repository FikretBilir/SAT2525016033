using System.Data;
 
namespace UnitOfWorks;
 
public interface IUnitOfWork
{
    Task<DataTable> ExecuteAsync(
        string procedure,
        (string Name, string Value)[] parameters);
}