---
uid: targettypes
title: targettypes
keywords: mdoprovider mdo provider targettypes
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "targettypes" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TargetTypeProvider">TargetTypeProvider</see> class.
The name of the MDO list is 'targettypes'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|The entity type for which to return target types. (Sale, Project, Selection, etc.)| TargetEntityType||
|Include All item.| IncludeAll|False|
|Include invalid choices (already used for all measure types).| IncludeAll|False|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/targettypes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("targettypes", forceFlatList: true);
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

* "targettypesheadings"
* "targettypesheadingswithallitem"
* "targettypesheadingswithallitemwithnoselection"
* "targettypesheadingswithnoselection"
* "targettypeswithallitem"
* "targettypeswithallitemwithnoselection"
* "targettypeswithnoselection"
