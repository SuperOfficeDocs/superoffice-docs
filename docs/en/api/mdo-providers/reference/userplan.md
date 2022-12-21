---
uid: userplan
title: userplan
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "userplan"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "userplan" MDO List

List provider for the UserPlan in the module license table.
Returns all user plans except the one specified by additional-info "exclude_id"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.UserPlanProvider">UserPlanProvider</see> class.
The name of the MDO list is 'userplan'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Exclude the given user-plan by id| exclude_id|1234|

## Sample Request

```http!
GET /api/v1/MDOList/userplan
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("userplan", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|79|(No Selection)||superlicense-no-selection|
|124|SalesPREM||ten-sales|
|129|ServicePREM||ten-service|
|131|Marketing||ten-marketing|
|132|SalesPREM-ServicePREM-Marketing||ten-salesservicemarketing|

## Related MDO Lists

* "userplanheadings"
* "userplanheadingswithallitem"
* "userplanheadingswithallitemwithnoselection"
* "userplanheadingswithnoselection"
* "userplanwithallitem"
* "userplanwithallitemwithnoselection"
* "userplanwithnoselection"
