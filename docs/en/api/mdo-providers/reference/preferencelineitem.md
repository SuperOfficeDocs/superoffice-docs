---
uid: preferencelineitem
title: preferencelineitem
keywords: mdoprovider mdo provider preferencelineitem
description: MDO Provider for preferences that have a list of possible values in the database
generated: true
content_type: reference
envir: onsite, online
---

# "preferencelineitem" MDO List
MDO Provider for preferences that have a list of possible values in the database

Some preferences have a set of possible values that does not correspond to any existing list. In such cases,
rows in the prefdescline table are used to create a list. This provider will take an additionalInfo of the form
section|key and return the list of possible values. If the key or section does not exist or do not have such
a list of possible values, an empty list is returned.


Consider using the <see cref="M:SuperOffice.CRM.Lists.PreferenceLineItemProvider.CreateAdditionalInfo(System.String,System.String)" /> method to avoid coding formatting dependencies.
Use the <see cref="T:SuperOffice.CRM.UserPreferenceStrings" /> class to avoid (mis)coding preference section and key names as strings.


The actual preference value to set, corresponding to each choice, is in the extraInfo of each list item.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PreferenceLineItemProvider">PreferenceLineItemProvider</see> class.
The name of the MDO list is 'preferencelineitem'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Preference section | preference key| |Functions|DisableContactDogEar|

Separator: |





## Sample Request

```http!
GET /api/v1/MDOList/preferencelineitem
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("preferencelineitem", forceFlatList: true);
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

* "preferencelineitemheadings"
* "preferencelineitemheadingswithallitem"
* "preferencelineitemheadingswithallitemwithnoselection"
* "preferencelineitemheadingswithnoselection"
* "preferencelineitemwithallitem"
* "preferencelineitemwithallitemwithnoselection"
* "preferencelineitemwithnoselection"
