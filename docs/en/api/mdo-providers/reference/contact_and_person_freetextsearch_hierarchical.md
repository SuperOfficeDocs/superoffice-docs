---
uid: contact_and_person_freetextsearch_hierarchical
title: contact_and_person_freetextsearch_hierarchical
keywords: mdoprovider mdo provider contact_and_person_freetextsearch_hierarchical
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "contact_and_person_freetextsearch_hierarchical" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContactAndPersonListFreetextSearchHierarchicalProvider">ContactAndPersonListFreetextSearchHierarchicalProvider</see> class.
The name of the MDO list is 'contact_and_person_freetextsearch_hierarchical'.




## Sample Request

```http!
GET /api/v1/MDOList/contact_and_person_freetextsearch_hierarchical
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("contact_and_person_freetextsearch_hierarchical", forceFlatList: true);
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

* "contact_and_person_freetextsearch_hierarchicalheadings"
* "contact_and_person_freetextsearch_hierarchicalheadingswithallitem"
* "contact_and_person_freetextsearch_hierarchicalheadingswithallitemwithnoselection"
* "contact_and_person_freetextsearch_hierarchicalheadingswithnoselection"
* "contact_and_person_freetextsearch_hierarchicalwithallitem"
* "contact_and_person_freetextsearch_hierarchicalwithallitemwithnoselection"
* "contact_and_person_freetextsearch_hierarchicalwithnoselection"
