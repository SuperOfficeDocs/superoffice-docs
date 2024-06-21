---
uid: emailfolder
title: emailfolder
keywords: mdoprovider mdo provider emailfolder
description: EmailFolderProvider gives you the folder hierarchy of a given mail account
generated: true
topic: reference
envir: onsite, online
---

# "emailfolder" MDO List
EmailFolderProvider gives you the folder hierarchy of a given mail account



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EmailFolderProvider">EmailFolderProvider</see> class.
The name of the MDO list is 'emailfolder'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Id of the account for which you want the folders| accountId|0|
|Use hierarchy| hierarchy|true|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/emailfolder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("emailfolder", forceFlatList: true);
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

* "emailfolderheadings"
* "emailfolderheadingswithallitem"
* "emailfolderheadingswithallitemwithnoselection"
* "emailfolderheadingswithnoselection"
* "emailfolderwithallitem"
* "emailfolderwithallitemwithnoselection"
* "emailfolderwithnoselection"
