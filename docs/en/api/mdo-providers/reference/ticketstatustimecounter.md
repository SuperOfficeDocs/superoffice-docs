---
uid: ticketstatustimecounter
title: ticketstatustimecounter
keywords: mdoprovider mdo provider ticketstatustimecounter
description: Ticket status timer count values - None, Internall, Externally, Queue
generated: true
content_type: reference
envir: onsite, online
---

# "ticketstatustimecounter" MDO List
Ticket status timer count values: None, Internall, Externally, Queue



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketStatusTimeCounterProvider">TicketStatusTimeCounterProvider</see> class.
The name of the MDO list is 'ticketstatustimecounter'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketstatustimecounter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketstatustimecounter", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_NONE_WITH_CAPITAL_LETTER]||None|
|1|[SR_TICKETSTATUS_TIMECOUNTER_INTERNALLY]||Internally|
|2|[SR_TICKETSTATUS_TIMECOUNTER_EXTERNALLY]||Externally|
|3|[SR_TICKETSTATUS_TIMECOUNTER_QUEUE]||Queue|


## Related MDO Lists

* "ticketstatustimecounterheadings"
* "ticketstatustimecounterheadingswithallitem"
* "ticketstatustimecounterheadingswithallitemwithnoselection"
* "ticketstatustimecounterheadingswithnoselection"
* "ticketstatustimecounterwithallitem"
* "ticketstatustimecounterwithallitemwithnoselection"
* "ticketstatustimecounterwithnoselection"
