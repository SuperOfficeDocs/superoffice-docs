---
uid: quotedocumenttype
title: quotedocumenttype
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

# "quotedocumenttype" MDO List
List of quote document types - assumes ExtraInfo is the name of RecordType enum value

AdditionalInfo = "email=Email"
(DocTmplType enum value)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteDocumentTypeProvider">QuoteDocumentTypeProvider</see> class.
The name of the MDO list is 'quotedocumenttype'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|DocTmplType value to filter.| |Email|





## Sample Request

```http!
GET /api/v1/MDOList/quotedocumenttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quotedocumenttype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Template for Quote Document|||
|3|Template for Quote Details|||
|5|Template for Order Confirmations|||


## Related MDO Lists

* "quotedocumenttypeheadings"
* "quotedocumenttypeheadingswithallitem"
* "quotedocumenttypeheadingswithallitemwithnoselection"
* "quotedocumenttypeheadingswithnoselection"
* "quotedocumenttypewithallitem"
* "quotedocumenttypewithallitemwithnoselection"
* "quotedocumenttypewithnoselection"
