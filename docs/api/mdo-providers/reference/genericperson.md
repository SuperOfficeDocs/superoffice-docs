---
uid: genericperson
title: genericperson
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "genericperson" MDO List
List of persons with mail. Supports Selection(any type), project and associate.
Uses an inner provider <see cref="T:SuperOffice.CRM.Lists.PersonListGenericContactProjectProvider" />.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericPersonListProvider">GenericPersonListProvider</see> class.
The name of the MDO list is 'genericperson'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|User-group (-2 for all groups)| associategroup_id|12|
|Persons in the given selection| selection_id|12|
|Members of the given project| project_id|12|

Separator: ;





## Sample Request

```http!
GET /api/v1/MDOList/genericperson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("genericperson", forceFlatList: true);
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

* "genericpersonheadings"
* "genericpersonheadingswithallitem"
* "genericpersonheadingswithallitemwithnoselection"
* "genericpersonheadingswithnoselection"
* "genericpersonwithallitem"
* "genericpersonwithallitemwithnoselection"
* "genericpersonwithnoselection"
