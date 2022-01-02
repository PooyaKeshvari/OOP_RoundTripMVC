using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Controllers
{
    public class ProductController : Controller
    {
        #region [-Ctor-]
        public ProductController()
        {
            RefProductViewModel = new Models.ViewModels.ProductViewModel();
        }
        #endregion

        #region [-Props-]
        public Models.ViewModels.ProductViewModel RefProductViewModel { get; set; }
        #endregion

        #region [-Actions-]

        #region [-Index()-]
        public IActionResult Index()
        {
            var q = RefProductViewModel.FillGrid();
            return View(q);
        }
        #endregion

        #region [-Create()-]
        #region [-Get-]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = new SelectList(RefProductViewModel.GetCategory(), "Id", "CategoryTitle");
            return View();
        }
        #endregion
        #region [-Post-]
        [HttpPost]
        public IActionResult Create([Bind(include: "Id,Title,CategoryID,UnitPrice,Quantity")] Dtos.ProductDto productDto)
        {
            RefProductViewModel.Create(productDto);
            return RedirectToAction("Index");
        }
        #endregion
        #endregion

        #region [-Edit()-]
        #region [-Get-]
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            var productInfo = RefProductViewModel.ShowDetail(id);
            ViewBag.Category = new SelectList(RefProductViewModel.GetCategory(), "Id", "CategoryTitle", productInfo.Category);
            return View(productInfo);
        }
        #endregion
        #region [-Post-]
        [HttpPost]
        public IActionResult Edit([Bind(include: "Id,Title,CategoryID,UnitPrice,Quantity")] Dtos.ProductDto productDto)
        {

            RefProductViewModel.Edit(productDto);
            return RedirectToAction("Index");
        }
        #endregion
        #endregion

        #region [-Delete()-]
        #region [-Get-]
        [HttpGet]
        public IActionResult Delete(Guid? id)
        {
            var productInfo = RefProductViewModel.ShowDetail(id);
            return View(productInfo);
        }
        #endregion
        #region [-Post-]

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {

            RefProductViewModel.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion

        #endregion

        #region [-ShowDetails(Guid? id)-]
        [HttpGet]
        public IActionResult ShowDetails(Guid id)
        {
            var q = RefProductViewModel.ShowDetail(id);
            return View(q);
        }
        #endregion

        #endregion




    }
}
