using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface IGroupService
    {
        bool AddGroup(GroupModel model);
        List<GroupModel> GetGroup();
        bool DeleteGroup(int unitId);
        DataTable GetGroupData();
        bool UpdateGroup(GroupModel editedModel);
    }
}
