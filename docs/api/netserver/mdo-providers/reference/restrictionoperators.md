---
uid: restrictionoperators
title: restrictionoperators
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "restrictionoperators"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "restrictionoperators" MDO List
This SoList provider will generate the operator list for a given search criterion data type. The data type is
passed in as the extraInfo parameter, and is generally one of the constants in <see cref="!:SuperOffice.CRM.ArchiveLists.ArchiveListConstants.ColumnTypes" />.
The <see cref="T:SuperOffice.CRM.ArchiveLists.RestrictionOperations" /> class is the source of the data, so this list will change if that class is extended.



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.OperatorProvider">OperatorProvider</see> class.
The name of the MDO list is 'restrictionoperators'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|RestrictionType for which we want the list of supported operators, and their value hints; use the SuperOffice.CRM.ArchiveLists.Constants.RestrictionTypes constant strings| |associate|





## Sample Request

```http!
GET /api/v1/MDOList/restrictionoperators
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("restrictionoperators", forceFlatList: true);
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

* "restrictionoperatorsheadings"
* "restrictionoperatorsheadingswithallitem"
* "restrictionoperatorsheadingswithallitemwithnoselection"
* "restrictionoperatorsheadingswithnoselection"
* "restrictionoperatorswithallitem"
* "restrictionoperatorswithallitemwithnoselection"
* "restrictionoperatorswithnoselection"
