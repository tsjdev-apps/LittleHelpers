# LittleHelpers

Collection of helpful methods/functions for nearly every C# project.

## Download

This package is available on NuGet as `LittleHelpersSharp`:
[![Nuget](https://img.shields.io/nuget/v/LittleHelpersSharp)](https://www.nuget.org/packages/LittleHelpersSharp/)

## Compatible with

- .NET Core
- .NET Framework 4.5+
- Mono 4.6
- Xamarin
- Universal Windows Platform (UWP)
- Windows 8+
- Windows Phone 8.1


## Features

### Extension Methods

- `DateTimeExtensions`
    - `ToUnixTimeStamp`
- `EnumerableExtensions`
    - `PickRandom`
    - `Shuffle`    
    - `HasItems`
    - `IsEmpty`
    - `IsNullOrEmpty`
    - `ToObservableCollection`
    - `ForEach`
    - `AddRange`
- `ExceptionExtensions`
    - `LogDebug`
- `ObjectExtensions`
    - `IsNotNull`
    - `IsNull`
    - `AsString`
- `StringExtensions`
    - `IsNeitherNullNorEmpty`
    - `IsNullOrEmpty`

### Helpers

- `EnumHelper`
    - `GetEnumDefault`
    - `GetEnumAsEnumarable`

### Services

- `HttpService`
    - `GetRequestAsync`
