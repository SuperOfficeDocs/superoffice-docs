---
uid: allpersonsearch
title: allpersonsearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "allpersonsearch"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "allpersonsearch" MDO List

Provider for selecting a Person, including search on contacts that match as well as persons. this provider will
return a mix of contact and person records. The type is indicated in the Type property of the item, and the contact
ID is always in the extraInfo.

Searchs contact and person tables for matches, in addition to the contact
search of the base class "contact" search.
<para />
Returns a mix of Persons with Contact and Person without contact items sorted by relevance: own contacts, recently added or updated
are more relevant.
<para />
id = person_id,
<para />
Name = contact.name + department or person first+last name (contact name + department)
<para />
ExtraInfo = contact_id,
<para />
Type = "Person"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.AllPersonListSearchProvider">AllPersonListSearchProvider</see> class.
The name of the MDO list is 'allpersonsearch'.

## Sample Request

```http!
GET /api/v1/MDOList/allpersonsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("allpersonsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |

## Related MDO Lists

* "allpersonsearchheadings"
* "allpersonsearchheadingswithallitem"
* "allpersonsearchheadingswithallitemwithnoselection"
* "allpersonsearchheadingswithnoselection"
* "allpersonsearchwithallitem"
* "allpersonsearchwithallitemwithnoselection"
* "allpersonsearchwithnoselection"
