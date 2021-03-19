---
uid: chatchannel
title: chatchannel
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "chatchannel"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "chatchannel" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ChatChannelProvider">ChatChannelProvider</see> class.
The name of the MDO list is 'chatchannel'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include ALL value in result or not| notAll|True|





## Sample Request

```http!
GET /api/v1/MDOList/chatchannel
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("chatchannel", forceFlatList: true);
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
