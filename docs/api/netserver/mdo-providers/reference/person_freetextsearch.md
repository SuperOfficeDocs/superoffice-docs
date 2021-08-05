---
uid: person_freetextsearch
title: person_freetextsearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "person_freetextsearch"
so.generated: true
so.date: 03.19.2021
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

id = person_id,

Name = contact.name + department or person first+last name (contact name + department)

ExtraInfo = contact_id,

IconHint = Personwithcontact or Personwithoutcontact

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
|19|Arne Arnesen||3|
|20|Arnt Arntsen||3|
|21|Arnhild Arvestad||4|
|22|Arjan Abelsen||4|
|23|Britt Bærum||6|
|24|Bente Båstad||6|
|25|Bjørn Bjørnsen||5|
|26|Bjørge Bastesen||5|
|27|Carl-Oskar Cederström||8|
|28|Cidrik Culien||8|
|29|Cecilie Carlsen||7|

## Related MDO Lists

* "person_freetextsearchheadings"
* "person_freetextsearchheadingswithallitem"
* "person_freetextsearchheadingswithallitemwithnoselection"
* "person_freetextsearchheadingswithnoselection"
* "person_freetextsearchwithallitem"
* "person_freetextsearchwithallitemwithnoselection"
* "person_freetextsearchwithnoselection"
