using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices.Models
{
    class MuskSite
    {
        // Attributes
        private int _siteId { get; set; }
        private string _name { get; set; }
        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

        // Constructor
        public MuskSite(int siteId, string name) {
            _siteId = siteId;
            _name = name;
        }

        // Methods
        public static List<MuskSite> getAllSites()
        {
            // Select all sites from database 
            string queryExpression = String.Format("SELECT * FROM Sites");
            DataSet result = queryExpression.getDataSetFromDB();

            // Empty list of sites
            List<MuskSite> sites = new List<MuskSite>();

            foreach (DataRow row in result.Tables[0].Rows)
            {
                sites.Add(new MuskSite(row.Field<int>("SiteID"), row.Field<string>("Name")));
            }

            return sites;
        }

        public int SiteId
        {
            get { return _siteId; }
        }
        public string Name
        {
            get { return _name; }
        }
    }
}
