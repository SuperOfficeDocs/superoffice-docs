---
# Mandatory fields.
title: erp_api_pluginresponseinfo # (Required) Very important for SEO.
description: Sync Connector API - PluginResponseInfo# (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# PluginResponseInfo

`PluginResponseInfo` exists for the connector to be able to respond with more than just a true or false, but also an explanation. For user interaction methods (such as creating an actor from the SO GUI), the explanation can be directly displayed to the user.

However, for the background synchronization tasks (detecting changes and transferring them to the other side), we will have to log them and possibly find a way to display urgent messages to the user in an asynchronous way.

> [!NOTE]
> As can be seen in the return types of `IErpConnector`, there are numerous types of `PluginResponseInfo` objects. These are all inherited from `PluginResponse`, and are given an extra property that will contain the main object that Erp Sync is interested in. The `PluginResponse` object will in these cases be a carrier that can report back to Erp Sync about any messages, warnings, or failures that may have happened during the operation at the Sync Connection side. Error and exception messages should be sent back using these carriers. **Exceptions should not be thrown if at all avoidable.**

## Members

| Member | Type | Description |
|---|---|---|
| IsOk | bool | Answer to the question / An indication if the operation went well. |
| State | ResponseState | More detailed status than IsOk. (public) |
| UserExplanation | string | A localized explanation to the answer, preferably readable by a user.<br>Example: `US:"Text in English"NO:"Text in Norwegian"GE:"Text in German"FR:"Text in French"` |
| TechExplanation | string |Always in English. May contain more technical details than `UserExplanation` (for example, stacktrace). |
| ErrorCode | string |An error code, if available |

## Enum ResponseState

This is used in `PluginResponse` to give a more detailed status than just true or false. If the value is anything other than "Ok", the `UserExplanation` and/or `TechExplanation` fields should be used to provide more info.

| Value | Description |
|---|---|
| Ok | The operation completed normally |
| OkWithInfo | The operation completed, but there is some information that should be shown or logged |
| Warning | The operation completed, possibly in a degraded fashion. The user should be warned |
| Error | The operation did not complete. The user should be told of the error |
