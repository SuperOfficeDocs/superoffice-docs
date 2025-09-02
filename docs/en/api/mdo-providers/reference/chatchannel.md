---
uid: chatchannel
title: chatchannel
keywords: mdoprovider mdo provider chatchannel
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "chatchannel" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ChatChannelProvider">ChatChannelProvider</see> class.
The name of the MDO list is 'chatchannel'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include ALL value in result or not| notAll|True|
|Include all chat channels| listAll|False|





## Sample Request

```http!
GET /api/v1/MDOList/chatchannel
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("chatchannel", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|All|||


## Related MDO Lists

* "chatchannelheadings"
* "chatchannelheadingswithallitem"
* "chatchannelheadingswithallitemwithnoselection"
* "chatchannelheadingswithnoselection"
* "chatchannelwithallitem"
* "chatchannelwithallitemwithnoselection"
* "chatchannelwithnoselection"
