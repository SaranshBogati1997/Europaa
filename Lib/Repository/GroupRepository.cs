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
    public class GroupRepository :IGroupService
    {
        IDataAccess _dataAccess;
        public GroupRepository()
        {
            _dataAccess = new DataAccess();
        }
        public bool AddGroup(GroupModel model)
        {
            try
            {
                string query = "INSERT INTO tbl_mn_Group (GroupName, GroupDescription)" +
                    "VALUES (@GroupName, @GroupDescription)";
                var obj = _dataAccess.Query<object>(query, model);
                return obj != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<GroupModel> GetGroup()
        {
            try
            {
                string query = "SELECT * FROM tbl_mn_Group";
                return _dataAccess.Query<GroupModel>(query);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteGroup(int groupId)
        {
            string query = "DELETE FROM tbl_mn_Group WHERE GroupId = @GroupId";
            var obj = _dataAccess.Query<object>(query, new { GroupId = groupId });      
            return obj != null;
        }

        public DataTable GetGroupData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Description", typeof(string));
            List<GroupModel> unitList = GetGroup();
            foreach (GroupModel unit in unitList)
            {
                table.Rows.Add(unit.GroupId, unit.GroupName, unit.GroupDescription);
            };
            return table;
        }

        public bool UpdateGroup(GroupModel editedModel)
        {
            string query = "Update tbl_mn_Group set GroupName = @GroupName" +
                    " GroupDescription = @GroupDescription where GroupId = @GroupId";       
            var obj = _dataAccess.Query<object>(query, editedModel);
            return obj != null;
        }
    }
}
