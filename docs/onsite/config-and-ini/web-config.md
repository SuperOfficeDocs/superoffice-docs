---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: web_config       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Web.config # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite            # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Web.config

Used by web, remote web services, service.

The web.config file is an XML file that can be changed as needed, but we recommend running the SuperOffice Web Configurator which is installed by the [web client][1]. Administrators can use configuration files to set policies that affect how applications run on their computers. Read more on [MSDN][2].

There are some SuperOffice specific sections, defined under the SuperOffice sectionGroup.

## Security

> [!WARNING]
> Do not change these values unless absolutely sure!

| Parameter | Description |
|-----------|-------------|
| Authentication | TrustedDomains(String) Check if a domain name is trusted.  Note -  separate section within the SuperOffice Security group section, it needs to be declared before it can be defined. |
| Cryptography | Cryptographic options, see table below. Note: change any of these keys at your own peril |
| Sentry | Ignore the Sentry mechanism, everything will be allowed (default 'False')<br>Relates to the Sentry system in SuperOffice. |

The sentry system can be thought of as the traffic cop, controlling access to the data in the database. Each object in Netserver has an associated sentry which is responsible for enforcing rules such as "private appointments are visible only to its owner". Sentry rules focus on ownership, group membership and user-level access.

### The *Cryptography* section is used for encrypting and decrypting user credentials

| Parameter | Description |
|-----------|-------------|
| SymmetricKey | Base64 encoded key-string as documented by System.Security.Cryptography.RijndaelManaged. |
| SymmetricSecret | String value representing the user-defined secret, used when creating a hash (signature) to verify that the encrypted-decrypted value has not been tampered with. |

### ActiveDirectoryCredentialPlugin

> [!CAUTION]
> To find and import Active Directory users NetServer WebServices need to be in the Active Directory domain. This is why we recommend [scenario 2][3] with [reverse proxy][4] so you do not expose it to the DMZ.

| Parameter | Description |
|-----------|-------------|
| Domain | ActiveDirectory domain to use when looking up users |
| Container | Container within the domain, use blank if you do not know |
| User | Domain user to log on to the domain  - needs to be able to list and view users |
| Password | Password of the domain user |

Single Sign on (SSO) if you mean that the user should not be presented with the SuperOffice login dialog will not work when using the recommended installation scenario, but the user may still authenticate with his AD username and password. Also note that using Remote web services for Web (where web and netserver are on different servers) is not supported due to [Kerberos double-hop issues][5].

## Mail

Configuration of mail parameters when using the SuperOffice Inbox. This is also the one used by Pocket CRM.

| Parameter | Description |
|-----------|-------------|
| Reader | The Key used for mail reader - default MailKit from 8.1, used to be EasyMail |
| Sender | The Key used for mail sender - default MailKit from 8.1, used to be EasyMail |
| NumberOfDaysToDownload | Change how many days to past we should download and store emails. Defaults to 180 day |

SuperOffice Inbox downloads emails from your mail box and stores them in the SuperOffice database.  
If you want to change how many days to past we should download and store emails, you can add the following key `<add key="NumberOfDaysToDownload" value="XX" />` in Mail section:

```xml
<Mail>
  <Component>
    <add key="Reader" value="MailKit" />
    <add key="Sender" value="MailKit" />
    <add key="NumberOfDaysToDownload" value="30" />
  </Component>
</Mail>`
```

Now the Inbox will download emails younger than 30 days only. If no value is set, it defaults to 180 days.

## Factory

The Factory is part of a NetServer extension mechanism to support plug-ins. To utilize the methods you must develop your own method and configure it in a specific way in the configuration file to identify that you are enhancing a provided method.

## Diagnostics

Settings related to logging.

| Parameter | Description |
|-----------|-------------|
| EnableScaffolding | Boolean value determines whether to log verbose, detailed, information. Default off, only turn on for extended debugging and do turn this off later. |
| EnableStackTracing | Should stack traces be collected by various events |
| LogError | Boolean value determines whether to log all error messages. Default = True |
| LogFailureAudit | Boolean value determines whether to log when an access failure occurs / failed authentications (default 'True') |
| LogFolder | Folder (e.g. UNC path) where the logfile is to reside. Note that the owner of the process needs to have access to manipulate files in this folder |
| LoggedServices | List of services to be logged; default blank means all, otherwise comma-separated list of service names (without the Agent suffix, for instance: BLOB, Appointment) |
| LogInformation | Log general information. This includes successful SQL's passed to the database. Only permit this option while debugging a bug. This will be a severe performance hit! (default 'False') |
| LogLongQueries | Should long-running queries be logged in textual form to a special file? default false |
| LogLongQueriesAsXML | Should long-running queries be logged to a special file (Query\_year.month.day.log) in XML serialized format, for later analysis and reruns using the QueryWorkbench tool |
| LogMail | Log mail server communication |
| LogMailFolder | Folder to output mail logs. Note that the owner of the process needs to have access to manipulate files in this folder |
| LogServiceCalls | Should calls to the service layer be logged |
| LogSuccessAudit | Boolean value determines whether to log when access is granted / successful authentications (default 'False') |
| LogTimes | Log time it takes |
| LogToEventLog | Boolean value determines whether to write message to OS Event Log. (Information Level Ignored) |
| LogToFile | Boolean value determines whether to log all Log-Levels to a file. (default 'False') |
| LogToSuperOffice | Boolean value. Log to SuperOffice Research and Product Development (Online through a WebService). If you experience poor performance during login, set this to False. |
| LogToTrace | Boolean value determines whether to log all Log-Levels to trace output. Log to a Trace that can be listened to by TraceListener. (default 'False') |
| LogWarning | Log warnings (default 'False') |
| LongQueryThreshold | Threshold for logging a long-running query, in milliseconds. Queries that execute in less than this time are not logged as long-running. The time is from the moment the SQL text is sent to the database until the first row (for a select) or the 'nn rows affected' return value is received. |

## Data / Database

### Data

The Data section group contains three sections, Database, Explicit and ImplicitAnonymous. Combined, these sections define which server and database the caller will connect, as well as what state settings to use. Which state settings take affect are determined by how the caller decides to connect, Explicit or ImplicitAnonymous.

The *Session* section relates to the lifetime of a Netserver communication session, such as the duration of a transaction, or group of transactions, and maintains the credentials defined in one of the following sections.

| Parameter | Description |
|-----------|-------------|
| Mode | String value representing the mode of the session object. Permitted values: Thread, Process and Context |

**Modes:**

* Thread: Session is stored in a thread static manner.  Each executing thread has a separate instance of session.  If the session is accessed on a different thread, it will contain a different value.  For further reference, see System.ThreadStaticAttribute.

* Process: Session is stored in a process static manner.  This is the normal option for windows applications.

* HttpContext: Recommended in ASP.NET applications. Added to prevent ASP.NET thread switches from changing identities in the middle of an ASP.net request.

* Context: Session is stored in a context static manner. For further reference, see System.ContextStaticAttribute.

* PartnerHttpContext: Helperclass for [SuperOffice.DevNet.Online.Login][6]

### Database

The *Database* section relates to location and database-vendor specific settings. Supported database servers include SQL Server and Oracle

| Parameter | Description |
|-----------|-------------|
| CommandTimeout | Integer value representing the command timeout in seconds. |
| ConnectionString | String value representing the connection string . |
| DatabaseMajor | String value representing the database. MSSQL and Oracle |
| DatabaseMinor | Integer value representing the version number of Database |
| DatabaseName | String value representing the name of the database. Also used for distinct service name. |
| Server | String value representing the computer or server name where the database resides. |
| TablePrefix | String value representing the prefix of the SuperOffice CRM tables in the database. |

**Sybase Specific Settings:**

| Parameter | Description |
|-----------|-------------|
| DynamicLoadedDataBaseDriver | String representing the location of the driver file. |
| DynamicLoadedDataBaseDriverPolicy | String representing the location of the policy file. |
| DynamicLoadedConnectionType | String representing the connection type. |

The *Explicit* section relates to employee and partner access to the SuperOffice database.

| Parameter | Description |
|-----------|-------------|
| CommonDBConnection | Boolean value determining what authentication mechanism to use when authenticating a user.<br>If this value is “True”, DBUser and DBPassword are used in the database connection.  Otherwise, the credentials provided in the authentication (e.g. **SoSession** class) will be used.  “True” is default for server (e.g. like web) applications and “False” is default for client (e.g. like Windows forms) applications. |
| DBPassword | String value representing the DBUser database password. |
| DBUser | String value representing a database username with access privileges. |
| EmployeeAllowed | Boolean value determining whether an employee is permitted access. |
| ExternalPersonAllowed | Boolean value determining whether an external person is permitted access. |
| SystemAllowed | Boolean value determining whether a system user is permitted access. |

The *ImplicitAnonymous* section relates to anonymous access to the SuperOffice database. Implicit Anonymous is what you get when you do not explicitly authenticate as a user. Usually disabled in SO.web, which uses explicit users.

| Parameter | Description |
|-----------|-------------|
| Allowed | Boolean value determining whether anonymous access is permitted. |
| DBPassword | String value representing the database password used to connect to the database. |
| DBUser | String value representing the database user (not the CRM5 user) used to connect to the database. |
| SoPassword | String value representing the SuperOffice CRM5 user password |
| SoUser | String value representing the SuperOffice CRM5 username of the Anonymous user |

## Documents

The Documents section exposes seven settings related to SuperOffice documents. It is used as a way for NetServer to know where the document archive is, what temporary directory to use, as well as exposes a way to allow NetServer to impersonate a user with read and write access to those directories if that is required. See Table Four for complete setting property definitions.

| Parameter | Description |
|-----------|-------------|
| ArchiveDomain | String value representing the ArchiveUsers domain name. |
| ArchivePassword | String value representing the password of the ImpersonateUser. |
| ArchivePath | String value representing the path to the SO\_ARC directory. The default template path is calculated from this folder if not set. |
| ArchiveUser | String value representing the ArchiveUsers domain name. |
| ArchiveDomain | String value representing the domain of the user to impersonate with |
| BufferSize | Integer value representing the internal buffer size in KB. Default buffer size is 32KB. |
| ImpersonateUser | True if impersonate is turned on. If So\_arc is located on a different server in the domain you need to turn this on. The impersonate user will also be used to write filestreams to the temp area during document |
| TemplatePath | String value representing the UNC path of template folder. (Optional) - if not set defaults to archivepath + \\Template |
| TemporaryPath | Temporary folder for working with documents. String value representing the temp directory for streaming files (must resolve to the same location for farms/clusters). |

### More than one ArchivePath

You can have more than one ArchivePath in your Web installation. You need to edit Web.config and add more Archive Paths under the Documents section:

```xml
<Documents>  
<!-- Location of SO\_ARC -->
  <add key="ArchivePath" value="E:\\SuperOffice\\SO\_ARC" />
  <add key="ArchivePath2" value="E:\\SuperOffice\\SO\_ARC2" />
```

You can add more alternative archive paths, like ArchivePath3, ArchivePath4,...

### Globalization

The Globalization section exposes two settings related to user origin values. This section allows an application's country code and whether to use the country code for all employees and external people.

Complete setting property definitions.

| Parameter | Description |
|-----------|-------------|
| ApplicationCountry | String value representing the country id for associates that are not persons (e.g. anonymous and system users).  Default is GBR (England). |
| ApplicationCountryCode | String value representing the country for associates that are persons (e.g. employees and external users). Default is GBR (England). |
| UseApplicationCountryForPersons | Boolean value determines whether to use the application's country for all persons (e.g. employees and external users). |

## Services

This section is used to specify whether an application is working locally or remotely.

| Parameter | Description |
|-----------|-------------|
| DefaultMode | String value representing the default operational mode, Local, Remote, or Switch. |
| RemoteBaseURL | String value representing the base url and filename of the NetServer web services application file, SuperOffice.Services.Stub. |
| SwitchDefault | String value representing the default mode for the switch. Can be Local or Remote. Default = Remote |
| SwitchFailover | Integer value representing the timeout before failover in seconds. Default = 60 |

## Scripting

[Read more on developer club][6]

| Parameter | Description |
|-----------|-------------|
| EnableScripting | Turn on or off the use of scripts |
| ScriptPath | Path to the scripts. Defaults to \\script if not set. |
| TimeoutLimit | Time in milliseconds allowed for the script to use. Default 20 sec. |
| MaxTimeouts | Integer value representing the number of timeouts the script are allowed before it is disabled. Default 5. Default = 5 |

## BatchService

| Parameter | Description |
|-----------|-------------|
| ServiceName | Default = SuperOffice Batch Service |
| MaxTasks | Default = 16 |
| CPUTreshold | Default = 100 |
| PollingInterval | Default = 2 |
| DiagnosticsWebUri | Default = http://localhost:8002 |
| RunTasksInProcess | Boolean value to start by IIS in the same process. Defaults to true |

## Client

In this section you add the [Reverse proxy][4] override if you want to export larger selections (Task-Export to Excel) from the web client.

| Parameter | Description |
|-----------|-------------|
| UrlSchemeOverride | http or https |
| UrlPortOverride | 80 or 443 |
| UrlHostOverride | In our examples this would be the external site; socrm.myorganization.com |
| ExportPageSize | Export large selections from the web client has a default value of 10000 rows. PS! preference has to be added in Web.config |
| ApplicationTitle | Change the title shown to the user, like My customized site name |
| HelpFilesBaseUrl | String value representing the URL to helpfiles. E.g. in large server farm environments you may point to one helpfile location. |
| HelpDispatcherUrl | Our SuperOffice helpfiles, showing correct help file language to the user. |

## WebServices

| Parameter | Description |
|-----------|-------------|
| AllowWebServiceRequests | Permit requests to web services.  Default True from 8.1  |
| WrapExceptions | Check if NetServer shall wrap and serialize exceptions, or leave it up to communication carrier (i.e. WCF) |
| RemoveInvalidXMLText | If we should remove UTF-8 characters that are not valid XML. The Text table is the only place where this filter is active. |

## WebApi

[Settings for the RESTapi][8]

| Parameter | Description |
|-----------|-------------|
| AuthorizeWithUsername | Default value true |
| AuthorizeWithTicket | Default value true |
| AuthorizeWithImplicit | Default value true |
| CORSEnable | Default value true |
| CORSOrigin | Default value enables our [SuperOfficeGmail link][9] to talk to the web client. |

## See Also

**MSDN** [Configuration files][10]

![imagef0sx9.png][11]

![images95t.png][12]

![image7tvjr.png][13]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/install-upgrade/web/Install-web/
[2]: https://www.microsoft.com/en-us/download/details.aspx?id=55984
[3]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/deployment-scenarios/
[4]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/setting-up-a-reverse-proxy-on-iis8/
[5]: https://blogs.technet.microsoft.com/askds/2008/06/13/understanding-kerberos-double-hop/
[6]: https://community.superoffice.com/login/CMS/~/link/bf56431a96cb48a1ba5ab6f29ac77cb5.aspx
[7]: https://community.superoffice.com/en/content/content/webclient/Scripting-in-the-NetServer-World/
[8]: https://community.superoffice.com/webapi/rest
[9]: https://online.superoffice.com/AppStore/superoffice-as/superoffice-gmail-link
[10]: http://msdn.microsoft.com/en-us/library/1xtk877y(VS.80).aspx
[11]: media/imagef0sx9.png
[12]: media/images95t.png
[13]: media/image7tvjr.png
