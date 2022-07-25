---
uid: personrestrictions
title: personrestrictions
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "personrestrictions"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "personrestrictions" MDO List

Implements a person mdolist provider that uses the conflicts detector to append information on
conflicts

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonListRestrictionsProvider">PersonListRestrictionsProvider</see> class.
The name of the MDO list is 'personrestrictions'.

## Sample Request

```http!
GET /api/v1/MDOList/personrestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("personrestrictions", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3136|Aaron Ophélie Austin|||
|15428|Aaron Black|||
|4783|Aaron Hélèna Bryant|||
|2869|Aaron Marie-noël Carr|||
|14715|Aaron Collins|||
|14719|Aaron Daniels|||
|10794|Aaron Annotés Diaz|||
|10049|Aaron Fields|||
|15713|Aaron Garcia|||
|14740|Aaron Gonzales|||
|14102|Aaron Gonzales|||
|3718|Aaron Séréna Graham|||
|10344|Aaron Mahélie Green|||
|10285|Aaron Hawkins|||
|3826|Aaron Maïlys James|||
|14469|Aaron Johnson|||
|3398|Aaron Johnston|||
|14251|Aaron Lewis|||
|1738|Aaron Faîtes Medina|||
|11707|Aaron Miller|||
|11274|Aaron Moore|||

## Related MDO Lists

* "personrestrictionsheadings"
* "personrestrictionsheadingswithallitem"
* "personrestrictionsheadingswithallitemwithnoselection"
* "personrestrictionsheadingswithnoselection"
* "personrestrictionswithallitem"
* "personrestrictionswithallitemwithnoselection"
* "personrestrictionswithnoselection"
