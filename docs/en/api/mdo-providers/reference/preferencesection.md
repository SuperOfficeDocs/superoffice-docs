---
uid: preferencesection
title: preferencesection
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "preferencesection"
so.generated: true
so.date: 01.23.2023
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
|1000059|Diary||DiaryView|
|1000084|Filter Dialog||FilterDialog|
|1000086|Freetext search||Freetext|
|1000094|Functions||Functions|
|1000148|E-mail||Mail|
|1000210|Marketing||Mailing|
|1000215|Grouped lists||MDOList|
|1000512|Data mirroring||Mirroring|
|1000286|Web Services||NetServices|
|1000305|Notifications via popup||notification|
|1000313|Notifications via e-mail||notificationEmail|
|1000321|Notifications via SMS||notificationSms|
|1000337|Contact||Person|
|1000356|Mobile CRM||PocketTasks|
|1000360|Request||request|
|1000379|Sale||Sale|
|1000396|SuperOffice Service system settings||serviceSettings|
|1000422|Service outbox||serviceSMTP|


## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
