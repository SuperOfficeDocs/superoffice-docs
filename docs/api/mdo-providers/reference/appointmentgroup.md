---
uid: appointmentgroup
title: appointmentgroup
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "appointmentgroup"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "appointmentgroup" MDO List
Appointment grouping types: TaskType.Appointment, Phone, ToDo



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentGroupProvider">AppointmentGroupProvider</see> class.
The name of the MDO list is 'appointmentgroup'.




## Sample Request

```http!
GET /api/v1/MDOList/appointmentgroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("appointmentgroup", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Appointment|||
|5|Phone|||
|6|Task|||


## Related MDO Lists

* "appointmentgroupheadings"
* "appointmentgroupheadingswithallitem"
* "appointmentgroupheadingswithallitemwithnoselection"
* "appointmentgroupheadingswithnoselection"
* "appointmentgroupwithallitem"
* "appointmentgroupwithallitemwithnoselection"
* "appointmentgroupwithnoselection"
