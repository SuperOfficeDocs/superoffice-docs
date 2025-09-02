---
uid: prefdescline
title: prefdescline
keywords: mdoprovider mdo provider prefdescline
description: PrefDesc creates a MDO list of prefdesclines for a given prefdesc id.
generated: true
content_type: reference
envir: onsite, online
---

# "prefdescline" MDO List
PrefDesc creates a MDO list of prefdesclines for a given prefdesc id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PrefDescLineProvider">PrefDescLineProvider</see> class.
The name of the MDO list is 'prefdescline'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Pref desc id (required)| |123|





## Sample Request

```http!
GET /api/v1/MDOList/prefdescline
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("prefdescline", forceFlatList: true);
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

* "prefdesclineheadings"
* "prefdesclineheadingswithallitem"
* "prefdesclineheadingswithallitemwithnoselection"
* "prefdesclineheadingswithnoselection"
* "prefdesclinewithallitem"
* "prefdesclinewithallitemwithnoselection"
* "prefdesclinewithnoselection"
