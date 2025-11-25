---
uid: service-report-parameters
title: Parameters for reports
description: Parameters for Service reports
author: SuperOffice Product and Engineering
date: 11.21.2025
content_type: reference
redirect_from: 
  - /en/service/reports/index
  - /en/service/reports/parameters
---

# Parameters for reports

Parameters can be defined anywhere in the report, but they look nicer when put together at the beginning of the report.

## Parameter types

* info (Only used to make headings and static text info)
* int
* string
* date
* time
* datetime
* bool
* float
* user
* category
* priority
* extraTableRelation - needs .extraTable("tableName") to specify table
* company
* typecustomer
* invoicetype
* status

## General parameter modifiers

The parameter statement is made up of several parts - the parameter name declaration, type declaration, and modifiers. These parts are separated by dots (".") and look like function calls.

| Statement | Description |
|---|---|
| .parameter("pMyInt")   | Name declaration |
| .type("int")           | Type declaration |
| .prompt("Value")       | The prompt the user will see |
| .defaultValue("12345") | A default value can be provided |
| .multiple("1")         | Lets the user add multiple parameter values |

## Examples

```text
%stat.parameter("pInfo1").type("info").defaultValue("<h1 style="font-size:15pt">These are the parameters for my report</h1>")%

%stat.parameter("pMyInt").type("int").prompt("Value").defaultValue("12345").multiple("1")%
```
