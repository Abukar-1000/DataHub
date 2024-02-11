
namespace ClassObjects {
    public class Weight {
        public string imperial { get; set; }
        public string metric { get; set; }

    }

    public class Animal {
        public Weight weight { get; set; }

        public string id { get; set; }
        public string name { get; set; }
        public string temperament { get; set; }
        public string origin { get; set; }
        public string country_codes { get; set; }
        public string country_code { get; set; }
        public string life_span { get; set; }
        public string wikipedia_url { get; set; }
    }


    public class Img {
        public string id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
        public Animal[] breeds { get; set; }

    }

}