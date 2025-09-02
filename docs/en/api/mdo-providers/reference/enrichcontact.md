---
uid: enrichcontact
title: enrichcontact
keywords: mdoprovider mdo provider enrichcontact
description: List of possible contacts to import from outside sources.
generated: true
content_type: reference
envir: onsite, online
---

# "enrichcontact" MDO List
List of possible contacts to import from outside sources.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EnrichContactProvider">EnrichContactProvider</see> class.
The name of the MDO list is 'enrichcontact'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Country ISO2 letter code to use for enrichment. e.g. 'no', 'se'. If not specified, the home country of the user will be used.| |countryIso2|





## Sample Request

```http!
GET /api/v1/MDOList/enrichcontact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("enrichcontact", forceFlatList: true);
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

* "enrichcontactheadings"
* "enrichcontactheadingswithallitem"
* "enrichcontactheadingswithallitemwithnoselection"
* "enrichcontactheadingswithnoselection"
* "enrichcontactwithallitem"
* "enrichcontactwithallitemwithnoselection"
* "enrichcontactwithnoselection"
