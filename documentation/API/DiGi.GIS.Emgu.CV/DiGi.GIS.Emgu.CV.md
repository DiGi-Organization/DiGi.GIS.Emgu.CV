#### [DiGi\.GIS\.Emgu\.CV](DiGi.GIS.Emgu.CV.Overview.md 'DiGi\.GIS\.Emgu\.CV\.Overview')

## DiGi\.GIS\.Emgu\.CV Namespace
### Classes

<a name='DiGi.GIS.Emgu.CV.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.GIS.Emgu.CV.Convert.ToDiGi_Table(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison_,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_)'></a>

## Convert\.ToDiGi\_Table\(this IEnumerable\<OrtoDatasComparison\>, IEnumerable\<YearBuiltData\>\) Method

Converts a collection of orthodata comparisons and optional year built data into a [DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table')\.

```csharp
public static DiGi.Core.IO.Table.Classes.Table? ToDiGi_Table(this System.Collections.Generic.IEnumerable<DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison>? ortoDatasComparisons, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.YearBuiltData>? yearBuiltDatas=null);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Convert.ToDiGi_Table(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison_,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_).ortoDatasComparisons'></a>

`ortoDatasComparisons` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of orthodata comparison data to convert\.

<a name='DiGi.GIS.Emgu.CV.Convert.ToDiGi_Table(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison_,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_).yearBuiltDatas'></a>

`yearBuiltDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of year built data to include in the table\.

#### Returns
[DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table')  
A [DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table') instance containing the converted data, or `null` if the source orthodata comparisons are null\.

<a name='DiGi.GIS.Emgu.CV.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.GIS.Emgu.CV.Create.Image(thisbyte[])'></a>

## Create\.Image\(this byte\[\]\) Method

Decodes an encoded image \(JPEG, PNG or any format OpenCV reads\) into a three\-channel 8\-bit BGR image; greyscale sources are expanded to three equal channels\.

```csharp
public static Image<Bgr,byte>? Image(this byte[]? bytes);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Create.Image(thisbyte[]).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The encoded image\.

#### Returns
[Emgu\.CV\.Image](https://learn.microsoft.com/en-us/dotnet/api/emgu.cv.image 'Emgu\.CV\.Image')  
The decoded image, or null when the bytes are missing or cannot be decoded\.

<a name='DiGi.GIS.Emgu.CV.Create.Mat(thisDiGi.GIS.Classes.OrtoData)'></a>

## Create\.Mat\(this OrtoData\) Method

Creates an Emgu CV Mat from a specific ortho data object by decoding its byte array\.

```csharp
public static Mat? Mat(this DiGi.GIS.Classes.OrtoData? ortoData);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Create.Mat(thisDiGi.GIS.Classes.OrtoData).ortoData'></a>

`ortoData` [DiGi\.GIS\.Classes\.OrtoData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodata 'DiGi\.GIS\.Classes\.OrtoData')

The ortho data containing the image bytes\.

#### Returns
[Emgu\.CV\.Mat](https://learn.microsoft.com/en-us/dotnet/api/emgu.cv.mat 'Emgu\.CV\.Mat')  
A [Emgu\.CV\.Mat](https://learn.microsoft.com/en-us/dotnet/api/emgu.cv.mat 'Emgu\.CV\.Mat') instance if successful; otherwise, null\.

<a name='DiGi.GIS.Emgu.CV.Create.Mat(thisDiGi.GIS.Classes.OrtoDatas,System.DateTime)'></a>

## Create\.Mat\(this OrtoDatas, DateTime\) Method

Creates an Emgu CV Mat from the ortho data associated with a specific date and time\.

```csharp
public static Mat? Mat(this DiGi.GIS.Classes.OrtoDatas? ortoDatas, System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Create.Mat(thisDiGi.GIS.Classes.OrtoDatas,System.DateTime).ortoDatas'></a>

`ortoDatas` [DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas')

The collection of ortho data\.

<a name='DiGi.GIS.Emgu.CV.Create.Mat(thisDiGi.GIS.Classes.OrtoDatas,System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time for which to retrieve the ortho data\.

#### Returns
[Emgu\.CV\.Mat](https://learn.microsoft.com/en-us/dotnet/api/emgu.cv.mat 'Emgu\.CV\.Mat')  
A [Emgu\.CV\.Mat](https://learn.microsoft.com/en-us/dotnet/api/emgu.cv.mat 'Emgu\.CV\.Mat') instance if successful; otherwise, null\.

<a name='DiGi.GIS.Emgu.CV.Create.OrtoDatasComparison(thisDiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OrtoDatas)'></a>

## Create\.OrtoDatasComparison\(this Building2D, OrtoDatas\) Method

Performs a detailed comparison of orthodata images for a specific building using various image processing metrics\.

```csharp
public static DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison? OrtoDatasComparison(this DiGi.GIS.Classes.Building2D? building2D, DiGi.GIS.Classes.OrtoDatas? ortoDatas);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Create.OrtoDatasComparison(thisDiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OrtoDatas).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') instance providing the geometric context for cropping and masking\.

<a name='DiGi.GIS.Emgu.CV.Create.OrtoDatasComparison(thisDiGi.GIS.Classes.Building2D,DiGi.GIS.Classes.OrtoDatas).ortoDatas'></a>

`ortoDatas` [DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas')

The collection of [DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas') to be compared\.

#### Returns
[OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')  
An [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') object containing the calculated metrics, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the building or orthodata is null, or if required geometry is missing\.

<a name='DiGi.GIS.Emgu.CV.Create.OrtoDatasComparison(thisDiGi.GIS.Classes.Building2D,string,DiGi.Core.Classes.Range_int_)'></a>

## Create\.OrtoDatasComparison\(this Building2D, string, Range\<int\>\) Method

Performs a comparison of orthodata associated with a building within a specified directory and year range\.

```csharp
public static DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison? OrtoDatasComparison(this DiGi.GIS.Classes.Building2D? building2D, string? directory, DiGi.Core.Classes.Range<int>? years);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Create.OrtoDatasComparison(thisDiGi.GIS.Classes.Building2D,string,DiGi.Core.Classes.Range_int_).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') instance to analyze\.

<a name='DiGi.GIS.Emgu.CV.Create.OrtoDatasComparison(thisDiGi.GIS.Classes.Building2D,string,DiGi.Core.Classes.Range_int_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system directory where the orthodata files are stored\.

<a name='DiGi.GIS.Emgu.CV.Create.OrtoDatasComparison(thisDiGi.GIS.Classes.Building2D,string,DiGi.Core.Classes.Range_int_).years'></a>

`years` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of years used to filter the orthodata\.

#### Returns
[OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')  
An [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') object containing the comparison results, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if any input is null, the directory is empty, or no data is found\.

<a name='DiGi.GIS.Emgu.CV.Create.OrtoObstacleFractions(thisbyte[])'></a>

## Create\.OrtoObstacleFractions\(this byte\[\]\) Method

Measures the shares of an encoded orthophoto tile \(JPEG or PNG, RGB or CIR\) hidden by cloud, haze, snow and deep shadow\.

```csharp
public static DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions? OrtoObstacleFractions(this byte[]? bytes);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Create.OrtoObstacleFractions(thisbyte[]).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The encoded image\.

#### Returns
[OrtoObstacleFractions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions')  
The fractions, or null when the bytes are missing or cannot be decoded\.

<a name='DiGi.GIS.Emgu.CV.Create.OrtoObstacleFractions(thisImage_Bgr,byte_)'></a>

## Create\.OrtoObstacleFractions\(this Image\<Bgr,byte\>\) Method

Measures the shares of an orthophoto tile \(RGB or CIR composite\) hidden by cloud, haze, snow and deep shadow, with the thresholds of [OrtoObstacleThreshold](DiGi.GIS.Emgu.CV.Constants.md#DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold 'DiGi\.GIS\.Emgu\.CV\.Constants\.OrtoObstacleThreshold')\.

The tile is cut into blocks of [BlockSize](DiGi.GIS.Emgu.CV.Constants.md#DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.BlockSize 'DiGi\.GIS\.Emgu\.CV\.Constants\.OrtoObstacleThreshold\.BlockSize') pixels (partial blocks at the edges included). A block that is bright, neutral and smooth is cloud; one that is neutral, smooth and of middle brightness is haze. In every other block each pixel is tested on its own: bright and neutral is snow, dark is shadow. A pixel therefore counts towards at most one obstacle.

Smooth neutral surfaces (a large flat roof, a car park) can pass the haze rule and open water passes the shadow rule; the fractions are for relative ranking of samples.

```csharp
public static DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions? OrtoObstacleFractions(this Image<Bgr,byte>? image);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Create.OrtoObstacleFractions(thisImage_Bgr,byte_).image'></a>

`image` [Emgu\.CV\.Image](https://learn.microsoft.com/en-us/dotnet/api/emgu.cv.image 'Emgu\.CV\.Image')

The decoded image\.

#### Returns
[OrtoObstacleFractions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions')  
The fractions, or null when the image is null or empty\.

<a name='DiGi.GIS.Emgu.CV.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GIS.Emgu.CV.Modify.AddRange(thisDiGi.Core.IO.Table.Classes.Table,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison_,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_)'></a>

## Modify\.AddRange\(this Table, IEnumerable\<OrtoDatasComparison\>, IEnumerable\<YearBuiltData\>\) Method

Adds a range of ortho\-data comparison results and associated building year data to the specified table\.

```csharp
public static bool AddRange(this DiGi.Core.IO.Table.Classes.Table? table, System.Collections.Generic.IEnumerable<DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison>? ortoDatasComparisons, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.YearBuiltData>? yearBuiltDatas=null);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Modify.AddRange(thisDiGi.Core.IO.Table.Classes.Table,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison_,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_).table'></a>

`table` [DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The [DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table') instance where the processed data rows will be added\.

<a name='DiGi.GIS.Emgu.CV.Modify.AddRange(thisDiGi.Core.IO.Table.Classes.Table,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison_,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_).ortoDatasComparisons'></a>

`ortoDatasComparisons` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') objects containing the image comparison data to process\.

<a name='DiGi.GIS.Emgu.CV.Modify.AddRange(thisDiGi.Core.IO.Table.Classes.Table,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison_,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_).yearBuiltDatas'></a>

`yearBuiltDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of [DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData') objects used to associate building years with the references\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') value indicating whether the data was successfully added to the table; returns `false` if the table or comparisons collection is null\.

<a name='DiGi.GIS.Emgu.CV.Modify.AddValue(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile,DiGi.GIS.Classes.Building2D,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions)'></a>

## Modify\.AddValue\(this OrtoDatasComparisonFile, Building2D, OrtoDatasComparisonOptions\) Method

Adds a value to the specified [OrtoDatasComparisonFile](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonFile') based on building data and provided options\.

```csharp
public static DiGi.Core.Classes.UniqueReference? AddValue(this DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile? ortoDatasComparisonFile, DiGi.GIS.Classes.Building2D? builidng2D, DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions? ortoDatasComparisonOptions=null);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Modify.AddValue(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile,DiGi.GIS.Classes.Building2D,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions).ortoDatasComparisonFile'></a>

`ortoDatasComparisonFile` [OrtoDatasComparisonFile](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonFile')

The target comparison file where the generated OrtoDatas comparison value will be added\.

<a name='DiGi.GIS.Emgu.CV.Modify.AddValue(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile,DiGi.GIS.Classes.Building2D,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions).builidng2D'></a>

`builidng2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object used as a source for creating the comparison data\.

<a name='DiGi.GIS.Emgu.CV.Modify.AddValue(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile,DiGi.GIS.Classes.Building2D,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions).ortoDatasComparisonOptions'></a>

`ortoDatasComparisonOptions` [OrtoDatasComparisonOptions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonOptions')

Optional settings to configure how the comparison data is generated\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A unique reference of the added value, or null if the input parameters were null or the creation process failed\.

<a name='DiGi.GIS.Emgu.CV.Modify.CalculateOrtoDatasComparisons(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions)'></a>

## Modify\.CalculateOrtoDatasComparisons\(this IEnumerable\<Building2D\>, string, OrtoDatasComparisonOptions\) Method

Calculates comparisons between orthodata and building data, saving the results to a specified file path\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Core.Classes.GuidReference>? CalculateOrtoDatasComparisons(this System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds, string? path, DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions? ortoDatasComparisonOptions);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Modify.CalculateOrtoDatasComparisons(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D buildings to be compared with orthodata\.

<a name='DiGi.GIS.Emgu.CV.Modify.CalculateOrtoDatasComparisons(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The destination file path where the comparison results will be stored\.

<a name='DiGi.GIS.Emgu.CV.Modify.CalculateOrtoDatasComparisons(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions).ortoDatasComparisonOptions'></a>

`ortoDatasComparisonOptions` [OrtoDatasComparisonOptions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonOptions')

Options to configure the comparison process, such as directory handling and whether to override existing data\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
An enumerable of [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') representing the buildings that were processed; returns null if inputs are invalid or no data was processed\.

<a name='DiGi.GIS.Emgu.CV.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.GIS.Emgu.CV.Query.IsOrtoBlank(thisbyte[])'></a>

## Query\.IsOrtoBlank\(this byte\[\]\) Method

Checks whether an encoded orthophoto tile \(JPEG or PNG\) is of one uniform colour, within [Tolerance](DiGi.GIS.Emgu.CV.Constants.md#DiGi.GIS.Emgu.CV.Constants.OrtoBlank.Tolerance 'DiGi\.GIS\.Emgu\.CV\.Constants\.OrtoBlank\.Tolerance')\.

This overload fits `Func<byte[], bool>`, so it can be passed as the `isBlank` argument of [DiGi\.GIS\.Query\.OrtoImageProbesAsync\(System\.Net\.Http\.HttpClient,DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D,System\.String,System\.String,System\.Collections\.Generic\.IEnumerable\{System\.String\},System\.Int32,System\.Func\{System\.Byte\[\],System\.Boolean\},System\.Int32,System\.TimeSpan,System\.Double,System\.Threading\.CancellationToken\)](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.query.ortoimageprobesasync#digi-gis-query-ortoimageprobesasync(system-net-http-httpclient-digi-geometry-planar-classes-boundingbox2d-system-string-system-string-system-collections-generic-ienumerable{system-string}-system-int32-system-func{system-byte[]-system-boolean}-system-int32-system-timespan-system-double-system-threading-cancellationtoken) 'DiGi\.GIS\.Query\.OrtoImageProbesAsync\(System\.Net\.Http\.HttpClient,DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D,System\.String,System\.String,System\.Collections\.Generic\.IEnumerable\{System\.String\},System\.Int32,System\.Func\{System\.Byte\[\],System\.Boolean\},System\.Int32,System\.TimeSpan,System\.Double,System\.Threading\.CancellationToken\)').

```csharp
public static bool IsOrtoBlank(this byte[]? bytes);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Query.IsOrtoBlank(thisbyte[]).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The encoded image\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True when the tile is uniform; false when it has content, or when the bytes are missing or cannot be decoded\.

<a name='DiGi.GIS.Emgu.CV.Query.IsOrtoBlank(thisbyte[],int)'></a>

## Query\.IsOrtoBlank\(this byte\[\], int\) Method

Checks whether an encoded orthophoto tile \(JPEG or PNG\) is of one uniform colour\.

The image is decoded to three channels and sampled on a grid of at most [SampleCount](DiGi.GIS.Emgu.CV.Constants.md#DiGi.GIS.Emgu.CV.Constants.OrtoBlank.SampleCount 'DiGi\.GIS\.Emgu\.CV\.Constants\.OrtoBlank\.SampleCount') positions per axis, always including the last row and column. The tile is uniform when, for every channel, the largest sampled value exceeds the smallest by no more than [tolerance](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Query.IsOrtoBlank(thisbyte[],int).tolerance 'DiGi\.GIS\.Emgu\.CV\.Query\.IsOrtoBlank\(this byte\[\], int\)\.tolerance').

An undecodable payload is not blank: [DiGi\.GIS\.Query\.OrtoImageProbesAsync\(System\.Net\.Http\.HttpClient,DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D,System\.String,System\.String,System\.Collections\.Generic\.IEnumerable\{System\.String\},System\.Int32,System\.Func\{System\.Byte\[\],System\.Boolean\},System\.Int32,System\.TimeSpan,System\.Double,System\.Threading\.CancellationToken\)](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.query.ortoimageprobesasync#digi-gis-query-ortoimageprobesasync(system-net-http-httpclient-digi-geometry-planar-classes-boundingbox2d-system-string-system-string-system-collections-generic-ienumerable{system-string}-system-int32-system-func{system-byte[]-system-boolean}-system-int32-system-timespan-system-double-system-threading-cancellationtoken) 'DiGi\.GIS\.Query\.OrtoImageProbesAsync\(System\.Net\.Http\.HttpClient,DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D,System\.String,System\.String,System\.Collections\.Generic\.IEnumerable\{System\.String\},System\.Int32,System\.Func\{System\.Byte\[\],System\.Boolean\},System\.Int32,System\.TimeSpan,System\.Double,System\.Threading\.CancellationToken\)') tells exceptions apart before it asks this question.

```csharp
public static bool IsOrtoBlank(this byte[]? bytes, int tolerance);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Query.IsOrtoBlank(thisbyte[],int).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The encoded image\.

<a name='DiGi.GIS.Emgu.CV.Query.IsOrtoBlank(thisbyte[],int).tolerance'></a>

`tolerance` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The largest per\-channel spread, on 0–255, that still counts as uniform\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True when the tile is uniform; false when it has content, or when the bytes are missing or cannot be decoded\.

<a name='DiGi.GIS.Emgu.CV.Query.OrtoDatasComparisonDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_)'></a>

## Query\.OrtoDatasComparisonDictionary\(string, IEnumerable\<Building2D\>\) Method

Retrieves a dictionary of ortho data comparisons for the specified buildings from files within the given directory\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Core.Classes.GuidReference,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison>? OrtoDatasComparisonDictionary(string? directory, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Query.OrtoDatasComparisonDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the comparison files\.

<a name='DiGi.GIS.Emgu.CV.Query.OrtoDatasComparisonDictionary(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') objects used to derive references\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary where keys are [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference') and values are [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') objects, or `null` if the directory is invalid or building list is null\.

<a name='DiGi.GIS.Emgu.CV.Query.OrtoDatasComparisonDictionary(string,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.OrtoDatasComparisonDictionary\(string, IEnumerable\<string\>\) Method

Retrieves a dictionary of ortho data comparisons for the specified references from files within the given directory\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison>? OrtoDatasComparisonDictionary(string? directory, System.Collections.Generic.IEnumerable<string>? references);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Query.OrtoDatasComparisonDictionary(string,System.Collections.Generic.IEnumerable_string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory containing the comparison files\.

<a name='DiGi.GIS.Emgu.CV.Query.OrtoDatasComparisonDictionary(string,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings to look up\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary where keys are reference strings and values are [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') objects, or `null` if the directory is invalid or references are null\.

<a name='DiGi.GIS.Emgu.CV.Query.OrtoImageComparisonDictionary(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison,System.DateTime,System.DateTime)'></a>

## Query\.OrtoImageComparisonDictionary\(this OrtoDatasComparison, DateTime, DateTime\) Method

Retrieves a dictionary of ortho\-image comparisons between two specified date times from the provided ortho data comparison set\. 
The method attempts to find matches by first using [dateTime\_1](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Query.OrtoImageComparisonDictionary(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison,System.DateTime,System.DateTime).dateTime_1 'DiGi\.GIS\.Emgu\.CV\.Query\.OrtoImageComparisonDictionary\(this DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison, System\.DateTime, System\.DateTime\)\.dateTime\_1') as the primary data source and [dateTime\_2](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Query.OrtoImageComparisonDictionary(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison,System.DateTime,System.DateTime).dateTime_2 'DiGi\.GIS\.Emgu\.CV\.Query\.OrtoImageComparisonDictionary\(this DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison, System\.DateTime, System\.DateTime\)\.dateTime\_2') as the comparison target; 
if no results are found, it reverses the roles of the two dates\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison>? OrtoImageComparisonDictionary(this DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison? ortoDatasComparison, System.DateTime dateTime_1, System.DateTime dateTime_2);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Query.OrtoImageComparisonDictionary(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison,System.DateTime,System.DateTime).ortoDatasComparison'></a>

`ortoDatasComparison` [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')

The collection of ortho data comparisons to query\.

<a name='DiGi.GIS.Emgu.CV.Query.OrtoImageComparisonDictionary(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison,System.DateTime,System.DateTime).dateTime_1'></a>

`dateTime_1` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The first date time used for the comparison\.

<a name='DiGi.GIS.Emgu.CV.Query.OrtoImageComparisonDictionary(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison,System.DateTime,System.DateTime).dateTime_2'></a>

`dateTime_2` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The second date time used for the comparison\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary where keys are group names and values are the corresponding [OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison') objects, or `null` if [ortoDatasComparison](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Query.OrtoImageComparisonDictionary(thisDiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison,System.DateTime,System.DateTime).ortoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Query\.OrtoImageComparisonDictionary\(this DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison, System\.DateTime, System\.DateTime\)\.ortoDatasComparison') is null\.

<a name='DiGi.GIS.Emgu.CV.Query.OrtoObstacles(thisDiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions)'></a>

## Query\.OrtoObstacles\(this OrtoObstacleFractions\) Method

Gets the obstacles measured on a probed orthophoto tile: each of [DiGi\.GIS\.Enums\.OrtoObstacle\.Shadow](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.shadow 'DiGi\.GIS\.Enums\.OrtoObstacle\.Shadow'), [DiGi\.GIS\.Enums\.OrtoObstacle\.Snow](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.snow 'DiGi\.GIS\.Enums\.OrtoObstacle\.Snow'), [DiGi\.GIS\.Enums\.OrtoObstacle\.Haze](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.haze 'DiGi\.GIS\.Enums\.OrtoObstacle\.Haze') and [DiGi\.GIS\.Enums\.OrtoObstacle\.Cloud](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.cloud 'DiGi\.GIS\.Enums\.OrtoObstacle\.Cloud') whose fraction reaches its threshold in [OrtoObstacleThreshold](DiGi.GIS.Emgu.CV.Constants.md#DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold 'DiGi\.GIS\.Emgu\.CV\.Constants\.OrtoObstacleThreshold')\.

The result is the `measuredOrtoObstacle` argument of [DiGi\.GIS\.Query\.OrtoObstacles\(DiGi\.GIS\.Classes\.OrtoSheet,System\.Nullable\{DiGi\.GIS\.Enums\.OrtoObstacle\}\)](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.query.ortoobstacles#digi-gis-query-ortoobstacles(digi-gis-classes-ortosheet-system-nullable{digi-gis-enums-ortoobstacle}) 'DiGi\.GIS\.Query\.OrtoObstacles\(DiGi\.GIS\.Classes\.OrtoSheet,System\.Nullable\{DiGi\.GIS\.Enums\.OrtoObstacle\}\)'); null passes on as "not probed".

```csharp
public static System.Nullable<DiGi.GIS.Enums.OrtoObstacle> OrtoObstacles(this DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions? ortoObstacleFractions);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Query.OrtoObstacles(thisDiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions).ortoObstacleFractions'></a>

`ortoObstacleFractions` [OrtoObstacleFractions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions')

The fractions measured on the tile\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.Enums\.OrtoObstacle](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle 'DiGi\.GIS\.Enums\.OrtoObstacle')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The measured obstacles \([DiGi\.GIS\.Enums\.OrtoObstacle\.None](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.none 'DiGi\.GIS\.Enums\.OrtoObstacle\.None') when no fraction reaches its threshold\), or null when [ortoObstacleFractions](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Query.OrtoObstacles(thisDiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions).ortoObstacleFractions 'DiGi\.GIS\.Emgu\.CV\.Query\.OrtoObstacles\(this DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions\)\.ortoObstacleFractions') is null\.