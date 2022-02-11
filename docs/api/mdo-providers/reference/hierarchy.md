---
uid: hierarchy
title: hierarchy
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "hierarchy"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "hierarchy" MDO List
List provider for the Hierarchy table. Pass the domain using Additional info.
MDO can be nested arbitrary levels deep.
Fullname contains path separated.
returns a list of domains if no domain is specified.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.HierarchyListProvider">HierarchyListProvider</see> class.
The name of the MDO list is 'hierarchy'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Specify type of hierarchy to get| domain|scripts|
|Return fullname rather than just node name| fullname|True|





## Sample Request

```http!
GET /api/v1/MDOList/hierarchy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("hierarchy", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|ExtraTables||Domain|
|2|ScreenDefinitions||Domain|
|3|Scripts||Domain|
|4|Selections||Domain|
|5|ExternalDocuments||Domain|
|6|UserGroups||Domain|
|7|ExternalDocumentRelatedToSpmMessage||Domain|
|8|Dashboards||Domain|


## Related MDO Lists

* "hierarchyheadings"
* "hierarchyheadingswithallitem"
* "hierarchyheadingswithallitemwithnoselection"
* "hierarchyheadingswithnoselection"
* "hierarchywithallitem"
* "hierarchywithallitemwithnoselection"
* "hierarchywithnoselection"
