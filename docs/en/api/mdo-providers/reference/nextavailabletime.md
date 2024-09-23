---
uid: nextavailabletime
title: nextavailabletime
keywords: mdoprovider mdo provider nextavailabletime
description: MDO Provider for identifying available times for meeting.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "nextavailabletime" MDO List
MDO Provider for identifying available times for meeting.

AdditionalInfo = "startTime | endTime | isAllDay 0/1 | assocId, assocIds"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.NextAvailableTime">NextAvailableTime</see> class.
The name of the MDO list is 'nextavailabletime'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Combined start, end, user ids, separated by | char| |2014-9-14 13:45:22|2014-9-14 14:45:22|0|23,34,45|

Separator: |





## Sample Request

```http!
GET /api/v1/MDOList/nextavailabletime
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("nextavailabletime", forceFlatList: true);
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

* "nextavailabletimeheadings"
* "nextavailabletimeheadingswithallitem"
* "nextavailabletimeheadingswithallitemwithnoselection"
* "nextavailabletimeheadingswithnoselection"
* "nextavailabletimewithallitem"
* "nextavailabletimewithallitemwithnoselection"
* "nextavailabletimewithnoselection"
