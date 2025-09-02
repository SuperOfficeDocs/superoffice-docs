---
uid: documenttemplatelanguage
title: documenttemplatelanguage
keywords: mdoprovider mdo provider documenttemplatelanguage
description: MDO Provider for Document Template langauges.
generated: true
content_type: reference
envir: onsite, online
---

# "documenttemplatelanguage" MDO List
MDO Provider for Document Template langauges.

ExtraInfo is used to decide which document template to fetch alternatives for.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentTemplateLanguageProvider">DocumentTemplateLanguageProvider</see> class.
The name of the MDO list is 'documenttemplatelanguage'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Document template id| |23|





## Sample Request

```http!
GET /api/v1/MDOList/documenttemplatelanguage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("documenttemplatelanguage", forceFlatList: true);
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

* "documenttemplatelanguageheadings"
* "documenttemplatelanguageheadingswithallitem"
* "documenttemplatelanguageheadingswithallitemwithnoselection"
* "documenttemplatelanguageheadingswithnoselection"
* "documenttemplatelanguagewithallitem"
* "documenttemplatelanguagewithallitemwithnoselection"
* "documenttemplatelanguagewithnoselection"
