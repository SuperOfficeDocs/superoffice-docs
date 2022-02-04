---
uid: appointmenttask
title: appointmenttask
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "appointmenttask"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "appointmenttask" MDO List
MDO list provider for the task list of the AppointmentDialog. This list extends the basic <see cref="T:SuperOffice.CRM.Rows.TaskRow" /> with
specialized icons based on the <see cref="T:SuperOffice.Data.TaskType" />.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentTaskProvider">AppointmentTaskProvider</see> class.
The name of the MDO list is 'appointmenttask'.




## Sample Request

```http!
GET /api/v1/MDOList/appointmenttask
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("appointmenttask", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|12|Annet||freebusy=0;allday=0;ispublished=0|
|7|Besøk||freebusy=0;allday=0;ispublished=0|
|14|Kampanje||freebusy=0;allday=0;ispublished=0|
|8|Lunsj||freebusy=0;allday=0;ispublished=0|
|13|Messe||freebusy=0;allday=0;ispublished=0|
|1|Møte inne||freebusy=0;allday=0;ispublished=0|
|2|Møte ute||freebusy=0;allday=0;ispublished=0|
|5|Oppfølging||freebusy=0;allday=0;ispublished=0|
|6|Planlegging||freebusy=0;allday=0;ispublished=0|
|11|Privat||freebusy=0;allday=0;ispublished=0|
|10|Service||freebusy=0;allday=0;ispublished=0|
|4|Telefon inn||freebusy=0;allday=0;ispublished=0|
|3|Telefon ut||freebusy=0;allday=0;ispublished=0|
|9|Tilbud||freebusy=0;allday=0;ispublished=0|

