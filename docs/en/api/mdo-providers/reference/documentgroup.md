---
uid: documentgroup
title: documentgroup
keywords: mdoprovider mdo provider documentgroup
description: Document types - TaskType.Document, Email, Fax, Merge draft, Merge Final.
generated: true
content_type: reference
envir: onsite, online
---

# "documentgroup" MDO List
Document types: TaskType.Document, Email, Fax, Merge draft, Merge Final.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentGroupProvider">DocumentGroupProvider</see> class.
The name of the MDO list is 'documentgroup'.




## Sample Request

```http!
GET /api/v1/MDOList/documentgroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("documentgroup", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|SR_REPORTER_DOCUMENT|||
|3|SR_REPORTER_E_MAIL|||
|4|SR_REPORTER_FAX|||
|7|SR_REPORTER_MAIL_MERGE_DRAFT|||
|8|SR_REPORTER_MAIL_MERGE_DOCUMENT |||


## Related MDO Lists

* "documentgroupheadings"
* "documentgroupheadingswithallitem"
* "documentgroupheadingswithallitemwithnoselection"
* "documentgroupheadingswithnoselection"
* "documentgroupwithallitem"
* "documentgroupwithallitemwithnoselection"
* "documentgroupwithnoselection"
