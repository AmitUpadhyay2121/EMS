using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Election.Data
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public int Class { get; set; }
        public string Section { get; set; }
        public int AdmNumber { get; set; }
        public string  House { get; set; }
        public string Committee { get; set; }
    }
}
