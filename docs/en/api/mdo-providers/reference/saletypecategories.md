---
uid: saletypecategories
title: saletypecategories
keywords: mdoprovider mdo provider saletypecategories
description: SaleTypeCategories creates a MDO list of sale type categories in the database.
generated: true
content_type: reference
envir: onsite, online
---

# "saletypecategories" MDO List
SaleTypeCategories creates a MDO list of sale type categories in the database.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleTypeCategoryListProvider">SaleTypeCategoryListProvider</see> class.
The name of the MDO list is 'saletypecategories'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|add a blank line to list| addblankstring|1|





## Sample Request

```http!
GET /api/v1/MDOList/saletypecategories
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("saletypecategories", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|General sales|||
|2|Special Sales|||


## Related MDO Lists

* "saletypecategoriesheadings"
* "saletypecategoriesheadingswithallitem"
* "saletypecategoriesheadingswithallitemwithnoselection"
* "saletypecategoriesheadingswithnoselection"
* "saletypecategorieswithallitem"
* "saletypecategorieswithallitemwithnoselection"
* "saletypecategorieswithnoselection"
