using SVSur.Models.Domain;
using SVSur.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSur.Manager.Contracts
{
  public  interface IChoferManager: ICrud<Chofer>
    {

        //Funcionalidades especificas
        IEnumerable<ChoferDTO> GetAllDTO(bool status);
    }
}
