---
title: Row improvements
uid: whats_new_70_rows
description: NetServer 7.0
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: reference
---

# Row improvements

## Get functions

For each unique index, we generate a .GetFromIdx( … ) method on the Row.

For each non-unique index, we generate a .GetFromIdx( … ) on the Rows collection.

Use them if you can, the indexes guarantee a quick lookup.

![ALT][img1]

Reflecting indexes from the database schema into code is done to encourage people to use them. However, if you only need one or two fields, then consider doing a custom SQL instead of fetching complete rows.

## Row objects from reader

![ALT][img2]

Points to note:

* `ReturnFields.Add` has an overload that takes a `TableInfo[]`, so you can add all fields in a table by one parameter. You can of course add any other odd fields you want as well (in a separate .Add)

* Select (and many other places that have restrictions) has a RestrictionAnd(r), which is short form for if( Restriction == null ) Restriction = r else Restriction = Restriction.And(r).  This again eases flow and makes the code easier to read

* You can construct Row objects from a reader, just as long as you have all the fields available. This will also transfer all Sentry info

* You can also GetXXX any fields at any time, of course

## Row documentation

We have improved the documentation on the Row/Rows objects

![ALT][img3]

<!-- Referenced images -->
[img1]: media/image005.jpg
[img2]: media/image006.jpg
[img3]: media/image007.jpg
