---
uid: location
title: location
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "location"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "location" MDO List
Implements the mdo provider for the list of avaiable locations. This list aggregates elements
from different sources like contact, person, associate, participants and resources to build
a list that represents all the relevant, available locations that can be used when creating
a new appointment.

The provider uses a set of name/value pairs in the additionalinfo parameter used in the construct()
function. The available names are:

ownercontactid (mandatory):     id of the contact for the owner of the appointment
currentassociate (mandatory):   currently logged in associate
appointmentcontactid:           id of the contact in the appointment
appointmentpersonid:            id of the person in the appointment
appointmentid:                  id of existing appointment
startdate:                      startdate used for conflict resolution
enddate:                        enddate used for conflict resolution
participantpersonidlist:        comma separated list of existing participant person ids
participantassociateidlist:     comma separated list of existing participant associate ids(resources)



Implemented by the <see cref="T:SuperOffice.CRM.Lists.LocationListProvider">LocationListProvider</see> class.
The name of the MDO list is 'location'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Mandatory: id of the contact for the owner of the appointment.| ownercontactid|2|
|Mandatory: id of the currently logged in associate.| currentassociate|2|
|id of the contact in the appointment.| appointmentcontactid|2|
|id of the person in the appointment.| appointmentpersonid|2|
|id of existing appointment.| appointmentid|2|
|startdate used for conflict resolution.| startdate|2|
|enddate used for conflict resolution.| enddate|2|
|comma separated list of existing participant person ids| participantpersonidlist|2,34|
|comma separated list of existing participant associate ids(resources)| participantassociateidlist|2|

Separator: ;





## Sample Request

```http!
GET /api/v1/MDOList/location
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("location", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|(No Selection)||[SR_NO_SELECTION]|


## Related MDO Lists

* "locationheadings"
* "locationheadingswithallitem"
* "locationheadingswithallitemwithnoselection"
* "locationheadingswithnoselection"
* "locationwithallitem"
* "locationwithallitemwithnoselection"
* "locationwithnoselection"
