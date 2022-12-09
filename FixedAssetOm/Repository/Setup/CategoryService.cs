using FixedAssetOm.Context;
using FixedAssetOm.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using FixedAssetOm.Models.HelperModel;

namespace FixedAssetOm.Repository.Setup
{
    public class CategoryService : ICategory
    {
        private readonly FixedAssetContext _fixedAssetContext;
        public CategoryService(FixedAssetContext fixedAssetContext)

        {
            _fixedAssetContext = fixedAssetContext;
        }

		public ReturnModel AddAssetCategory(TblFacategory tblFacategory)
		{
            var retVal = new ReturnModel();

            // defining the sql parameters
            SqlParameter Retval3 = new SqlParameter("@retval", SqlDbType.Int);
            Retval3.Direction = System.Data.ParameterDirection.Output;

            SqlParameter RetMsg3 = new SqlParameter("@retmesg", SqlDbType.VarChar, 150);
            RetMsg3.Direction = System.Data.ParameterDirection.Output;
            try
            {
                var AppList = _fixedAssetContext.Database.ExecuteSqlRaw("Proc_InsFACategory @CatCode,@CatDesc,@userid,@authid,@retval output,@retmesg output",
                    new SqlParameter("@CatCode", tblFacategory.CatCode),
                    new SqlParameter("@CatDesc", tblFacategory.CatDesc),
                    new SqlParameter("@userid", tblFacategory.UserId),
                    new SqlParameter("@authid", tblFacategory.AuthId),
                    Retval3, RetMsg3);

                retVal.retVal = Convert.ToInt32(Retval3.Value);
                retVal.retmsg = RetMsg3.Value.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retVal;
        }
		public ReturnModel UpdateAssetCategory(TblFacategory tblFacategory)
		{
            var retVal = new ReturnModel();
            SqlParameter Retval3 = new SqlParameter("@retval", SqlDbType.Int);
            Retval3.Direction = System.Data.ParameterDirection.Output;

            SqlParameter RetMsg3 = new SqlParameter("@retmesg", SqlDbType.VarChar, 150);
            RetMsg3.Direction = System.Data.ParameterDirection.Output;
            try
            {
                var AppList = _fixedAssetContext.Database.ExecuteSqlRaw("Proc_UpFACategory @Id @CatCode,@CatDesc,@userid,@authid,@retval output,@retmesg output",
                    new SqlParameter("@Id", tblFacategory.Id),
                    new SqlParameter("@CatCode", tblFacategory.CatCode),
                    new SqlParameter("@CatDesc", tblFacategory.CatDesc),
                    new SqlParameter("@userid", tblFacategory.UserId),
                    new SqlParameter("@authid", tblFacategory.AuthId),
                    Retval3, RetMsg3);

                retVal.retVal = Convert.ToInt32(Retval3.Value);
                retVal.retmsg = RetMsg3.Value.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retVal;
        }

		public ReturnModel DeleteAssetCategory(TblFacategory tblFacategory)
		{
            var retVal = new ReturnModel();
            SqlParameter Retval3 = new SqlParameter("@retval", SqlDbType.Int);
            Retval3.Direction = System.Data.ParameterDirection.Output;

            SqlParameter RetMsg3 = new SqlParameter("@retmesg", SqlDbType.VarChar, 150);
            RetMsg3.Direction = System.Data.ParameterDirection.Output;
            try
            {
                var AppList = _fixedAssetContext.Database.ExecuteSqlRaw("Proc_RemFACategory @Id,@retval output,@retmesg output",
                    new SqlParameter("@Id", tblFacategory.Id),
                    Retval3, RetMsg3);

                retVal.retVal = Convert.ToInt32(Retval3.Value);
                retVal.retmsg = RetMsg3.Value.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retVal;

        }

		public IEnumerable<TblFacategory> GetCategoryList()
		{
			var CatList = new List<TblFacategory>();
			try
			{
				_fixedAssetContext.TblFaclasses.FromSqlRaw("Proc_GetCategory").ToList();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return CatList;
		}

		public TblFacategory GetAssetByCatCode(string CatCode)
		{
			var CatList = new TblFacategory();
			try
			{
				CatList = _fixedAssetContext.TblFacategories.FromSqlRaw("Proc_GetCategoryByID @catcode",
					new SqlParameter("@classcode", CatCode)).FirstOrDefault();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return CatList;
		}

	}
}
            

			


		



