---
title: blogic_ejscript_element
description: Ejscript element
author:
so.date:
keywords:
so.topic: reference
---

# Ejscript element

This element is completely script-able.

1. The system loads a script and executes the global code of the script at instantiation time.
2. You create CRMScript functions for all the standard functions in [HtmlElement](@crmscript_htmlelement) and place those in the **Body** tab.
    * You can call `print()` to create output, or perform other actions on the element.

## Example

```crmscript
Void element_printJavaScriptSection() {
  print("function mySetSizeFunction(width, height) { document.getElementById('myElement').style.width width* 4; document.getElementById('myElement').style.height = height* 4; }\r\n");
}
```

```crmscript
Void element_setFieldValue(String field, Map map) {
  if (field == "setMessage")
    message = map.get("message");
}
```

## Functions

### getVariable()

All config variables are available using `getVariable()`.

### Print

| Function                       | Type | Called                                             | Comments                                               |
|:-------------------------------|:-----|:---------------------------------------------------|:-------------------------------------------------------|
| element_printHeadSection       | Void | After the opening `<head>` tag                     | This is a good place to print embedded CSS code        |
| element_printJavaScriptSection | Void | Inside a `<script>` tag in the head section        |                                                        |
| element_printOnLoadSection     | Void | Wen the page is loaded (`HtmlPage_onload()`)       |                                                        |
| element_printBodySection       | Void | When the body part of the element is to be printed | This is where you print your main HTML for the element |

### JavaScript and CSS

| Function                    | Type     | Description                                          |
|:----------------------------|:---------|:-----------------------------------------------------|
| element_getJsIncludes       | String[] | Adds a list of JavaScript include files for the page |
| element_getCssIncludes      | String[] | Adds a list of CSS include files for the page        |
| element_getSetSizeStatement | String   | Returns the opening part of a JavaScript statement that will be executed by the resizing model.<br/>The available width, height, and closing parenthesis will be appended to this statement before it is evaluated (executed). |

### Values

| Function                       | Type   | Parameters  | Comments                                       |
|:-------------------------------|:-------|:------------|:-----------------------------------------------|
| element_setValue               | Void   | String      | Sets a simple value for your element           |
| element_clearValue             | Void   |             | Clears the value of the element                |
| element_setFromCgi             | Void   |             | Called when the element should find its values from the CGI variables |
| element_setFieldValue          | Void   | String, Map | Sets a value or attribute for your element     |
| element_getFieldValue          | String |             | Returns a value or attribute from your element |
| element_toString               | String |             | Converts a simple value to a string            |
