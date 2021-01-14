---
title: Built-in debugger
uid: crmscript_debug_built_in_debugger
SortOrder: 10
---

SuperOffice CRM has an integrated graphic debugger. Use it to step through scripts.

## How to run in debug mode

1. Go to **CRMScripts** in the Admin client.
2. Locate and select your script.
3. Click **Debug script** on the toolbar.

The left side will show the code, and the right side will show variables, info, and the script's status (stored in the database). You can now:

* Click **Step** to go to the next statement.

* Click a line number to set a breakpoint, and then click **Next breakpoint** to advance the script to that point

* Click a code line with a statement to run the script until that line

* Run to the end

* Stop execution of the script

> [!CAUTION]
> Use the debugger with care. Otherwise, the server will soon become swamped with processes running scripts in debug mode.

## Debug panel (onsite)

If you have an **onsite** tenant:

1. Call `enableDebug(String)` in the script with ID matching value set in */bin/rms.exe?action=debug*.
2. Then call `debugWait()` (consider it a breakpoint). This opens the **Debug** panel.

Parameters set in the **Debug** panel are stored in browser cookies and apply to your session only. This lets you debug without disturbing other users and avoids crowding the log files.

If the script is run from another browser (where the ID is different or not set), it will run as normal, ignoring all calls to `enableDebug()` and `debugWait()`. This allows you to debug in a "hot" environment.
