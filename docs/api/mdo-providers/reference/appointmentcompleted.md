---
uid: appointmentcompleted
title: appointmentcompleted
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("appointmentcompleted", forceFlatList: true);
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
