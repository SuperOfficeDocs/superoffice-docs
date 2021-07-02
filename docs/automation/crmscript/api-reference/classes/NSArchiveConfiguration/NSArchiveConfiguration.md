---
uid: crmscript_ref_NSArchiveConfiguration
title: NSArchiveConfiguration
intellisense: Void.NSArchiveConfiguration
keywords: NSArchiveConfiguration
so.topic: reference
---

This service is used to store and fetch the configuration of an archive. The configuration consists of entities and columns; entities correspond to archive provider entities and the checkboxes you see in the bottom of standard archives. Column configuration includes both what columns should be visible, what order they are in (left to right), and whether the archive rows should be sorted by one or more columns.<para/>Note that desired columns can be set through the selectable mdo list called archiveColumns:&lt;perovider name&gt;, and entities can be set through the selectable mdo list archiveEntities:&lt;provider name&gt;. You can also use the SetChosenEntities and SetChosenColumns method of this service. The selectable mdo list implementation is suitable for data binding using mdo list controls.
