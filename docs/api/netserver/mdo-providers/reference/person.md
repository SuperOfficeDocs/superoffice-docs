---
uid: person
title: person
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "person"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "person" MDO List
List of persons from the Archive provider



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonListProvider">PersonListProvider</see> class.
The name of the MDO list is 'person'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Restrict results to selection memebers.| selection_id|23|





## Sample Request

```http!
GET /api/v1/MDOList/person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("person", forceFlatList: true);
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

* "personheadings"
* "personheadingswithallitem"
* "personheadingswithallitemwithnoselection"
* "personheadingswithnoselection"
* "personwithallitem"
* "personwithallitemwithnoselection"
* "personwithnoselection"
