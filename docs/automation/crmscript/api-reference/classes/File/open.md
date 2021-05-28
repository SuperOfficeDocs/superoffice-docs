---
uid: crmscript_class_file_open
title: File.open(String filename, String mode)
description: CRMScript method in the File class that opens the file to be available for other calls
intellisense: File.open
sortOrder: 343
keywords: open(String,String), open(String,String,String)
so.topic: reference
---

# open()

Opens the file to be available for other method calls.

You can optionally provide a codepage.

## Methods

* File.open(String filename, String mode)
* File.open(String filename, String mode, String codepage)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| filename String | Path to the file |
| mode | String | How to open the file |
| codepage | String | Optional. What text codepage the file is in.<br>Default is ISO-8859-1 (Latin-1), but UTF-8 is common for Unicode text files. |

### Modes

| Mode | Description |
|---|---|
| r or rb | Open file for reading. |
| w or wb | Truncate to zero length or create a file for writing. |
| a or ab | Append; open or create a file for writing at the end-of-file. |
| r+ or rb+ or r+b | Open file for update (reading and writing). |
| w+ or wb+ or w+b | Truncate to zero length or create a file for update. |
| a+ or ab+ or a+b | Append; open or create a file for update, writing at end-of-file. |
