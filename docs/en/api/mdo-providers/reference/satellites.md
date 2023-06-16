---
uid: satellites
title: satellites
keywords: mdoprovider mdo provider satellites
description: SatelliteProvider creates a MDO list of satellites.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "satellites" MDO List
SatelliteProvider creates a MDO list of satellites.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SatellitesProvider">SatellitesProvider</see> class.
The name of the MDO list is 'satellites'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|add a the central satellite to list| addcentral|1|





## Sample Request

```http!
GET /api/v1/MDOList/satellites
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("satellites", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "satellitesheadings"
* "satellitesheadingswithallitem"
* "satellitesheadingswithallitemwithnoselection"
* "satellitesheadingswithnoselection"
* "satelliteswithallitem"
* "satelliteswithallitemwithnoselection"
* "satelliteswithnoselection"
