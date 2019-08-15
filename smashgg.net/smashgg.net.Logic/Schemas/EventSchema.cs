namespace smashgg.net.Logic.Schemas
{
    public static class EventSchema
    {
        public static string BasicEventSchema =>
            "id\nname\nslug\nstate\nstartAt\nnumEntrants\ncheckInBuffer\ncheckInDuration\ncheckInEnabled\nisOnline\nteamNameAllowed\nteamManagementDeadline";
    }
}