using Attributes;
 
namespace Enums;
 
public enum Operation
{
    [Color("success"), DisplayText("Ekle")]
    [Symbol("➕")]
    Insert = 1,
 
    [Color("warning"), DisplayText("Güncelle")]
    [Symbol("✏️")]
    Update = 0,
 
    [Color("danger"), DisplayText("Sil")]
    [Symbol("🗑️")]
    Delete = -1,
}