---
uid: createdocumenttemplateplugin
title: createdocumenttemplateplugin
keywords: mdoprovider mdo provider createdocumenttemplateplugin
description: List of document plugins that can create document templates.
generated: true
content_type: reference
envir: onsite, online
---

# "createdocumenttemplateplugin" MDO List
List of document plugins that can create document templates.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CreateDocumentTemplatePluginsProvider">CreateDocumentTemplatePluginsProvider</see> class.
The name of the MDO list is 'createdocumenttemplateplugin'.




## Sample Request

```http!
GET /api/v1/MDOList/createdocumenttemplateplugin
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("createdocumenttemplateplugin", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|SO Archive|||


## Related MDO Lists

* "createdocumenttemplatepluginheadings"
* "createdocumenttemplatepluginheadingswithallitem"
* "createdocumenttemplatepluginheadingswithallitemwithnoselection"
* "createdocumenttemplatepluginheadingswithnoselection"
* "createdocumenttemplatepluginwithallitem"
* "createdocumenttemplatepluginwithallitemwithnoselection"
* "createdocumenttemplatepluginwithnoselection"
