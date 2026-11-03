#### [DiGi\.GIS\.Emgu\.CV](DiGi.GIS.Emgu.CV.Overview.md 'DiGi\.GIS\.Emgu\.CV\.Overview')

## DiGi\.GIS\.Emgu\.CV\.Classes Namespace
### Classes

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison'></a>

## OrtoDataComparison Class

Represents a comparison of orthophoto data, containing the date of comparison and associated image comparison groups\.

```csharp
public class OrtoDataComparison : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → OrtoDataComparison

Implements [DiGi\.GIS\.Interfaces\.IGISObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.interfaces.igisobject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.OrtoDataComparison(DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison)'></a>

## OrtoDataComparison\(OrtoDataComparison\) Constructor

Initializes a new instance of the [OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison') class by copying another [OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison') instance\.

```csharp
public OrtoDataComparison(DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison ortoDataComparison);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.OrtoDataComparison(DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison).ortoDataComparison'></a>

`ortoDataComparison` [OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison')

The source comparison object to copy from\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.OrtoDataComparison(System.DateTime,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup_)'></a>

## OrtoDataComparison\(DateTime, IEnumerable\<OrtoImageComparisonGroup\>\) Constructor

Initializes a new instance of the [OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison') class\.

```csharp
public OrtoDataComparison(System.DateTime dateTime, System.Collections.Generic.IEnumerable<DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup> ortoImageComparisonGroups);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.OrtoDataComparison(System.DateTime,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup_).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time when the comparison was performed\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.OrtoDataComparison(System.DateTime,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup_).ortoImageComparisonGroups'></a>

`ortoImageComparisonGroups` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoImageComparisonGroup](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparisonGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of orthophoto image comparison groups\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.OrtoDataComparison(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDataComparison\(JsonObject\) Constructor

Initializes a new instance of the [OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public OrtoDataComparison(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.OrtoDataComparison(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the comparison data\.
### Properties

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.DateTime'></a>

## OrtoDataComparison\.DateTime Property

Gets the date and time when the orthophoto data comparison was performed\.

```csharp
public System.DateTime DateTime { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison.OrtoImageComparisonGroups'></a>

## OrtoDataComparison\.OrtoImageComparisonGroups Property

Gets or sets the collection of orthophoto image comparison groups associated with this data comparison\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup>? OrtoImageComparisonGroups { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoImageComparisonGroup](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparisonGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison'></a>

## OrtoDatasComparison Class

Represents a collection of orthodata comparisons associated with a specific reference, 
providing functionality to manage and retrieve comparison data based on dates\.

```csharp
public class OrtoDatasComparison : DiGi.Core.Classes.GuidObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → OrtoDatasComparison

Implements [DiGi\.GIS\.Interfaces\.IGISObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.interfaces.igisobject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.OrtoDatasComparison(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison)'></a>

## OrtoDatasComparison\(OrtoDatasComparison\) Constructor

Initializes a new instance of the [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') class by copying an existing instance\.

```csharp
public OrtoDatasComparison(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison? ortoDatasComparison);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.OrtoDatasComparison(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison).ortoDatasComparison'></a>

`ortoDatasComparison` [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')

The source [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') instance to copy from\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.OrtoDatasComparison(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison_)'></a>

## OrtoDatasComparison\(string, IEnumerable\<OrtoDataComparison\>\) Constructor

Initializes a new instance of the [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') class\.

```csharp
public OrtoDatasComparison(string? reference, System.Collections.Generic.IEnumerable<DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison>? ortoDataComparisons);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.OrtoDatasComparison(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the comparison data\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.OrtoDatasComparison(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison_).ortoDataComparisons'></a>

`ortoDataComparisons` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of orthodata comparisons to be included in this set\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.OrtoDatasComparison(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDatasComparison\(JsonObject\) Constructor

Initializes a new instance of the [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') class from a JSON object\.

```csharp
public OrtoDatasComparison(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.OrtoDatasComparison(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the instance\.
### Properties

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.OrtoDataComparisons'></a>

## OrtoDatasComparison\.OrtoDataComparisons Property

Gets or sets the collection of orthodata comparisons\. 
The data is internally stored in a sorted dictionary to maintain chronological order\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison>? OrtoDataComparisons { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.Reference'></a>

## OrtoDatasComparison\.Reference Property

Gets the reference identifier associated with these orthodata comparisons\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.GetOrtoDataComparison(System.DateTime)'></a>

## OrtoDatasComparison\.GetOrtoDataComparison\(DateTime\) Method

Retrieves the orthodata comparison corresponding to the specified date, 
or the closest preceding value if an exact match is not found\.

```csharp
public DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison? GetOrtoDataComparison(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.GetOrtoDataComparison(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date used to search for a comparison\.

#### Returns
[OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison')  
The matching [OrtoDataComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDataComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDataComparison') instance, or null if no suitable record exists\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison.GetYears()'></a>

## OrtoDatasComparison\.GetYears\(\) Method

Extracts the unique years from all available orthodata comparisons and returns them as a range\.

```csharp
public DiGi.Core.Classes.Range<int>? GetYears();
```

#### Returns
[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')  
A [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of integers representing the years, or null if the internal data store is null\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile'></a>

## OrtoDatasComparisonFile Class

Represents a storage file for orthophoto data comparison information, providing functionality to persist and retrieve [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison') objects\.

```csharp
public class OrtoDatasComparisonFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison>, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1')[OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.storagefile-1 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\`1') → OrtoDatasComparisonFile

Implements [DiGi\.GIS\.Interfaces\.IGISObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.interfaces.igisobject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.OrtoDatasComparisonFile(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile)'></a>

## OrtoDatasComparisonFile\(OrtoDatasComparisonFile\) Constructor

Initializes a new instance of the [OrtoDatasComparisonFile](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonFile') class by copying an existing instance\.

```csharp
public OrtoDatasComparisonFile(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile? ortoDatasComparisonFile);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.OrtoDatasComparisonFile(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile).ortoDatasComparisonFile'></a>

`ortoDatasComparisonFile` [OrtoDatasComparisonFile](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonFile')

The source storage file to copy from\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.OrtoDatasComparisonFile(string)'></a>

## OrtoDatasComparisonFile\(string\) Constructor

Initializes a new instance of the [OrtoDatasComparisonFile](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonFile') class from the specified file path\.

```csharp
public OrtoDatasComparisonFile(string? path);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.OrtoDatasComparisonFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the storage file\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.OrtoDatasComparisonFile(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDatasComparisonFile\(JsonObject\) Constructor

Initializes a new instance of the [OrtoDatasComparisonFile](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonFile') class from a JSON object\.

```csharp
public OrtoDatasComparisonFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.OrtoDatasComparisonFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the storage file data\.
### Methods

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.GetUniqueReference(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison)'></a>

## OrtoDatasComparisonFile\.GetUniqueReference\(OrtoDatasComparison\) Method

Generates a unique reference for the specified orthophoto data comparison object\.

```csharp
public override DiGi.Core.Classes.UniqueReference? GetUniqueReference(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison? ortoDatasComparison);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.GetUniqueReference(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison).ortoDatasComparison'></a>

`ortoDatasComparison` [OrtoDatasComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparison')

The orthophoto data comparison object to generate a reference for\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') associated with the provided object, or null if the object is null\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.GetUniqueReference(string)'></a>

## OrtoDatasComparisonFile\.GetUniqueReference\(string\) Method

Generates a unique reference based on the provided string identifier for orthophoto data\.

```csharp
public static DiGi.Core.Classes.UniqueReference? GetUniqueReference(string? reference);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonFile.GetUniqueReference(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string reference identifier\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') if the reference is not null; otherwise, null\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions'></a>

## OrtoDatasComparisonOptions Class

Provides options for comparing orthodata, extending the base directory name specifications\.

```csharp
public class OrtoDatasComparisonOptions : DiGi.GIS.Classes.DirectoryNamesOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [DiGi\.GIS\.Classes\.DirectoryNamesOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.directorynamesoptions 'DiGi\.GIS\.Classes\.DirectoryNamesOptions') → OrtoDatasComparisonOptions
### Constructors

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions.OrtoDatasComparisonOptions()'></a>

## OrtoDatasComparisonOptions\(\) Constructor

Initializes a new instance of the [OrtoDatasComparisonOptions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonOptions') class\.

```csharp
public OrtoDatasComparisonOptions();
```

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions.OrtoDatasComparisonOptions(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions)'></a>

## OrtoDatasComparisonOptions\(OrtoDatasComparisonOptions\) Constructor

Initializes a new instance of the [OrtoDatasComparisonOptions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonOptions') class based on an existing [OrtoDatasComparisonOptions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonOptions') instance\.

```csharp
public OrtoDatasComparisonOptions(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions ortoDatasComparisonOptions);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions.OrtoDatasComparisonOptions(DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions).ortoDatasComparisonOptions'></a>

`ortoDatasComparisonOptions` [OrtoDatasComparisonOptions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonOptions')

The source options to copy from\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions.OrtoDatasComparisonOptions(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoDatasComparisonOptions\(JsonObject\) Constructor

Initializes a new instance of the [OrtoDatasComparisonOptions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoDatasComparisonOptions') class from a JSON object\.

```csharp
public OrtoDatasComparisonOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions.OrtoDatasComparisonOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the options data\.
### Properties

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions.OverrideExisting'></a>

## OrtoDatasComparisonOptions\.OverrideExisting Property

Gets or sets a value indicating whether existing values should be overridden\.

```csharp
public bool OverrideExisting { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoDatasComparisonOptions.Years'></a>

## OrtoDatasComparisonOptions\.Years Property

Gets or sets the range of years to be considered during the orthodata comparison process\.

```csharp
public DiGi.Core.Classes.Range<int> Years { get; set; }
```

#### Property Value
[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison'></a>

## OrtoImageComparison Class

Represents the results of a comparison between two ortho\-images, containing various computer vision metrics 
such as color similarity, histogram correlation, and structural indices\.

```csharp
public class OrtoImageComparison : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → OrtoImageComparison

Implements [DiGi\.GIS\.Interfaces\.IGISObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.interfaces.igisobject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison)'></a>

## OrtoImageComparison\(OrtoImageComparison\) Constructor

Initializes a new instance of the [OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison') class by copying an existing instance\.

```csharp
public OrtoImageComparison(DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison ortoImageComparison);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison).ortoImageComparison'></a>

`ortoImageComparison` [OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison')

The source [OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison') instance to copy from\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float)'></a>

## OrtoImageComparison\(DateTime, int, float, float, float, float, float, float, float, float, float, float, float\) Constructor

Initializes a new instance of the [OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison') class with specified comparison metrics\.

```csharp
public OrtoImageComparison(System.DateTime dateTime, int hammingDistace, float colorDistributionShift, float grayHistogramFactor, float averageColorSimilarity, float histogramCorrelation, float shapeComparisonFactor, float structuralSimilarityIndex_AbsoluteDifference, float structuralSimilarityIndex_MatchTemplate, float meanLaplacianFactor, float standardDeviationLaplacianFactor, float opticalFlowAverageMagnitude, float oRBFeatureMatchingFactor);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time when the comparison was performed\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).hammingDistace'></a>

`hammingDistace` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The Hamming distance between matrices based on their average gray masks\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).colorDistributionShift'></a>

`colorDistributionShift` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The Euclidean distance between the mean colors of the two images\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).grayHistogramFactor'></a>

`grayHistogramFactor` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The correlation factor between the grayscale histograms of the two image matrices\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).averageColorSimilarity'></a>

`averageColorSimilarity` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The Euclidean distance between the average colors of the two images\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).histogramCorrelation'></a>

`histogramCorrelation` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The correlation value between the hue histograms of the two images\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).shapeComparisonFactor'></a>

`shapeComparisonFactor` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The sum of absolute differences between the Hu Moments of the primary contours\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).structuralSimilarityIndex_AbsoluteDifference'></a>

`structuralSimilarityIndex_AbsoluteDifference` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The similarity index based on the absolute difference of grayscale representations\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).structuralSimilarityIndex_MatchTemplate'></a>

`structuralSimilarityIndex_MatchTemplate` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The similarity index using template matching with normalized cross\-correlation\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).meanLaplacianFactor'></a>

`meanLaplacianFactor` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The calculated mean factor of the Laplacian\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).standardDeviationLaplacianFactor'></a>

`standardDeviationLaplacianFactor` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The calculated standard deviation factor of the Laplacian\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).opticalFlowAverageMagnitude'></a>

`opticalFlowAverageMagnitude` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The average magnitude of optical flow vectors between two images\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.DateTime,int,float,float,float,float,float,float,float,float,float,float,float).oRBFeatureMatchingFactor'></a>

`oRBFeatureMatchingFactor` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The average distance of the ORB feature matches; a lower value indicates a better match\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoImageComparison\(JsonObject\) Constructor

Initializes a new instance of the [OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public OrtoImageComparison(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OrtoImageComparison(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the comparison data\.
### Properties

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.AverageColorSimilarity'></a>

## OrtoImageComparison\.AverageColorSimilarity Property

Gets the Euclidean distance between the average colors of the two images\.

```csharp
public float AverageColorSimilarity { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.ColorDistributionShift'></a>

## OrtoImageComparison\.ColorDistributionShift Property

Gets the Euclidean distance between the mean colors of the two images\.

```csharp
public float ColorDistributionShift { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.DateTime'></a>

## OrtoImageComparison\.DateTime Property

Gets the date and time when the image comparison was performed\.

```csharp
public System.DateTime DateTime { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.GrayHistogramFactor'></a>

## OrtoImageComparison\.GrayHistogramFactor Property

Gets the correlation factor between the grayscale histograms of the two images\.

```csharp
public float GrayHistogramFactor { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.HammingDistance'></a>

## OrtoImageComparison\.HammingDistance Property

Gets the Hamming distance between matrices based on their average gray masks\.

```csharp
public int HammingDistance { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.HistogramCorrelation'></a>

## OrtoImageComparison\.HistogramCorrelation Property

Gets the correlation value between the hue histograms of the two images\.

```csharp
public float HistogramCorrelation { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.MeanLaplacianFactor'></a>

## OrtoImageComparison\.MeanLaplacianFactor Property

Gets the calculated mean factor of the Laplacian\.

```csharp
public float MeanLaplacianFactor { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.OpticalFlowAverageMagnitude'></a>

## OrtoImageComparison\.OpticalFlowAverageMagnitude Property

Gets the average magnitude of optical flow vectors between two images\.

```csharp
public float OpticalFlowAverageMagnitude { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.ORBFeatureMatchingFactor'></a>

## OrtoImageComparison\.ORBFeatureMatchingFactor Property

Gets the average distance of the ORB feature matches; a lower value indicates a better match\.

```csharp
public float ORBFeatureMatchingFactor { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.ShapeComparisonFactor'></a>

## OrtoImageComparison\.ShapeComparisonFactor Property

Gets the sum of absolute differences between the Hu Moments of the primary contours\.

```csharp
public float ShapeComparisonFactor { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.StandardDeviationLaplacianFactor'></a>

## OrtoImageComparison\.StandardDeviationLaplacianFactor Property

Gets the calculated standard deviation factor of the Laplacian\.

```csharp
public float StandardDeviationLaplacianFactor { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.StructuralSimilarityIndex_AbsoluteDifference'></a>

## OrtoImageComparison\.StructuralSimilarityIndex\_AbsoluteDifference Property

Gets the similarity index based on the absolute difference of grayscale representations\.

```csharp
public float StructuralSimilarityIndex_AbsoluteDifference { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison.StructuralSimilarityIndex_MatchTemplate'></a>

## OrtoImageComparison\.StructuralSimilarityIndex\_MatchTemplate Property

Gets the similarity index using template matching with normalized cross\-correlation\.

```csharp
public float StructuralSimilarityIndex_MatchTemplate { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup'></a>

## OrtoImageComparisonGroup Class

Represents a group of orthophoto image comparisons, typically organized by date and time\.

```csharp
public class OrtoImageComparisonGroup : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → OrtoImageComparisonGroup

Implements [DiGi\.GIS\.Interfaces\.IGISObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.interfaces.igisobject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.OrtoImageComparisonGroup(DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup)'></a>

## OrtoImageComparisonGroup\(OrtoImageComparisonGroup\) Constructor

Initializes a new instance of the [OrtoImageComparisonGroup](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparisonGroup') class by copying an existing group\.

```csharp
public OrtoImageComparisonGroup(DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup? ortoImageComparisonGroup);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.OrtoImageComparisonGroup(DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup).ortoImageComparisonGroup'></a>

`ortoImageComparisonGroup` [OrtoImageComparisonGroup](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparisonGroup')

The source [OrtoImageComparisonGroup](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparisonGroup') to copy from\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.OrtoImageComparisonGroup(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison_)'></a>

## OrtoImageComparisonGroup\(string, IEnumerable\<OrtoImageComparison\>\) Constructor

Initializes a new instance of the [OrtoImageComparisonGroup](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparisonGroup') class\.

```csharp
public OrtoImageComparisonGroup(string? name, System.Collections.Generic.IEnumerable<DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison>? ortoImageComparisons);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.OrtoImageComparisonGroup(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name of the comparison group\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.OrtoImageComparisonGroup(string,System.Collections.Generic.IEnumerable_DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison_).ortoImageComparisons'></a>

`ortoImageComparisons` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of orthophoto image comparisons to be added to the group\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.OrtoImageComparisonGroup(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoImageComparisonGroup\(JsonObject\) Constructor

Initializes a new instance of the [OrtoImageComparisonGroup](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparisonGroup') class from a JSON object\.

```csharp
public OrtoImageComparisonGroup(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.OrtoImageComparisonGroup(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the serialized data for the group\.
### Properties

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.Name'></a>

## OrtoImageComparisonGroup\.Name Property

Gets the name of the orthophoto image comparison group\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.OrtoImageComparisons'></a>

## OrtoImageComparisonGroup\.OrtoImageComparisons Property

Gets or sets the collection of orthophoto image comparisons associated with this group\.
The internal storage ensures that these are sorted by their date and time\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison>? OrtoImageComparisons { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.GetOrtoImageComparison(System.DateTime)'></a>

## OrtoImageComparisonGroup\.GetOrtoImageComparison\(DateTime\) Method

Retrieves the orthophoto image comparison for the specified date and time, 
or the closest preceding entry if an exact match is not found\.

```csharp
public DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison? GetOrtoImageComparison(System.DateTime dateTime);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoImageComparisonGroup.GetOrtoImageComparison(System.DateTime).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The target date and time to search for\.

#### Returns
[OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison')  
The matching [OrtoImageComparison](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoImageComparison 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoImageComparison'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no suitable comparison exists\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions'></a>

## OrtoObstacleFractions Class

The shares of an orthophoto tile hidden by shadow, snow, haze and cloud, each on \[0, 1\]\.

Every pixel is assigned to at most one obstacle, so the four fractions add up to [Total](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.Total 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions\.Total'), which is the `obstacleFraction` argument of [DiGi\.GIS\.Query\.OrtoSheetUsability\(DiGi\.GIS\.Classes\.OrtoSheet,System\.Nullable\{System\.Double\}\)](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.query.ortosheetusability#digi-gis-query-ortosheetusability(digi-gis-classes-ortosheet-system-nullable{system-double}) 'DiGi\.GIS\.Query\.OrtoSheetUsability\(DiGi\.GIS\.Classes\.OrtoSheet,System\.Nullable\{System\.Double\}\)'). [OrtoObstacles\(this OrtoObstacleFractions\)](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Query.OrtoObstacles(thisDiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions) 'DiGi\.GIS\.Emgu\.CV\.Query\.OrtoObstacles\(this DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions\)') turns the fractions into the measured obstacles of [DiGi\.GIS\.Query\.OrtoObstacles\(DiGi\.GIS\.Classes\.OrtoSheet,System\.Nullable\{DiGi\.GIS\.Enums\.OrtoObstacle\}\)](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.query.ortoobstacles#digi-gis-query-ortoobstacles(digi-gis-classes-ortosheet-system-nullable{digi-gis-enums-ortoobstacle}) 'DiGi\.GIS\.Query\.OrtoObstacles\(DiGi\.GIS\.Classes\.OrtoSheet,System\.Nullable\{DiGi\.GIS\.Enums\.OrtoObstacle\}\)').

Build one from an image with [OrtoObstacleFractions\(this byte\[\]\)](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Create.OrtoObstacleFractions(thisbyte[]) 'DiGi\.GIS\.Emgu\.CV\.Create\.OrtoObstacleFractions\(this byte\[\]\)').

```csharp
public class OrtoObstacleFractions : DiGi.Core.Classes.SerializableObject, DiGi.GIS.Interfaces.IGISSerializableObject, DiGi.GIS.Interfaces.IGISObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → OrtoObstacleFractions

Implements [DiGi\.GIS\.Interfaces\.IGISSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.interfaces.igisserializableobject 'DiGi\.GIS\.Interfaces\.IGISSerializableObject'), [DiGi\.GIS\.Interfaces\.IGISObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.interfaces.igisobject 'DiGi\.GIS\.Interfaces\.IGISObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions)'></a>

## OrtoObstacleFractions\(OrtoObstacleFractions\) Constructor

Initializes a new instance of the [OrtoObstacleFractions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions') class as a copy of another instance\.

```csharp
public OrtoObstacleFractions(DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions? ortoObstacleFractions);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions).ortoObstacleFractions'></a>

`ortoObstacleFractions` [OrtoObstacleFractions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions')

The instance to copy\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(double,double,double,double)'></a>

## OrtoObstacleFractions\(double, double, double, double\) Constructor

Initializes a new instance of the [OrtoObstacleFractions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions') class\.

```csharp
public OrtoObstacleFractions(double shadow, double snow, double haze, double cloud);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(double,double,double,double).shadow'></a>

`shadow` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The share of the tile in deep shadow\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(double,double,double,double).snow'></a>

`snow` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The share of the tile covered by snow\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(double,double,double,double).haze'></a>

`haze` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The share of the tile veiled by haze or fog\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(double,double,double,double).cloud'></a>

`cloud` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The share of the tile covered by cloud\.

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(System.Text.Json.Nodes.JsonObject)'></a>

## OrtoObstacleFractions\(JsonObject\) Constructor

Initializes a new instance of the [OrtoObstacleFractions](DiGi.GIS.Emgu.CV.Classes.md#DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions 'DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions') class from its JSON representation\.

```csharp
public OrtoObstacleFractions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.OrtoObstacleFractions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object\.
### Properties

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.Cloud'></a>

## OrtoObstacleFractions\.Cloud Property

Gets the share of the tile covered by cloud\.

```csharp
public double Cloud { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.Haze'></a>

## OrtoObstacleFractions\.Haze Property

Gets the share of the tile veiled by haze or fog\.

```csharp
public double Haze { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.Shadow'></a>

## OrtoObstacleFractions\.Shadow Property

Gets the share of the tile in deep shadow\.

```csharp
public double Shadow { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.Snow'></a>

## OrtoObstacleFractions\.Snow Property

Gets the share of the tile covered by snow\.

```csharp
public double Snow { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions.Total'></a>

## OrtoObstacleFractions\.Total Property

Gets the share of the tile hidden by any obstacle: the sum of the four fractions, which never overlap\.

```csharp
public double Total { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')