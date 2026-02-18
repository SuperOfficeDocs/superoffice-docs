---
uid: projectmembereventparticipantstatus
title: projectmembereventparticipantstatus
keywords: mdoprovider mdo provider projectmembereventparticipantstatus
description: List of project member event status fields.
generated: true
content_type: reference
envir: onsite, online
---

# "projectmembereventparticipantstatus" MDO List
List of project member event status fields.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectMemberEventParticipantStatusProvider">ProjectMemberEventParticipantStatusProvider</see> class.
The name of the MDO list is 'projectmembereventparticipantstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/projectmembereventparticipantstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("projectmembereventparticipantstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Not an event|||
|1|Not reacted|||
|2|Declined|||
|3|Registered|||
|4|Attending|||
|5|No-show|||


## Related MDO Lists

* "projectmembereventparticipantstatusheadings"
* "projectmembereventparticipantstatusheadingswithallitem"
* "projectmembereventparticipantstatusheadingswithallitemwithnoselection"
* "projectmembereventparticipantstatusheadingswithnoselection"
* "projectmembereventparticipantstatuswithallitem"
* "projectmembereventparticipantstatuswithallitemwithnoselection"
* "projectmembereventparticipantstatuswithnoselection"
