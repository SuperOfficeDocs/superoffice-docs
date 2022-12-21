---
uid: preferencesection
title: preferencesection
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "preferencesection"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "preferencesection" MDO List

MDO Provider that retrieves a list of preference sections

Preferences are described in the prefdesc table. This provider will retrieve descriptions for all sections.
<para />
Each item contains the programmatic section name in the extraInfo field.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PreferenceSectionProvider">PreferenceSectionProvider</see> class.
The name of the MDO list is 'preferencesection'.

## Sample Request

```http!
GET /api/v1/MDOList/preferencesection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("preferencesection", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1000003|Customer Centre password policy||ccAuthentication|
|1000013|Statistics||DataCollection|
|1000024|Default values||Defaults|
|1000058|Diary||DiaryView|
|1000083|Filter Dialog||FilterDialog|
|1000085|Freetext search||Freetext|
|1000093|Functions||Functions|
|1000147|E-mail||Mail|
|1000209|Marketing||Mailing|
|1000214|Grouped lists||MDOList|
|1000285|Web Services||NetServices|
|1000304|Notifications via popup||notification|
|1000312|Notifications via e-mail||notificationEmail|
|1000320|Notifications via SMS||notificationSms|
|1000336|Contact||Person|
|1000355|Mobile CRM||PocketTasks|
|1000359|Request||request|
|1000378|Sale||Sale|
|1000395|SuperOffice Service system settings||serviceSettings|
|1000420|Service outbox||serviceSMTP|
|1000426|SMS configuration||sms|

## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
