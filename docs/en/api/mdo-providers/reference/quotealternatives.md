---
uid: quotealternatives
title: quotealternatives
keywords: mdoprovider mdo provider quotealternatives
description: Quote alternative selector for one Quote Version. Send QuoteVersionId=&lt;id&gt; in ExtraInfo to specify quote version id
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "quotealternatives" MDO List
Quote alternative selector for one Quote Version. Send QuoteVersionId=&lt;id&gt; in ExtraInfo to specify quote version id



Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteAlternativeProvider">QuoteAlternativeProvider</see> class.
The name of the MDO list is 'quotealternatives'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|The quote version we want to list the alternatives for.| QuoteVersionId|321|





## Sample Request

```http!
GET /api/v1/MDOList/quotealternatives
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quotealternatives", forceFlatList: true);
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

* "quotealternativesheadings"
* "quotealternativesheadingswithallitem"
* "quotealternativesheadingswithallitemwithnoselection"
* "quotealternativesheadingswithnoselection"
* "quotealternativeswithallitem"
* "quotealternativeswithallitemwithnoselection"
* "quotealternativeswithnoselection"
