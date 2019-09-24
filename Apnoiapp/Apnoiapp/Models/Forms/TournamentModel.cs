using System;
using System.Collections.Generic;
using System.Text;

namespace Apnoiapp.Models.Forms
{
    public class TournamentModel
    {
        public int Id_Tournament { get; set; }
        public string EventName { get; set; }
        public string Ubication { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }

    public class CategoryModel
    {
        public int Id_Category { get; set; }
        public string CategoryName { get; set; }
        public string AgeRange { get; set; }
        public List<EventModel> Events { get; set; }
    }

    public class EventModel
    {
        public int Id_Event { get; set; }
        public string EventName { get; set; }
        public CompetitionStyle Style { get; set; }
    }

    public class CompetitionStyle
    {
        public int Id_Style { get; set; }
        public string StyleName { get; set; }
        public string Description { get; set; }
    }
}
