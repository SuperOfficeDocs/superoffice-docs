---
uid: appointmenttype
title: appointmenttype
keywords: mdoprovider mdo provider appointmenttype
description: List of AppointmentType values - inDiary, inChecklist, Note, Document, SavedReport, BookingForDiary, BookingForChecklist
generated: true
content_type: reference
envir: onsite, online
---

# "appointmenttype" MDO List
List of AppointmentType values: inDiary, inChecklist, Note, Document, SavedReport, BookingForDiary, BookingForChecklist



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentTypeProvider">AppointmentTypeProvider</see> class.
The name of the MDO list is 'appointmenttype'.




## Sample Request

```http!
GET /api/v1/MDOList/appointmenttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("appointmenttype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Has start time|||
|2|Has no start time|||
|3|Note|||
|4|Document|||
|5|Saved Report|||
|6|Booking has start time|||
|7|Booking has no start time|||


## Related MDO Lists

* "appointmenttypeheadings"
* "appointmenttypeheadingswithallitem"
* "appointmenttypeheadingswithallitemwithnoselection"
* "appointmenttypeheadingswithnoselection"
* "appointmenttypewithallitem"
* "appointmenttypewithallitemwithnoselection"
* "appointmenttypewithnoselection"
