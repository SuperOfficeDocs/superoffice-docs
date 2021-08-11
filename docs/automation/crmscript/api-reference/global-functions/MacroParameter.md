---
uid: crmscript_global_macroparameter
title: MacroParameter MacroParameter()
description: CRMScript MacroParameter constructor
intellisense: Void.MacroParameter
langref: 1
keywords: MacroParameter(String,String,Map,String,String,Bool), MacroParameter(String,String,Map,String,String,Bool,String,Bool)
so.topic: reference
---

# MacroParameter MacroParameter()

MacroParameter constructor. You can optionally pass a default value and specify whether or not it is fixed.
The Map control-configuration values the type of the parameter allow is also optional.

## Functions

* MacroParameter MacroParameter(String name, String type, Map controlConfig, String label, String description, Bool isOptional)
* MacroParameter MacroParameter(String name, String type, Map controlConfig, String label, String description, Bool isOptional, String defaultValue, Bool defaultValueIsFixed)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| name | String | The name of the parameter. |
| type | String | The type of the parameter. |
| controlConfig | Map | Optional. The control-configuration values the type of the parameter allow. |
| label | String | The label of the parameter. |
| description | String | A longer description of the parameter. |
| isOptional | Bool | Whether the parameter is optional. |
| defaultValue | String | |
| defaultValueIsFixed | Bool | Whether the default value of the parameter is fixed. |
