using smashgg.net.Logic.Schemas;

namespace smashgg.net.Querys.Querys
{
    public class TournamentQuerys
    {
        // Credit to BrandonCookeDev.
        public static string GetTournamentById => "query TournamentQuery($id: ID!){tournament(id: $id){"+TournamentSchema.BasicTournamentSchema+"}}";
        
        // Credit to BrandonCookeDev.
        public static string GetTournamentBySlug => "query TournamentQuery($slug: String) {tournament(slug: $slug){" + TournamentSchema.BasicTournamentSchema + "}}";
        
        // Credit to BrandonCookeDev.
        public static string GetEventsByTournamentId => "query TournamentEvents($id: ID!){tournament(id: $id){\nevents{\n"+ EventSchema.BasicEventSchema+"}}}";
    }
}