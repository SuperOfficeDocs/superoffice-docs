---
uid: personcontact_freetextsearch
title: personcontact_freetextsearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "personcontact_freetextsearch"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "personcontact_freetextsearch" MDO List

Provider for selecting a Person - with contact search.
Does keyword matching and scoring across multiple
tables using freetext index.
First does BEGINS and CONTAINS searches in parallel.
If neither results in anything, then falls back to SOUNDEX search.

User's own contacts, recently added + modified contacts, contacts modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.
Contacts with lots of activity or lots of recent activity (according to the SAINT counters) are also
preferred.

Returns person items only: Id = ExtraInfo = person_id, Type = "Person", StyleHint = "stop"

Stopped contacts are marked with stylehint = "stop" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonContactListFreetextSearchProvider">PersonContactListFreetextSearchProvider</see> class.
The name of the MDO list is 'personcontact_freetextsearch'.

## Sample Request

```http!
GET /api/v1/MDOList/personcontact_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("personcontact_freetextsearch", forceFlatList: true);
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

* "personcontact_freetextsearchheadings"
* "personcontact_freetextsearchheadingswithallitem"
* "personcontact_freetextsearchheadingswithallitemwithnoselection"
* "personcontact_freetextsearchheadingswithnoselection"
* "personcontact_freetextsearchwithallitem"
* "personcontact_freetextsearchwithallitemwithnoselection"
* "personcontact_freetextsearchwithnoselection"
