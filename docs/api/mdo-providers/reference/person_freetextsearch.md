---
uid: person_freetextsearch
title: person_freetextsearch
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

# "person_freetextsearch" MDO List
Provider for selecting a Person - without contact search.
Does keyword matching and scoring across multiple
tables using freetext index.

User's own contacts, recently added + modified contacts, contacts modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.
<para />
id = person_id,
<para />
Name = contact.name + department or person first+last name (contact name + department)
<para />
ExtraInfo = contact_id,
<para />
IconHint = Personwithcontact or Personwithoutcontact
<para />
Type = "Person"
Stopped contacts are marked with stylehint = "stop" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonListFreetextSearchProvider">PersonListFreetextSearchProvider</see> class.
The name of the MDO list is 'person_freetextsearch'.




## Sample Request

```http!
GET /api/v1/MDOList/person_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("person_freetextsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|9|Admin Adminson||2|
|10|Arne Arnesen||2|
|11|Brede Bredesen||2|
|12|Cato Carlsson||2|
|13|Donald Duck||2|
|14|Erik Eide||2|
|15|Frode Freestad||2|
|16|Geir Grønbeck||2|
|17|Hans Hansen||2|
|18|Ingrid Istad||2|
|147|Adm0||2|
|148|Adm1||2|
|149|Adm2||2|
|150|Adm3||2|
|151|Adm4||2|
|152|Adm5||2|
|153|Sal0||2|
|154|Sal1||2|
|155|Sal2||2|
|156|Sal3||2|
|157|Sal4||2|


## Related MDO Lists

* "person_freetextsearchheadings"
* "person_freetextsearchheadingswithallitem"
* "person_freetextsearchheadingswithallitemwithnoselection"
* "person_freetextsearchheadingswithnoselection"
* "person_freetextsearchwithallitem"
* "person_freetextsearchwithallitemwithnoselection"
* "person_freetextsearchwithnoselection"
