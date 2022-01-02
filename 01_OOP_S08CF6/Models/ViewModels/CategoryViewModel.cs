using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Models.ViewModels
{
    public class CategoryViewModel
    {
        #region [-Ctor-]
        public CategoryViewModel()
        {
            RefCategoryService = new DomainModels.Services.CategoryService();
        }
        //public CategoryViewModel(/*IMapper mapper ,*/ DomainModels.Services.CategoryService categoryService)
        //{
        //    RefCategoryService = categoryService;
        //   // Mapper = mapper;
        //}
        #endregion

        #region [-Props-]
        public DomainModels.Services.CategoryService RefCategoryService { get; set; }
       // public IMapper Mapper { get; set; }
        #endregion

        #region [-Methods-]

        #region [-FillGrid()-]
        public dynamic FillGrid()
        {
            var q = RefCategoryService.Select();
            var conQ = Infrastructure.Convertor.DtoConvertor(q);
            //return q;
            return conQ;
            //return Mapper.Map<List<Controllers.Dtos.CategoryDto>>(q);
        }
        #endregion

        #region [-Create(CategoryDto categoryDto)-]
        public void Create(Controllers.Dtos.CategoryDto categoryDto)
        {
            RefCategoryService.Insert(Infrastructure.Convertor.DtoConvertor(categoryDto));
        }
        #endregion

        #region [-Edit(CategoryDto categoryDto)-]
        public void Edit(Controllers.Dtos.CategoryDto categoryDto)
        {
            RefCategoryService.Update(Infrastructure.Convertor.DtoConvertor(categoryDto));
        }
        #endregion

        #region [-Delete(Guid id)-]
        public void Delete(Guid id)
        {
            RefCategoryService.Delete(id);
        }
        #endregion

        #region [-ShowDetail(Guid? id)-]
        public Controllers.Dtos.CategoryDto ShowDetail(Guid? id)
        {
            var target = RefCategoryService.Find(id);
            var conId = Infrastructure.Convertor.DtoConvertor(target);
            return conId;
        }
        #endregion

        #endregion





    }
}
