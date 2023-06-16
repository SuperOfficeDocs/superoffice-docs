---
uid: enum-selectionuniontype
title: Enum values for SelectionUnionType
description: Lists the enum values for SelectionUnionType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# SelectionUnionType Enum

How should the inputs of a combined selection be combined

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Combination type is unknown/indefined|
|SubtractRightFromLeft|1|All of left, except where it overlaps with right|
|SubtractLeftFromRight|2|All of right, except where it overlaps with left|
|Intersect|3|Those present in left AND right only|
|XOR|4|Those present in left or right, but not both|
|Union|5|All, but no duplicates for those present in left and right|

## Usage

* [selection](../selection.md).combinationType - Selections
