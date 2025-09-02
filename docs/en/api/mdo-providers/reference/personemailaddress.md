---
uid: personemailaddress
title: personemailaddress
keywords: mdoprovider mdo provider personemailaddress
description: List of e-mail addresses matching the search value, possibly restricted to a given company or person.
generated: true
content_type: reference
envir: onsite, online
---

# "personemailaddress" MDO List
List of e-mail addresses matching the search value, possibly restricted to a given company or person.

AdditionalInfo:
itemId= person id
extraId= contact-id

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonEmailAddressProvider">PersonEmailAddressProvider</see> class.
The name of the MDO list is 'personemailaddress'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Person id| itemId|23|
|Company id| extraId|23|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/personemailaddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("personemailaddress", forceFlatList: true);
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

* "personemailaddressheadings"
* "personemailaddressheadingswithallitem"
* "personemailaddressheadingswithallitemwithnoselection"
* "personemailaddressheadingswithnoselection"
* "personemailaddresswithallitem"
* "personemailaddresswithallitemwithnoselection"
* "personemailaddresswithnoselection"
