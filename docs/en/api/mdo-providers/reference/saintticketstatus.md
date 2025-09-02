---
uid: saintticketstatus
title: saintticketstatus
keywords: mdoprovider mdo provider saintticketstatus
description: This SoList provider generates the ticket status list for the Saint criteria. This is a simple, hard-coded list, special for this context
generated: true
content_type: reference
envir: onsite, online
---

# "saintticketstatus" MDO List
This SoList provider generates the ticket status list for the Saint criteria. This is a simple, hard-coded list, special for this context



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.SaintTicketStatusProvider">SaintTicketStatusProvider</see> class.
The name of the MDO list is 'saintticketstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/saintticketstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("saintticketstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|All|||
|1|Open|||


## Related MDO Lists

* "saintticketstatusheadings"
* "saintticketstatusheadingswithallitem"
* "saintticketstatusheadingswithallitemwithnoselection"
* "saintticketstatusheadingswithnoselection"
* "saintticketstatuswithallitem"
* "saintticketstatuswithallitemwithnoselection"
* "saintticketstatuswithnoselection"
