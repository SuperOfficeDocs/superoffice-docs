---
uid: quoteversion
title: quoteversion
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "quoteversion"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quoteversion" MDO List
Quote version selector for one Quote. Send QuoteId=&lt;id&gt; in ExtraInfo to specify quote id



Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteVersionProvider">QuoteVersionProvider</see> class.
The name of the MDO list is 'quoteversion'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Required: Quote primary key| QuoteId|1234|





## Sample Request

```http!
GET /api/v1/MDOList/quoteversion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quoteversion", forceFlatList: true);
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

* "quoteversionheadings"
* "quoteversionheadingswithallitem"
* "quoteversionheadingswithallitemwithnoselection"
* "quoteversionheadingswithnoselection"
* "quoteversionwithallitem"
* "quoteversionwithallitemwithnoselection"
* "quoteversionwithnoselection"
