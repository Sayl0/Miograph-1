using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miograph
{
    public class AnamnesisDiagnosisModel
    {
        // Properties
        public int Id { get; set; }
        public int PId { get; set; }
        public string Anamnesis { get; set; }
        public string Diagnosis { get; set; }

        // Constructor
        public AnamnesisDiagnosisModel(int id, int pId, string anamnesis, string diagnosis)
        {
            Id = id;
            PId = pId;
            Anamnesis = anamnesis;
            Diagnosis = diagnosis;
        }
    }
}
