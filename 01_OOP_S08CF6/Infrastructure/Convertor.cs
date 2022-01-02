using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Infrastructure
{
    public static class Convertor
    {


        #region [-ListDtoConvertors-]

         #region [-ReturnCotrollerList-]
          #region [-ToProduct-]
        //Used For FillGrid In ProductVM
        public static List<Controllers.Dtos.ProductDto> DtoConvertor(List<Models.DomainModels.Aggregations.ProductAggregate.Product> productsModel)
        {
            var controllerList = new List<Controllers.Dtos.ProductDto>();
            foreach (var item in productsModel)
            {
                var controllerItem = new Controllers.Dtos.ProductDto();
                controllerItem.Id = item.Id;
                controllerItem.Title = item.Title;
                controllerItem.CategoryID = item.CategoryID;
                controllerItem.Category = new Controllers.Dtos.CategoryDto()
                { Id = item.Category.Id, CategoryTitle = item.Category.CategoryTitle };
                controllerItem.UnitPrice = item.UnitPrice;
                controllerItem.Quantity = item.Quantity;

                controllerList.Add(controllerItem);
            }
            return controllerList;
        }
        #endregion
          #region [-ToCategory-]
        //Used For GetCategory In ProductVM
        public static List<Controllers.Dtos.CategoryDto> DtoConvertor(List<Models.DomainModels.Aggregations.CategoryAggregate.Category> categoriesModel)
        {
            var controllerList = new List<Controllers.Dtos.CategoryDto>();
            foreach (var item in categoriesModel)
            {
                var controllerItem = new Controllers.Dtos.CategoryDto();
                controllerItem.Id = item.Id;
                controllerItem.CategoryTitle = item.CategoryTitle;

                controllerList.Add(controllerItem);
            }
            return controllerList;

        }
        #endregion
         #endregion

         #region [-ReturnModelList-]
        //NOT Used Any Where.
          #region [-ToProduct-]
        public static List<Models.DomainModels.Aggregations.ProductAggregate.Product> DtoConvertor(List<Controllers.Dtos.ProductDto> productsController)
        {
            var modelList = new List<Models.DomainModels.Aggregations.ProductAggregate.Product>();
            foreach (var item in productsController)
            {
                var modelItem = new Models.DomainModels.Aggregations.ProductAggregate.Product();
                modelItem.Id = item.Id;
                modelItem.Title = item.Title;
                modelItem.CategoryID = item.CategoryID;
                modelItem.Category = new Models.DomainModels.Aggregations.CategoryAggregate.Category()
                { Id = item.Id, CategoryTitle = item.Category.CategoryTitle };
                modelItem.UnitPrice = item.UnitPrice;
                modelItem.Quantity = item.Quantity;

                modelList.Add(modelItem);
            }
            return modelList;
        }
        #endregion
          #region [-ToCategory-]
        public static List<Models.DomainModels.Aggregations.CategoryAggregate.Category> DtoConvertor(List<Controllers.Dtos.CategoryDto> categoriesController)
        {
            var modelList = new List<Models.DomainModels.Aggregations.CategoryAggregate.Category>();
            foreach (var item in categoriesController)
            {
                var modelItem = new Models.DomainModels.Aggregations.CategoryAggregate.Category();
                modelItem.Id = item.Id;
                modelItem.CategoryTitle = item.CategoryTitle;

                modelList.Add(modelItem);
            }
            return modelList;
        }
        #endregion
        #endregion

        #endregion


        #region [-ClassDtoConvertors-]

         #region [-ReturnModelClass-]
          #region [-ToProduct-]
        //Used For Edit & Create In ProductVM
        public static Models.DomainModels.Aggregations.ProductAggregate.Product DtoConvertor(Controllers.Dtos.ProductDto productController)
        {
            var model = new Models.DomainModels.Aggregations.ProductAggregate.Product();
            model.Id = productController.Id;
            model.Title = productController.Title;
            model.CategoryID = productController.CategoryID;
            model.UnitPrice = productController.UnitPrice;
            model.Quantity = productController.Quantity;
            return model;
        }
        #endregion
        #region [-ToCategory-]
        //Used For Edit & Create In CategorVM

        public static Models.DomainModels.Aggregations.CategoryAggregate.Category DtoConvertor(Controllers.Dtos.CategoryDto categoryController)
        {
            var model = new Models.DomainModels.Aggregations.CategoryAggregate.Category();
            model.Id = categoryController.Id;
            model.CategoryTitle = categoryController.CategoryTitle;
            return model;
        }
        #endregion
         #endregion

         #region [-ReturnControllerClass-]
          #region [-ToProduct-]
        //Used For Show Details In ProductVM
        public static Controllers.Dtos.ProductDto DtoConvertor(Models.DomainModels.Aggregations.ProductAggregate.Product  model)
        {
            var controllerItem = new Controllers.Dtos.ProductDto();
            controllerItem.Id = model.Id;
            controllerItem.Title = model.Title;
            controllerItem.CategoryID = model.CategoryID;
            controllerItem.UnitPrice = model.UnitPrice;
            controllerItem.Quantity = model.Quantity;
            return controllerItem;
        }
        #endregion
          #region [-ToCategory-]
        //Used For ShowDetails In CategoryVM
        public static  Controllers.Dtos.CategoryDto DtoConvertor(Models.DomainModels.Aggregations.CategoryAggregate.Category model)
        {
            var controllerItem = new Controllers.Dtos.CategoryDto();
            controllerItem.Id = model.Id;
            controllerItem.CategoryTitle = model.CategoryTitle;

            return controllerItem;
        }
        #endregion 
         #endregion

        #endregion


    }
}
