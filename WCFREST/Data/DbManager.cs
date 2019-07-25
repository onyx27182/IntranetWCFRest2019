using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WCFREST.Data
{
    public class DbManager
    {

        public static List<PeoplePOCO> GetPeople()
        {

            List <PeoplePOCO> people = new List<PeoplePOCO>();
            {
                using (DB_125405_joeEntities context = new DB_125405_joeEntities())
                {
                    foreach (var peopleObj in context.people)
                    {

                        PeoplePOCO idea = new PeoplePOCO { FirstName = peopleObj.FirstName, Id = peopleObj.Id };
                        people.Add(idea);
                    }
                }

            }
            return people;
        }

        public static List<IdeaPOCO> GetIdeas()
        {
            List<IdeaPOCO> ideas = new List<IdeaPOCO>();
            using (DB_125405_joeEntities context = new DB_125405_joeEntities())
            {

                foreach(var ideaObj in context.Ideas)
                {
     
                    IdeaPOCO idea = new IdeaPOCO {  Text = ideaObj.Text, Id=ideaObj.Id };
                    ideas.Add(idea);
                }

            }
            ideas.Reverse();
            return ideas;
        }

        public static string SaveIdea(string text)
        {

            string err = null;
            try
            {
                using (DB_125405_joeEntities context = new DB_125405_joeEntities())
                {
                    var existingIdea = context.Ideas.Where(x => x.Text.Trim().Replace(" ", "").ToUpper().Trim() ==
                                                            text.Trim().Replace(" ", "").ToUpper().Trim()).FirstOrDefault();
                    if (existingIdea != null)
                    {
                        throw new Exception("idea already exists ");
                    }
                    Idea idea = new Idea { Text = text };
                    context.Ideas.Add(idea);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                err = ex.Message;
                if(  (ex.InnerException != null ) && (!string.IsNullOrEmpty(ex.InnerException.Message)))
                {
                    err += ex.InnerException.Message;
                }
            }
            return err;
        }
    }
}