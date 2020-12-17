---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: troubleshooting_webtools       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Troubleshooting Web Tools # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: article        # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Troubleshooting Web Tools

## I'm running single sign-on, but the credential window pops up many times

Using single sign-on delegates the authentication to your domain controller (or the component that acts as the authentication server). Authentication will fail if the password on the local machine is different than the password stored centrally (hint: NTLM password hashes). It will also fail if the account has been locked.

## The document dialog pops up instead of Web Tools when I double-click a document in the archive

This is often caused by Web Tools not being properly configured. Note that earlier versions of 8.0 had stability issues. The web page *WebToolsDiagnostics.aspx* can give indicators on which clients are registered with the logged-in user.

## Which types of debugging utilities are available for Web Tools diagnostics?

*WebToolsDiagnostics.aspx* is, as the name suggests, a tool to give hints on the current connectivity state between SuperOffice Web Tools and the web browser. Information such as the version and the machine name of Web Tools are displayed along with which signals clients are connected.

The registry keys `LogFile` and `ProtocolLogFile` enable logging of the main actions and the SignalR-protocol respectively.

> [!NOTE]
> A restart of web tools is often necessary for applying the registry settings.
