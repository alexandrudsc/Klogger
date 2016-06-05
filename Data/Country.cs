using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klogger.Data
{
    class Country
    {
        public String name;
        public int idx;
        public String language;

        public Country()
        {
        }

        public Country(String name, int idx)
        {
            this.name = name;
            this.idx = idx;
        }

        public override String ToString()
        {
            return this.name;
        }

        public static Country CreateCountry(DataRow rs)
        {
            if (rs == null) return null;
            try
            {
                Country c = new Country();
                c.name = rs[DB.COUNTRY_NAME].ToString();
                c.idx = int.Parse(rs[DB.COUNTRY_ID].ToString());
                return c;
            }
            catch
            {
                return null;
            }
        }

        public static ArrayList CreateListCountries(DataTable rs)
        {
            ArrayList list = new ArrayList();
            try
            {
                if (rs == null) return null;

                foreach (DataRow row in rs.Rows)
                    list.Add(Country.CreateCountry(row));
            }
            catch
            {
                return null;
            }
            return list;
        }
    }
}
