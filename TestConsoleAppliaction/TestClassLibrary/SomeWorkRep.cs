using System.Linq;

namespace TestClassLibrary
{
    public static class SomeWorkRep
    {
        public static string ReversedUserData(string userName)
        {
            return new string(userName.Reverse().ToArray());
        }
    }
}
