---
uid: dashboardcurrency
title: dashboardcurrency
keywords: mdoprovider mdo provider dashboardcurrency
description: 
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("dashboardcurrency", forceFlatList: true);
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
|1|ADF|||
|2|AED|||
|3|AFA|||
|4|ALL|||
|5|ANG|||
|6|ARP|||
|7|ATS|||
|8|AUD|||
|9|BAK|||
|10|BEF|||
|11|BGL|||
|12|BND|||
|13|BOB|||
|14|BRR|||
|15|BSD|||
|16|BYR|||
|17|CAD|||
|18|CHF|||


## Related MDO Lists

* "dashboardcurrencyheadings"
* "dashboardcurrencyheadingswithallitem"
* "dashboardcurrencyheadingswithallitemwithnoselection"
* "dashboardcurrencyheadingswithnoselection"
* "dashboardcurrencywithallitem"
* "dashboardcurrencywithallitemwithnoselection"
* "dashboardcurrencywithnoselection"
