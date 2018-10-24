namespace PerformanceLab.IsNumber.NET461
{
    public static class StringTestData
    {
        public static readonly string[] ValidStrings = new string[]
                                                            {
                                                                "1",
                                                                "234",
                                                                "456789",
                                                                "0123456789",
                                                            };

        public static readonly string[] InvalidStrings = new string[]
                                                          {
                                                                "a",
                                                                "bgf",
                                                                "23vbnt",
                                                                "asdfgt4121cv",
                                                          };

        public static readonly string[] MixedStrings = new string[]
                                                          {
                                                                 "1",
                                                                 "b",
                                                                "234",
                                                                "1234vF",
                                                                "45678d9",
                                                                "0123456789",
                                                                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                                                                "0987"
                                                          };
    }
}
