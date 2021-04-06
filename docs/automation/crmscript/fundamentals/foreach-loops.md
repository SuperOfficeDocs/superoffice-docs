---
uid: crmscript_fundamentals_loops_foreach
title: Loops - foreach
author:
so.date:
keywords:
so.topic:
---

# Loops - foreach

A `foreach` loop is a control structure for repeating a block of code a number of times. It will run as long as there are more elements in the collection.

The definition has 5 parts:

* keyword **foreach**
* initialization enclosed in parentheses:
  * declaration of the loop variable
  * keyword **in**
  * collection to iterate
* 1 or more statements enclosed in curly brackets

```crmscript!
String[] mTwain;
mTwain.pushBack("The secret");
mTwain.pushBack("of");
mTwain.pushBack("getting ahead");
mTwain.pushBack("is");
mTwain.pushBack("getting started");

foreach (String s in mTwain) {
  print(s + " ");
}
```

## Initialization

The statement in the parenthesis initializes the iterator variable for the loop. The iterator must be declared as the same type as the collection. For example, if your array is of type String, then the iterator must be a string as well.

You can loop through any type of collection with `foreach`, even your own [structs][1].

## Usage

You should use a `foreach` loop when you would use a `for` loop with the following pattern:

```crmscript
for (Integer i = 0; i < array.length(); i++) {
 print(array[i]);
}
```

This is a more compact structure that and handles the indexing for you. It is also faster!

> [!NOTE]
> The foreach statement is used to iterate through the array to get the information that you want, but can not be used to add or remove items from the source array to avoid unpredictable side effects.<br>Arrays of intrinsic types, such as String or Integer, are passed by value, while an array or a struct is passed by reference. Therefore, while inside a `foreach` loop, you can update a struct property, but not a String value.

<!-- Referenced links -->
[1]: structs.md
