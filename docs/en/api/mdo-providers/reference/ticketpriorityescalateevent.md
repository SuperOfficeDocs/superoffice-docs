---
uid: ticketpriorityescalateevent
title: ticketpriorityescalateevent
keywords: mdoprovider mdo provider ticketpriorityescalateevent
description: MDO list provider for ticket Priority EscalateEvents enum.
generated: true
content_type: reference
envir: onsite, online
---

# "ticketpriorityescalateevent" MDO List
MDO list provider for ticket Priority EscalateEvents enum.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketPriorityEscalateEventsProvider">TicketPriorityEscalateEventsProvider</see> class.
The name of the MDO list is 'ticketpriorityescalateevent'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include all existing values in the enum| |all|





## Sample Request

```http!
GET /api/v1/MDOList/ticketpriorityescalateevent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketpriorityescalateevent", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Stop||Stop|
|1|Continue||Continue|
|2|Restart||Restart|


## Related MDO Lists

* "ticketpriorityescalateeventheadings"
* "ticketpriorityescalateeventheadingswithallitem"
* "ticketpriorityescalateeventheadingswithallitemwithnoselection"
* "ticketpriorityescalateeventheadingswithnoselection"
* "ticketpriorityescalateeventwithallitem"
* "ticketpriorityescalateeventwithallitemwithnoselection"
* "ticketpriorityescalateeventwithnoselection"
