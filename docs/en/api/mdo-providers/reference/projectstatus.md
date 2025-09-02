---
uid: projectstatus
title: projectstatus
keywords: mdoprovider mdo provider projectstatus
description: List of project guide steps status values.
generated: true
content_type: reference
envir: onsite, online
---

# "projectstatus" MDO List
List of project guide steps status values.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectStatusProvider">ProjectStatusProvider</see> class.
The name of the MDO list is 'projectstatus'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|The project type id.| ProjectTypeId|123|
|Include deleted items| GetDeleted|True|
|Include deleted projects| GetDeletedLinks|True|
|Project types to get project statuses for| ProjectTypeIDs|1,2,3,4|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/projectstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("projectstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|Project planning||IsDeleted=False&ProjectTypeStatusLinkId=1&|
|6|Implementation||IsDeleted=False&ProjectTypeStatusLinkId=2&|
|7|Completion||IsDeleted=False&ProjectTypeStatusLinkId=3&|


## Related MDO Lists

* "projectstatusheadings"
* "projectstatusheadingswithallitem"
* "projectstatusheadingswithallitemwithnoselection"
* "projectstatusheadingswithnoselection"
* "projectstatuswithallitem"
* "projectstatuswithallitemwithnoselection"
* "projectstatuswithnoselection"
