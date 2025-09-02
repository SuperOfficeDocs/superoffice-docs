---
uid: exporttemplate
title: exporttemplate
keywords: mdoprovider mdo provider exporttemplate
description: MDO provider for the list of template files for the 'export to file' function in the Selection Task pane. These are .sxf files found in so_arc/template, as well as in the so_arc/&lt;username&gt; directory of the current user. Impersonation is used if specified by the config file to access the document directories. The file name is returned as the list item name, while the full path is in the extrainfo.
generated: true
content_type: reference
envir: onsite, online
---

# "exporttemplate" MDO List
MDO provider for the list of template files for the 'export to file' function
in the Selection Task pane. These are .sxf files found in so_arc/template, as
well as in the so_arc/&lt;username&gt; directory of the current user.


Impersonation is used if specified by the config file to access the document directories.


The file name is returned as the list item name, while the full path is in
the extrainfo.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExportTemplateProvider">ExportTemplateProvider</see> class.
The name of the MDO list is 'exporttemplate'.




## Sample Request

```http!
GET /api/v1/MDOList/exporttemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("exporttemplate", forceFlatList: true);
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

* "exporttemplateheadings"
* "exporttemplateheadingswithallitem"
* "exporttemplateheadingswithallitemwithnoselection"
* "exporttemplateheadingswithnoselection"
* "exporttemplatewithallitem"
* "exporttemplatewithallitemwithnoselection"
* "exporttemplatewithnoselection"
