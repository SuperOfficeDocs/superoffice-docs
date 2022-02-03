---
uid: business
title: business
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "business"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "business" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'business'.




## Sample Request

```http!
GET /api/v1/MDOList/business
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("business", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Advokater|||
|13|Annen|||
|2|Bank/Finans|||
|3|Forsikring|||
|5|Grafisk|||
|9|Grosister|||
|6|Handel|||
|7|Hotell/Restaurant|||
|8|Industri|||
|4|IT / EDB|||
|10|Offentlig|||
|11|Service|||
|12|Transport|||


## Related MDO Lists

* "businessheadings"
* "businessheadingswithallitem"
* "businessheadingswithallitemwithnoselection"
* "businessheadingswithnoselection"
* "businesswithallitem"
* "businesswithallitemwithnoselection"
* "businesswithnoselection"
