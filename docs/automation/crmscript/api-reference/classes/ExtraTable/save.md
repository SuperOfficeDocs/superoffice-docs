---
uid: crmscript_class_extratable_save
title: ExtraTable.save()
description: CRMScript method in the ExtraTable class that creates a new or updates an existing extra-table
intellisense: ExtraTable.save
sortOrder: 320
keywords: save(), save(Bool)
so.topic: reference
---

# Integer save()

Saves an extra table. If ID is set, the table will be updated. Otherwise, a new extra-table entry will be created.

You can optionally signal that the entry should be reloaded after the save.

Returns the ID of the newly saved extra-table.

## Methods

* Integer ExtraTable.save()
* Integer ExtraTable.save(Bool reload)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| reload | Bool | Optional | Whether the extra-table entry should be reloaded after the save. True = reload |
