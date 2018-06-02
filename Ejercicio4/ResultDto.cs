using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class ResultDto
    {
        private bool hasDuplicates;
        private long steps;

        public bool HasDuplicate()
        {
            return hasDuplicates;
        }

        public void SetHasDuplicates(bool hasDuplicates)
        {
            this.hasDuplicates = hasDuplicates;
        }

        public long GetSteps()
        {
            return steps;
        }

        public void SetSteps(long steps)
        {
            this.steps = steps;
        }
    }
}
