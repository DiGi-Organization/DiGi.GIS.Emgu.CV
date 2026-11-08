using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Emgu.CV.Classes;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DiGi.GIS.Emgu.CV
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a dictionary of ortho data comparisons for the specified references from files within the given directory.
        /// </summary>
        /// <param name="directory">The path to the directory containing the comparison files.</param>
        /// <param name="references">A collection of reference strings to look up.</param>
        /// <returns>A dictionary where keys are reference strings and values are <see cref="OrtoDatasComparison"/> objects, or <c>null</c> if the directory is invalid or references are null.</returns>
        public static Dictionary<string, OrtoDatasComparison>? OrtoDatasComparisonDictionary(string? directory, IEnumerable<string>? references)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = [];
            foreach (string reference in references)
            {
                UniqueReference? uniqueReference = OrtoDatasComparisonFile.GetUniqueReference(reference);
                if (uniqueReference is null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, OrtoDatasComparison> result = [];

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format(CultureInfo.CurrentCulture, "*.{0}", Constants.FileExtension.OrtoDatasComparisonFile));
            if (paths == null || paths.Length == 0)
            {
                return result;
            }

            foreach (string path in paths)
            {
                using OrtoDatasComparisonFile ortoDatasComparisonFile = new(path);

                List<OrtoDatasComparison?>? ortoDatasComparisonList = ortoDatasComparisonFile.GetValues(uniqueReferences)?.ToList();
                if (ortoDatasComparisonList == null || ortoDatasComparisonList.Count == 0)
                {
                    continue;
                }

                for (int i = ortoDatasComparisonList.Count - 1; i >= 0; i--)
                {
                    if (ortoDatasComparisonList[i] is null)
                    {
                        continue;
                    }

                    UniqueReference uniqueReference = uniqueReferences.ElementAt(i);

                    string? reference = uniqueReference?.UniqueId;

                    if (string.IsNullOrWhiteSpace(reference))
                    {
                        continue;
                    }

                    result[reference!] = ortoDatasComparisonList[i]!;
                    uniqueReferences.Remove(uniqueReference!);

                    if (uniqueReferences.Count == 0)
                    {
                        return result;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a dictionary of ortho data comparisons for the specified buildings from files within the given directory.
        /// </summary>
        /// <param name="directory">The path to the directory containing the comparison files.</param>
        /// <param name="building2Ds">A collection of <see cref="Building2D"/> objects used to derive references.</param>
        /// <returns>A dictionary where keys are <see cref="GuidReference"/> and values are <see cref="OrtoDatasComparison"/> objects, or <c>null</c> if the directory is invalid or building list is null.</returns>
        public static Dictionary<GuidReference, OrtoDatasComparison>? OrtoDatasComparisonDictionary(string? directory, IEnumerable<Building2D>? building2Ds)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || building2Ds == null)
            {
                return null;
            }

            Dictionary<string, GuidReference>? dictionary = [];
            foreach (Building2D building2D in building2Ds)
            {
                string? reference = building2D?.Reference;
                if (reference == null)
                {
                    continue;
                }

                dictionary[reference] = new GuidReference(building2D);
            }

            Dictionary<string, OrtoDatasComparison>? ortoDatasComparisonDictionary = OrtoDatasComparisonDictionary(directory, dictionary.Keys);
            if (ortoDatasComparisonDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatasComparison>? result = [];
            foreach (KeyValuePair<string, GuidReference> keyValuePair in dictionary)
            {
                string reference = keyValuePair.Key;

                if (ortoDatasComparisonDictionary.TryGetValue(reference, out OrtoDatasComparison ortoDatasComparison))
                {
                    result[dictionary[reference]] = ortoDatasComparison;
                }
            }

            return result;
        }
    }
}