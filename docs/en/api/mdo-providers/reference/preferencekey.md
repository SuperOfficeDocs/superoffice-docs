---
uid: preferencekey
title: preferencekey
keywords: mdoprovider mdo provider preferencekey
description: MDO Provider that retrieves a list of preference keys corresponding to a given section
generated: true
content_type: reference
envir: onsite, online
---

# "preferencekey" MDO List
MDO Provider that retrieves a list of preference keys corresponding to a given section

Preferences are described in the prefdesc table. This provider will retrieve descriptions for all keys
grouped under a given section, passed in as the additionalInfo to the constructor.


Use the <see cref="T:SuperOffice.CRM.UserPreferenceStrings" /> class to avoid (mis)coding preference section and key names as strings.


Each item contains the programmatic key name in the extraInfo field.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PreferenceKeyProvider">PreferenceKeyProvider</see> class.
The name of the MDO list is 'preferencekey'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Preference section name, optionally followed by ;excludesystemwide to exclude preferences that belong in the System Settings gui| |Functions|





## Sample Request

```http!
GET /api/v1/MDOList/preferencekey
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("preferencekey", forceFlatList: true);
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

* "preferencekeyheadings"
* "preferencekeyheadingswithallitem"
* "preferencekeyheadingswithallitemwithnoselection"
* "preferencekeyheadingswithnoselection"
* "preferencekeywithallitem"
* "preferencekeywithallitemwithnoselection"
* "preferencekeywithnoselection"
