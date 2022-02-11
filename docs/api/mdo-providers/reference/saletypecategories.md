---
uid: saletypecategories
title: saletypecategories
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "saletypecategories"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saletypecategories", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|General sales|||


## Related MDO Lists

* "saletypecategoriesheadings"
* "saletypecategoriesheadingswithallitem"
* "saletypecategoriesheadingswithallitemwithnoselection"
* "saletypecategoriesheadingswithnoselection"
* "saletypecategorieswithallitem"
* "saletypecategorieswithallitemwithnoselection"
* "saletypecategorieswithnoselection"
