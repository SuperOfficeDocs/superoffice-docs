---
uid: saintamountclass
title: saintamountclass
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "saintamountclass"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "saintamountclass" MDO List
This SoList provider generates the amount class list for the Saint criteria. This list is an extension of the basic
AmountClass MDO list, with the addition of an ALL choice with ID 0.



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.SaintAmountClassProvider">SaintAmountClassProvider</see> class.
The name of the MDO list is 'saintamountclass'.




## Sample Request

```http!
GET /api/v1/MDOList/saintamountclass
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saintamountclass", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|All|||
|4|Extra large|||
|3|Large|||
|2|Medium|||
|1|Small|||


## Related MDO Lists

* "saintamountclassheadings"
* "saintamountclassheadingswithallitem"
* "saintamountclassheadingswithallitemwithnoselection"
* "saintamountclassheadingswithnoselection"
* "saintamountclasswithallitem"
* "saintamountclasswithallitemwithnoselection"
* "saintamountclasswithnoselection"
