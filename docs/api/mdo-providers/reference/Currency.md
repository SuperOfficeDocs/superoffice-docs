---
uid: currency
title: currency
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

# "currency" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'currency'.




## Sample Request

```http!
GET /api/v1/MDOList/currency
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("currency", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
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
|19|CLP|||
|20|CNY|||
|21|COP|||


## Related MDO Lists

* "currencyheadings"
* "currencyheadingswithallitem"
* "currencyheadingswithallitemwithnoselection"
* "currencyheadingswithnoselection"
* "currencywithallitem"
* "currencywithallitemwithnoselection"
* "currencywithnoselection"
