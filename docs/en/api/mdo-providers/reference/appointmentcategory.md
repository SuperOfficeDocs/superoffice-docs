---
uid: appointmentcategory
title: appointmentcategory
keywords: mdoprovider mdo provider appointmentcategory
description: 
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("appointmentcategory", forceFlatList: true);
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
