---
uid: appointmentresource
title: appointmentresource
keywords: mdoprovider mdo provider appointmentresource
description: 
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "appointmentresource" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentResource">AppointmentResource</see> class.
The name of the MDO list is 'appointmentresource'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Removes resources with conflicts. Requires start and end times for conflict, either explicitly set or from appointment_id.| remove_conflicts|False|
|Conflict datetime start.| |conflict_start|
|Conflict datetime end.| |conflict_end|
|Appointment id used for conflict resolution. Preferentially used to determine conflict start/end.| |appointment_id|





## Sample Request

```http!
GET /api/v1/MDOList/appointmentresource
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("appointmentresource", forceFlatList: true);
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

* "appointmentresourceheadings"
* "appointmentresourceheadingswithallitem"
* "appointmentresourceheadingswithallitemwithnoselection"
* "appointmentresourceheadingswithnoselection"
* "appointmentresourcewithallitem"
* "appointmentresourcewithallitemwithnoselection"
* "appointmentresourcewithnoselection"
