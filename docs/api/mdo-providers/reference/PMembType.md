---
uid: pmembtype
title: pmembtype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "pmembtype"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "pmembtype" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'pmembtype'.




## Sample Request

```http!
GET /api/v1/MDOList/pmembtype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("pmembtype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|6|Ekstern kontakt|||
|5|Fagperson|||
|1|Oppdragsgiver|||
|2|Prosjektleder|||
|4|Prosjektmedlem|||
|3|Sekretær|||


## Related MDO Lists

* "pmembtypeheadings"
* "pmembtypeheadingswithallitem"
* "pmembtypeheadingswithallitemwithnoselection"
* "pmembtypeheadingswithnoselection"
* "pmembtypewithallitem"
* "pmembtypewithallitemwithnoselection"
* "pmembtypewithnoselection"
