using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_7
{
    class Database
    {
         private static Database database;
        private ToursDataSetTableAdapters.ToursTableAdapter toursTable;
        private ToursDataSet toursData;
        private Database()
        {
            toursTable = new ToursDataSetTableAdapters.ToursTableAdapter();
            toursData = new ToursDataSet();
            toursTable.Fill(toursData.Tours);
            
        }
        public static Database DatabaseInstance
        {
            get
            {
                if (database == null)
                {
                    database = new Database();

                }
                return database;
            }
        }
        public ToursDataSetTableAdapters.ToursTableAdapter ToursTableAdapter
        {
            get
            {
                return toursTable;
            }
        }
        public ToursDataSet ToursData
        {
            get
            {
                return toursData;
            }
        }
    }
}
