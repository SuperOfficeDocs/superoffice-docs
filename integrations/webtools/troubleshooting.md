---
uid: webtools-troubleshooting
title: Troubleshooting
description: Troubleshooting WebTools
keywords: WebTools, troubleshooting
author: Jostein K, Bergfrid Dias
date: 01.23.2024
content_type: howto
category: integration
topic: WebTools
language: en
redirect_from: /en/document/webtools/troubleshooting
---

# Troubleshooting WebTools

By understanding how SuperOffice WebTools works, it is easier to troubleshoot issues and to have a common ground when reporting and discussing wishes and issues.

## I'm running single sign-on, but the credential window pops up many times

Using single sign-on delegates the authentication to your domain controller (or the component that acts as the authentication server). Authentication will fail if the password on the local machine is different than the password stored centrally (hint: NTLM password hashes). It will also fail if the account has been locked.

## The document dialog opens instead of WebTools when I select document in archive

This is often caused by WebTools not being properly configured. Note that earlier versions of 8.0 had stability issues. The web page *WebToolsDiagnostics.aspx* can give indicators on which clients are registered with the logged-in user.

## Which types of debugging utilities are available for WebTools diagnostics?

*WebToolsDiagnostics.aspx* is, as the name suggests, a tool to give hints on the current connectivity state between SuperOffice WebTools and the browser. Information such as the version and the machine name of WebTools are displayed along with which signals clients are connected.

The registry key `LogFile` enables logging of the main actions.

> [!NOTE]
> A restart of WebTools is often necessary for applying the registry settings.

## Related content

* [What to do when SuperOffice archiving button has disappeared from Outlook?][13] - FAQ

<!-- Referenced links -->
[13]: https://community.superoffice.com/no/support-faqs/faq/what-to-do-when-superoffice-archiving-button-has-disappeared-from-outlook/

<!-- Referenced images -->
