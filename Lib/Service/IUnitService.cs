using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface IUnitService
    {
        bool AddUnit(UnitModel model);
        List<UnitModel> GetUnit();
        bool DeleteUnit(int unitId);
        DataTable GetUnitData();
        bool UpdateUnit(UnitModel editedModel);
    }
}
