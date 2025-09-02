---
uid: direction
title: direction
keywords: mdoprovider mdo provider direction
description: Document and Task directions - TaskDirection.Incoming, Outgoing
generated: true
content_type: reference
envir: onsite, online
---

# "direction" MDO List
Document and Task directions: TaskDirection.Incoming, Outgoing



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DirectionProvider">DirectionProvider</see> class.
The name of the MDO list is 'direction'.




## Sample Request

```http!
GET /api/v1/MDOList/direction
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("direction", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Incoming|||
|2|Outgoing|||


## Related MDO Lists

* "directionheadings"
* "directionheadingswithallitem"
* "directionheadingswithallitemwithnoselection"
* "directionheadingswithnoselection"
* "directionwithallitem"
* "directionwithallitemwithnoselection"
* "directionwithnoselection"
