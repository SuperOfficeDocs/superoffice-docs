---
title: crmscript_debug_log_messages
description: Log Messages
author:
so.date:
keywords:
so.topic: concept
---

# Log Messages

## Online - database log

You can write to and inspect the system log.

The date format is **YYYY-MM-DD**.

Messages are written to the log immediately: if your script should crash, everything logged up to that point is preserved.

The database log also works for scripts that redirect and for scripts that run in the background.

**Write to log:** `Void log(String msg)`

```crmscript
log("2020 is a leap year");
```

Use `log()` as you would use `print()`.

> [!TIP]
> You can customize logging by adding the following URL fragment: <br> `/scripts/ticket.fcgi?_sf=0&action=searchTable&table=log_events`

**Read log:**

Beside your profile picture, select the **hamburger menu**, then select **System design**. Click **Debug log** to open the **Search log** screen.

## Onsite - logfile

This is the old log, kept locally on disk.

**Write to log:** `Void logMessage(String p0)`

```crmscript
log("The next leap year is 2024");
```

**Read log:**
The log files are located in the CS install directory, for example, *E:\SuperOffice\Customer Service\log*

In browser with fcgi:

* *scripts/ticket.fcgi?_sf=0&action=searchTable&table=log_events*
* *scripts/rms.fcgi?action=dumpWarningLog&date=&lt;date&gt;*
