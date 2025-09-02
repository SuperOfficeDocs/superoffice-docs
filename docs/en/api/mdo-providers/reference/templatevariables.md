---
uid: templatevariables
title: templatevariables
keywords: mdoprovider mdo provider templatevariables
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "templatevariables" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TemplateVariablesProvider">TemplateVariablesProvider</see> class.
The name of the MDO list is 'templatevariables'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include company variables. Default = true| includeCompanies|True|





## Sample Request

```http!
GET /api/v1/MDOList/templatevariables
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("templatevariables", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|First name||{atfn}|
|2|Last name||{atln}|
|3|Salutation||{atsa}|
|4|E-mail||{amai}|
|5|Title||{atti}|
|6|Mobile phone||{atpc}|
|7|Direct phone||{phon}|
|8|Category||{acat}|
|9|Business||{abus}|
|10|Number||{anum}|
|11|Position||{atpo}|
|12|Name||{name}|
|13|Department||{dept}|
|14|Country||{cntr}|
|15|Phone||{cpho}|
|16|Web page||{cwww}|
|17|Category||{cate}|
|18|Business||{busi}|
|19|Number||{numb}|
|20|City||{city}|


## Related MDO Lists

* "templatevariablesheadings"
* "templatevariablesheadingswithallitem"
* "templatevariablesheadingswithallitemwithnoselection"
* "templatevariablesheadingswithnoselection"
* "templatevariableswithallitem"
* "templatevariableswithallitemwithnoselection"
* "templatevariableswithnoselection"
