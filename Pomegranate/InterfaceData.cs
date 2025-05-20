using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomegranate
{
    public interface InterfaceData
    {
        public void CreateRecord();
        public void UpdateRecord();
        public void DeleteRecord();
        public void ExportDataTable();
        public void ImportXML();
    }
}
