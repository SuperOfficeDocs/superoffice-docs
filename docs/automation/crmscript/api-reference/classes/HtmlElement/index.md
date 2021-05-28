---
uid: crmscript_ref_HtmlElement
title: HtmlElement
intellisense: Void.HtmlElement
sortOrder: 377
title: HtmlElement
author:
so.date:
keywords:
so.topic:
so.topic: reference
---

# HtmlElement

The CRMScript **HtmlElement** class represents HTML elements in the SuperOffice UI.

## Types

* String [getTypeName()][1]

### Type conversion

You can convert the value of an `HtmlElement` object to a string, number, or boolean:

* Bool toBool()
* Integer toInteger()
* String toString()

## Values

* Void [setFromCgi()][2]
* String [getFieldValue(String field)][3]
* Void [setFieldValue(String name, Map map)][4]
* Void [setValue(String value)][5]
* Void [clearValue()][6]

## Messages

* Void [setErrorMessage(String errorMessage)][7]
* Void [setInfoMessage(String infoMessage)][8]

## Element properties

* Bool [isEmpty()][9]
* Void [setDisabled(Bool invisible)][10]
* Void [setNotEditable(Bool canEdit)][11]
* Integer [getNextTabIndex()][12]
* String [getTabIndexString()][13]
* String [getTabIndexString(Bool noId)][13]

<!-- Referenced links -->
[1]: gettypename.md
[2]: setfromcgi.md
[3]: getfieldvalue.md
[4]: setfieldvalue.md
[5]: setvalue.md
[6]: clearvalue.md
[7]: seterrormessage.md
[8]: setinfomessage.md
[9]: isempty.md
[10]: setdisabled.md
[11]: setnoteditable.md
[12]: getnexttabindex.md
[13]: gettabindexstring.md
