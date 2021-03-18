---
uid: systemeventtype
title: systemeventtype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "systemeventtype" MDO List
System event types: NoLogin, NoFreeText, NoTravel, Message-of-the-day



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SystemEventTypeProvider">SystemEventTypeProvider</see> class.
The name of the MDO list is 'systemeventtype'.




## Sample Request

```http!
GET /api/v1/MDOList/systemeventtype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("systemeventtype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|No Login|||
|2|No Freetext|||
|3|No Travel|||
|4|Message of the Day|||


## Related MDO Lists

* "systemeventtypeheadings"
* "systemeventtypeheadingswithallitem"
* "systemeventtypeheadingswithallitemwithnoselection"
* "systemeventtypeheadingswithnoselection"
* "systemeventtypewithallitem"
* "systemeventtypewithallitemwithnoselection"
* "systemeventtypewithnoselection"
