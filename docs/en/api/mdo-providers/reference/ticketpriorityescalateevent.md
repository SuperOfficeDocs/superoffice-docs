---
uid: ticketpriorityescalateevent
title: ticketpriorityescalateevent
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ticketpriorityescalateevent"
so.generated: true
so.date: 05.09.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketpriorityescalateevent", forceFlatList: true);
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
