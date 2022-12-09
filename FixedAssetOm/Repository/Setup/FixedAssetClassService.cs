using FixedAssetOm.Models;
using FixedAssetOm.Context;
using FixedAssetOm.Repository;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using FixedAssetOm.Repository.Setup;
using Microsoft.Data.SqlClient;
using FixedAssetOm.Models.HelperModel;
using System.Linq;
using System.Data.SqlTypes;

namespace FixedAssetOm.Repository.Setup
{
	public class FixedAssetClassService :IassetClass
	{
		private readonly FixedAssetContext _fixedAssetContext;
		public FixedAssetClassService(FixedAssetContext fixedAssetContext)
		{
			_fixedAssetContext= fixedAssetContext;
		}


		public ReturnModel AddAssetClass(TblFaclass tblFaclass) // what is return type returnmodel
		{

			var retVal = new ReturnModel();
			SqlParameter Retval3 = new SqlParameter("@retval", SqlDbType.Int);
			Retval3.Direction = System.Data.ParameterDirection.Output;

			SqlParameter RetMsg3 = new SqlParameter("@retmesg", SqlDbType.VarChar, 150);
			RetMsg3.Direction = System.Data.ParameterDirection.Output;
			try
			{
				var AppList = _fixedAssetContext.Database.ExecuteSqlRaw("Proc_InsFAClass @Catcode,@classcode,@classname,@depMethod,@depRate,@lifespan" +
					",@userid,@authid,@retval output,@retmesg output",
					new SqlParameter("@Catcode", tblFaclass.CatCode),
					new SqlParameter("@classcode", tblFaclass.ClassCode),
					new SqlParameter("@classname", tblFaclass.ClassName),
					new SqlParameter("@depMethod", tblFaclass.DepMethod),
					new SqlParameter("@depRate", tblFaclass.DepRate),
					new SqlParameter("@lifespan", tblFaclass.LifeSpan),
					new SqlParameter("@userid", tblFaclass.UserId),
					new SqlParameter("@authid", tblFaclass.AuthId),
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

		public ReturnModel UpdateAssetClass(TblFaclass tblFaclass)
		{

			var retVal = new ReturnModel();
			SqlParameter Retval3 = new SqlParameter("@retval", SqlDbType.Int);
			Retval3.Direction = System.Data.ParameterDirection.Output;

			SqlParameter RetMsg3 = new SqlParameter("@retmesg", SqlDbType.VarChar, 150);
			RetMsg3.Direction = System.Data.ParameterDirection.Output;
			try
			{
				var AppList = _fixedAssetContext.Database.ExecuteSqlRaw("Proc_UpFAclass @CatCode,@classcode,@classname,@depMethod,@depRate,@lifespan,@userid," +
					"@authid,@retval output,@retmesg output",
					new SqlParameter("@CatCode", tblFaclass.CatCode),
					new SqlParameter("@classcode", tblFaclass.ClassCode),
					new SqlParameter("@classname", tblFaclass.ClassName),
					new SqlParameter("@depMethod", tblFaclass.DepMethod),
					new SqlParameter("@depRate", tblFaclass.DepRate),
					new SqlParameter("@lifespan", tblFaclass.LifeSpan),
					new SqlParameter("@userid", tblFaclass.UserId),
					new SqlParameter("@authid", tblFaclass.AuthId),
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
		public ReturnModel DeleteAssetClass(TblFaclass tblFaclass)
		{

			var retVal = new ReturnModel();
			SqlParameter Retval3 = new SqlParameter("@retval", SqlDbType.Int);
			Retval3.Direction = System.Data.ParameterDirection.Output;

			SqlParameter RetMsg3 = new SqlParameter("@retmesg", SqlDbType.VarChar, 150);
			RetMsg3.Direction = System.Data.ParameterDirection.Output;
			try
			{
				var AppList = _fixedAssetContext.Database.ExecuteSqlRaw("Proc_RemFAClass @classcode,@userid,@authid,@retval output,@retmesg output",
					new SqlParameter("@classcode", tblFaclass.ClassCode),
					 new SqlParameter("@userid", tblFaclass.UserId),
					new SqlParameter("@authid", tblFaclass.AuthId),
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
		
		public IEnumerable<TblFaclass> GetClassList()
		{
			var ClassList = new List<TblFaclass>();
			try
			{
				ClassList = _fixedAssetContext.TblFaclasses.FromSqlRaw("Proc_GetFAClass").ToList();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return ClassList;
		}

		 public TblFaclass GetAssetByClassCode(string ClassCode)
		{
			var ClassList = new TblFaclass();
			try
			{
				ClassList = _fixedAssetContext.TblFaclasses.FromSqlRaw("Proc_GetFAClassByClassCode @classcode",
					new SqlParameter("@classcode", ClassCode)).FirstOrDefault();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return ClassList;
		}

		
	



	}
}
