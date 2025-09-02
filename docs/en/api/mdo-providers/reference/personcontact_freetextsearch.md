---
uid: personcontact_freetextsearch
title: personcontact_freetextsearch
keywords: mdoprovider mdo provider personcontact_freetextsearch
description: Provider for selecting a Person - with contact search. Does keyword matching and scoring across multiple tables using freetext index. First does BEGINS and CONTAINS searches in parallel. If neither results in anything, then falls back to SOUNDEX search.
generated: true
content_type: reference
envir: onsite, online
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

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Skip retired employees| skipRetired|False|





## Sample Request

```http!
GET /api/v1/MDOList/personcontact_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("personcontact_freetextsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|9|Admin Adminson (statezerodatabase)||2|
|10|Arne Arnesen (statezerodatabase)||2|
|11|Brede Bredesen (statezerodatabase)||2|
|12|Cato Carlsson (statezerodatabase)||2|
|13|Donald Duck (statezerodatabase)||2|
|14|Erik Eide (statezerodatabase)||2|
|15|Frode Freestad (statezerodatabase)||2|
|16|Geir Grønbeck (statezerodatabase)||2|
|17|Hans Hansen (statezerodatabase)||2|
|18|Ingrid Istad (statezerodatabase)||2|
|147|Adm0 (statezerodatabase)||2|
|148|Adm1 (statezerodatabase)||2|
|149|Adm2 (statezerodatabase)||2|
|150|Adm3 (statezerodatabase)||2|
|151|Adm4 (statezerodatabase)||2|
|152|Adm5 (statezerodatabase)||2|
|153|Sal0 (statezerodatabase)||2|
|154|Sal1 (statezerodatabase)||2|
|155|Sal2 (statezerodatabase)||2|
|156|Sal3 (statezerodatabase)||2|
|157|Sal4 (statezerodatabase)||2|


## Related MDO Lists

* "personcontact_freetextsearchheadings"
* "personcontact_freetextsearchheadingswithallitem"
* "personcontact_freetextsearchheadingswithallitemwithnoselection"
* "personcontact_freetextsearchheadingswithnoselection"
* "personcontact_freetextsearchwithallitem"
* "personcontact_freetextsearchwithallitemwithnoselection"
* "personcontact_freetextsearchwithnoselection"
