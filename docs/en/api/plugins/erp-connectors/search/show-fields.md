---
title: Showing fields in GUI or search results
uid: erp_sync_gui_vs_sync
description: Showing fields in GUI or search results
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: concept
# so.envir:
# so.client:
---

# Showing fields in GUI or search results

There are 2 mutually exclusive options for each field: Synchronization and simply showing the field value in the SuperOffice GUI.

**Synchronization** means the value is passed between the systems and stored on each side. Which ways the value passes is determined by the direction values selected in the [field mapping][1] GUI.

**Show in ERP tab** means the value will **not** be stored in SuperOffice, but rather retrieved directly from the ERP side when the user views it in the GUI. Also, these fields will not be editable (in client GUI), they will be purely for display purposes.

The main advantage of this option is that ERP values may be made visible in SuperOffice without having to synchronize the value to a SuperOffice field (either standard or user-defined).

![07][img1]

Example of setting up mapping for the available ERP fields. Available actor types are added as tabs across the top.

> [!NOTE]
> Mapping a field disables the ability to show the field in the GUI and vice versa.

![02][img2]

The **Show In Search** checkbox tells us which ERP Actor properties to display in the **Advanced Search** dialog in SuperOffice.

<!-- Referenced links -->
[1]: ../setup-mapping.md

<!-- Referenced images -->
[img1]: ../media/image007.png
[img2]: media/image002.png
