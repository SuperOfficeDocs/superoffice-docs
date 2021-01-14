---
title: crmscript_parser
description: Parser
author:
so.date:
keywords:
so.topic:
---

# Parser

The `Parser` class is a **template engine**. Use an instance to set template variable values, then parse a formatted string containing template variable placeholders to replace their values.

```crmscript!
Parser p;
p.setVariable("firstName", "John");
p.setVariable("lastName", "Smith");

String output = p.parseString("Hello [[firstName]] [[lastName]]!\n");

print(output);
```

This example defines the template and its variables inline. You can also use a [reply template][1].

## List available variables

You can use the variable `PARSER_TREE` in double square brackets to print a list of all available variables.

```crmscript!
Parser p;
printLine(p.parseString("[[PARSER_TREE]]"));
```

## Define data

### Void toParser(Parser parser)

Copies a set of values to the parser.

```crmscript
Parser p;
Ticket t;
t.load(getVariable("ticketId").toInteger());
t.toParser(p);
```

### Void setVariable(String name, String value)

Sets a named variable to the given value in the parser.

If this variable already has a value, the old value will be overwritten with the new value.

```crmscript
Parser p;
p.setVariable("firstName", "John");
```

### Void addVariable(String field, String value)

Similar to `setVariable()`.

## Get info

### String getVariable(String name, Integer row)

Retrieves the value of a named variable at the given index.

```crmscript
p.getVariable("firstName", 0);
```

## Run parser

### String parseString(String stringToParse)

Parses a text and returns the result.

```crmscript
Parser p;
String output = p.parseString("Hello [[firstName]] [[lastName]]!\n");
```

### String evaluateString(String stringToParse)

Parses the text and returns the outcome of a RETURN statement within the text.

## Statistics

### Integer getVariableCount(String name)

Counts the occurrences of a named variable in the parser instance.

```crmscript
print(p.getVariableCount("firstName").toString());
```

<!-- Referenced links -->
[1]: reply-template.md
