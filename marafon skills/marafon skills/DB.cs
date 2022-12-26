using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marafon_skills
{
    public static class Util
    {
        private static MarathonSkillsEntities database;
        public static MarathonSkillsEntities db
        {
             get
                {
                if (database == null)
                    database = new MarathonSkillsEntities();    
                return database;
            }
        }
        
    }
}
