---
uid: emailflow
title: emailflow
keywords: mdoprovider mdo provider emailflow
description: List provider for EmailFlow
generated: true
content_type: reference
envir: onsite, online
---

# "emailflow" MDO List
List provider for EmailFlow



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EmailFlowListProvider">EmailFlowListProvider</see> class.
The name of the MDO list is 'emailflow'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Specified workflow statuses| statuses||

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/emailflow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("emailflow", forceFlatList: true);
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

* "emailflowheadings"
* "emailflowheadingswithallitem"
* "emailflowheadingswithallitemwithnoselection"
* "emailflowheadingswithnoselection"
* "emailflowwithallitem"
* "emailflowwithallitemwithnoselection"
* "emailflowwithnoselection"
