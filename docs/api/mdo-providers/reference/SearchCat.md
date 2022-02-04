---
uid: searchcat
title: searchcat
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "searchcat"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "searchcat" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'searchcat'.




## Sample Request

```http!
GET /api/v1/MDOList/searchcat
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("searchcat", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|4|Faste utsendelser|||
|1|Kampanje|||
|2|Konsernliste|||
|3|Private adresseliste|||


## Related MDO Lists

* "searchcatheadings"
* "searchcatheadingswithallitem"
* "searchcatheadingswithallitemwithnoselection"
* "searchcatheadingswithnoselection"
* "searchcatwithallitem"
* "searchcatwithallitemwithnoselection"
* "searchcatwithnoselection"
