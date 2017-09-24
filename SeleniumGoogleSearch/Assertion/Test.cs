using NUnit.Framework;


namespace SeleniumGoogleSearch.Assertion
{
    public static class Test
    {
        public static void Perform(string expected, string actual)
        {
            StringAssert.Contains(expected, actual, "The result list should contains {expected}, but presents {actual}");
        }
    }
}
