---
uid: ticketalert
title: ticketalert
keywords: mdoprovider mdo provider ticketalert
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "ticketalert" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketAlertProvider">TicketAlertProvider</see> class.
The name of the MDO list is 'ticketalert'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketalert
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketalert", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "ticketalertheadings"
* "ticketalertheadingswithallitem"
* "ticketalertheadingswithallitemwithnoselection"
* "ticketalertheadingswithnoselection"
* "ticketalertwithallitem"
* "ticketalertwithallitemwithnoselection"
* "ticketalertwithnoselection"
