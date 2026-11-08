using DiGi.Core.Classes;
using DiGi.Core.IO.Table.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Emgu.CV.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DiGi.GIS.Emgu.CV
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds a range of ortho-data comparison results and associated building year data to the specified table.
        /// </summary>
        /// <param name="table">The <see cref="Table" /> instance where the processed data rows will be added.</param>
        /// <param name="ortoDatasComparisons">A collection of <see cref="OrtoDatasComparison" /> objects containing the image comparison data to process.</param>
        /// <param name="yearBuiltDatas">An optional collection of <see cref="YearBuiltData" /> objects used to associate building years with the references.</param>
        /// <returns>A <see cref="System.Boolean" /> value indicating whether the data was successfully added to the table; returns <c>false</c> if the table or comparisons collection is null.</returns>
        public static bool AddRange(this Table? table, IEnumerable<OrtoDatasComparison>? ortoDatasComparisons, IEnumerable<YearBuiltData>? yearBuiltDatas = null)
        {
            if (ortoDatasComparisons == null || table == null)
            {
                return false;
            }

            HashSet<int> years = [];
            foreach (OrtoDatasComparison ortoDatasComparison in ortoDatasComparisons)
            {
                Range<int>? range_Years_Temp = ortoDatasComparison?.GetYears();
                if (range_Years_Temp == null)
                {
                    continue;
                }

                years.Add(range_Years_Temp.Min);
                years.Add(range_Years_Temp.Max);
            }

            Range<int> range_Years = new(years);

            foreach (OrtoDatasComparison ortoDatasComparison in ortoDatasComparisons)
            {
                for (int i = range_Years.Min; i <= range_Years.Max; i++)
                {
                    DateTime dateTime_1 = new(i, 1, 1);

                    Dictionary<string, object?> dictionary = new()
                    {
                        [nameof(ortoDatasComparison.Reference)] = ortoDatasComparison.Reference,
                        [nameof(dateTime_1.Year)] = i
                    };

                    int? yearBuilt = null;
                    if (yearBuiltDatas != null)
                    {
                        foreach (YearBuiltData yearBuiltData in yearBuiltDatas)
                        {
                            if (ortoDatasComparison.Reference != yearBuiltData?.Reference)
                            {
                                continue;
                            }

                            yearBuilt = yearBuiltData?.GetUserYearBuilt()?.Year;
                            break;
                        }
                    }

                    dictionary["YearBuilt"] = yearBuilt;

                    OrtoDataComparison? ortoDataComparison = ortoDatasComparison.GetOrtoDataComparison(dateTime_1);
                    if (ortoDataComparison == null)
                    {
                        continue;
                    }

                    if (ortoDataComparison.OrtoImageComparisonGroups is not IEnumerable<OrtoImageComparisonGroup> ortoImageComparisonGroups)
                    {
                        continue;
                    }

                    foreach (OrtoImageComparisonGroup ortoImageComparisonGroup in ortoImageComparisonGroups)
                    {
                        string? name = ortoImageComparisonGroup.Name;

                        for (int j = range_Years.Min; j <= range_Years.Max; j++)
                        {
                            DateTime dateTime_2 = new(j, 1, 1);

                            OrtoImageComparison? ortoImageComparison = ortoImageComparisonGroup.GetOrtoImageComparison(dateTime_2);
                            if (ortoImageComparison == null)
                            {
                                continue;
                            }

                            string prefix = string.Format(CultureInfo.CurrentCulture, "{0}_{1}", name, j);

                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.AverageColorSimilarity))] = double.IsNaN(ortoImageComparison.AverageColorSimilarity) ? 0 : ortoImageComparison.AverageColorSimilarity;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.ColorDistributionShift))] = double.IsNaN(ortoImageComparison.ColorDistributionShift) ? 0 : ortoImageComparison.ColorDistributionShift;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.GrayHistogramFactor))] = double.IsNaN(ortoImageComparison.GrayHistogramFactor) ? 0 : ortoImageComparison.GrayHistogramFactor;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.HammingDistance))] = ortoImageComparison.HammingDistance;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.HistogramCorrelation))] = double.IsNaN(ortoImageComparison.HistogramCorrelation) ? 0 : ortoImageComparison.HistogramCorrelation;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.ShapeComparisonFactor))] = double.IsNaN(ortoImageComparison.ShapeComparisonFactor) ? 0 : ortoImageComparison.ShapeComparisonFactor;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.StructuralSimilarityIndex_AbsoluteDifference))] = double.IsNaN(ortoImageComparison.StructuralSimilarityIndex_AbsoluteDifference) ? 0 : ortoImageComparison.StructuralSimilarityIndex_AbsoluteDifference;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.StructuralSimilarityIndex_MatchTemplate))] = double.IsNaN(ortoImageComparison.StructuralSimilarityIndex_MatchTemplate) ? 0 : ortoImageComparison.StructuralSimilarityIndex_MatchTemplate;

                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.MeanLaplacianFactor))] = double.IsNaN(ortoImageComparison.MeanLaplacianFactor) ? 0 : ortoImageComparison.MeanLaplacianFactor;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.StandardDeviationLaplacianFactor))] = double.IsNaN(ortoImageComparison.StandardDeviationLaplacianFactor) ? 0 : ortoImageComparison.StandardDeviationLaplacianFactor;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.OpticalFlowAverageMagnitude))] = double.IsNaN(ortoImageComparison.OpticalFlowAverageMagnitude) ? 0 : ortoImageComparison.OpticalFlowAverageMagnitude;
                            dictionary[string.Format(CultureInfo.CurrentCulture, "{0}_{1}", prefix, nameof(ortoImageComparison.ORBFeatureMatchingFactor))] = double.IsNaN(ortoImageComparison.ORBFeatureMatchingFactor) ? 0 : ortoImageComparison.ORBFeatureMatchingFactor;
                        }
                    }

                    table.AddRow(dictionary);
                }
            }

            return true;
        }
    }
}