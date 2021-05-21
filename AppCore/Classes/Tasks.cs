using System.Collections.Generic;
using System.Linq;

namespace AppCore.Classes
{
    public class Tasks : List<Task>
    {
        public void Update()
        {
            var sortedOrder = this.OrderBy(i => i.DateDue).ToList();
            Clear();
            AddRange(sortedOrder);
        }
    }
}