---
uid: appointmentcautionwarning
title: appointmentcautionwarning
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "appointmentcautionwarning"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "appointmentcautionwarning" MDO List
Appointment.CautionWarning. Appointment and invitation synchronization info



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentCautionWarningProvider">AppointmentCautionWarningProvider</see> class.
The name of the MDO list is 'appointmentcautionwarning'.




## Sample Request

```http!
GET /api/v1/MDOList/appointmentcautionwarning
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("appointmentcautionwarning", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|OK|||
|1|Not in sync|||
|2|Not notified by e-mail|||
|3|Repeating pattern not supported|||
|4|This change of the repeating pattern is not supported|||
|5|Date/time mismatch|||


## Related MDO Lists

* "appointmentcautionwarningheadings"
* "appointmentcautionwarningheadingswithallitem"
* "appointmentcautionwarningheadingswithallitemwithnoselection"
* "appointmentcautionwarningheadingswithnoselection"
* "appointmentcautionwarningwithallitem"
* "appointmentcautionwarningwithallitemwithnoselection"
* "appointmentcautionwarningwithnoselection"
