---
uid: crmscript_class_searchengine_adddatafield
title: SearchEngine.addDataField()
description: CRMScript method in class SearchEngine that adds a data field (a reference to a field instead of a value)
intellisense: SearchEngine.addDataField
keywords: addDataField(String,String), addDataField(String,String,String)
so.topic: reference
---

# addDataField()

Adds a data field to the SearchEngine. A **data field** is a field assigned to another field instead of a value.

You can optionally add a function to be applied to the second field.

> [!NOTE]
> Can only be used in `update()` queries.

## Methods

* SearchEngine.addDataField(String field1, String field2)
* SearchEngine.addDataField(String field1, String field2, String function)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| field1 | String | Field to assign to. |
| field2 | String | Field where the value is found. |
| function | String | Optional. Aggregate function to use for `field2`. |

### Available functions

* count
* avg
* sum
* max
* min
* hour
* wday
* upper
* lower
* castToVarchar
* date
* time

## Example

```crmscript
se.addDataField("customer.phone", "customer.cellphone");
```

This means that we are going to assign the cellphone to the phone field.
