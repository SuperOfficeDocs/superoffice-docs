---
uid: chatuser
title: chatuser
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "chatuser"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "chatuser" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ChatUserProvider">ChatUserProvider</see> class.
The name of the MDO list is 'chatuser'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Only users who are present| onlyPresent|True|
|Do not include current user| removeSelf|True|
|Return Associate ID instead of ejUser id| associate|True|





## Sample Request

```http!
GET /api/v1/MDOList/chatuser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("chatuser", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Adm0|||
|23|Adm1|||
|24|Adm2|||
|25|Adm3|||
|26|Adm4|||
|27|Adm5|||
|13|Admin Adminson|||
|14|Arne Arnesen|||
|41|AdmNS02 NetServer|||
|45|RevNS03 NetServer|||
|46|SalNS00 NetServer|||
|48|Listadm Listadm|||
|49|Useradm Useradm|||
|50|User Local|||
|51|Localuser2 Localuser2|||
|52|Localuser3 Localuser3|||
|53|Johan Jensen|||
|54|Kjell Jensen|||
|55|Olga Jensen|||
|56|Lollo Johansen|||
|57|Morten Johansen|||


## Related MDO Lists

* "chatuserheadings"
* "chatuserheadingswithallitem"
* "chatuserheadingswithallitemwithnoselection"
* "chatuserheadingswithnoselection"
* "chatuserwithallitem"
* "chatuserwithallitemwithnoselection"
* "chatuserwithnoselection"
