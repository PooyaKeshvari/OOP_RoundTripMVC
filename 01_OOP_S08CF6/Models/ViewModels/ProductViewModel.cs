using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Models.ViewModels
{
    public class ProductViewModel
    {
        #region [-Ctor-]
        public ProductViewModel()
        {
            RefProductService = new DomainModels.Services.ProductService();
        }
        #endregion

        #region [-Props-]
        public DomainModels.Services.ProductService RefProductService { get; set; }
        #endregion

        #region [-Methods-]

        #region [-FillGrid()-]
        public dynamic FillGrid()
        {
            var q = RefProductService.Select();
            var conQ = Infrastructure.Convertor.DtoConvertor(q);
            return conQ;
        }
        #endregion

        #region [-Create(ProductDto productDto)-]
        public void Create(Controllers.Dtos.ProductDto productDto)
        {
            RefProductService.Insert(Infrastructure.Convertor.DtoConvertor(productDto));
        }
        #endregion

        #region [-Edit(ProductDto productDto)-]
        public void Edit(Controllers.Dtos.ProductDto productDto)
        {
            RefProductService.Update(Infrastructure.Convertor.DtoConvertor(productDto));
        }
        #endregion

        #region [-Delete(Guid id)-]
        public void Delete(Guid id)
        {
            RefProductService.Delete(id);
        }
        #endregion

        #region [-ShowDetail(Guid? id)-]
        public Controllers.Dtos.ProductDto ShowDetail(Guid? id)
        {
            var q = RefProductService.Find(id);
            var dto = Infrastructure.Convertor.DtoConvertor(q);
            return dto;
        }
        #endregion

        #region [-GetCategory()-]
        public dynamic GetCategory()
        {
            var q = RefProductService.SelectCategroy();
            var conQ = Infrastructure.Convertor.DtoConvertor(q);
            return conQ;
        }
        #endregion

        #endregion

    }
}
