#### [DiGi\.GIS\.Emgu\.CV](DiGi.GIS.Emgu.CV.Overview.md 'DiGi\.GIS\.Emgu\.CV\.Overview')

## DiGi\.GIS\.Emgu\.CV\.Constants Namespace
### Classes

<a name='DiGi.GIS.Emgu.CV.Constants.FileExtension'></a>

## FileExtension Class

Provides a collection of constant strings representing supported file extensions\.

```csharp
public static class FileExtension
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → FileExtension
### Fields

<a name='DiGi.GIS.Emgu.CV.Constants.FileExtension.OrtoDatasComparisonFile'></a>

## FileExtension\.OrtoDatasComparisonFile Field

The file extension for Orto Datas Comparison files\.

```csharp
public const string OrtoDatasComparisonFile = "odcf";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoBlank'></a>

## OrtoBlank Class

Provides the parameters of the uniform\-colour \(blank\) check on orthophoto tiles \([IsOrtoBlank\(this byte\[\]\)](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Query.IsOrtoBlank(thisbyte[]) 'DiGi\.GIS\.Emgu\.CV\.Query\.IsOrtoBlank\(this byte\[\]\)')\)\.

```csharp
public static class OrtoBlank
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → OrtoBlank
### Fields

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoBlank.SampleCount'></a>

## OrtoBlank\.SampleCount Field

The number of sample positions along each axis of the tile; the sampled grid is at most [SampleCount](DiGi.GIS.Emgu.CV.Constants.md#DiGi.GIS.Emgu.CV.Constants.OrtoBlank.SampleCount 'DiGi\.GIS\.Emgu\.CV\.Constants\.OrtoBlank\.SampleCount') × [SampleCount](DiGi.GIS.Emgu.CV.Constants.md#DiGi.GIS.Emgu.CV.Constants.OrtoBlank.SampleCount 'DiGi\.GIS\.Emgu\.CV\.Constants\.OrtoBlank\.SampleCount') pixels\.

```csharp
public const int SampleCount = 64;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoBlank.Tolerance'></a>

## OrtoBlank\.Tolerance Field

The largest spread \(maximum minus minimum, per channel, on 0–255\) of the sampled pixels for which a tile still counts as one uniform colour\.

The blank tile the GUGiK WMS answers outside its coverage or scale range decodes as exactly uniform white, so the tolerance only has to absorb JPEG ringing; real imagery spreads far wider.

```csharp
public const int Tolerance = 8;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold'></a>

## OrtoObstacleThreshold Class

Provides the thresholds of the shadow, snow, haze and cloud heuristics on orthophoto tiles \([OrtoObstacleFractions\(this byte\[\]\)](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Create.OrtoObstacleFractions(thisbyte[]) 'DiGi\.GIS\.Emgu\.CV\.Create\.OrtoObstacleFractions\(this byte\[\]\)'), [OrtoObstacles\(this OrtoObstacleFractions\)](DiGi.GIS.Emgu.CV.md#DiGi.GIS.Emgu.CV.Query.OrtoObstacles(thisDiGi.GIS.Emgu.CV.Classes.OrtoObstacleFractions) 'DiGi\.GIS\.Emgu\.CV\.Query\.OrtoObstacles\(this DiGi\.GIS\.Emgu\.CV\.Classes\.OrtoObstacleFractions\)')\)\.

Brightness is the mean of the three channels and saturation is (max − min) / max of a pixel, so the rules read an RGB composite and a CIR composite (NIR, red, green) alike: snow and cloud are bright and neutral in every band, deep shadow is dark in every band. The values are heuristics for relative sample selection, not radiometric claims.

```csharp
public static class OrtoObstacleThreshold
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → OrtoObstacleThreshold
### Fields

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.BlockSize'></a>

## OrtoObstacleThreshold\.BlockSize Field

The edge, in pixels, of the square blocks on which texture \(brightness standard deviation\) is measured for the cloud and haze rules\.

```csharp
public const int BlockSize = 16;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.CloudBrightnessMin'></a>

## OrtoObstacleThreshold\.CloudBrightnessMin Field

The smallest block mean brightness \(0–255\) of a cloud block\.

```csharp
public const double CloudBrightnessMin = 200;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.CloudFraction'></a>

## OrtoObstacleThreshold\.CloudFraction Field

The cloud fraction from which [DiGi\.GIS\.Enums\.OrtoObstacle\.Cloud](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.cloud 'DiGi\.GIS\.Enums\.OrtoObstacle\.Cloud') is reported\.

```csharp
public const double CloudFraction = 0.05;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.CloudSaturationMax'></a>

## OrtoObstacleThreshold\.CloudSaturationMax Field

The largest block mean saturation \(0–1\) of a cloud block\.

```csharp
public const double CloudSaturationMax = 0.15;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.CloudTextureMax'></a>

## OrtoObstacleThreshold\.CloudTextureMax Field

The largest block brightness standard deviation \(0–255\) of a cloud block: cloud is bright and smooth, whereas snow on the ground keeps the texture of what it covers\.

```csharp
public const double CloudTextureMax = 6;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.HazeBrightnessMin'></a>

## OrtoObstacleThreshold\.HazeBrightnessMin Field

The smallest block mean brightness \(0–255\) of a haze block; darker smooth blocks are left to the shadow rule\.

```csharp
public const double HazeBrightnessMin = 110;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.HazeFraction'></a>

## OrtoObstacleThreshold\.HazeFraction Field

The haze fraction from which [DiGi\.GIS\.Enums\.OrtoObstacle\.Haze](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.haze 'DiGi\.GIS\.Enums\.OrtoObstacle\.Haze') is reported\.

```csharp
public const double HazeFraction = 0.25;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.HazeSaturationMax'></a>

## OrtoObstacleThreshold\.HazeSaturationMax Field

The largest block mean saturation \(0–1\) of a haze block\.

```csharp
public const double HazeSaturationMax = 0.2;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.HazeTextureMax'></a>

## OrtoObstacleThreshold\.HazeTextureMax Field

The largest block brightness standard deviation \(0–255\) of a haze block: haze is a washed\-out, low\-contrast veil\.

```csharp
public const double HazeTextureMax = 5;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.ShadowBrightnessMax'></a>

## OrtoObstacleThreshold\.ShadowBrightnessMax Field

The largest brightness \(0–255\) of a deep\-shadow pixel\. Dark water passes this rule too; the heuristic does not tell the two apart\.

```csharp
public const double ShadowBrightnessMax = 40;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.ShadowFraction'></a>

## OrtoObstacleThreshold\.ShadowFraction Field

The shadow fraction from which [DiGi\.GIS\.Enums\.OrtoObstacle\.Shadow](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.shadow 'DiGi\.GIS\.Enums\.OrtoObstacle\.Shadow') is reported\. Building shadows are normal on any tile, so the bar is high\.

```csharp
public const double ShadowFraction = 0.25;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.SnowBrightnessMin'></a>

## OrtoObstacleThreshold\.SnowBrightnessMin Field

The smallest brightness \(0–255\) of a snow pixel\.

```csharp
public const double SnowBrightnessMin = 210;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.SnowFraction'></a>

## OrtoObstacleThreshold\.SnowFraction Field

The snow fraction from which [DiGi\.GIS\.Enums\.OrtoObstacle\.Snow](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.ortoobstacle.snow 'DiGi\.GIS\.Enums\.OrtoObstacle\.Snow') is reported\.

```csharp
public const double SnowFraction = 0.1;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.Emgu.CV.Constants.OrtoObstacleThreshold.SnowSaturationMax'></a>

## OrtoObstacleThreshold\.SnowSaturationMax Field

The largest saturation \(0–1\) of a snow pixel\.

```csharp
public const double SnowSaturationMax = 0.1;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')