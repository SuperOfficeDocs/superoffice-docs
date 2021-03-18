---
uid: time
title: time
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

# "time" MDO List
MDO provider for the hard-coded list of time alternatives in the appointment dialog and in edit/preferences

The type field contains seconds past midnight for the items' hour/minute value; extrainfo contains hh:mm
(always 2 + 2 digits and colon, regardless of culture); and name/tooltip contain a time value encoded
with CultureDataFormatter.<see cref="M:SuperOffice.CRM.Globalization.CultureDataFormatter.EncodeTime(System.DateTime)" />.




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TimeListProvider">TimeListProvider</see> class.
The name of the MDO list is 'time'.




## Sample Request

```http!
GET /api/v1/MDOList/time
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("time", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|12:00 AM||00:00|
|900|12:15 AM||00:15|
|1800|12:30 AM||00:30|
|2700|12:45 AM||00:45|
|3600|1:00 AM||01:00|
|4500|1:15 AM||01:15|
|5400|1:30 AM||01:30|
|6300|1:45 AM||01:45|
|7200|2:00 AM||02:00|
|8100|2:15 AM||02:15|
|9000|2:30 AM||02:30|
|9900|2:45 AM||02:45|
|10800|3:00 AM||03:00|
|11700|3:15 AM||03:15|
|12600|3:30 AM||03:30|
|13500|3:45 AM||03:45|
|14400|4:00 AM||04:00|
|15300|4:15 AM||04:15|
|16200|4:30 AM||04:30|
|17100|4:45 AM||04:45|
|18000|5:00 AM||05:00|


## Related MDO Lists

* "timeheadings"
* "timeheadingswithallitem"
* "timeheadingswithallitemwithnoselection"
* "timeheadingswithnoselection"
* "timewithallitem"
* "timewithallitemwithnoselection"
* "timewithnoselection"
