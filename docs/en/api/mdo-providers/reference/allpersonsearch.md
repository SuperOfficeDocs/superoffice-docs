---
uid: allpersonsearch
title: allpersonsearch
keywords: mdoprovider mdo provider allpersonsearch
description: Provider for selecting a Person, including search on contacts that match as well as persons. This provider will return a mix of contact and person records. The type is indicated in the Type property of the item, and the contact ID is always in the extraInfo. Uses freetext to perform a speedy search on the contact and person tables. Does not include sub-tables, like userdefined fields, text records etc.
generated: true
content_type: reference
envir: onsite, online
---

# "allpersonsearch" MDO List
Provider for selecting a Person, including search on contacts that match as well as persons. This provider will
return a mix of contact and person records. The type is indicated in the Type property of the item, and the contact
ID is always in the extraInfo.
Uses freetext to perform a speedy search on the contact and person tables. Does not include sub-tables, like userdefined fields, text records etc.

Searchs contact and person tables for matches, in addition to the contact
search of the base class "contact" search.


Returns a mix of Persons with Contact and Person without contact items sorted by relevance: own contacts, recently added or updated
are more relevant.


id = person_id,


Name = contact.name + department or person first+last name (contact name + department)


ExtraInfo = contact_id


Type = "Person"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.AllPersonListSearchProvider">AllPersonListSearchProvider</see> class.
The name of the MDO list is 'allpersonsearch'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Skip retired employees| skipRetired|False|
|Boost scores for persons on this contact| contactId|123|





## Sample Request

```http!
GET /api/v1/MDOList/allpersonsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("allpersonsearch", forceFlatList: true);
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
