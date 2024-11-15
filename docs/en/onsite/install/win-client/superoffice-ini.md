---
title: SuperOffice.ini
uid: superoffice_ini
description: SuperOffice.ini
author: {github-id}
keywords:
topic: reference
# envir:
# client:# online, web, win, pocket, or mobile
---

# SuperOffice.ini

*SuperOffice.ini* - archive settings, datapath, templates override

* extra info about the servers SuperOffice.ini
* creating the ODBC if does not exist

The configuration file for SuperOffice Win client has several parameters that describe the program’s database environment. From CRM 7 a *SuperOffice.config* file is also required since NetServer is used by windows client.

All connections between a database/archive and the program are governed by this configuration file.

*SuperOffice.INI* is created on installation and does not normally need to be changed but there are cases where it may be useful to change some of the parameters in it.

There are several sections of parameters and they are described below.

## \[SuperOffice\]

Description of the Database and Archive connections.

| Parameter | Description |
|-----------|-------------|
| archivepath= | Defines where documents in S&M will be saved. Documents may be read from the other archivepaths but saved in default only |
| archivepath2= | Alternative document folder. Not needed but may be useful if satellites have access to the central SO_ARC folder as well. You can have up to 8 alternative archive paths. |
| Local_ArchivePath= | Defines where documents in Sales & Marketing will be stored when user is on Travel<br>Default value is: %localappdata%\SuperOffice\SO_LOCAL |
| Local_archivepath2= | Alternative document folder from which documents can be read while the user is on Travel. Not needed but may be useful if travelusers have access to the central SO_ARC folder as well. By default, only the traveluser's documents from the previous and current period will be copied. |
| Datapath= | ODBC source used by the S&M windows client. Defines the location of the database. |
| Local_DataPath= | Defines the location of the local database when on Travel. Not needed if a built-in database is used. |
| GlobalPrefix= | If you use another prefix than the default CRM7. |
| GlobalTravelPrefix= | If this is set, all clients that will either do local updates or generate a prototype must have this prefix set. |
| CRMCaption= | You may set your own caption so it's easier to separate which version you're logged in to if you are running several installations on your computer. |
| SOCachePath= | SOCachePath will default to the user’s local settings folder rather than the Windows directory if the SOCACHE folder does not exist in WINDOWS already. |
| templatepath= | Defines where templates are located. Not needed, if not set defaults to SO_ARC\Template |
| EnableHdbCache= | Setting it to 0 means SuperOffice does not cache writes |
| LocalDbEngineParam= | If not present, it will default to '-c 16m' meaning 16 MB of local cache memory for the built-in database engine. |
| ProtoServerPath= |Full path to the folder you want the prototypes to be created in (as viewed from the server). This should always be a local path (example: C:\SuperOffie\SO_Proto). This path is going to be used when SuperOffice tells the SQL Server to create a new prototype database.<br>This is needed only on computers used for generating prototypes other than for build-in database (MS SQL Express, Sybase). |
| ProtoClientPath= | Full path to the folder where prototypes reside (as viewed from the client computer). This path should always be a network path (UNC path), or a mapped drive. If you choose mapped drive, be sure all clients have it mapped the same way.  Needed only if MS SQL Express or Sybase is used as a Travel database. |

The only parameters that **must** be specified are `archivepath` and `datapath`.

If the other parameters do not exist, they are given values that are determined by the archivepath, for example:

```text
templatepath= "archivepath"\TEMPLATE
```

> [!NOTE]
> You can add further archive paths, for example, `archivepath2`, `archivepath3`, and so on. The same goes for `local_archivepath2`, `local_archivepath3`.

### Using the Datapath parameter

`Datapath for SQL`

An ODBC data source must be defined, and `datapath` must begin with *_ODBC:,* followed by the Data Source Name.

> [!NOTE]
> You must enter ODBC in uppercase. If you have not already defined a Data Source Name for the database, use the name *SuperOffice*.

## \[Error\]

Defines more comprehensive Error Logging

If required, you can define that error logging will be more comprehensive than that specified by the default setup.

For DBSetup database error logging see [DBSetup.exe page][1].

| Parameter | Description |
|-----------|-------------|
| EnableDebug=0/1 | Turn debug logging off/on |
| Truncate=0/1 | Allow log file to keep growing beyond 20K. |
| LogPath= | Where log is saved. Defaults to SO_ARC\DATA |
| OLEDBLogFile= | Where log is saved from reporter components. Defaults to LogPath. |
| EnableReporterLog=0/1 | Starts logging from reporter components. You need to have EnableDebug=1 as well. |
| EnableOLEDBLog=0 to 5 | Determines what level of details the OLE-DB provider logs. |
| EnableRibbonLog=0/1 | Enable debug logging from Ribbons off/on |
| EnableSoArcLog=0/1 | Enable debug logging from SO_Arc document plugin off/on |

### Log levels

* 1 = SQL logging only
* 2 = also report component creation/destruction
* 3 = report method calls - should be sufficient in most cases
* 4 = report sub method calls
* 5 = report mind-numbing detail

### Example

```text
[Error]
EnableDebug=1 (enable comprehensive error logging)
Truncate=0 (do not truncate the log once it reaches the default maximum size)
Logpath=C:\SO_ERROR.LOG (where the log file is saved, if not set it defaults to \so_arc\data\so_log.txt)
OLEDBLogFile=c:\so_arc\oledb.log (if not set, will use the same as logpath)
EnableReporterLog=1
EnableOLEDBLog=1 (you may set a value between 1 and 5, 3 is recommended)
```

If you enable the comprehensive error logging function, you must remember to disable it afterward, or the hard disk will fill up.

To disable it, enter the following:

```text
[Error]
EnableDebug=0
```

## \[Client\]

In the central SuperOffice.ini file. Used to define how the default client is set up when installing.

| Parameter | Description |
|-----------|-------------|
| PrefLang | This is the suggested language when installing a new client. PrefLang=NO will suggest that you install a new client workstation with Norwegian language files. This may be overridden during setup. |
| PrefMailClient | This is the suggested mail client used on new clients. Options are: <br>Outlook2007 – MS Outlook 2007 and newer<br>Notes – Notes Mail Link<br>Other – the default mail client/Simple Mapi solution. Note – Simple Mapi is ANSI compatible only (ref Microsoft) |
| PrefWordProcessor | Default editor to use. Options are:<br>Word2007 – Microsoft Word 2007 and newer<br>RTF – all other editors. Note - when you double click a document with this extension in Windows explorer it should open the editor you want to use.|

## \[ServerSetup installation\]

In the central SuperOffice.ini file.

| Parameter | Description |
|-----------|-------------|
| ServerSetup version | For information only |
| ServerSetup folder | For information only |

<!-- Referenced links -->
[1]: ../database/dbsetup-exe.md
