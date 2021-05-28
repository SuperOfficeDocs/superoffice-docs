---
uid: crmscript_global_getparservariable
title: getParserVariable
description: CRMScript function that gets the value of the given variable from the global Parser instance
intellisense: Void.getParserVariable
langref: 1
keywords: getParserVariable(String), getParserVariable(String,Integer)
so.topic: reference
---

# String getParserVariable()

Returns the (first) value for the given variable from the global Parser instance. You can optionally pass the zero-based row of the parser-query result set.

## Functions

* String getParserVariable(String varName)
* String getParserVariable(String varName, Integer row)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| varName | String | The name of the variable |
| row | Integer | Optional. The zero-based index of the value to return |
