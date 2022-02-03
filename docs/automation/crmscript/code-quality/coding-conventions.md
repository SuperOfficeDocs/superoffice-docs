---
uid: crmscript_conventions
title: CRMScript coding conventions
author:
so.date:
keywords:
so.topic: reference
---

# CRMScript coding conventions

Always use the same conventions for all your CRMScripts. This will:

* Improve code readability
* Make it easier to maintain the code

> [!NOTE]
> Variables, structs, and methods must be declared before they are used.

## Naming conventions

### Variable names

Use camelCase for variable names. Start all names with a letter.

```crmscript
Integer shoeSize = 42;
String firstName = "Eva";
```

You may also use numbers \[0-9\] and underscore.
Hyphens and the $ sign are not allowed in CRMScript names.

Strive to pick names as descriptive as possible, within reason. Favor readability over space. Avoid unfamiliar abbreviations. For example, don't shorten `firstName` to `fn`.

> [!NOTE]
> The built-in classes use Pascal case, as do the methods in the NetServer classes.

### File extensions

CRMScript files should have a .crm extension.

### Filenames

Use lower-case file names for portability. Some, but not all, web servers are case sensitive. If you choose to mix cases, you need to be painstakingly consistent to avoid errors.

## Statement rules

* One statement per line.
* Always end simple statements with a semicolon. Don't end complex statements with a semicolon.

```crmscript
Integer i = 10;
while (i > 0) {
  doSomething();
  i++;
}
```

**Kernighan and Ritchie style brackets:**

* The first statement of a non-empty block must begin on its own line.
* Put the opening bracket at the end of the 1st line.
* Use a single space before the opening bracket.
* Put the closing bracket by itself on a new line without any leading spaces.

## Struct rules

General rules for struct definition:

* Put the opening bracket on the same line as the struct name.
* Put the closing bracket on a new line without any leading spaces and end with a semicolon.

```crmscript
struct Car {
  String brand;
  String model;
  Integer modelYear;

  Void print() {
    print( this.brand + " " + this.model + ", " + this.modelYear.toString());
  }
};
```

## Formatting

### Code indentation

Always use 2 spaces for indentation of code blocks.
Don't use tabs for indentation.

### Line length

Avoid lines longer than 80 characters.

If a statement doesn't fit on 1 line, you can break it after an [operator][1] or a comma. Use +4 spaces indentation for the wrapped (continued) lines.

**Exceptions:**

* Long URLs should be clickable in the source.
* Preserve long strings that should be searchable as a whole (for example paths).
* Don't split import and export statements.

### Whitespace

* Always put a single space on either side of binary operators and after commas.
* Put a single blank line between consecutive methods and structs.
* Use blank lines sparingly to group statement blocks.
* Put a single space between reserved words and an opening parenthesis
* Put a space before and after the double slash // for comments
* Omit trailing whitespace.
* Don't align values horizontally.

<!-- Referenced links -->
[1]: ../fundamentals/operators.md
