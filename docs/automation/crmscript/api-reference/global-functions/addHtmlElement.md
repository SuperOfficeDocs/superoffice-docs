---
uid: crmscript_global_addhtmlelement
title: addHtmlElement
description: CRMScript function used to add an HTML element to the associated screen
intellisense: Void.addHtmlElement
langref: 1
keywords: addHtmlElement(Integer,String,Integer,Map), addHtmlElement(Integer,String,Integer,String)
so.topic: reference
---

# HtmlElement addHtmlElement()

Adds an HTML element to the associated screen when this script is executed as the load script for a screen.

The configuration for the HTML element can be provided as a String or a Map. You can optionally provide the zero-based position of the element in the list of elements for the screen.

Returns the element that was added.

## Functions

* HtmlElement addHtmlElement(Integer id, String name, Integer type, Map config)
* HtmlElement addHtmlElement(Integer id, String name, Integer type, Map config, Integer position)
* HtmlElement addHtmlElement(Integer id, String name, Integer type, String config)
* HtmlElement addHtmlElement(Integer id, String name, Integer type, String config, Integer position)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| id | Integer | The ID of this HTML element. Normally not relevant. |
| name | String | The unique name of this HTML element. Used for accessing it later. |
| type | Integer | The type of this element. Types are documented under bLogic. |
| config | Map OR<br>String | The map containing the configuration for the HTML element.<br>The configuration string for the HTML element. Line-based, same as configuration text for elements in Screen definition. |
| position | Integer | Optional. The zero-based position of the element in the list of elements for the screen. |
