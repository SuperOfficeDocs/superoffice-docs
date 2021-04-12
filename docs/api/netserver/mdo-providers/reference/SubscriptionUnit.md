---
uid: subscriptionunit
title: subscriptionunit
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "subscriptionunit"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "subscriptionunit" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'subscriptionunit'.




## Sample Request

```http!
GET /api/v1/MDOList/subscriptionunit
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("subscriptionunit", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Half year|||
|4|Month|||
|3|Quarter|||
|5|Week|||
|1|Year|||


## Related MDO Lists

* "subscriptionunitheadings"
* "subscriptionunitheadingswithallitem"
* "subscriptionunitheadingswithallitemwithnoselection"
* "subscriptionunitheadingswithnoselection"
* "subscriptionunitwithallitem"
* "subscriptionunitwithallitemwithnoselection"
* "subscriptionunitwithnoselection"
