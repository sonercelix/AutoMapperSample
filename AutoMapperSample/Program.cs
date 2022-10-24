using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.Code = "CODE1";
            product.Name = "Samsung S21";
            product.Description = "Samsung S21 64 GB Cep telefonu";

            //ProductDTO productDTO = new ProductDTO();
            //productDTO.Id = product.Id;
            //productDTO.Code = product.Code;
            //productDTO.Name = product.Name;
            //productDTO.Description = product.Description;


            //Initialize the mapper
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()
            .ForMember(dest=> dest.Desc, act=> act.MapFrom(src=>src.Description)));
            //Using automapper
            var mapper = config.CreateMapper();
            //var productDTO = mapper.Map<HEDEF_NESNE>(KAYNAK_NESNESİ);
            var productDTO = mapper.Map<ProductDTO>(product);
            
            Console.WriteLine("Code:" + productDTO.Code);
            Console.WriteLine("Name:" + productDTO.Name);
            Console.WriteLine("Description:" + productDTO.Desc);

        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }


    public class ProductDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }


}
