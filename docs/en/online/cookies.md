---
title: Cookies overview
uid: cookies_overview
description: Cookies overview
author: {github-id}
keywords: security, cookies
topic: reference
date:
# envir:
# client:
---

# Cookies overview

Overview of cookies used in SuperOffice product offering both for Onsite and Online deployment.

## Online environment

Cookies specific to SuperOffice Online deployment.

| Cookie name | Type | Usage | Description |
|---|---|---|---|
| OnlineLogin | string | Online login | Session handling in login page load balancer |
| SOOnline | string | Online login | Session state for Online login |
| SoAuth.Xsrf | string | Online login | Anti-forgery token for Online login |
| SoContextHints | string | Online login | Online login |
| SoOnlineAuth | string | Online login | Online login - login session |
| SoRT_custXXXXX | string | Online login | Online login |
| SoRT_global | string | Online login | Online login |
| ai_session | string | Online env. | Application Insights monitoring of the system - anonymized data for monitoring Online systems |
| ai_user | string | Online env. | Application Insights monitoring of the system - anonymized data for monitoring Online systems |

## Sales & Marketing

Cookies used by Sales & Marketing client both in Online and Onsite deployment.

| Cookie name | Type | Usage | Description |
|---|---|---|---|
| ASP.NET_SessionId | string | CRM | Used to identify the user's session on the server |
| FirstDayOfWeek | number | CRM | Used to set Sunday or Monday as the first day of the week |
| SoWtt | string | CRM | CRM Client Signal R session |
| XSRF-TOKEN | string | CRM | Prevent cross-site request forgery |
| SoCrmCurrentUserUICulture | string | CRM | Used to store selected language for the client |
| SoCrm75SR1FirstUse | boolean | CRM | Used to indicate first-time use of the client |

## Service

Cookies used by the Service client both in Online and Onsite deployment.

| Cookie name | Type | Usage | Description |
|---|---|---|---|
| SoCrmCurrentUserCulture | string | Service | Number and date format selected in GUI |
| SuperOffice_Service_menuCollapsed | boolean | Service | Used to control if Navigator menu should be collapsed |
| ckCsrfToken | string | Service | Used by CKEditor for CSRF protection |
| crmUrl | url | Service | Storing URL to CRM client |
| key | string | Service | Authentication |
| loginId | number | Service | Authentication |
| logoutUrl | url | Service | URL for redirect when logging out |
| userId | number | Service | Authentication |
| sessionId | number | Chat | Storing ongoing chat session with customer |
| sessionKey | string | Chat | Storing ongoing chat session with customer |
| custSessionKey | string | Customer Centre, Chat*, Forms* | Authentication |
| customerLang | string | Customer Centre | Which language to show pages in |
| debug.debugSessionId | number | Service | Used for debugging option in Service |
| debug.stageScripts | boolean | Service | Used for debugging option in Service |
| debug.breakpoint | string | Service | Used for debugging option in Service |
| debug.traceScripts | boolean | Service | Used for debugging option in Service |
| debug.sleep | boolean | Service | Used for debugging option in Service |
| debug.noexpire | boolean | Service | Used for debugging option in Service |
| debug.layout | boolean | Service | Used for debugging option in Service |
| debug.socket | boolean | Service | Used for debugging option in Service |
| debug.db | boolean | Service | Used for debugging option in Service |
| debug.searchEngine | boolean | Service | Used for debugging option in Service |
| debug.dbTimeAll | boolean | Service | Used for debugging option in Service |
| debug.slowdb | boolean | Service | Used for debugging option in Service |
| debug.NetServer | boolean | Service | Used for debugging option in Service |
| debug.performance | boolean | Service | Used for debugging option in Service |
| debug.ext | boolean | Service | Used for debugging option in Service |
| debug.smtp | boolean | Service | Used for debugging option in Service |
| debug.rest | boolean | Service | Used for debugging option in Service |
| debug.forceImmediateFileLogging | boolean | Service | Used for debugging option in Service |
| debug.dumpCgi | boolean | Service | Used for debugging option in Service |
| debug.dumpCgiToScreen | boolean | Service | Used for debugging option in Service |
| debug.resize | boolean | Service | Used for debugging option in Service |
| debug.ejscript | boolean | Service | Used for debugging option in Service |
| debug.unlockPackages | boolean | Service | Used for debugging option in Service |
| debug_seconds | number | Service | Used for debugging option in Service |
| slowdb_seconds | number | Service | Used for debugging option in Service |
| debug.debugId | number | Service | Used for debugging option in Service |
| debug.stackTraceFilter | number | Service | Used for debugging option in Service |
| debug.logHttpRequest | boolean | Service | Used for debugging option in Service |
| debug.disableCombinedJavascripts | boolean | Service | Used for debugging option in Service |
| debug.disableCombinedCss | boolean | Service | Used for debugging option in Service |
| debug.bustJavascriptAndCssCache | boolean | Service | Used for debugging option in Service |
| debug.disableNotifications | boolean | Service | Used for debugging option in Service |
| debug.printExceptions | boolean | Service | Used for debugging option in Service |

\* when embedded in the Customer Centre
