---
uid: crmscript_class_statlib_addgroup
title: StatLib.addGroup()
description: CRMScript method in the StatLib class that adds a group to the StatLib instance
intellisense: StatLib.addGroup
keywords: addGroup(Integer,Bool), addGroup(Integer,Bool,Bool)
so.topic: reference
---

# addGroup()

Adds a group to the `StatLib` instance. A **group** is a subset of the results that have a common value for a given column. Aggregate values can be calculated for groups, for example,  the average response time per category.

## Methods

* StatLib.addGroup(Integer column, Bool desc)
* StatLib.addGroup(Integer column, Bool desc, Bool compareAsNumber)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| column | Integer | The column to used to identify the groups |
| desc | Bool | Sort order. True = descending, otherwise ascending |
| compareAsNumber | Bool | Optional. True if the value is a number and you want numeric sorting/grouping |
