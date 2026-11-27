
namespace Entities;

public class Department : BaseEntityCreated, IBaseEntity, IBaseEntityName
{
    // Skaler özellikler
    public int Id { get; set; }
    public string? Name { get; set; }

    // Gezinme özellikleri
    public List<Student> Students { get; set; } = [];

    internal static object FirstName()
    {
        throw new NotImplementedException();
    }


    // Metotlar
    public override string ToString() => $"{Id} - {Name}";
}
