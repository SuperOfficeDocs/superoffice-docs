---
uid: salestatus
title: salestatus
keywords: mdoprovider mdo provider salestatus
description: List for the Sale.Status field - Open, Lost, Sold, Stalled.
generated: true
content_type: reference
envir: onsite, online
---

# "salestatus" MDO List
List for the Sale.Status field: Open, Lost, Sold, Stalled.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleStatusProvider">SaleStatusProvider</see> class.
The name of the MDO list is 'salestatus'.




## Sample Request

```http!
GET /api/v1/MDOList/salestatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("salestatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_SALE_OPEN]|||
|3|[SR_SALE_LOST]|||
|2|[SR_SALE_SOLD]|||
|4|[SR_SALE_STALLED]|||


## Related MDO Lists

* "salestatusheadings"
* "salestatusheadingswithallitem"
* "salestatusheadingswithallitemwithnoselection"
* "salestatusheadingswithnoselection"
* "salestatuswithallitem"
* "salestatuswithallitemwithnoselection"
* "salestatuswithnoselection"
