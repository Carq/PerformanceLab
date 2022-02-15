namespace PerformanceLab.IsNumber.NET461
{
    public static class StringTestData
    {
        public static readonly string[] ValidStrings = new string[]
                                                            {
                                                                "1",
                                                                "234",
                                                                "23456",
                                                                "456789",
                                                                "0123456789",
                                                                "2147483647",
                                                            };

        public static readonly string[] InvalidStrings = new string[]
                                                          {
                                                                "adas",
                                                                "bgf",
                                                                "23vbnt",
                                                                "vfd123fd56",
                                                                "asdfgt4121321cv",
                                                                "11asdfgt4121321cv",
                                                          };

        public static readonly string[] MixedStrings = new string[]
                                                          {
                                                                 "1",
                                                                 "b",
                                                                "234",
                                                                "1234vF",
                                                                "2147483647",
                                                                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                                                          };
    }
}
