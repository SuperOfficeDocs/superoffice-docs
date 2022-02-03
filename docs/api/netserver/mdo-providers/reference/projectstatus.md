---
uid: projectstatus
title: projectstatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "projectstatus"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "projectstatus" MDO List
List of project guide steps status values.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectStatusProvider">ProjectStatusProvider</see> class.
The name of the MDO list is 'projectstatus'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Return all pricelists, not just the active ones| ProjectTypeId|123|
|Include deleted items| GetDeleted|True|
|Include deleted projects| GetDeletedLinks|True|

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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("projectstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|Project planning||IsDeleted=False&ProjectTypeStatusLinkId=1|
|6|Implementation||IsDeleted=False&ProjectTypeStatusLinkId=2|
|7|Completion||IsDeleted=False&ProjectTypeStatusLinkId=3|


## Related MDO Lists

* "projectstatusheadings"
* "projectstatusheadingswithallitem"
* "projectstatusheadingswithallitemwithnoselection"
* "projectstatusheadingswithnoselection"
* "projectstatuswithallitem"
* "projectstatuswithallitemwithnoselection"
* "projectstatuswithnoselection"
