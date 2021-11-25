using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    class Intervention
    {
        private int _interventionId { get; set; }
        private int _siteInspectionId { get; set; }
        private int _subHeaderId { get; set; }
        private int _count { get; set; }
        private string _comment { get; set; }
        private bool _completed { get; set; }
        private string _actionTaken { get; set; }

        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

        public Intervention() {}

        public Intervention(int subHeaderId, int count, string comment, bool completed, string actionTaken) {
            _subHeaderId = subHeaderId;
            _count = count;
            _comment = comment;
            _completed = completed;
            _actionTaken = actionTaken;
        }

        public int InterventionID
        {
            get { return _interventionId; }
            set { _interventionId = value; }
        }
        public int SiteInspectionID
        {
            get { return _siteInspectionId; }
            set { _siteInspectionId = value; }
        }
        public int SubHeaderID
        {
            get { return _subHeaderId; }
            set { _subHeaderId = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }
        public string ActionTaken
        {
            get { return _actionTaken; }
            set { _actionTaken = value; }
        }

    }
}
