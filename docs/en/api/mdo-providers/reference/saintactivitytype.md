---
uid: saintactivitytype
title: saintactivitytype
keywords: mdoprovider mdo provider saintactivitytype
description: This SoList provider generates the appointment/task type list for the Saint criteria. This is a simple, hard-coded list corresponding to the type field of the <see cref="!:SuperOffice.CRM.Rows.DocTmpl" /> and <see cref="!:SuperOffice.CRM.Rows.Task" /> tables. Tasks are both appointments and documents.
generated: true
content_type: reference
envir: onsite, online
---

# "saintactivitytype" MDO List
This SoList provider generates the appointment/task type list for the Saint criteria. This is a simple, hard-coded list corresponding
to the type field of the <see cref="!:SuperOffice.CRM.Rows.DocTmpl" /> and <see cref="!:SuperOffice.CRM.Rows.Task" /> tables. Tasks are both
appointments and documents.



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.SaintActivityTypeProvider">SaintActivityTypeProvider</see> class.
The name of the MDO list is 'saintactivitytype'.




## Sample Request

```http!
GET /api/v1/MDOList/saintactivitytype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("saintactivitytype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|[SR_ACTIVITY_TYPE_ALL]|||
|1|[SR_SINGULAR_ACTIVITY]|||
|5|[SR_ACTIVITY_PHONE]|||
|6|[SR_ACTIVITY_TODO]|||
|2|[SR_SINGULAR_DOCUMENT]|||
|4|[SR_ACTIVITY_FAX]|||
|3|[SR_SINGULAR_MAIL]|||
|8|[SR_ACTIVITY_MAILMERGE]|||


## Related MDO Lists

* "saintactivitytypeheadings"
* "saintactivitytypeheadingswithallitem"
* "saintactivitytypeheadingswithallitemwithnoselection"
* "saintactivitytypeheadingswithnoselection"
* "saintactivitytypewithallitem"
* "saintactivitytypewithallitemwithnoselection"
* "saintactivitytypewithnoselection"
