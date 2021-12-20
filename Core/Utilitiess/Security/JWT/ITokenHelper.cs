
using Core.Entities.Concrete;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilitiess.Security.JWT
{
    public interface ITokenHelper
    {

        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
