---
uid: crmscript_best_practice
title: CRMScript best practices
author:
so.date:
keywords:
so.topic: reference
---

# CRMScript best practices

## Prefer readability

* Use meaningful names.
* Keep methods short and to the point.
* Use comments wisely.
* Don't use lowercase letter *l*, uppercase letter *O*, or uppercase letter *I* as 1-character variable names.

## Put declarations at the beginning of a scope

Putting all declarations at the top of each script, struct, or method before the statements is a good coding practice. This:

* Gives you a cleaner code.
* Makes it easier to scan for and find variables.
* Makes it less likely that you attempt to use something before it is declared.

## Initialize variables

Preferably initialize variables when you declare them. It makes your script cleaner and avoids undefined values.

## Use comments wisely

Don't repeat the obvious. If the variable name is `firstName` ... Rather focus on the *how*  and *why*.

### Top (file) level comments

A CRMScript file may have a top-level overview containing stuff such as a copyright notice and author information.

### Method and struct comments

Parameters must be documented. Describe what a method does (without repeating its name).
Place comments above the code they pertain to, not at the end of the code line.

## Quotes

CRMScript lets you choose between single and double quotes for strings. Don't mix quotes in the same script. Pick a style and stick to it.

## Type checking

It is a good practice to check the actual type of your value and to check you do indeed *have* a value before using it.
