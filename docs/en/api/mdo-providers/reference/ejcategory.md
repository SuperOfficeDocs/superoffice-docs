---
uid: ejcategory
title: ejcategory
keywords: mdoprovider mdo provider ejcategory
description: EjCategoryProvider creates a flat or tree list based on the table - EJ_CATEGORY
generated: true
content_type: reference
envir: onsite, online
---

# "ejcategory" MDO List
EjCategoryProvider creates a flat or tree list based on the table: EJ_CATEGORY



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EjCategoryProvider">EjCategoryProvider</see> class.
The name of the MDO list is 'ejcategory'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Use hierarchy| hierarchy|true|
|Return only categories owned by requester| onlyOwnCategories|False|
|Return short names instead of full path| shortNames|False|
|Return short text (FullName) as a tooltip| shortTooltip|False|
|Include admin UI info: resolve Category master name and icons| includeAdministrativeInfo|True|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/ejcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ejcategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Administration||parentId=0&replyTemplateId=-1|
|4|Administration/Accounting||parentId=2&replyTemplateId=-1|
|7|Administration/Accounting/Fraud||parentId=4&replyTemplateId=-1|
|9|Administration/Accounting/Fraud/Serious||parentId=7&replyTemplateId=-1|
|10|Administration/Accounting/Fraud/Silly||parentId=7&replyTemplateId=-1|
|8|Administration/Accounting/Overdue||parentId=4&replyTemplateId=-1|
|11|Administration/Accounting/Overdue/Long||parentId=8&replyTemplateId=-1|
|13|Administration/Catering||parentId=2&replyTemplateId=-1|
|12|Administration/IT||parentId=2&replyTemplateId=-1|
|3|Sale||parentId=0&replyTemplateId=0|
|1|Support||parentId=0&replyTemplateId=-1|
|6|Support/On-line||parentId=1&replyTemplateId=-1|
|5|Support/Out-call||parentId=1&replyTemplateId=-1|


## Related MDO Lists

* "ejcategoryheadings"
* "ejcategoryheadingswithallitem"
* "ejcategoryheadingswithallitemwithnoselection"
* "ejcategoryheadingswithnoselection"
* "ejcategorywithallitem"
* "ejcategorywithallitemwithnoselection"
* "ejcategorywithnoselection"
