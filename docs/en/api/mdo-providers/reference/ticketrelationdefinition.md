---
uid: ticketrelationdefinition
title: ticketrelationdefinition
keywords: mdoprovider mdo provider ticketrelationdefinition
description: MDO list provider for ticket relation definitions.
generated: true
content_type: reference
envir: onsite, online
---

# "ticketrelationdefinition" MDO List
MDO list provider for ticket relation definitions.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketRelationDefinitionProvider">TicketRelationDefinitionProvider</see> class.
The name of the MDO list is 'ticketrelationdefinition'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketrelationdefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketrelationdefinition", forceFlatList: true);
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

* "ticketrelationdefinitionheadings"
* "ticketrelationdefinitionheadingswithallitem"
* "ticketrelationdefinitionheadingswithallitemwithnoselection"
* "ticketrelationdefinitionheadingswithnoselection"
* "ticketrelationdefinitionwithallitem"
* "ticketrelationdefinitionwithallitemwithnoselection"
* "ticketrelationdefinitionwithnoselection"
