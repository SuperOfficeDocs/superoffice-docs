---
uid: privacytemplate
title: privacytemplate
keywords: mdoprovider mdo provider privacytemplate
description: This is a variant of the DocTmpl list - document templates - restricted to those that are of some privacy document type.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "privacytemplate" MDO List
This is a variant of the DocTmpl list - document templates - restricted to those that are of some privacy document type.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PrivacyTemplateProvider">PrivacyTemplateProvider</see> class.
The name of the MDO list is 'privacytemplate'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|DocTmplPrivacyType enum value| DocTmplPrivacyType|MainDocument|





## Sample Request

```http!
GET /api/v1/MDOList/privacytemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("privacytemplate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|20|Confirmation - Contact added|||


## Related MDO Lists

* "privacytemplateheadings"
* "privacytemplateheadingswithallitem"
* "privacytemplateheadingswithallitemwithnoselection"
* "privacytemplateheadingswithnoselection"
* "privacytemplatewithallitem"
* "privacytemplatewithallitemwithnoselection"
* "privacytemplatewithnoselection"
