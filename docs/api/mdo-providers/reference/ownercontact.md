---
uid: ownercontact
title: ownercontact
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ownercontact"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ownercontact" MDO List
MDO provider for listing owner contacts.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.OwnerContactProvider">OwnerContactProvider</see> class.
The name of the MDO list is 'ownercontact'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Add an extra item for ALL Companies to list| addallitem|y|





## Sample Request

```http!
GET /api/v1/MDOList/ownercontact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ownercontact", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|21|Jensen Madrasser, JAvdeling|||
|30|Nilsen'S VVS ANS, NAvdeling|||
|2|statezerodatabase|||


## Related MDO Lists

* "ownercontactheadings"
* "ownercontactheadingswithallitem"
* "ownercontactheadingswithallitemwithnoselection"
* "ownercontactheadingswithnoselection"
* "ownercontactwithallitem"
* "ownercontactwithallitemwithnoselection"
* "ownercontactwithnoselection"
