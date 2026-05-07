---
uid: teams-archive-file
title: Save a file from a Teams channel
description: How to save a file from a standard Teams channel to SuperOffice.
keywords: SuperOffice for Teams, Teams, archive, file, channel, save file
author:
date: 07.05.2026
version:
content_type: howto
category: integration
topic: SuperOffice for Teams
language: en
---

# Save a file from a Teams channel

When you are in a standard channel, you can save a single file to SuperOffice alongside or instead of a conversation archive. File saving is not available in chat contexts.

> [!NOTE]
> See [Archive a conversation][1] for instructions on opening the archive window.

## How the Save File option becomes available

* **Started from a message** – the **Save File** button is enabled if that specific message contains a file.
* **Started from the compose bar** – the **Save File** button is enabled if the channel contains any files. Use the file picker to select which file to archive.

## File picker status icons

| Icon | Meaning |
|---|---|
| Green check | Already archived to SuperOffice. Shows when and by whom. |
| File icon | Not yet archived. Ready to save. |
| Red warning | File is too large to archive. |

![The file picker showing a green check on an archived file, a file icon on a new file, and a red warning on an oversized file][img1]

## Limitations

* The file picker is single-select. You can save one file at a time.
* Saving a file with the same name always creates a new document in SuperOffice. Overwriting is not supported.
* The maximum supported file size is 94 MB.

<!-- Referenced links -->
[1]: archive-conversation.md

<!-- Referenced images -->
[img1]: media/teams-file-picker-status.png