namespace smashgg.net.Querys.Querys
{
    public class EventQuerys
    {
        public static string GetStandingsForEvent =>
            "query EventStandings($eventId: ID!, $page: Int!, $perPage: Int!) {\n  event(id: $eventId) {\name\nstandings(query:{\nperPage: $perPage,\npage: $page\n}){\nnodes {\nstanding\nentrant{\nname}}}}}";
    }
}