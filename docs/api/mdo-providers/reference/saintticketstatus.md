---
uid: saintticketstatus
title: saintticketstatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "saintticketstatus"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saintticketstatus", forceFlatList: true);
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
