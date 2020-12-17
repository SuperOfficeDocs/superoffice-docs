---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: doclink_registry_entries       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: DocLink registry entries # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# DocLink registry entries

The following registry entries in *HKCU\\Software\\SuperOffice\\DocLink* are available (complete list at the time of writing).

| Name | Type | Description |
|------|------|-------------|
| SupressExitWarning | REG_DWORD | Set to 1 to disable the exit warning when closing Web Tools |
| ClientId | REG_SZ | The identifier which uniquely identifies the user and machine when multiple Web Tools from the same user are connecting to one installation. Incorrect values of ClientId result in loss of functionality. |
| ProtocolLogFile | REG_SZ | The path incl filename where data sent and received through the SignalR-connection are logged. Empty or missing value results in no logging. |
| LogFile | REG_SZ | Path incl. Filename where general logging is stored. Empty or missing value results in no logging. |
| NetworkTimeoutPeriod | REG_DWORD | The default timeout-period before network-invocations are considered unresponsive. (SignalR) |
| ConnectTimeoutRatio | REG_DWORD | The default factor which NetworkTimeoutPeriod is scaled by between connection timeouts. A lower value will give more immediate reconnect attempts on connection failures, but will also lead to new connections to more quickly be deemed unsuccessful. |
| QueueLength | REG_DWORD | The default queue-length for the responsiveness-checker. |
| EnableTracing | REG_DWORD |1 to enable. Enables SignalR connection level tracing. Files are stored to %TEMP% with prefix trace_. |
| DisableHttpExpect100Header | REG_DWORD | 1 to disable. Disables the Expect: 100-continue HTTP header in violation of HTTP-spec when working with proxies. Required when working against squid-proxies. |
| ProxyUsesDefaultCredentials | REG_DWORD | 1 to enable. Use the logged-in user's Windows credentials for authenticating towards the proxy. |
| DisableTls10 | REG_DWORD | 1 to disable. Disable TLS 1.0. (Only support TLS 1.1 and 1.2) |
| ProxyCredentialType | REG_SZ | Set the credential type when authenticating towards a proxy. Valid values: Windows, Ntlm, Digest and Basic. ProxyUsesDefaultCredentials must be set to 1 for this setting to have effect. |
