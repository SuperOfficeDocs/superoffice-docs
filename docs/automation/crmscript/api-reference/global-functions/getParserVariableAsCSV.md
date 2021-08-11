---
title: String getParserVariableAsCSV(String paramName, Bool forceQuoting)
description: String getParserVariableAsCSV(String paramName, Bool forceQuoting)
intellisense: Void.getParserVariableAsCSV
langref: 1
keywords: getParserVariableAsCSV(String,Bool)
so.topic: reference
---

# String getParserVariableAsCSV(String paramName, Bool forceQuoting)

Return a variable from the global Parser instance as a comma-separated string.

* **paramName:** The name of the variable to return.
* **forceQuoting:** If True, then each element will be quoted. If false, only elements that need to be quoted (i.e. when they contain a comma) will be quoted.
