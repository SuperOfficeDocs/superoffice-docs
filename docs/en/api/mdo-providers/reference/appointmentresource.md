---
uid: appointmentresource
title: appointmentresource
keywords: mdoprovider mdo provider appointmentresource
description: 
generated: true
content_type: reference
envir: onsite, online
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
|Conflict datetimes are in UTC time.| |conflict_utc|
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("appointmentresource", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|41|ResourceItem 1: No heading||associate_id=41&location=False|
|42|ResourceItem 2: No heading||associate_id=42&location=False|
|43|ResourceItem 3: No heading||associate_id=43&location=False|
|44|ResourceItem 4: Heading 1||associate_id=44&location=False|
|45|ResourceItem 5: Heading 1||associate_id=45&location=False|
|46|ResourceItem 6: Heading 1||associate_id=46&location=False|
|47|ResourceItem 7: Heading 2||associate_id=47&location=False|
|48|ResourceItem 8: Heading 2||associate_id=48&location=False|
|49|ResourceItem 9: Heading 2||associate_id=49&location=False|
|79|ResourceItem 12: Heading 1 og 3||associate_id=79&location=False|
|80|ResourceItem 13: Heading 2 og 3||associate_id=80&location=False|


## Related MDO Lists

* "appointmentresourceheadings"
* "appointmentresourceheadingswithallitem"
* "appointmentresourceheadingswithallitemwithnoselection"
* "appointmentresourceheadingswithnoselection"
* "appointmentresourcewithallitem"
* "appointmentresourcewithallitemwithnoselection"
* "appointmentresourcewithnoselection"
