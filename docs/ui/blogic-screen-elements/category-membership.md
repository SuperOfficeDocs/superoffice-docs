---
title: blogic_category_membership
description: Category membership
author:
so.date:
keywords:
so.topic: reference
---

# Category membership

This element is used to visualize (and change) which category a user belongs to.

## Configuration

| Setting    | Description                                      |
|:-----------|:-------------------------------------------------|
| label      | UI label                                         |
| categoryId | Loads the membership for the specified category  |
| noWeights  | Whether to show the weights for each user (Bool) |

## Example

```crmscript
categoryId = 2
label = Category
noWeights = false
```

## Functions

### getFieldValue(String field)

| Field   | Description                                                    |
|:--------|:---------------------------------------------------------------|
| members | A comma-separated string with the user ID of each member       |
| user ID | The weight of a user ID<br/>**-1** if the user is not a member |

### setFieldValue(String action, Map values)

| Field           | Map keys   | Description                                         |
|:----------------|:-----------|:----------------------------------------------------|
| saveMemberships | categoryId | Saves the members to the specified category (by ID) |
