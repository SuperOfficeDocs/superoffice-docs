---
uid: preferencesearch
title: preferencesearch
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

# "preferencesearch" MDO List
MDO Provider that retrieves a list of preference keys corresponding to a given keyword.

Preferences are described in the prefdesc table. This provider will retrieve descriptions for all keys
for a given keyword. A search for the keyword, passed in as the additionalInfo to the constructor, is preformed in both name and descriptio fields.
<para />
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
|11280|Visible follow-ups per day view||Defaults|
|11285|Diary autorefresh interval||DiaryView|
|11287|Diary start time|bold|DiaryView|
|11313|Maximum number of hits (multi-word)||Freetext|
|11315|Maximum number of hits (single word)||Freetext|
|11319|Archive page size||Functions|
|11321|Limit for auto-loading||Functions|
|11395|IMAP Server name||Mail|
|11402|Attachment size-threshold||Mail|
|11419|Fax no. format in e-mail address.||Mail|
|11423|SMTP Server name||Mail|
|11428|Timeout||Mail|
|11446|Enable long list names and tooltips||MDOList|
|11477|Maximum list size||MDOList|
|11579|Autologout time||PocketTasks|
|11725|JPEG quality|bold|Visual|
|11726|Status image transparency||Visual|


## Related MDO Lists

* "preferencesearchheadings"
* "preferencesearchheadingswithallitem"
* "preferencesearchheadingswithallitemwithnoselection"
* "preferencesearchheadingswithnoselection"
* "preferencesearchwithallitem"
* "preferencesearchwithallitemwithnoselection"
* "preferencesearchwithnoselection"
