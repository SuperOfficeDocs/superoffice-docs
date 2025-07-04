---
uid: recurrenceweekcycle
title: recurrenceweekcycle
keywords: mdoprovider mdo provider recurrenceweekcycle
description: MDO provider for the hard-coded list of week cycle alternatives in the recurrence dialog.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "recurrenceweekcycle" MDO List
MDO provider for the hard-coded list of week cycle alternatives in the recurrence dialog.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.RecurrenceWeekCycleProvider">RecurrenceWeekCycleProvider</see> class.
The name of the MDO list is 'recurrenceweekcycle'.




## Sample Request

```http!
GET /api/v1/MDOList/recurrenceweekcycle
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("recurrenceweekcycle", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|1|||
|2|2|||
|3|3|||
|4|4|||
|5|5|||
|6|6|||
|7|7|||
|8|8|||
|9|9|||
|10|10|||


## Related MDO Lists

* "recurrenceweekcycleheadings"
* "recurrenceweekcycleheadingswithallitem"
* "recurrenceweekcycleheadingswithallitemwithnoselection"
* "recurrenceweekcycleheadingswithnoselection"
* "recurrenceweekcyclewithallitem"
* "recurrenceweekcyclewithallitemwithnoselection"
* "recurrenceweekcyclewithnoselection"
