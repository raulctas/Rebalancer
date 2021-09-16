using System.Collections.Generic;

namespace Products.Domain
{
    public class RestrictionCode
    {
        public const string IMSI = "IMSI";
        public const string IMSS = "IMSS";
        public const string IMM = "IMM";
        public const string IMR = "IMR";
        public const string IMO = "IMO";

        private static Dictionary<string, string> _restrictionCodes
            = new Dictionary<string, string>()
            {
                {IMSI, "Importe Mínimo Suscripción Inicial"},
                {IMSS, "Importe Mínimo Suscripción Sucesiva"},
                {IMM, "Importe Mínimo Mantener"},
                {IMR, "Importe Máximo Reembolso"},
                {IMO, "Importe Mínimo Por Operación"}
            };

        public static Dictionary<string, string> CodigosRestriccion
        {
            get
            {
                return _restrictionCodes;
            }
        }
    }
}
