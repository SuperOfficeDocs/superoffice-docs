---
title: CollectionOps
uid: whats_new_70_collectionops
description: NetServer 7.0
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: reference
---

# CollectionOps

A collection of static methods for manipulation of collections

* To/from `Dictionary<>`

* NamedValue strings

* Compare and massage arrays

Generally very null-tolerant, simplifying your code a lot

## Arrays

```csharp
bool ArraysEquivalent<T> (T[] left, T[] right)
```

Checks for contents, irrespective of order

`[2, 1, 4]` is equiv to `[1, 2, 4]`

![ALT][img1]

* `ConvertArray` applies a converter delegate to each element. But nowadays you can use LINQ to do that
* `AddToArray` makes a new, longer array
* Consider using `List<>;` but sometimes you’re stuck with arrays…

![ALT][img2]

## Dictionary of Lists

I quite often find myself using a dictionary, where the value is a list

```csharp
Dictionary<string, List<Item>>
```

This can be done quite smoothly:

![ALT][img3]

## Dictionaries

CreateDictionaryFromXXX( … ) – many overloads

* Take some kind of collection of items
* Apply a delegate to each item, to extract/make a key
* Add the key and the item to a dictionary

Most are O(n) (linear speed)

![ALT][img4]

LINQ has a completely corresponding `ToDictionary<>` extension method, but ours was first.

## ParameterBuilder

A class that will take n string items and concatenate them with front, middle, and end delimiters.

* Eliminates all those pesky if( !first ) AddComma(); first = false; constructions
* Has a static method that does everything at once
* Use it to make useful error messages!

MiddleDelimiter will be dropped when relevant (empty items).

### How to build an error message

Restrictions is an `ArchiveRestrionInfo[]`

![ALT][img5]

The error message contains multiple, indented lines, each showing one restriction.

Since `ArchiveRestrictionInfo` has an overridden `ToString` method, meant for debugging, this is easy and useful. So easy that you should really do it.

### Making a tooltip

![ALT][img6]

<!-- Referenced images -->
[img1]: media/image008.jpg
[img2]: media/image009.jpg
[img3]: media/image010.jpg
[img4]: media/image011.jpg
[img5]: media/image012.jpg
[img6]: media/image013.jpg