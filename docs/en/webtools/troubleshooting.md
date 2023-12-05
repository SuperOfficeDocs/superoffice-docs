---
title: Troubleshooting
uid: webtools-troubleshooting
description: Troubleshooting WebTools
author: {github-id}
keywords: WebTools
so.topic: howto
# so.envir:
# so.client:
---

# Troubleshooting WebTools

By understanding how SuperOffice WebTools works, it is easier to troubleshoot issues and to have a common ground when reporting and discussing wishes and issues.

## I'm running single sign-on, but the credential window pops up many times

Using single sign-on delegates the authentication to your domain controller (or the component that acts as the authentication server). Authentication will fail if the password on the local machine is different than the password stored centrally (hint: NTLM password hashes). It will also fail if the account has been locked.

## The document dialog opens instead of WebTools when I select document in archive

This is often caused by WebTools not being properly configured. Note that earlier versions of 8.0 had stability issues. The web page *WebToolsDiagnostics.aspx* can give indicators on which clients are registered with the logged-in user.

## Which types of debugging utilities are available for WebTools diagnostics?

*WebToolsDiagnostics.aspx* is, as the name suggests, a tool to give hints on the current connectivity state between SuperOffice WebTools and the browser. Information such as the version and the machine name of WebTools are displayed along with which signals clients are connected.

The registry keys `LogFile` and `ProtocolLogFile` enable logging of the main actions and the SignalR-protocol respectively.

> [!NOTE]
> A restart of WebTools is often necessary for applying the registry settings.
