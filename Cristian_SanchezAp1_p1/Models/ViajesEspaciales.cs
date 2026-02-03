using System.ComponentModel.DataAnnotations;
namespace Cristian_SanchezAp1_p1.Models;

public class ViajesEspaciales
{
    [Key]
    public int ViajeId { get; set; }
    
    public int fechaid { get; set; }
    
    public string Descripcion { get; set; }

    public int costo { get; set; }
    

}
