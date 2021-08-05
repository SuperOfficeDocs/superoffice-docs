---
uid: contactperson_freetextsearch
title: contactperson_freetextsearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "contactperson_freetextsearch"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "contactperson_freetextsearch" MDO List

Provider for selecting a Contact - with person search.
Does keyword matching and scoring across multiple
string fields. Checks name, department, soundex fields.

User's own contacts, recently added + modified contacts, contacts modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.
Contacts with lots of activity or lots of recent activity (according to the SAINT counters) are also
preferred.

Returns contact items only: Id = ExtraInfo = contact_id, Type = "Contact", StyleHint = "stop"

Stopped contacts are marked with stylehint = "stop" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContactPersonListFreetextSearchProvider">ContactPersonListFreetextSearchProvider</see> class.
The name of the MDO list is 'contactperson_freetextsearch'.

## Sample Request

```http!
GET /api/v1/MDOList/contactperson_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("contactperson_freetextsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|statezerodatabase||2|
|3|Amadeus AS, AAvdeling||3|
|4|Arne'S Kebab, AAvdeling||4|
|5|Bjørge AS, BAvdeling||5|
|6|Bever Inc, BAvdeling||6|
|7|Colina AS, CAvdeling||7|
|8|Chevrolet Norge AS, CAvdeling||8|
|9|Delta Produkter AS, DAvdeling||9|
|10|Dansukker AS, DAvdeling||10|
|11|Endorfin Import AS, EAvdeling||11|
|12|Elan Hoppski, EAvdeling||12|
|13|Fritz & Frantz Import, FAvdeling||13|
|14|Familien AS, FAvdeling||14|
|15|Galliano Liquer, GAvdeling||15|
|16|Golf-Import A/S, GAvdeling||16|
|17|Hotel Lord Nelson, HAvdeling||17|
|18|Hard Core Imports Inc., HAvdeling||18|
|19|Indian Carpets AS, IAvdeling||19|
|20|Illinoise Market Fare INC, IAvdeling||20|
|21|Jensen Madrasser, JAvdeling||21|
|22|Juul & Hansen AS, JAvdeling||22|

## Related MDO Lists

* "contactperson_freetextsearchheadings"
* "contactperson_freetextsearchheadingswithallitem"
* "contactperson_freetextsearchheadingswithallitemwithnoselection"
* "contactperson_freetextsearchheadingswithnoselection"
* "contactperson_freetextsearchwithallitem"
* "contactperson_freetextsearchwithallitemwithnoselection"
* "contactperson_freetextsearchwithnoselection"
