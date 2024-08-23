---
uid: ticketpriority
title: ticketpriority
keywords: mdoprovider mdo provider ticketpriority
description: MDO list provider for ticket priorities.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "ticketpriority" MDO List
MDO list provider for ticket priorities.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketPriorityListProvider">TicketPriorityListProvider</see> class.
The name of the MDO list is 'ticketpriority'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include deleted items| |showDeleted|
|Flag to include default values (e.g., 'Automatic')| |includeDefaultItems|
|ticketType| |1|





## Sample Request

```http!
GET /api/v1/MDOList/ticketpriority
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketpriority", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Low||1|
|2|Medium||2|
|3|High||3|


## Related MDO Lists

* "ticketpriorityheadings"
* "ticketpriorityheadingswithallitem"
* "ticketpriorityheadingswithallitemwithnoselection"
* "ticketpriorityheadingswithnoselection"
* "ticketprioritywithallitem"
* "ticketprioritywithallitemwithnoselection"
* "ticketprioritywithnoselection"
