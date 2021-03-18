---
uid: credentialgroup
title: credentialgroup
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "credentialgroup" MDO List
List of user groups supported by a named creditial plugin, sorted by group name.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CredentialGroupProvider">CredentialGroupProvider</see> class.
The name of the MDO list is 'credentialgroup'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Credential type to get list of user groups from| type|ActiveDirectory|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/credentialgroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("credentialgroup", forceFlatList: true);
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

* "credentialgroupheadings"
* "credentialgroupheadingswithallitem"
* "credentialgroupheadingswithallitemwithnoselection"
* "credentialgroupheadingswithnoselection"
* "credentialgroupwithallitem"
* "credentialgroupwithallitemwithnoselection"
* "credentialgroupwithnoselection"
