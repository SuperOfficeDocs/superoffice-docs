---
description: String getScreenElementName(Integer index)
intellisense: Void.getScreenElementName
langref: 1
keywords: getScreenElementName(Integer)
so.topic: reference
---


This function can only be called from a screen definition, it will fail if called from a regular script.


It returns the name of the screen element with the given index in the current screen definition.

The index can be retrieved with `getHtmlElementIndex(elementName)`.


* **index:** The index of the element
* **Returns:** An integer defining the type of the element


