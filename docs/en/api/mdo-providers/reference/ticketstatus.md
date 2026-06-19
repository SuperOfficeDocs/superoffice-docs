---
uid: ticketstatus
title: ticketstatus
keywords: mdoprovider mdo provider ticketstatus
description: Ticket status values - Open, Closed, Inactive, Deleted, Connected and Spam (if enabled).
generated: true
content_type: reference
envir: onsite, online
---

# "ticketstatus" MDO List
Ticket status values: Open, Closed, Inactive, Deleted, Connected and Spam (if enabled).



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketStatusProvider">TicketStatusProvider</see> class.
The name of the MDO list is 'ticketstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_TICKETARCHIVE_STATUS_OPEN]||Active|
|2|[SR_TICKETARCHIVE_STATUS_CLOSED]||Closed|
|3|[SR_TICKETARCHIVE_STATUS_INACTIVE]||Postponed|
|4|[SR_TICKETARCHIVE_STATUS_DELETED]||Deleted|
|5|[SR_TICKETARCHIVE_STATUS_CONNECTED]||Merged|


## Related MDO Lists

* "ticketstatusheadings"
* "ticketstatusheadingswithallitem"
* "ticketstatusheadingswithallitemwithnoselection"
* "ticketstatusheadingswithnoselection"
* "ticketstatuswithallitem"
* "ticketstatuswithallitemwithnoselection"
* "ticketstatuswithnoselection"
