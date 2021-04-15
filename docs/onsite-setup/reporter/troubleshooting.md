---
title: Troubleshooting
uid: troubleshooting_web_reporter
description: Troubleshoot Reporter
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
so.client: web
---

# Troubleshooting

## We get "Error code: 3, Error: System.ApplicationException: Failed to impersonate user 'xxx'. Error message:, Last error; 87 at SuperOffice.Security.Util.WindowsIdentityHelper.LogonUser(String userName, String domain, String password, LogonType logonType"

Reporter will use the Impersonate User from Archive domain, archive user, and archive password (web.config), and this user must have access to log on to the server where the web client is running. This user or the group he belongs to must be members of the list **Log on locally** in security policy. If this right is missing we will receive error 87 from Windows.

![x][img4]

## All users receive an "Error message: Unable to get file stream." when they try to preview a report

Check the rights on the Web temporary path folder (location is found in the [web.config][1] file under the Documents section).

```xml
<!-- Location of the temporary folder for streaming files.
This path must resolve to the same location for farms/clusters. -->

<add key="TemporaryPath" value="C:\temp-path" />
```

<!-- Referenced links -->
[1]: ../config-and-ini/web-config.md

<!-- Referenced images -->
[img4]: media/allow-log-on-locally.png
