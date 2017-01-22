using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace web.modules
{
    public class linq_poc
    {
        public Array result;

        private TVL_DBDataContext db = new TVL_DBDataContext();

        static void Main()
        {
            
        }

        public void processStringQuery()
        {
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
            ArrayList temp = new ArrayList();

            var shortWords = from word in words
                             where word.Length <= 5
                             select word;

            foreach (var word in shortWords)
            {
                temp.Add(word);
            }

            result = temp.ToArray();
        }

        public IQueryable<Person> getPeople()
        {
            IQueryable<Person> people = from p in db.Persons
                                         select p;

            return people;
        }
    }
}