using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Results
{
    public class Login : Success
    {
        public Farmer farmer { get; set; }
        public string token { get; set; }

        public class Farmer
        {
            public int id { get; set; }
            public string login { get; set; }
            public Team team { get; set; }
            public string name { get; set; }
            public int talent { get; set; }
            public Dictionary<string,Leek> leeks { get; set; }
            public DateTime avatar_changed { get; set; }
            public int talent_more { get; set; }
            public int victories { get; set; }
            public int draws { get; set; }
            public int defeats { get; set; }
            public decimal ratio { get; set; }
            public bool connected { get; set; }
            public DateTime last_connection { get; set; }
            public DateTime register_date { get; set; }
            public List<Fight> fight_history { get; set; }
            public List<Tournament_history> tournaments { get; set; }
            public bool admin { get; set; }
            public bool moderator { get; set; }
            public string country { get; set; }
            public Farmer2 godfather { get; set; }
            public List<Farmer2> godsons { get; set; }
            public string color { get; set; }
            public int banned { get; set; }
            public int won_solo_tournaments { get; set; }
            public int won_farmer_tournaments { get; set; }
            public int won_team_tournaments { get; set; }
            public int total_level { get; set; }
            public int leek_count { get; set; }
            public int in_garden { get; set; }
            public int fights { get; set; }
            public string github { get; set; }
            public string website { get; set; }
            public int forum_messages { get; set; }
            public int didactitiel_seen { get; set; }
            public bool contributor { get; set; }
            public int trophies { get; set; }
            public int habs { get; set; }
            public int crystals { get; set; }
            public List<Weapon> weapons { get; set; }
            public List<Chip> chips { get; set; }
            public List<AIS> ais { get; set; }
            public List<Potion> potions { get; set; }
            public List<Hat> hats { get; set; }
            public Tournament tournament { get; set; }


            public class Team
            {
                public int id { get; set; }
                public string name { get; set; }
                public int level { get; set; }
            }

            public class Leek
            {
                public int id { get; set; }
                public string name { get; set; }
                public string color { get; set; }
                public int capital { get; set; }
                public int level { get; set; }
                public int talent { get; set; }
                public int skin { get; set; }
                public int? hat { get; set; }
            }

            public class Fight
            {
                public int id { get; set; }
                public DateTime date { get; set; }
                public int type { get; set; }
                public int context { get; set; }
                public int status { get; set; }
                public int winner { get; set; }
                public int farmer_team { get; set; }
                public string result { get; set; }
                public int farmer1 { get; set; }
                public int farmer2 { get; set; }
                public string farmer1_name { get; set; }
                public string farmer2_name { get; set; }
            }

            public class Tournament_history
            {
                public int id { get; set; }
                public DateTime date { get; set; }
            }

            public class Farmer2
            {
                public int id { get; set; }
                public string name { get; set; }
            }

            public class Weapon
            {
                public int id { get; set; }
                public int template { get; set; }
            }

            public class Chip
            {

            }

            public class AIS
            {
                public int id { get; set; }
                public string name { get; set; }
                public int level { get; set; }
            }

            public class Potion
            {
                public int id { get; set; }
                public int template { get; set; }
                public int quantity { get; set; }
            }

            public class Hat
            {
                
            }

            public class Tournament
            {
                public bool registered { get; set; }
            }
        }
    }


    class SearchResults : Success
    {
        public List<Result> results { get; set; }
        public class Result
        {
            public int id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public int level { get; set; }
            public string image { get; set; }
        }
}

    public class Success
    {
        public bool success { get; set; }
    }
}
