using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Controllers
{
    public class CategoryController : Controller
    {
        #region [-Ctor-]
        public CategoryController()
        {
            RefCategoryViewModel = new Models.ViewModels.CategoryViewModel();
        }
        #endregion

        #region [-Props-]
        public Models.ViewModels.CategoryViewModel RefCategoryViewModel { get; set; }
        #endregion
        #region [-Actions-]

        #region [-Index()-]
        public IActionResult Index()
        {
            var q = RefCategoryViewModel.FillGrid();
            return View(q);
        }
        #endregion
     
        #region [-Create()-]
        #region [-Get-]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        #endregion
        #region [-Post()-]
        [HttpPost]
        public IActionResult Create([Bind(include:"Id,CategoryTitle")] Dtos.CategoryDto categoryDto)
        {
            RefCategoryViewModel.Create(categoryDto);
            return RedirectToAction("Index");
        }
        #endregion
        #endregion

        #region [-Edit()-]
        #region [-Get-]
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            var q = RefCategoryViewModel.ShowDetail(id);
            return View(q);
        }
        #endregion
        #region [-Post()-]
        [HttpPost]
        public IActionResult Edit([Bind(include: "Id,CategoryTitle")] Dtos.CategoryDto categoryDto)
        {
            RefCategoryViewModel.Edit(categoryDto);
            return RedirectToAction("Index");
        }
        #endregion
        #endregion

        #region [-Delete()-]
        #region [-Get-]
        [HttpGet]
        public IActionResult Delete(Guid? id)
        {
            var q = RefCategoryViewModel.ShowDetail(id);
            return View(q);
        }
        #endregion
        #region [-Post()-]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            RefCategoryViewModel.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion
        #endregion

        #region [-ShowDetails()-]
        public IActionResult ShowDetails(Guid id)
        {
            var q = RefCategoryViewModel.ShowDetail(id);
            return View(q);
        }
        #endregion
        #endregion

    }
}
