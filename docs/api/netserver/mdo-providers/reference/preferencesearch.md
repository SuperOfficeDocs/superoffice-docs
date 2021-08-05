---
uid: preferencesearch
title: preferencesearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "preferencesearch"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "preferencesearch" MDO List
MDO Provider that retrieves a list of preference keys corresponding to a given keyword.

Preferences are described in the prefdesc table. This provider will retrieve descriptions for all keys
for a given keyword. A search for the keyword, passed in as the additionalInfo to the constructor, is preformed in both name and descriptio fields.

Each item contains the programmatic key name in the extraInfo field.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PreferenceSearchProvider">PreferenceSearchProvider</see> class.
The name of the MDO list is 'preferencesearch'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Preference section name| |Functions|





## Sample Request

```http!
GET /api/v1/MDOList/preferencesearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("preferencesearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5495|Visible follow-ups per day view||Defaults|
|5500|Diary autorefresh interval||DiaryView|
|5502|Diary start time|bold|DiaryView|
|5528|Maximum number of hits (multi-word)||Freetext|
|5530|Maximum number of hits (single word)||Freetext|
|5534|Archive page size||Functions|
|5536|Limit for auto-loading||Functions|
|5609|IMAP Server name||Mail|
|5616|Attachment size-threshold||Mail|
|5633|Fax no. format in e-mail address.||Mail|
|5637|SMTP Server name||Mail|
|5642|Timeout||Mail|
|5660|Enable long list names and tooltips||MDOList|
|5691|Maximum list size||MDOList|
|5793|Autologout time||PocketTasks|
|5939|JPEG quality|bold|Visual|
|5940|Status image transparency||Visual|


## Related MDO Lists

* "preferencesearchheadings"
* "preferencesearchheadingswithallitem"
* "preferencesearchheadingswithallitemwithnoselection"
* "preferencesearchheadingswithnoselection"
* "preferencesearchwithallitem"
* "preferencesearchwithallitemwithnoselection"
* "preferencesearchwithnoselection"
