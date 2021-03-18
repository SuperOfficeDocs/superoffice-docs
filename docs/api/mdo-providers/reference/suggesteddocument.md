---
uid: suggesteddocument
title: suggesteddocument
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "suggesteddocument" MDO List
SuggestedDocumentProvider creates a MDO list of suggested documents in the database.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SuggestedDocumentProvider">SuggestedDocumentProvider</see> class.
The name of the MDO list is 'suggesteddocument'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include deleted records| ShowDeleted|True|
|Suggested docs for a given stage link| SaleTypeStageLinkId|1234|
|Suggested docs for a given stage link| ProjectTypeStatusLinkId|4321|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/suggesteddocument
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("suggesteddocument", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Invitations|||
|2|Write report|||
|3|Write quote doc|||
|4|Write a letter|||


## Related MDO Lists

* "suggesteddocumentheadings"
* "suggesteddocumentheadingswithallitem"
* "suggesteddocumentheadingswithallitemwithnoselection"
* "suggesteddocumentheadingswithnoselection"
* "suggesteddocumentwithallitem"
* "suggesteddocumentwithallitemwithnoselection"
* "suggesteddocumentwithnoselection"
