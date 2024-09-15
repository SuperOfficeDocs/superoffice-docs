---
uid: enum-selectionsystemtype
title: Enum values for SelectionSystemType
description: Lists the enum values for SelectionSystemType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# SelectionSystemType Enum

Selection system type - defines if this selection is one that is managed by the system, and what kind it is

| Name | Value | Description |
|------|-------|-------------|
|User|0|User selection, managed by users|
|TemporaryShortTermStatic|1|Temporary static selection, one per user, for short-term operations|
|PersonalForFind|2|Personal dynamic, for the Find mode in the selection panel|
|DashboardTileSelection|3|Selecton is associated with a dashboard tile|
|PersonalForDashboard|4|Personal dynamic, for dashboard tiles|
|PersonalForDashboardSecondary|5|Personal dynamic secondary, for dashboard tiles|

## Usage

* [selection](../selection.md).SystemType - Selections
