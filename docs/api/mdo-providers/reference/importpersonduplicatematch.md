---
uid: importpersonduplicatematch
title: importpersonduplicatematch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "importpersonduplicatematch" MDO List
Import Person Fields to match on: Name, E-mail, phone, number, id, None



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportPersonDuplicateMatchProvider">ImportPersonDuplicateMatchProvider</see> class.
The name of the MDO list is 'importpersonduplicatematch'.




## Sample Request

```http!
GET /api/v1/MDOList/importpersonduplicatematch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("importpersonduplicatematch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Name:|||
|2|E-mail address|||
|3|Mobile phone|||
|4|Number|||
|5|None - do not import contact|||
|6|ID|||


## Related MDO Lists

* "importpersonduplicatematchheadings"
* "importpersonduplicatematchheadingswithallitem"
* "importpersonduplicatematchheadingswithallitemwithnoselection"
* "importpersonduplicatematchheadingswithnoselection"
* "importpersonduplicatematchwithallitem"
* "importpersonduplicatematchwithallitemwithnoselection"
* "importpersonduplicatematchwithnoselection"
