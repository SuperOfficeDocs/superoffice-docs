---
title: ejournalCron
uid: automated_task_ejournalcron
description: Automated tasks in Service - ejournalCron
author: {github-id}
keywords: service
topic: reference
envir: onsite
# client:
---

# ejournalCron

Executed by the **ejSchedule** service every minute through the ejCrontab.txt file together with **importMail**.

Apart from importing mail, this file executes most automated tasks in Service.

Tasks in the order they are executed:

```text
doActivateTicket()
doInternalLogOut()
doCheckTicketAlerts()
doWarnActiveTickets()
doEjscripts()
doRemoveDeletedTickets(14)
doRemoveOldAutoSaves()
doRemoveExpiredNotifications()
deleteSentMail(m_db)
doFork()
doSendBatch()
doPopulateShipments()
buildFaq()
checkDiskSpace()
checkLicenseExpiration()
checkSessions
doSendStatEmail
doSendUsageStat
```

As with most other executables, **ejournalCron** can be executed with parameters for debugging purposes.

**Usage**: `ejournalCron [OPTION] domain`

**Options:**

* **-dbDebug** Displays database debug information
* **-force** Will force all jobs to run no matter when they are scheduled
* **-debug** Display debug information
* **-maxdebug** Display all debug information (enables debug)
* **-about** Show about
* **-noSender** Will not start the mailing job
* **-noOutbox** Will not start the job sending out emails
* **-noDBI** Will not start the DBI sync job

**Example:** `ejournalCron -maxdebug -noSender support.yourdomain.com`
