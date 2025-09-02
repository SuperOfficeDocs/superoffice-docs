---
uid: ticketfavourite
title: ticketfavourite
keywords: mdoprovider mdo provider ticketfavourite
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "ticketfavourite" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketFavouriteListProvider">TicketFavouriteListProvider</see> class.
The name of the MDO list is 'ticketfavourite'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Indicates how to format item name| nameformat|includePersonAndCompany|





## Sample Request

```http!
GET /api/v1/MDOList/ticketfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketfavourite", forceFlatList: true);
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

* "ticketfavouriteheadings"
* "ticketfavouriteheadingswithallitem"
* "ticketfavouriteheadingswithallitemwithnoselection"
* "ticketfavouriteheadingswithnoselection"
* "ticketfavouritewithallitem"
* "ticketfavouritewithallitemwithnoselection"
* "ticketfavouritewithnoselection"
