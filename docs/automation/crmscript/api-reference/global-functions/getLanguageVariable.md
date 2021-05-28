---
uid: crmscript_global_getlanguagevariable
title: getLanguageVariable
description: CRMScript function that returns the language variable in the language given by language code or of the current user
intellisense: Void.getLanguageVariable
langref: 1
keywords: getLanguageVariable(String), getLanguageVariable(String,String)
so.topic: reference
---

# String getLanguageVariable()

Converts a language variable to a string in the language of the current user or, if provided, corresponding to a specific language code. Passing the language code is optional.

It will search in the language variables for the current screen in addition to the common language variables.

Returns the language variable in the language given.

## Functions

* String getLanguageVariable(String langVar)
* String getLanguageVariable(String langVar, String langCode)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| langVar | String | The language variable, for example, lang_global_global_okSave |
| langCode | String | Optional. The language code. Can be "no", "en", "de", "se", "dk", or "nl" |
