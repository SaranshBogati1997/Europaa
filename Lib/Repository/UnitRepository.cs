using Lib.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class UnitRepository :IUnitService
    {
        IDataAccess _dataAccess;
        public UnitRepository()
        {
            _dataAccess = new DataAccess();
        }
        public bool AddUnit(UnitModel model)
        {
            try
            {
                string query = "INSERT INTO tbl_mn_Unit (UnitName, UnitShortName)" +
                    "VALUES (@UnitName, @UnitShortName)";
                var obj = _dataAccess.Query<object>(query, model);
                return obj != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<UnitModel> GetUnit()
        {
            try
            {
                string query = "SELECT * FROM tbl_mn_Unit";
                return _dataAccess.Query<UnitModel>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteUnit(int unitId)
        {
            string query = "DELETE FROM tbl_mn_Unit WHERE UnitId = @UnitId";
            var obj = _dataAccess.Query<object>(query, new { UnitId = unitId });
            return obj != null;
        }

        public DataTable GetUnitData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Short Name", typeof(string));
            List<UnitModel> unitList = GetUnit();
            foreach (UnitModel unit in unitList)
            {

                table.Rows.Add(unit.UnitId, unit.UnitName, unit.UnitShortName);
            };
            return table;
        }

        public bool UpdateUnit(UnitModel editedModel)
        {
            string query = "Update tbl_mn_Unit set UnitName = @UnitName" +
                   " UnitShortName = @UnitShortName where UnitId = @UnitId";
            var obj = _dataAccess.Query<object>(query, editedModel);
            return obj != null;
        }
    }
}
