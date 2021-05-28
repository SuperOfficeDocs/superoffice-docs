---
uid: crmscript_ref_htmlelement_gettabindexstring
title: HtmlElement.getTabIndexString()
description: CRMScript method in class HtmlElement that retrieves the tabulator index string of the element
intellisense: HtmlElement.getTabIndexString
sortOrder: 384
keywords: getTabIndexString(), getTabIndexString(Bool)
so.topic: reference
---

# String getTabIndexString()

Returns the tabulator index string of the element. By default, a special ID is added for the 1st element. You can optionally signal to omit element ID if it is the 1st element.

The HTML `tabindex` attribute specifies the tab order of an element. It determines the sequence of entering fields with Tab or Shift+Tab.

A variant of `getTabIndexString()` that omits element ID if it is the 1st element.

## Parameters

| Parameter | Type | Description |
|---|---|---|
| noId | Bool | Optional. Don't add element ID to the string if it is the 1st element |
