---
uid: freetextsearchentity
title: freetextsearchentity
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "freetextsearchentity"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "freetextsearchentity" MDO List
List provider that returns the entities supported by free text search. The extraInfo field contains the
programmatic table name, which can be used as input for the OwnerEntityName restriction of the
<see cref="T:SuperOffice.CRM.ArchiveLists.FreetextCountProvider" />. The ID of each item is the table number
corresponding to the entity, and can also be used as a restriction value.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FreetextSearchEntityProvider">FreetextSearchEntityProvider</see> class.
The name of the MDO list is 'freetextsearchentity'.




## Sample Request

```http!
GET /api/v1/MDOList/freetextsearchentity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("freetextsearchentity", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|Company||contact|
|6|Contact||person|
|11|Project||project|
|9|Follow-up||appointment|
|10|Document||document|
|13|Sale||sale|
|23|Selection||selection|


## Related MDO Lists

* "freetextsearchentityheadings"
* "freetextsearchentityheadingswithallitem"
* "freetextsearchentityheadingswithallitemwithnoselection"
* "freetextsearchentityheadingswithnoselection"
* "freetextsearchentitywithallitem"
* "freetextsearchentitywithallitemwithnoselection"
* "freetextsearchentitywithnoselection"
