using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model
{
    public class Cell
    {
        public int State { get; set; }
        public int Id { get; set; }
        public bool Recrystallized { get; set; }

        public int Energy { get; set; }
        public Cell()
        {
            State = 0;
            Recrystallized = false;
            Energy = 0;
        }

        public void ChangeState()
        {
            State = (State == 0) ? 1 : 0;
        }

        public void ChangeState(int state)
        {
            State = state;
        }

        public void Reset()
        {
            State = 0;
            Recrystallized = false;
            Id = 0;
            Energy = 0;
        }
    }
}
