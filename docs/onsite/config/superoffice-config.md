---
title: SuperOffice.config
uid: superoffice_config
description: SuperOffice.config
author: {github-id}
keywords:
so.topic: reference
so.envir: onsite
so.client: win
---

# SuperOffice.config

Used for NetServer config info for the Win client and MailLink.

## You will find SuperOffice.config in

a) your SuperOffice server installation folder *[server_inst]\SuperOffice*

b) and if Windows client is installed: in your locale SuperOffice folder on each of the clients, default: *C:\Program Files\SuperOffice\SuperOffice Windows*. The file will be "copied" (settings are transferred over) from the server's SuperOffice.config / SuperOffice.ini while installing.

## Application Configuration Files

An application configuration file is an XML file used to control assembly binding. It can redirect an application from using one version of a side-by-side assembly to another version of the same assembly. This is called per-application configuration.

Application configuration files contain settings specific to an application. This file contains configuration settings that the common language runtime reads (such as assembly binding policy, remoting objects, and so on) and settings that the application can read.

The configuration file for an application hosted by the executable host is in the same directory as the application. The name of the configuration file is the name of the application with a .config extension. For example, an application called myApp.exe can be associated with a configuration file called myApp.exe.config.

Read more on [MSDN][2]:

The settings you set in SuperOffice.config is transferred over to 'appname'.exe.config. They are essentially the same files. The reason 'appname'.config exists is because when the executable is run, its config file is simple the executable's name with a `.config` suffix.

## Database connection

Database connection details are in *SuperOffice.config*.

Some parts of S&M use the ODBC connection to the database, configured in the *SuperOffice.ini* file, and some use the NetServer as the connection to the database, configured in the *SuperOffice.config* file.

If Oracle SQL server is used, there are extra config settings in *SuperOffice.config* that tell the client where to find the Oracle drivers.

### Oracle settings

In *SuperOffice.config*, you do not actually need to specify the `DynamicLoadedConnectionType` and location of the Oracle driver DLLs, if they are properly installed and can be found by our algorithms. However you **can** specify them, and those specifications will be used.

On the other hand, the Server and Database specifications are **always** overridden, both in-memory in the Win client and when writing the config file for the MailLink. The override is based on the registry settings created by the Oracle ODBC client setup, **not** on whatever values may be in the *SuperOffice.config* file; and Database will always (correctly) be set to blank since it is not used by the connection string.

We have a multilevel algorithm to pick up the Oracle drivers. This is run no matter what so it should therefore work successfully at the customer without this info in the *SuperOffice.config*.

The SuperOffice configuration for Oracle is constructed as follows:

1. The Win client reads registry information about the Oracle driver ODBC setup; notably the `ServerName` value.

2. This server name overrides the SuperOffice.config file.

3. Database name is hard-set to blank; since the substitution variable `[@Database]` is not present in the configuration string that value would not have been used anyway.

4. We set `DynamicLoadedConnectionType` to *Oracle.DataAccess.Client.OracleConnection*, set major version to Oracle and minor to 11; then we analyze registry settings to locate the Oracle Home and look for driver files there (based on ODP.NET or ORACLE sections, in current user and local machine; in that order).

The bottom line is:

* The `Server` and `Database` settings in the *SuperOffice.config* file are **always overwritten**.
* `Server` is based on the registry information from the ODBC setup, while `Database` is not used and set to blank.

Oracle ODBC is generally an intermediate layer, where the actual connection information (server, listener, port, and so on) is specified in TNSNames, using the Oracle Net Configuration Assistant (netca).

The *SuperOffice.config* file on the clients may be cleaned up with a stripped version. There can be a limited amount of info in the Database and ImplicitAnonymous section. The client does not need anymore. Also, the `ArchivePath` is gone, cause we read this from *SuperOffice.ini*.

If impersonating is true then they need to update the info here along with the info for dbuser and dbpassword.

## System user

The system user is defined in the `<SuperOffice><Data><Explicit>` section.

> [!NOTE]
> We do not allow the previous default naming of the standard user, like "CRM7" and password any similar to the CRM 7 default password. You will be prompted at the upgrade to change the system user if you do.

## Enable debug

For enabling logging and set logpath, see [Enable debug][3].

## Use a seperate SuperOffice.config

To specify and use a separate SuperOffice.config, see `/INIPATH` in [Command line switches][4].

## NetServer.config

When MailLink is configured to depend on the Windows installation, MailLink will host its own NetServer. MailLink generates a valid *NetServer.config* file automatically by executing socrm.exe (This generates a config file transformed with parameters from both *SuperOffice.ini* and *SuperOffice.config*). This file is placed in *%AppData%\SuperOffice\MailLink\NetServer.config*. Changing the *SuperOffice.config* file will automatically update the *NetServer.config* used by MailLink. Changes that are done manually in the generated *NetServer.config* file are lost when we regenerate a new *NetServer.config* file.

If you want to have a dynamically loaded module (such as a document plugin), you need to add this in the *SuperOffice.config* file when using a Windows client. (If you use Web, you need to add this to the Web client's *web.config* file.)

## Mapping SuperOffice users to Active Directory

This configuration is required when the user executing SoAdmin has limited rights to the domain or if there is a complex domain infrastructure in place. This will typically be the case in large organizations, organizations with multiple domain controllers, when using hosting providers or in Citrix environments.

This advanced configuration has to be tweaked manually in the SuperOffice.config file. These settings are not added by default when installing the Windows client, so they have to be added manually. [Read more in this blog][5].

## FeatureToggles - Onsite Windows client

Some features are enabled by "FeatureToggles".
This is how you do it for the Onsite Windows client:

Both [SOUSER.INI][6] and SuperOffice.config files for each client need to be updated.

**How to update SuperOffice.config:**

To enable toggled features - you need to add 2 sections manually in your web.config file:


1. Open web.config file for your web installation
2. There are 2 sections to include into the web.config

    ***a) Under sectionGroup name="SuperOffice"***

      Under ``` <configuration> -> <configSections> -> <sectionGroup name="SuperOffice"> ```

      Section to add:
      ```
      <sectionGroup name="FeatureToggles">
        <section name="State" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      </sectionGroup>
      ```
      _Original without the needed section:_
      
      ![image](https://user-images.githubusercontent.com/42037679/142607241-bc958091-640c-4495-91ac-57cbb3bbed15.png)


      _After added the new section:_
      
      ![image](https://user-images.githubusercontent.com/42037679/142607385-7cb214e0-5f1d-42c8-812e-8903f7255921.png)

    ***b) Under configuration -> SuperOffice***

      Section to add:
      ```
      <FeatureToggles>
        <State>
          <add key="FeatureToggleName1" value="true" />
          <add key="FeatureToggleName2" value="true" />
        </State>
      </FeatureToggles>
      ```
      Update the key name with the feature you want to add.
      
      You can see some of the previous FeatureToggle names here: https://docs.superoffice.com/onsite/config/web-config.html#feature-toggles
  
      _Original without the needed section:_
      
      ![image](https://user-images.githubusercontent.com/42037679/142607443-f768f7dc-4cd2-4096-885d-b6c58854b893.png)
  
      _After added the new section:_
      
      ![image](https://user-images.githubusercontent.com/42037679/142607468-b76acbb6-5c51-4d36-944d-82c2fd2a4b88.png)
  
3. Save the file
Restart the windows client.

<!-- Referenced links -->
[2]: https://www.microsoft.com/en-us/download/details.aspx?id=55984
[3]: ../debug/win-client.md
[4]: ../command-line-switches.md
[5]: ../../identity-management/ad/mapping-so-user-to-ad-v-7-1.md
[6]: https://docs.superoffice.com/onsite/config/souser-ini.html#FeatureToggles---Onsite-Windows-client
