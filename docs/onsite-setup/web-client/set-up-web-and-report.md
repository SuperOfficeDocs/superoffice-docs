---
title: set_up_web_and_report
description: 
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
so.client: web
---

# Setup Web and Reports

If you are running Web with remote NetServer web services, this must be set up on the server running NetServer web services.

When you have completed the SuperOffice Web installation, the SuperOffice Product Configuration program is launched automatically, provided you selected I would like to launch SuperOffice Web Configuration in the final step of the installation. Otherwise, you can start it manually by selecting Start > All Programs > SuperOffice > SuperOffice Web > Product Configuration (instance name), where "instance name" is the name of the instance you want to configure (also referred to as the application title).

## Configure Reporter

After the configuration of the application, the Reporter configuration should start automatically.

![x][img1]

In the Reporter dialog, do the following:

![x][img2]

1. Add an ODBC data source and type the name in the ODBC field
2. Enter the table prefix of the database
3. The impersonate user can either be:
    * a domain user with read/write access to the document archive and rights to log on to the web server or
    * a local user on both the web server and the archive server with the same user name and password, and with read/write access to the document archive.

The latter will be the case for workgroups or other situations where a domain controller is not available to the server running Web or the server holding the document archive.

In the Domain field, specify the name of the domain if a domain user has been specified, or the name of the local computer Web is installed on if you have specified a local user. The User and Password fields should contain the user name and password for the user being impersonated. Click the **Validate** button to verify that you have entered the password correctly.

![x][img3]

In the SuperOffice Product Configuration Complete dialog, you get a summary of the installation settings you have selected. You may click **Back** to go back and make any necessary changes. When you are done, click **Finish**.

## Troubleshooting

### We get "Error code: 3, Error: System.ApplicationException: Failed to impersonate user 'xxx'. Error message:, Last error; 87 at SuperOffice.Security.Util.WindowsIdentityHelper.LogonUser(String userName, String domain, String password, LogonType logonType"

Reporter will use the Impersonate User from Archive domain, archive user, and archive password (web.config), and this user must have access to log on to the server where the web client is running. This user or the group he belongs to must be members of the list **Log on locally** in security policy. If this right is missing we will receive error 87 from Windows.

![x][img4]

### All users receive an "Error message: Unable to get file stream." when they try to preview a report

Check the rights on the Web temporary path folder (location is found in the [web.config][1] file under the Documents section).

```xml
<!-- Location of the temporary folder for streaming files.
This path must resolve to the same location for farms/clusters. -->

<add key="TemporaryPath" value="C:\temp-path" />
```

<!-- Referenced links -->
[1]: ../config-and-ini/web-config.md

<!-- Referenced images -->
[img1]: media/sixwebreportconfig1.jpg
[img2]: media/sixwebreportconfig2.jpg
[img3]: media/sixwebreportconfig3.jpg
[img4]: media/allow-log-on-locally.png
