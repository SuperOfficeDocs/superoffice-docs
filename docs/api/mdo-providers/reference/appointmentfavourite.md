---
uid: appointmentfavourite
title: appointmentfavourite
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "appointmentfavourite"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "appointmentfavourite" MDO List

MDO list provider for Favourites

Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentFavouriteListProvider">AppointmentFavouriteListProvider</see> class.
The name of the MDO list is 'appointmentfavourite'.

## Sample Request

```http!
GET /api/v1/MDOList/appointmentfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("appointmentfavourite", forceFlatList: true);
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

* "appointmentfavouriteheadings"
* "appointmentfavouriteheadingswithallitem"
* "appointmentfavouriteheadingswithallitemwithnoselection"
* "appointmentfavouriteheadingswithnoselection"
* "appointmentfavouritewithallitem"
* "appointmentfavouritewithallitemwithnoselection"
* "appointmentfavouritewithnoselection"
