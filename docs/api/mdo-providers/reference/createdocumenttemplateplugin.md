---
uid: createdocumenttemplateplugin
title: createdocumenttemplateplugin
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "createdocumenttemplateplugin"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("createdocumenttemplateplugin", forceFlatList: true);
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
