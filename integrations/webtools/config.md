---
uid: webtools-configure
title: Configure WebTools
description: How to configure WebTools.
keywords: configure WebTools, SiteInfo, registry
author: H.O. Waaler, Jostein K, Bergfrid Dias
date: 01.23.2024
content_type: howto
category: integration
topic: WebTools
deployment: onsite
language: en
redirect_from: /en/document/webtools/config
index: true
---

# Configure WebTools

Configuration in SuperOffice WebTools can be segmented into configuration stored per site in the **SiteInfo** files and configuration stored in the **Windows Registry**.

## SiteInfo

The encrypted SiteInfo files contain all connectivity information such as the endpoint URL and the credentials used for authentication. The settings from the **Preferences** dialog in WebTools are also included here.

Versions before 8.0 stored SiteInfo files in the IsolatedFileStorage provided by .NET in local application data. Versions from 8.1 store the SiteInfo files in *%AppData%\SuperOffice\TrayApp* (Roaming Profiles).

There are no command-line utilities for creating, modifying, and viewing the SiteInfo files directly. All manipulation must be performed through the user interface in SuperOffice WebTools.

## Registry

Settings that are not site-specific are usually found in the registry. "Normal" installations should not require any tweaking in the registry.

### Available registry entries

The following registry entries in *HKCU\Software\SuperOffice\DocLink* are available:

| Name | Type | Description |
|------|------|-------------|
| SupressExitWarning | REG_DWORD | Set to 1 to disable the exit warning when closing WebTools |
| ClientId | REG_SZ | The identifier which uniquely identifies the user and machine when multiple WebTools from the same user are connecting to one installation. Incorrect values of ClientId result in loss of functionality. |
| LogFile | REG_SZ | Path incl. Filename where general logging is stored. Empty or missing value results in no logging. |
| DisableHttpExpect100Header | REG_DWORD | 1 to disable. Disables the Expect: 100-continue HTTP header in violation of HTTP-spec when working with proxies. Required when working against squid-proxies. |
| ProxyUrl | REG_SZ | Hardcoded URL for proxy to use |
| ProxyUsesDefaultCredentials | REG_DWORD | 1 to enable. Use the logged-in user's Windows credentials for authenticating towards the proxy. |
| ProxyCredentialType | REG_SZ | Set the credential type when authenticating towards a proxy. Valid values: Windows, Ntlm, Digest, and Basic. ProxyUsesDefaultCredentials must be set to 1 for this setting to take effect. |
| DisableTls10 | REG_DWORD | 1 to disable. Disable TLS 1.0. (Only support TLS 1.1 and 1.2) |

### When authenticating towards a proxy

* Set the credential type to Windows, Ntlm, Digest, or Basic.
* Set `ProxyUsesDefaultCredentials` to 1.

## Proxy

Both Mail Link and Web Extensions support connection via proxy server. It automatically inherits proxy settings from Internet Explorer. If the proxy server doesn't require authentication no changes to the configuration are required.

### Log in with Windows credentials

If the proxy server requires a user to log in with their Windows credentials, you can instruct both Mail Link and Web Extensions to do so.

Add this key (type dword) with value 1:

**For Web Extensions (TrayApp):**

`HKCU\Software\SuperOffice\DocLink\ProxyUsesDefaultCredentials`

**For Mail Link:**

`HKCU\Software\SuperOffice\MailLink\ProxyUsesDefaultCredentials`

By setting ProxyUsesDefaultCredentials to 1 will WebTools authenticate with the credentials of the currently logged-on user.

### Support for forced authentication type

Since SuperOffice 8.0.6110 (8.0 SR4) we support proxy authentication with specified authentication type. Both Web Extensions and Mail Link support forcing a credential type for the proxy authentication.

There are 2 new registry entries - one for Mail Link and one for Web Extensions:

Setting `HKCU\Software\SuperOffice\{DocLink|MailLink}\ProxyCredentialType` (type string) to either Windows, Ntlm, Digest, or Basic will use the corresponding authentication schemes.

The setting `HKCU\Software\SuperOffice\{DocLink|MailLink}\ProxyUsesDefaultCredentials` should be set to 1 if ProxyCredentialType is set.

For Windows authentication type, add this key (type string) with value *Windows*:

**For Web Extensions (TrayApp):**

`HKCU\Software\SuperOffice\DocLink\ProxyCredentialType`

**For Mail Link:**

`HKCU\Software\SuperOffice\MailLink\ProxyCredentialType`

<!-- Referenced links -->
