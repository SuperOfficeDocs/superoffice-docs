---
title: superoffice_config      
description: SuperOffice.config
author: {github-id}
keywords:
so.topic: reference            # article, howto, reference, concept, guide
so.envir: onsite             # cloud or onsite
so.client: win              # online, web, win, pocket, or mobile
---

# SuperOffice.config

Used for NetServer config info for the Win client and MailLink.

## You will find SuperOffice.config in

a) your SuperOffice server installation folder *\[server\_inst.-path\]\\SuperOffice\\*
b) and if Windows client is installed: in your locale SuperOffice folder on each of the clients, default: *C:\\Program Files\\SuperOffice\\SuperOffice Windows*. The file will be "copied" (settings are transferred over) from server's SuperOffice.config / SuperOffice.ini while installing.

## Application Configuration Files

An application configuration file is an XML file used to control assembly binding. It can redirect an application from using one version of a side-by-side assembly to another version of the same assembly. This is called per-application configuration.

Application configuration files contain settings specific to an application. This file contains configuration settings that the common language runtime reads (such as assembly binding policy, remoting objects, and so on), and settings that the application can read.

The configuration file for an application hosted by the executable host is in the same directory as the application. The name of the configuration file is the name of the application with a .config extension. For example, an application called myApp.exe can be associated with a configuration file called myApp.exe.config.

Read more on [MSDN][2]:

The settings you set in SuperOffice.config is transferred over to 'appname'.exe.config. They are essentially the same files. The reason 'appname'.config exists is because when the executable is run, it's config file is simple the executable's name with a `.config` suffix.

## Database connection

Database connection details are in *SuperOffice.config*.

Some parts of S&M uses the ODBC connection to the database, configured in the *SuperOffice.ini* file, and some uses the NetServer as connection to the database, configured in the *SuperOffice.config* file.

If Oracle SQL server is used, there are extra config settings in *SuperOffice.config* that tells the client where to find the Oracle drivers.

### Oracle settings

In *SuperOffice.config*, you do not actually need to specify the `DynamicLoadedConnectionType` and location of the Oracle driver DLLs, if they are properly installed and can be found by our algorithms. However you **can** specify them, and those specifications will be used.

On the other hand, the Server and Database specifications are **always** overridden, both in-memory in the Win client and when writing the config file for the MailLink. The override is based on the registry settings created by the Oracle ODBC client setup, **not** on whatever values may be in the *SuperOffice.config* file; and Database will always (correctly) be set to blank since it is not used by the connection string.

We have a multilevel algorithm to pick up the Oracle drivers. This is run no matter what so it should therefore work successful at the customer without this info in the *SuperOffice.config*.

The SuperOffice configuration for Oracle is constructed as follows:

1. The Win client reads registry information about the Oracle driver ODBC setup; notably the `ServerName` value.

2. This server name overrides the SuperOffice.config file.

3. Database name is hard-set to blank; since the substitution variable `[@Database]` is not present in the configuration string that value would not have been used anyway.

4. We set `DynamicLoadedConnectionType` to *Oracle.DataAccess.Client.OracleConnection*, set major version to Oracle and minor to 11; then we analyze registry settings to locate the Oracle Home and look for driver files there (based on ODP.NET or ORACLE sections, in current user and local machine; in that order).

The bottom line is:

* The `Server` and `Database` settings in the *SuperOffice.config* file are **always overwritten**.
* Server is based on the registry information from the ODBC setup, while database is not used and set to blank.

Oracle ODBC is generally an intermediate layer, where the actual connection information (server, listener, port, and so on) is specified in TNSNames, using the Oracle Net Confguration Assistant (netca).

The *SuperOffice.config* file on the clients may be cleaned up with a stripped version. There can be a limited amount of info in the Database and ImplicitAnonymous section. The client does not need anymore. Also, the `ArchivePath` is gone, cause we read this from *SuperOffice.ini*.

If impersonating is true then they need to update the info here along with the info for dbuser and dbpassword.

## System user

The system user is defined in the `<SuperOffice><Data><Explicit>` section.

> [!NOTE]
> We do not allow the previous default naming of the standard user, like "CRM7" and password any similar to the CRM 7 default password. You will be prompted on upgrade to change the system user if you do.

## Enable debug

For enabling logging and set logpath, see [Enable debug][3].

## Use a seperate SuperOffice.config

To specify and use a separate SuperOffice.config, see `/INIPATH` in [Command line switches][4].

## NetServer.config

When MailLink is configured to depend on the Windows installation, MailLink will host its own NetServer. MailLink generates a valid *NetServer.config* file automatically by executing socrm.exe (This generates a config file transformed with parameters from both *SuperOffice.ini* and *SuperOffice.config*). This file is placed in *%AppData%\\SuperOffice\\MailLink\\NetServer.config*. Changing the *SuperOffice.config* file will automatically update the *NetServer.config* used by the MailLink. Changes done manually in the generated *NetServer.config* file are lost when we regenerate a new *NetServer.config* file.

If you want to have a dynamically loaded module (such as a document plugin), you need to add this in the *SuperOffice.config* file when using a Windows client. (If you use web, you need to add this to the Web client's *web.config* file.)

## Mapping SuperOffice users to Active Directory

This configuration is required when the user executing SoAdmin has limited rights to the domain or if there is a complex domain infrastructure in place. This will typically be the case in large organizations, organizations with multiple domain controllers, when using hosting providers or in Citrix environments.

This advanced configuration has to be tweaked manually in the SuperOffice.config file. These settings are not added by default when installing the Windows client, so they have to be added manually. [Read more in this blog][5].

<!-- Referenced links -->
[2]: https://www.microsoft.com/en-us/download/details.aspx?id=55984
[3]: ../debug/win-client.md
[4]: ../command-line-switches.md
[5]: ../../identity-management/ad/mapping-so-user-to-ad-v-7-1.md
