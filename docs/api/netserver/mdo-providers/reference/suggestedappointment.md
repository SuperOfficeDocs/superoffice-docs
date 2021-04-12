---
uid: suggestedappointment
title: suggestedappointment
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "suggestedappointment"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "suggestedappointment" MDO List
Suggested Appointment Provider creates a MDO list of suggested appointments for a given guide stage.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SuggestedAppointmentProvider">SuggestedAppointmentProvider</see> class.
The name of the MDO list is 'suggestedappointment'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include deleted records| ShowDeleted|True|
|Suggested appointments for a given stage link| SaleTypeStageLinkId|1234|
|Suggested appointments for a given stage link| ProjectTypeStatusLinkId|4321|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/suggestedappointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("suggestedappointment", forceFlatList: true);
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

* "suggestedappointmentheadings"
* "suggestedappointmentheadingswithallitem"
* "suggestedappointmentheadingswithallitemwithnoselection"
* "suggestedappointmentheadingswithnoselection"
* "suggestedappointmentwithallitem"
* "suggestedappointmentwithallitemwithnoselection"
* "suggestedappointmentwithnoselection"
