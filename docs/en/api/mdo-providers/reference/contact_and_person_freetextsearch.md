---
uid: contact_and_person_freetextsearch
title: contact_and_person_freetextsearch
keywords: mdoprovider mdo provider contact_and_person_freetextsearch
description: Provider for selecting a Contact or a Person Does keyword matching and scoring across multiple string fields. Checks name, department, soundex fields. Additional - <list type="bullet"><item>Name = Person or PersonContact or ContactPerson</item><item>AddContact = true or false - add a contact item for person items</item><item>ExpandContact = TRUE or false - add all persons for a contact items</item><item>SkipRetired = TRUE or false - skip retired persons</item><item>ContactId = 123 - boost persons belonging to contact id in results rank</item></list>
generated: true
content_type: reference
envir: onsite, online
---

# "contact_and_person_freetextsearch" MDO List
Provider for selecting a Contact or a Person
Does keyword matching and scoring across multiple
string fields. Checks name, department, soundex fields.


Additional:
<list type="bullet"><item>Name = Person or PersonContact or ContactPerson</item><item>AddContact = true or false - add a contact item for person items</item><item>ExpandContact = TRUE or false - add all persons for a contact items</item><item>SkipRetired = TRUE or false - skip retired persons</item><item>ContactId = 123 - boost persons belonging to contact id in results rank</item></list>

User's own contacts, recently added + modified contacts, contacts modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.


Returns contact or person items: Id = contact_id or person_id, ExtraInfo = "contact_id"=contact_id, Type = "Contact" or "Person", StyleHint = "stop"


Stopped contacts are marked with stylehint = "stop" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContactAndPersonListFreetextSearchProvider">ContactAndPersonListFreetextSearchProvider</see> class.
The name of the MDO list is 'contact_and_person_freetextsearch'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Person, PersonContact, ContactPerson| Name|PersonContact|
|Add Contact items for person matches| AddContact|True|
|Add all persons for a contact match| ExpandContact|True|
|Skip retired employees| skipRetired|False|
|Boost scores on this contact to top| contactId|123|





## Sample Request

```http!
GET /api/v1/MDOList/contact_and_person_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("contact_and_person_freetextsearch", forceFlatList: true);
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

* "contact_and_person_freetextsearchheadings"
* "contact_and_person_freetextsearchheadingswithallitem"
* "contact_and_person_freetextsearchheadingswithallitemwithnoselection"
* "contact_and_person_freetextsearchheadingswithnoselection"
* "contact_and_person_freetextsearchwithallitem"
* "contact_and_person_freetextsearchwithallitemwithnoselection"
* "contact_and_person_freetextsearchwithnoselection"
