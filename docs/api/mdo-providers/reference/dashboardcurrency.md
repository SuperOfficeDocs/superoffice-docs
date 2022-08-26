---
uid: dashboardcurrency
title: dashboardcurrency
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "dashboardcurrency"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "dashboardcurrency" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.CurrencyProvider">CurrencyProvider</see> class.
The name of the MDO list is 'dashboardcurrency'.




## Sample Request

```http!
GET /api/v1/MDOList/dashboardcurrency
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("dashboardcurrency", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|None|||
|-1|Base (NOK)|||
|-2|Own (NOK)|||


## Related MDO Lists

* "dashboardcurrencyheadings"
* "dashboardcurrencyheadingswithallitem"
* "dashboardcurrencyheadingswithallitemwithnoselection"
* "dashboardcurrencyheadingswithnoselection"
* "dashboardcurrencywithallitem"
* "dashboardcurrencywithallitemwithnoselection"
* "dashboardcurrencywithnoselection"
