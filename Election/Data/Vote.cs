using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Election.Data
{
    public class Vote
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int VoteID { get; set; }
        public string CandidateName { get; set; }
        public string House { get; set; }
        public string Committee { get; set; }
    }
}
