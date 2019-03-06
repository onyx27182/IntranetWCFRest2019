using System;
using System.Collections.Generic;
using System.Linq;
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

                foreach(var ideaObj in context.Ideas )
                {
     
                    IdeaPOCO idea = new IdeaPOCO {  IdeaText = ideaObj.Text};
                    if( ideaObj.person != null )
                    {
                        idea.Name = ideaObj.person.FirstName;
                        idea.NameId = ideaObj.FK_People_Id;
                    }
                    ideas.Add(idea);
                }

            }
           return ideas;
        }

        public static void SaveIdea(string text, int personId)
        {
            using (DB_125405_joeEntities context = new DB_125405_joeEntities())
            {
                Idea idea = new Idea { Text = text };
                if ( personId != -1)
                {
                    idea.FK_People_Id = personId;
                }

                context.Ideas.Add(idea);
                context.SaveChanges();
            }
        }
    }
}