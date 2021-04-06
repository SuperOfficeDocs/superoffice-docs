---
description: Map getScreenElementConfig(Integer index)
intellisense: Void.getScreenElementConfig
langref: 1
keywords: getScreenElementConfig(Integer)
so.topic: reference
---


This function can only be called from a screen definition, it will fail if called from a regular script.


It returns the config of the screen element with the given index in the current screen definition.

The index can be retrieved with `getHtmlElementIndex(elementName)`.


* **index:** The index of the element
* **Returns:** A map containing the config of the element


