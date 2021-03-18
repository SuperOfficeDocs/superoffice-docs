---
uid: reason
title: reason
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

# "reason" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'reason'.




## Sample Request

```http!
GET /api/v1/MDOList/reason
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("reason", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|7|Annet|||
|4|Budsjett kutt|||
|5|Forhold til kunde|||
|6|Politikk internt|||
|1|Pris|||
|2|Produkt|||
|3|Service nivå|||


## Related MDO Lists

* "reasonheadings"
* "reasonheadingswithallitem"
* "reasonheadingswithallitemwithnoselection"
* "reasonheadingswithnoselection"
* "reasonwithallitem"
* "reasonwithallitemwithnoselection"
* "reasonwithnoselection"
