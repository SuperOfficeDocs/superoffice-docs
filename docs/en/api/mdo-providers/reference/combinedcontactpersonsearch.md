---
uid: combinedcontactpersonsearch
title: combinedcontactpersonsearch
keywords: mdoprovider mdo provider combinedcontactpersonsearch
description: Consider using the ContactAndPersonListFreetextSearchProvider/"contact_and_person_freetextsearch" MDO list instead of this one.

Provider for selecting a Person or a Contact, including search on contacts that match as well as persons. this provider will
return a mix of contact and person records. The type is indicated in the Type property of the item, and the contact
ID is always in the extraInfo.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "combinedcontactpersonsearch" MDO List
Consider using the ContactAndPersonListFreetextSearchProvider/"contact_and_person_freetextsearch" MDO list instead of this one.

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
Type = "Person", "Contact"
<para />
IconHint = "Personwithcontact", "contact", "Personwithoutcontact"

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
| 2 | Example | | |


## Related MDO Lists

* "combinedcontactpersonsearchheadings"
* "combinedcontactpersonsearchheadingswithallitem"
* "combinedcontactpersonsearchheadingswithallitemwithnoselection"
* "combinedcontactpersonsearchheadingswithnoselection"
* "combinedcontactpersonsearchwithallitem"
* "combinedcontactpersonsearchwithallitemwithnoselection"
* "combinedcontactpersonsearchwithnoselection"
