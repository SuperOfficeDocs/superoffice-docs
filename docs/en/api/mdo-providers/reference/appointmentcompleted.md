---
uid: appointmentcompleted
title: appointmentcompleted
keywords: mdoprovider mdo provider appointmentcompleted
description: Appointment completed statuses - AppointmentStatus.NotStarted, AppointmentStatus.Completed
generated: true
content_type: reference
envir: onsite, online
---

# "appointmentcompleted" MDO List
Appointment completed statuses: AppointmentStatus.NotStarted, AppointmentStatus.Completed



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentCompleted">AppointmentCompleted</see> class.
The name of the MDO list is 'appointmentcompleted'.




## Sample Request

```http!
GET /api/v1/MDOList/appointmentcompleted
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("appointmentcompleted", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|No|||
|3|Yes|||


## Related MDO Lists

* "appointmentcompletedheadings"
* "appointmentcompletedheadingswithallitem"
* "appointmentcompletedheadingswithallitemwithnoselection"
* "appointmentcompletedheadingswithnoselection"
* "appointmentcompletedwithallitem"
* "appointmentcompletedwithallitemwithnoselection"
* "appointmentcompletedwithnoselection"
