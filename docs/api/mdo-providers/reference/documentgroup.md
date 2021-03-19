---
uid: documentgroup
title: documentgroup
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "documentgroup"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("documentgroup", forceFlatList: true);
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
