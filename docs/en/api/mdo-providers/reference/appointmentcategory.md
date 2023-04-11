---
uid: appointmentcategory
title: appointmentcategory
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "appointmentcategory"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "appointmentcategory" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.AppointmentCategoryListProvider">AppointmentCategoryListProvider</see> class.
The name of the MDO list is 'appointmentcategory'.




## Sample Request

```http!
GET /api/v1/MDOList/appointmentcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("appointmentcategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Appointment|||
|2|Phone|||
|3|Task|||


## Related MDO Lists

* "appointmentcategoryheadings"
* "appointmentcategoryheadingswithallitem"
* "appointmentcategoryheadingswithallitemwithnoselection"
* "appointmentcategoryheadingswithnoselection"
* "appointmentcategorywithallitem"
* "appointmentcategorywithallitemwithnoselection"
* "appointmentcategorywithnoselection"
