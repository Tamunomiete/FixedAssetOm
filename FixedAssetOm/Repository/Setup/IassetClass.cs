using FixedAssetOm.Models;
using System;
using FixedAssetOm.Controllers;
using System.Data;
using System.Data.SqlClient;
using FixedAssetOm.Models.HelperModel;

namespace FixedAssetOm.Repository.Setup
{
	public interface  IassetClass
	{
		IEnumerable<TblFaclass> GetClassList();
		TblFaclass GetAssetByClassCode(string ClassCode);
		 ReturnModel AddAssetClass(TblFaclass tblFaclass);
		ReturnModel UpdateAssetClass(TblFaclass tblFaclass);
		ReturnModel DeleteAssetClass(TblFaclass tblFaclass);
	}
}
