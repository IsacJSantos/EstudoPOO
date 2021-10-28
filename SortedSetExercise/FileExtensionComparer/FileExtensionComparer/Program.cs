using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace FileExtensionComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IEnumerable<string> files1 =
                    Directory.EnumerateFiles(@"C:\temp",
                    "*", SearchOption.AllDirectories);

                var mediaFiles1 = new SortedSet<string>(new ByFileExtension());

                foreach (string f in files1)
                {
                    mediaFiles1.Add(f.Substring(f.LastIndexOf(@"\") + 1));
                }

                Console.WriteLine("Remove docs from the set...");
                Console.WriteLine($"\tCount before: {mediaFiles1.Count}");
                mediaFiles1.RemoveWhere(s =>
                {
                    s = s.ToLower();
                    return !(s.EndsWith(".txt") ||
                        s.EndsWith(".xls") ||
                        s.EndsWith(".xlsx") ||
                        s.EndsWith(".pdf") ||
                        s.EndsWith(".docx"));
                });
                Console.WriteLine($"\tCount after: {mediaFiles1.Count}");

                Console.WriteLine();

                Console.WriteLine("List of mediaFiles1: ");
                foreach (string f in mediaFiles1)
                {
                    Console.WriteLine($"\t{f}");
                }

                IEqualityComparer<SortedSet<string>> comparer = SortedSet<string>.CreateSetComparer();

                HashSet<SortedSet<string>> allMedia = new HashSet<SortedSet<string>>(comparer);
                allMedia.Add(mediaFiles1);

            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
            catch (UnauthorizedAccessException AuthEx) 
            {
                Console.WriteLine(AuthEx.Message);
            }
        }
    }

    public class ByFileExtension : IComparer<string>
    {
        string xExt, yExt;
        CaseInsensitiveComparer caseiComp = new CaseInsensitiveComparer();

        public int Compare(string x, string y)
        {
            xExt = x.Substring(x.LastIndexOf(".") + 1);
            yExt = y.Substring(y.LastIndexOf(".") + 1);

            int vExt = caseiComp.Compare(xExt, yExt);

            if (vExt != 0)
                return vExt;
            else
                return caseiComp.Compare(x, y);

        }
    }
}
