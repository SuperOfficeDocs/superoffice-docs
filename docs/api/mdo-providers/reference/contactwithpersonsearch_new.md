---
uid: contactwithpersonsearch_new
title: contactwithpersonsearch_new
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

# "contactwithpersonsearch_new" MDO List
Provider for selecting a Contact, including search on persons that match as well as contacts. this provider will
return a mix of contact and person records. The type is indicated in the Type property of the item, and the contact
ID is always in the extraInfo.

Searchs contact and person tables for matches, in addition to the contact
search of the base class "contact" search.
<para />
Returns a mix of Contact and Person items sorted by relevance: own contacts, recently added or updated
are more relevant.
<para />
id = contact or person_id,
<para />
Name = contact.name + department or person first+last name (contact name + department)
<para />
ExtraInfo = contact_id,
<para />
Type = "Contact" or "Person"
<para />
Stopped contacts are marked with stylehint = "stop" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContactListWithPersonSearchProvider">ContactListWithPersonSearchProvider</see> class.
The name of the MDO list is 'contactwithpersonsearch_new'.




## Sample Request

```http!
GET /api/v1/MDOList/contactwithpersonsearch_new
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("contactwithpersonsearch_new", forceFlatList: true);
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

* "contactwithpersonsearch_newheadings"
* "contactwithpersonsearch_newheadingswithallitem"
* "contactwithpersonsearch_newheadingswithallitemwithnoselection"
* "contactwithpersonsearch_newheadingswithnoselection"
* "contactwithpersonsearch_newwithallitem"
* "contactwithpersonsearch_newwithallitemwithnoselection"
* "contactwithpersonsearch_newwithnoselection"
