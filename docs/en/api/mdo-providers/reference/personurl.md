---
uid: personurl
title: personurl
keywords: mdoprovider mdo provider personurl
description: List of urls (web pages) matching the search value, possibly restricted to a given company or person.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "personurl" MDO List
List of urls (web pages) matching the search value, possibly restricted to a given company or person.

AdditionalInfo:
itemId= person id
extraId= contact-id

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonUrlProvider">PersonUrlProvider</see> class.
The name of the MDO list is 'personurl'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Person id| itemId|23|
|Company id| extraId|23|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/personurl
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("personurl", forceFlatList: true);
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

* "personurlheadings"
* "personurlheadingswithallitem"
* "personurlheadingswithallitemwithnoselection"
* "personurlheadingswithnoselection"
* "personurlwithallitem"
* "personurlwithallitemwithnoselection"
* "personurlwithnoselection"
