---
uid: appointmentcautionwarning
title: appointmentcautionwarning
keywords: mdoprovider mdo provider appointmentcautionwarning
description: Appointment.CautionWarning. Appointment and invitation synchronization info
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("appointmentcautionwarning", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_APPOINTMENT_CAUTIONWARNING_OK]|||
|1|[SR_APPOINTMENT_CAUTIONWARNING_NOTINSYNC]|||
|2|[SR_APPOINTMENT_CAUTIONWARNING_NOTNOTIFIED]|||
|3|[SR_APPOINTMENT_CAUTIONWARNING_NOTSUPPORTEDPATTERN]|||
|4|[SR_APPOINTMENT_CAUTIONWARNING_RECURRENCECHANGENOTSUPPORTED]|||
|5|[SR_APPOINTMENT_CAUTIONWARNING_DATETIMEMISMATCH]|||


## Related MDO Lists

* "appointmentcautionwarningheadings"
* "appointmentcautionwarningheadingswithallitem"
* "appointmentcautionwarningheadingswithallitemwithnoselection"
* "appointmentcautionwarningheadingswithnoselection"
* "appointmentcautionwarningwithallitem"
* "appointmentcautionwarningwithallitemwithnoselection"
* "appointmentcautionwarningwithnoselection"
