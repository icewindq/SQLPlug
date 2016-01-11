using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLPlug
{
    /// <summary>
    /// This is Just a mockup service
    /// Modify in branch2 1745
    /// </summary>
    public class MockupService
    {
        /// <summary>
        /// The primary id
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }

        public MockupService()
        {
            this.Id = 0;
            this.Name = "";
        }
    }
}
