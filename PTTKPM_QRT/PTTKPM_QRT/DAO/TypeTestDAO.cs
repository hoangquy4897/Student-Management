using PTTKPM_QRT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKPM_QRT.DAO
{
    class TypeTestDAO
    {
        private static TypeTestDAO instance;

        internal static TypeTestDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TypeTestDAO();
                return TypeTestDAO.instance;
            }
            set => TypeTestDAO.instance = value;
        }

        private TypeTestDAO() { }

        public List<TypeTest> GetListTypeTest()
        {
            List<TypeTest> typeTests = new List<TypeTest>();

            string query = "Select * From LOAIKIEMTRA";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            DataRow[] dataRows = data.Select();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                TypeTest typeTest = new TypeTest(dataRows[i]);
                typeTests.Add(typeTest);
            }

            return typeTests;
        }

        public string TypeToTypeID(string type)
        {
            string typeID = "";
            switch (type)
            {
                case "Miệng": typeID = "M"; break;
                case "15 Phút": typeID = "15P"; break;
                case "1 Tiết": typeID = "1T"; break;
                case "Thi Học Kỳ": typeID = "HK"; break;
            }
            return typeID;
        }
    }
}
