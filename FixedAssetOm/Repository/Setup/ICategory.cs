using FixedAssetOm.Models;
using FixedAssetOm.Models.HelperModel;

namespace FixedAssetOm.Repository.Setup
{
    public interface ICategory
    {
		
		ReturnModel AddAssetCategory(TblFacategory tblFacategory);
		ReturnModel UpdateAssetCategory(TblFacategory tblFacategory);
		ReturnModel DeleteAssetCategory(TblFacategory tblFacategory);
		IEnumerable<TblFacategory> GetCategoryList();
		TblFacategory GetAssetByCatCode(string CatCode);
	}
}
