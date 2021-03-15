---
title: crmscript_def
description: What is CRMScript?
author:
so.date:
keywords:
so.topic:
---

# What is CRMScript?

CRMScript is a light-weight, interpreted programming language with curly-bracket syntax. It is statically typed and supports object-oriented and imperative styles.

The CRMScript language is similar to JavaScript, with some traits of Python.

## An imperative programming style

CRMScript uses **statements**, a sequence of steps describing exactly how to do something.
The statements are grouped into sections called *code blocks*.

This is very similar to the structured programming syntax of C. However, unlike C, CRMScript is not compiled and doesn't use pointers.

## An object-oriented programming style

CRMScript is object-oriented *to some extent*. The language has a wide variety of **built-in classes**, which you can create objects from and use their methods to manipulate data. However, you can't define your own classes. Thus, think of these as **complex data types** rather than templates to extend or inherit from.

You can still build custom data structures by defining [structs][1].

## A statically and strongly typed language

Unlike most other scripting languages, including JavaScript and Python, CRMSCript is **statically typed**. This means that you can't change the type of a variable after it has been declared. CRMScript associates the type with the variable's name, not its value.

The language is also **strongly typed**, meaning there are restrictions to mixing values of different data types. For example, the `print()` function expects a String - if you pass an Integer as-is, you will get a type error.

The types are checked *before* runtime. As a bonus, type errors are detected before the code is even run. Catching this group of errors immediately means you don't have to worry about them in production. It also gives a small performance boost, because there is less checking to do at runtime.

## An interpreted scripting language

At some point, the source code must be converted into something a computer can read. With CRMScript, the code is translated **on-the-fly**, during execution. You don't need a compilation stage before it can be run. This means that your scripts are portable and can run on all platforms.

However, this also means that your scripts are "public", shared in a human-readable form. If you for some reason don't want to share your secret sauce, perhaps creating a custom application with our APIs is a better fit in your particular case.

<!-- Referenced links -->
[1]: ../fundamentals/structs.md
