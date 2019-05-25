using System;

namespace MalikP.IVAO.Library.Common
{
    public interface IIVAOStringService
    {
        DateTime? IVAO_GetDateTime(string value);

        decimal IVAO_GetDecimal(string value);

        int IVAO_GetInt(string value);
    }
}
