---
uid: preferencesection
title: preferencesection
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "preferencesection"
so.generated: true
so.date: 19.03.2021
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
|5773|Contact||Person|
|5442|Customer Centre password policy||ccAuthentication|
|5463|Default values||Defaults|
|5497|Diary||DiaryView|
|5587|E-mail||Mail|
|5522|Filter Dialog||FilterDialog|
|5524|Freetext search||Freetext|
|5532|Functions||Functions|
|5651|Grouped lists||MDOList|
|5648|Mailing||Mailing|
|5749|Notifications via e-mail||notificationEmail|
|5741|Notifications via popup||notification|
|5757|Notifications via SMS||notificationSms|
|5792|Pocket CRM||PocketTasks|
|5798|Request||request|
|5816|Sale||Sale|
|5860|Service outbox||serviceSMTP|
|5866|SMS configuration||sms|
|5871|Sorting||Sorting|
|5452|Statistics||DataCollection|
|5835|SuperOffice Service system settings||serviceSettings|


## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
