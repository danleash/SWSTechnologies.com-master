using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWSTechnologies1.Models
{
    public class TestimonyViewModel
    {
        public TestimonyViewModel()
        {
            TestimonyModels = new List<TestimonyModel>();
            TestimonyModel = new TestimonyModel();
        }
        public IEnumerable<TestimonyModel> TestimonyModels { get; set; }
        public TestimonyModel TestimonyModel { get; set; }
    }
}
