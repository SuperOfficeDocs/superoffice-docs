---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: webtools_diagnostics       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Webtools diagnostics

WebTools consist of Tray App Web Extention and MailLink.

Tray App is dependent on a constant connection to the CRM Server to work properly. If you are having connectivity issues then there are a few things you may do to troubleshoot.

## Open the WebTools Connectivity diagnostics page

This is available on the same URL as your CRM web client, typically `http://socrm.myorganization.com/SuperOffice/WebToolsDiagnostics.aspx`.

Note, if you are using SuperOffice onsite and have not yet upgraded to SuperOffice 8.0 SR1 or higher: If the same user is connected more than once, via different computers, then we do not which one to open the document on. This means that if you have been working from your home computer, but you are now connected from your office computer, the document you just asked to open may have been opened at home instead.  
From 8.0 SR1 and CRM Online R14 we check the last active computer and open the document there.

## Turn on logging

With web tools you may enable two different logfiles.

### This is the file support usually will ask for - LogFile

Open registry and add a new String value under *HKCU\\Software\\SuperOffice\\DocLink*

The value name of the new string value is LogFile and value data is the full path to a logfile where it should write diagnostics, note that the user needs write permission to the file.

![x][img1]

### Get extra logging from SignalR - ProtocolLogfile

Open registry and add a new String value under *HKCU\\Software\\SuperOffice\\DocLink*.

The value name fo the new string is ProtocolLogFile and value is the full path to a logfile where it should write

![x][img2]

## Change the default timeout value - NetworkTimeoutPeriod

The timeout value is from when a message is sent and until we expect a response. By default this is set to 1000 milliseconds, meaning 1 second. If however, you have a slow connection, this may not be enough and you may experience that Web tools looses connection. You may change the default timeout period by adding a DWORD (32bit) value with a different value. Note that the value here is in milliseconds, so adding 5000 will change the default timeout value from 1 second to 5 seconds.

![imgx][3]

<!-- Referenced images -->
[img1]: media/webtoolslog.png
[img2]: media/registrywebtoolsnetwork.png
[img3]: media/registrywebtoolsnetwork.png
