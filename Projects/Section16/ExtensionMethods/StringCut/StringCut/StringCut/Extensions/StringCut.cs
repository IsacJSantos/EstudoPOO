namespace System
{
    static class StringCut
    {
        public static string Cut(this String thisObj, int count)
        {
            if (thisObj.Length < count)
                return thisObj;
            else
                return thisObj.Substring(0, count) + "...";
        }
    }
}
