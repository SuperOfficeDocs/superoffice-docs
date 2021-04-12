---
uid: combinedcontactpersonsearch
title: combinedcontactpersonsearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "combinedcontactpersonsearch"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "combinedcontactpersonsearch" MDO List
Provider for selecting a Person or a Contact, including search on contacts that match as well as persons. this provider will
return a mix of contact and person records. The type is indicated in the Type property of the item, and the contact
ID is always in the extraInfo.

Searchs contact and person tables for matches, in addition to the contact
search of the base class "contact" search.
<para />
Returns a mix of Persons with Contact and Person without contact items sorted by relevance: own contacts, recently added or updated
are more relevant.
<para />
id = contact or person_id,
<para />
Name = contact.name + department or person first+last name (contact name + department)
<para />
ExtraInfo = contact_id,
<para />
Type = "Person"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.CombinedContactPersonSearchProvider">CombinedContactPersonSearchProvider</see> class.
The name of the MDO list is 'combinedcontactpersonsearch'.




## Sample Request

```http!
GET /api/v1/MDOList/combinedcontactpersonsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("combinedcontactpersonsearch", forceFlatList: true);
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

* "combinedcontactpersonsearchheadings"
* "combinedcontactpersonsearchheadingswithallitem"
* "combinedcontactpersonsearchheadingswithallitemwithnoselection"
* "combinedcontactpersonsearchheadingswithnoselection"
* "combinedcontactpersonsearchwithallitem"
* "combinedcontactpersonsearchwithallitemwithnoselection"
* "combinedcontactpersonsearchwithnoselection"
