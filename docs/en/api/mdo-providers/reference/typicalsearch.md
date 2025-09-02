---
uid: typicalsearch
title: typicalsearch
keywords: mdoprovider mdo provider typicalsearch
description: MDO provider for the TypicalSearch Title, Tooltip and Id ExtraInfo parameter specifies the entity of the typical search rows to fetch
generated: true
content_type: reference
envir: onsite, online
---

# "typicalsearch" MDO List
MDO provider for the TypicalSearch Title, Tooltip and Id
ExtraInfo parameter specifies the entity of the typical search rows to fetch



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TypicalSearchProvider">TypicalSearchProvider</see> class.
The name of the MDO list is 'typicalsearch'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Name of the entity (contact, person, sale, ...) to get the TypicalSearches for| EntityName|person|





## Sample Request

```http!
GET /api/v1/MDOList/typicalsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("typicalsearch", forceFlatList: true);
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

* "typicalsearchheadings"
* "typicalsearchheadingswithallitem"
* "typicalsearchheadingswithallitemwithnoselection"
* "typicalsearchheadingswithnoselection"
* "typicalsearchwithallitem"
* "typicalsearchwithallitemwithnoselection"
* "typicalsearchwithnoselection"
