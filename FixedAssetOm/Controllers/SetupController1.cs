using FixedAssetOm.Context;
using FixedAssetOm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using FixedAssetOm.Repository;
using FixedAssetOm.Repository.Setup;

namespace FixedAssetOm.Controllers
{
	public class SetupController1 : Controller
	{
		// GET: SetupController1
		private readonly IassetClass _iassetClass;
		private readonly ICategory _icategory;
		public SetupController1(IassetClass iassetClass, ICategory icategory)
		{
			_iassetClass = iassetClass;
			_icategory = icategory;

		}

		public ActionResult AssetClassList()
		{
			var data = _iassetClass.GetClassList();
			return View(data);
		}

		// GET: SetupController1/Details/5


		// GET: SetupController1/Create
		[HttpGet]
        public ActionResult AssetClassCreate()
		{
			return View();
		}
		[HttpPost]
        public ActionResult AssetClassCreate(TblFaclass tblFaclass)
		{
			tblFaclass.UserId = "";
			tblFaclass.AuthId = "";
			bool Status = false;
			string Message = "";
			if (ModelState.IsValid)
			{
				var data = _iassetClass.AddAssetClass(tblFaclass);
				if (data.retVal == 0)
				{
					Status = true;
					Message = data.retmsg;
					//return RedirectToAction("RoleList", "Setup");
				}
				else
				{
					Status = false;
					Message = data.retmsg;
				}
			}
			ViewBag.Message = Message;
			ViewBag.Status = Status;
			return View();
		}

		[HttpGet]
		public ActionResult EditAssetClass(string classcode)
		{
			var data = _iassetClass.GetAssetByClassCode(classcode);
			return View(data);
		}
		[HttpPost]
		public ActionResult EditAssetClass(TblFaclass tblFaclass)
		{
			tblFaclass.UserId = "";
			tblFaclass.AuthId = "";
			bool Status = false;
			string Message = "";
			if (ModelState.IsValid)
			{
				var data = _iassetClass.UpdateAssetClass(tblFaclass);
				if (data.retVal == 0)
				{
					Status = true;
					Message = data.retmsg;
					//return RedirectToAction("RoleList", "Setup");
				}
				else
				{
					Status = false;
					Message = data.retmsg;
				}
			}
			ViewBag.Message = Message;
			ViewBag.Status = Status;

			return View();
		}

		public ActionResult DeleteAssetClass()
		{
			return View();
		}


		[HttpDelete]
		public ActionResult DeleteAssetClass(string classcode)
		{
			var model = new TblFaclass();
			model.ClassCode = classcode;
			model.UserId = "";
			model.AuthId = "";

			var result = _iassetClass.DeleteAssetClass(model);
			if (result.retVal == 0)
			{
				ViewBag.Message = String.Format("Error!!!{0} ", result.retmsg);
				return RedirectToAction("AssetClassList", "Setup");
			}
			else
			{
				ViewBag.Message = String.Format("Error!!!{0} ", result.retmsg);
			}
			return View(model);
		}

		public ActionResult AssetCategoryList()
		{
			var data = _icategory.GetCategoryList();
			return View(data);
		}

		public ActionResult createCategoryClass(TblFacategory model)
		{
			bool Status = false;
			string Message = "";
			if (ModelState.IsValid)
			{

				model.UserId = "";
				model.AuthId = "";

				var data = _icategory.AddAssetCategory(model);
				if (data.retVal == 0)
				{
					Status = true;
					Message = data.retmsg;
					//return RedirectToAction("RoleList", "Setup");
				}
				else
				{
					Status = false;
					Message = data.retmsg;
				}
			}

			ViewBag.Message = Message;
			ViewBag.Status = Status;
			return View();
		}


		[HttpGet]
		public ActionResult EditCategoryClass(string CatCode)
		{
			var model = _icategory.GetAssetByCatCode(CatCode);
			return View(model);
	
	}
		[HttpPost]
		public ActionResult EditCategoryClass(TblFacategory model)
		{
			model.UserId = "";
			model.AuthId = "";
			bool Status = false;
			string Message = "";
			if (ModelState.IsValid)
			{
				var data = _icategory.UpdateAssetCategory(model);
				if (data.retVal == 0)
				{
					Status = true;
					Message = data.retmsg;
					//return RedirectToAction("RoleList", "Setup");
				}
				else
				{
					Status = false;
					Message = data.retmsg;
				}
				ViewBag.Message = Message;
				ViewBag.Status = Status;
			}
			return View();
		}
		public ActionResult DeleteCategoryClass(string CatCode)
		{
			var model = new TblFacategory();
			model.CatCode = CatCode;
			model.UserId = "";
			model.AuthId = "";

			var result = _icategory.DeleteAssetCategory(model);
			if (result.retVal == 0)
			{
				ViewBag.Message = String.Format("Error!!!{0} ", result.retmsg);
				return RedirectToAction("CategoryClassList", "Setup");
			}
			else
			{
				ViewBag.Message = String.Format("Error!!!{0} ", result.retmsg);
			}
			return View(model);
		}



	}
}

		
	
		
		
	
