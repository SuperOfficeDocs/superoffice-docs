---
uid: formfolder
title: formfolder
keywords: mdoprovider mdo provider formfolder
description: FormFolderProvider creates a flat or tree list based on the table - s_picture_folder
generated: true
content_type: reference
envir: onsite, online
---

# "formfolder" MDO List
FormFolderProvider creates a flat or tree list based on the table: s_picture_folder



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FormFolderProvider">FormFolderProvider</see> class.
The name of the MDO list is 'formfolder'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Use hierarchy| hierarchy|true|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/formfolder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formfolder", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|(No Selection)|||


## Related MDO Lists

* "formfolderheadings"
* "formfolderheadingswithallitem"
* "formfolderheadingswithallitemwithnoselection"
* "formfolderheadingswithnoselection"
* "formfolderwithallitem"
* "formfolderwithallitemwithnoselection"
* "formfolderwithnoselection"
