using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaManagement
{
    internal class Idea
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Creation_Date { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Title}";
        }
    }
}
