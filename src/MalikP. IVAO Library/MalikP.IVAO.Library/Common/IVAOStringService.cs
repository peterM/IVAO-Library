using System;

namespace MalikP.IVAO.Library.Common
{
    public class IVAOStringService : IIVAOStringService
    {
        public DateTime? IVAO_GetDateTime(string value)
        {
            return value.IVAO_GetDateTime();
        }

        public int IVAO_GetInt(string value)
        {
            return value.IVAO_GetInt();
        }

        public decimal IVAO_GetDecimal(string value)
        {
            return value.IVAO_GetDecimal();
        }
    }
}
