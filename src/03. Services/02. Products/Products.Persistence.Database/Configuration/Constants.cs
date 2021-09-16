using Products.Domain;
using System.Collections.Generic;

namespace Products.Persistence.Database.Configuration
{
    public class Constants
    {
        public class Productos
        {
            public const int NUMBER_FUNDS = 500;
            public const int NUMBER_ACTIONS = 500;
            public const int NUMBER_SICAVS = 500;
            public const int NUMBER_ETFS = 500;
            public const int NUMBER_DEPOSITOS = 500;
            public const int NUMBER_RENTAFIJA = 500;
            public const int NUMBER_PLANPENSIONES = 500;
            public const int NUMBER_SEGUROS = 500;

            public const int NUMBER_GESTORAS = 10;
            public const int NUMBER_MERCADOS = 10;
            public const int NUMBER_AGRUPACION_CLASE = 3;
            public const int NUMBER_AGRUPACION_CLASE_PRODUCTOS = 3;
            public const int NUMBER_CERO_DECIMALES_TITULOS = 0;
            public const int NUMBER_MAXIMO_DECIMALES_TITULOS = 6;

            public const int NUMBER_DECIMALES_TITULOS_DEPOSITOS = 2;

            public const int NUMBER_DECIMALES_TITULOS_SEGUROS = 2;
            public const int PRECIO_SEGUROS = 1;
        }

        public class ProductTypes
        {
            public static ProductType Accion { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.ACCIONES, Order = 1 };
            public static ProductType Fondo { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.FONDOS, Order = 2 };
            public static ProductType Liquidez { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.LIQUIDEZ, Order = 3 };
            public static ProductType Etf { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.ETFs, Order = 4 };
            public static ProductType Sicav { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.SICAVs, Order = 5 };
            public static ProductType Depositos { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.DEPOSITOS, Order = 6 };
            public static ProductType RentaFija { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.RENTAFIJA, Order = 7 };
            public static ProductType PlanesPensiones { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.PLANESPENSIONES, Order = 8 };
            public static ProductType Seguros { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.SEGUROS, Order = 9 };
            public static ProductType Otros { get; set; } = new ProductType() { Code = Products.Domain.ProductTypes.OTROS, Order = 10 };
        }

        public const decimal Precio = 1;

        public Dictionary<int, decimal> PreciosPorDivisas { get; set; } = new Dictionary<int, decimal>() { { DIVISA_EUR, 1 } };

        public const int DIVISA_EUR = 1;

        public const int DIVISA_USD = 2;

        public const int DIVISA_CAD = 3;

        public const int DIVISA_MXN = 4;

        public const int DIVISA_COP = 5;

        public const int DIVISA_CRC = 6;

        public const int DECIMALES = 6;

        public static List<int> Currencies = new List<int> { DIVISA_EUR/*"EUR"*/, DIVISA_USD/*"USD"*/, DIVISA_CAD/*"CAD"*/, DIVISA_MXN /*"MXN"*/, DIVISA_COP/*"COP"*/, DIVISA_CRC/*"CRC"*/ };

        public static List<string> CodigosRestricciones = new List<string>() { RestrictionCode.IMSI, RestrictionCode.IMSS, RestrictionCode.IMM, RestrictionCode.IMR, RestrictionCode.IMO };
    }
}
