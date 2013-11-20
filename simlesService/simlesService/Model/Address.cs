namespace simlesService.Model {
    public class Address {
        public int Id { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public State State { get; set; }

        public string ZipCode { get; set; }

    }

    public enum State {
        AK,

        AZ,

        AR,

        CA,

        CO,

        CT,

        DE,

        FL,

        GA,

        HI,

        ID,

        IL,

        IN,

        IA,

        KS,

        KY,

        LA,

        ME,

        MD,

        MA,

        MI,

        MN,

        MS,

        MO,

        MT,

        NE,

        NV,

        NH,

        NJ,

        NM,

        NY,

        NC,

        ND,

        OH,

        OK,

        OR,

        PA,

        RI,

        SC,

        SD,

        TN,

        TX,

        UT,

        VT,

        VA,

        WA,

        WV,

        WI,

        WY,
    }
}