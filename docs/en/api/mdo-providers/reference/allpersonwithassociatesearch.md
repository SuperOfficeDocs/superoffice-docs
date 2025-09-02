---
uid: allpersonwithassociatesearch
title: allpersonwithassociatesearch
keywords: mdoprovider mdo provider allpersonwithassociatesearch
description: Provides the same baseline functionality as <see cref="T:SuperOffice.CRM.Lists.AllPersonListSearchProvider" />, but additionally adds the associateId of the person to the extrainfo and changes the iconhint if the person is an associate. Uses freetext to perform a speedy search on the contact and person tables. Does not include sub-tables, like userdefined fields, text records etc.
generated: true
content_type: reference
envir: onsite, online
---

# "allpersonwithassociatesearch" MDO List
Provides the same baseline functionality as <see cref="T:SuperOffice.CRM.Lists.AllPersonListSearchProvider" />, but additionally adds the associateId of the person to the extrainfo
and changes the iconhint if the person is an associate.
Uses freetext to perform a speedy search on the contact and person tables. Does not include sub-tables, like userdefined fields, text records etc.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AllPersonWithAssociateListSearchProvider">AllPersonWithAssociateListSearchProvider</see> class.
The name of the MDO list is 'allpersonwithassociatesearch'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Skip retired employees| skipRetired|False|
|Boost scores on this contact| contactId|123|
|Include has_email=true/false in extrainfo| includeHasEmail|False|
|Boost associates score| boostAssociates|False|





## Sample Request

```http!
GET /api/v1/MDOList/allpersonwithassociatesearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("allpersonwithassociatesearch", forceFlatList: true);
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
