---
uid: allpersonwithassociatesearch
title: allpersonwithassociatesearch
keywords: mdoprovider mdo provider allpersonwithassociatesearch
description: Provides the same baseline functionality as <see cref="T:SuperOffice.CRM.Lists.AllPersonListSearchProvider" />, but additionally adds the associateId of the person to the extrainfo and changes the iconhint if the person is an associate.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "allpersonwithassociatesearch" MDO List
Provides the same baseline functionality as <see cref="T:SuperOffice.CRM.Lists.AllPersonListSearchProvider" />, but additionally adds the associateId of the person to the extrainfo and changes the iconhint if the person is an associate.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AllPersonWithAssociateListSearchProvider">AllPersonWithAssociateListSearchProvider</see> class.
The name of the MDO list is 'allpersonwithassociatesearch'.




## Sample Request

```http!
GET /api/v1/MDOList/allpersonwithassociatesearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("allpersonwithassociatesearch", forceFlatList: true);
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

* "allpersonwithassociatesearchheadings"
* "allpersonwithassociatesearchheadingswithallitem"
* "allpersonwithassociatesearchheadingswithallitemwithnoselection"
* "allpersonwithassociatesearchheadingswithnoselection"
* "allpersonwithassociatesearchwithallitem"
* "allpersonwithassociatesearchwithallitemwithnoselection"
* "allpersonwithassociatesearchwithnoselection"
