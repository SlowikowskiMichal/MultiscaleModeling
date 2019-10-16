using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model
{
    class Cell
    {
        public int State { get; set; }
        public int Id { get; set; }
        public bool Recrystallized { get; set; }

        public Cell()
        {
            State = 0;
            Recrystallized = false;
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
        }
    }
}
