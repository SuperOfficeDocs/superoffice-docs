---
title: Debugging CRMScript modules
uid: crmscript_debug_development_mode
SortOrder: 40
---

CRMScript modules are scripts imported into other scripts files by using the `#included` directive.

Historically, you couldn't run CRMScript modules. Now, scriptwriters **can use environment variables** to invoke and debug module scripts:

* developmentMode
* includeId

## Debugging modules

`developmentMode` and `includeId` are set only when the script is run inside the code editor. To access them, call `getVariable()`. For example:

```crmscript
getVariable("includeId");
```

When the **Execute script** button is clicked, the engine sets `developmentMode*` to **true** and `includeId` to the includeId of the current script.

This lets you incorporate global code in your CRMScript:

```crmscript
// my global script

String foo() {
    return "Foo";
}

String bar() {
    return "Bar";
}

if (getVariable("developmentMode") == "true" && getVariable("includeId") == "foobar")
{
  printLine(foo() + bar());
}
```

* When editing your module library, only the part inside the `if` statement is run by the **Execute script** click event.

* When the library is included in production code, the debug code is not run when the production code is.
