using System;
using System.Collections.Generic;
using SVSur.Models.Domain;
using SVSur.Models.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSur.Manager.Contracts
{
     public interface IRutaManager: ICrud<Ruta>
    {

        //Funcionalidades especificas
        IEnumerable<RutaDTO> GetAllDTO(bool status);

        IEnumerable<RutaDTO> buscar(string CiudadOrigen,string CiudadDestino,string viaje);
    }
}
