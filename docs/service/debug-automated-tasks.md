---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: debug_automated_tasks_in_service       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Debug automated tasks in Service # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Debug automated tasks in Service

In Service, there are several tasks that are automated and run on a set schedule on the server. These tasks are carried out by the executables located in the bin folder of your Service installation.

This article will cover the most used executables and how to debug them. In addition to the parameters provided for the executables below, they all take the parameter `--help` to display more information.

If you want to store the output of running the executable in the command line to a file, add `>> <filename>` at the end of the command. Keep in mind that all output will be in the logfile and will not be shown in command prompt.

Example: `ejournalCron -maxdebug >> ejournalcronlog.txt`

## ejTermSetup

Used for priming your SuperOffice database with Service data. This executable should only be completed once for a healthy installation.

* --base-path: By setting this you can override the suggestion you get for basePath when running ejTermSetup.
* --unix-socket: Obsolete - no longer in use
* --config-file: Path to config file which ejTermSetup can use for input values. Makes it possible to run ejtermsetup.exe without user input.
* --noconfirm: When this is set we will use the default values for questions asked, like use MSSQL database and so on.
* --delete-tables: Obsolete - no longer in use and will be removed

## dbi

Used for executing your dbi tasks. Can be executed with parameters to see more debug information.

Usage: `dbi [OPTION] <domain>`

**Options:**

* -force Try to run all schedules.
* -debug Display debug information.
* -asap \<id> Run dbi schedule \<id> as soon as possible.
* -param \<name>=\<value> Set a dbi parameter from command line.
* -maxDebug Display all debug information (enables debug).
* -dump Dump XML package to console.
* -convert \<id> Convert external datasource to DBI Agent.
* -about Show about.

Example: `dbi -asap 12 -force -debug support.yourdomain.com`

## ejournalCron

Executed by the ejSchedule service every minute through the ejCrontab.txt file together with importMail.

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

As with most other executables, ejournalCron can be executed with parameters for debugging purposes.

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

## ejOutbox

Responsible connecting to the SMTP server and sending messages from Service.

**Usage:** `ejOutbox [OPTION] domain`

**Options**:

* **-force** Try to send all mails
* **-debug** Display debug information.
* **-maxDebug** Display all debug information (enables debug).
* **-smtpDebug** Display SMTP session information.
* **-about** Show about.

## ejSender

Responsible for sending out Mailings.

**Usage:** `ejSender [OPTION] domain`

**Options:**

* -shipmentId \<id> Id of the shipment. Required
* -timestamp Unix timestamp. Required.
* -senderNr \<sender number> Which sender this ejSender will be.
* -force Force the processes.
* -debug Display debug information.
* -maxDebug Display all debug information (enables debug).
* -doSending Start sending.
* -doPopulate Start populating.
* -about Show about.

Example: `ejSender -shipmentId 1 -timestamp 1464350088 -maxDebug support.yourdomain.com`

## importMail

Responsible for importing mail into Service.

**Usage:** `importMail [OPTION] domain`

**Options:**

* **-force** Try to import all mails.
* **-debug** Display debug information.
* **-maxdebug** Display all debug information (enables debug).
* **-interactive** Confirm each mail import.
* **-socketdebug** Debug socket activity (lots!).
* **-delay** Delay import for a random number of seconds.
* **-noinbox** Do not import inbox files.
* **-file** Import from a file.
* **-filter** Set `mail_in_filter.id`. Required together with file.
* **-about** Show about.

**Example:** `importMail -file "C:\Customer Service\text\Inbox\inbox.298231" -filter 13 support.yourdomain.com`

## upgrade

Used after upgrading your Service installation. Should usually be run by just executing upgrade.exe without any parameters unless you need something specific.

Can also be used to install/update things that were left out earlier. (As an example you may have chosen to not install FCGI, but want to install it at a later point, in which case you run upgrade -onlyFCGI)

**Usage:** `upgrade [options] [-u <username] [-d <domain>]`

* **-noconfirm** Do not confirm actions.
* **-dbDebug** Displays database debug information.
* **-verbose** Print debug info to stdout
* **-matchCrmUsername** Match username between ejuser and associate for unassigned ejusers
* **-recreateIndices** Recreate all indices in database
* **-u \<username>** Set user name of the person upgrading
* **-d \<domain>** Set the domain you wish to upgrade
* **-forcePackages** Force upgrade of unlocked packages
* **-force** Force upgrade of tables
* **-basePath \<path>** Set the base path of the installation
* **-resetSequences** Rebuild the sequence table
* **-onlySystemTemplates** Install new system templates
* **-onlyFCGI** Only installs the FastCGI handlers
* **-onlyRoleReport** Only generate report of role upgrade changes
* **-onlyMailingTemplates** Only update mailing templates
* **-onlyPackages** Only upgrade the packages
* **-config-file** Read a name-value file containing automated answers for all questions during upgrade
