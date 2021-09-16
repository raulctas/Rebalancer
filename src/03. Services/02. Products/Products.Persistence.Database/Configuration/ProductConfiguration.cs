using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain;
using System;
using System.Collections.Generic;

namespace Products.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        readonly Random random = new Random();

        public List<int> Currencies { get; set; }

        public List<string> Gestoras { get; set; }

        public List<string> Mercados { get; set; }

        public List<Product> Products { get; set; }

        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.Property(x => x.Manager).HasMaxLength(500);

            entityBuilder.Property(x => x.Market).HasMaxLength(500);

            Products = GetProducts();
            entityBuilder.HasData(Products);
        }

        private List<string> BuildGestorasList()
        {
            List<string> gestoras = new List<string>();
            for (int i = 0; i < Constants.Productos.NUMBER_GESTORAS; i++)
                gestoras.Add($"Gestora {i}");
            return gestoras;
        }

        private List<string> BuildMercadosList()
        {
            List<string> gestoras = new List<string>();
            for (int i = 0; i < Constants.Productos.NUMBER_MERCADOS; i++)
                gestoras.Add($"Mercado {i}");
            return gestoras;
        }

        private List<Product> GetProducts()
        {
            Currencies = Constants.Currencies;
            Gestoras = BuildGestorasList();
            Mercados = BuildMercadosList();
            //CodigosRestricciones = Constants.CodigosRestricciones;
            //Products = GetProducts();
            //Config = GetConfig();
            //ConfigsClasses = GetConfigsClasses();

            List<Product> products = new List<Product>();

            products.AddRange(GetActions());

            //products.AddRange(GetFunds());

            //products.AddRange(GetLiquidity());

            //products.AddRange(GetEtfs());

            //products.AddRange(GetSicavs());

            //products.AddRange(GetDepositos());

            //products.AddRange(GetRentaFija());

            //products.AddRange(GetPlanPensiones());

            //products.AddRange(GetSeguros());

            return products;
        }

        private IEnumerable<Product> GetActions()
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < Constants.Productos.NUMBER_ACTIONS; i++)
            {
                var divisa = Currencies[random.Next(Currencies.Count)];
                var id = $"Acción {i}";

                products.Add(GetProducto(id: id,
                                         divisa: divisa,
                                         esProductoComprasVentas: true,
                                         esTraspasable: false,
                                         generaOperacionesAutoliquidadas: false,
                                         gestora: null,
                                         decimalesTitulos: Constants.Productos.NUMBER_CERO_DECIMALES_TITULOS,
                                         productType: Constants.ProductTypes.Accion,
                                         preciosPorDivisa: new Dictionary<int, decimal>() { { Constants.DIVISA_EUR, (decimal)random.Next(0, 10) + (decimal)random.NextDouble() } },
                                         mercado: Mercados[random.Next(Mercados.Count)]
                                        )
                            );
            }

            return products;
        }

        private Product GetProducto(string id, int divisa, bool esProductoComprasVentas, bool esTraspasable, bool generaOperacionesAutoliquidadas, string gestora,
            int? decimalesTitulos, ProductType productType, Dictionary<int, decimal> preciosPorDivisa, string mercado)
        {
            var producto = new Product();
            producto.Id = id;
            producto.Currency = divisa;
            producto.IsProductPurchasesSales = esProductoComprasVentas;
            producto.IsTransferable = esTraspasable;
            producto.Manager = gestora;
            producto.DecimalesTitulos = decimalesTitulos;
            producto.ProductTypeCode = productType.Code;
            producto.ProductType = productType;
            producto.PricesByCurrency = preciosPorDivisa;
            producto.Market = mercado;
            return producto;
        }

    }
}
