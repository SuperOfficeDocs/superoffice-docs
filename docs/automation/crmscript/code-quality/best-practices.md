---
uid: crmscript_best_practice
title: CRMScript best practices
author: Bergfrid Dias
so.date: 10.21.2021
keywords: CRMScript, best practices, performance
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

## Security

Don't use **USEC** variable as login_secret or preview_secret in web panels. This is obsolete since version 8.1 where we introduced unified log-in and you do not need to authenticate the user for viewing screens/data coming from Service in the sales client. It is also a security risk!

## API usage

* Don't try to create an app with CRMScript. Scripts are great for small tweaks and customizations.

* Don't use the **NetServer agents** in a CRMScript unless absolutely necessary. Using SearchEngine or the classes that don't start with NS... will use fewer resources and be faster.

## Optimize searches

* Limit searches using SearchEngine to return **only the fields and rows you need**. Use `addCriteria()` for this. Even though not seen when running as a scheduled task, it will still take up resources. Also, for Online, set up the scheduled task to run just when needed, do you really need to be updated all the time?

* Don't add a SearchEngine inside another SearchEngine you're looping through.

* Do you need to search for updated information, or could you use a **webhook**? Be aware of cascading effect, any changes you do to an entity will trigger a webhook to be signaled to those who subscribe to it.
