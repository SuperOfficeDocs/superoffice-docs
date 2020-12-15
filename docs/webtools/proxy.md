---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: proxy       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Web Tools and Proxy # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Web Tools and Proxy

Both Mail Link and Web Extensions support connection via proxy server. It automatically inherits proxy settings from Internet Explorer. If the proxy server doesn't require authentication no changes to the configuration are required.

## Log in with Windows credentials

If the proxy server requires a user to log in with his windows credentials, you can instruct both Mail Link and Web Extensions to do so.

Add this key (type dword) with value 1:

**For Web Extensions (TrayApp):**

`HKCU\Software\SuperOffice\DocLink\ProxyUsesDefaultCredentials`

**For Mail Link:**

`HKCU\Software\SuperOffice\MailLink\ProxyUsesDefaultCredentials?`

By setting ProxyUsesDefaultCredentials to 1 will Web Tools authenticate with the credentials of the currently logged on user.

## Support for forced authentication type

Since SuperOffice 8.0.6110 (8.0 SR4) we support proxy authentication with specified authentication type. Both Web Extensions and Mail Link support forcing a credential type for the proxy authentication.

There are two new registry entries - one for Mail Link and one for Web Extensions:

Setting `HKCU\Software\SuperOffice\{DocLink|MailLink}\ProxyCredentialType` (type string) to either Windows, Ntlm, Digest or Basic will use the corresponding authentication schemes.

The setting `HKCU\Software\SuperOffice\{DocLink|MailLink}\ProxyUsesDefaultCredentials` should be set to 1 if ProxyCredentialType is set.

### Examples

For Windows authentication type, add this key (type string) with value *Windows*:

**For Web Extensions (TrayApp):**

`HKCU\Software\SuperOffice\DocLink\ProxyCredentialType`

**For Mail Link:**

`HKCU\Software\SuperOffice\MailLink\ProxyCredentialType`
