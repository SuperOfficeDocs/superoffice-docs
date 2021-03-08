---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: cookies       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Cookies overview # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
| SoRT\_custXXXXX | string | Online login | Online login |
| SoRT\_global | string | Online login | Online login |
| ai\_session | string | Online env. | Application Insights monitoring of the system - anonymized data for monitoring Online systems |
| ai\_user | string | Online env. | Application Insights monitoring of the system - anonymized data for monitoring Online systems |

## Sales & Marketing

Cookies used by Sales & Marketing client both in Online and Onsite deployment.

| Cookie name | Type | Usage | Description |
|---|---|---|---|
| ASP.NET\_SessionId | string | CRM | Used to identify the user's session on the server |
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
| SuperOffice\_Service\_menuCollapsed | boolean | Service | Used to control if Navigator menu should be collapsed |
| ckCsrfToken | string | Service | Used by CKEditor for CSRF protection |
| crmUrl | url | Service | Storing URL to CRM client |
| key | string | Service | Authentication |
| loginId | number | Service | Authentication |
| logoutUrl | url | Service | URL for redirect when logging out |
| userId | number | Service | Authentication |
| sessionId | number | Chat | Storing ongoing chat session with customer |
| sessionKey | string | Chat | Storing ongoing chat session with customer |
| custSessionKey | string | Customer Centre, Chat\*, Forms\* | Authentication |
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
| debug.netserver | boolean | Service | Used for debugging option in Service |
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
| debug\_seconds | number | Service | Used for debugging option in Service |
| slowdb\_seconds | number | Service | Used for debugging option in Service |
| debug.debugId | number | Service | Used for debugging option in Service |
| debug.stackTraceFilter | number | Service | Used for debugging option in Service |
| debug.logHttpRequest | boolean | Service | Used for debugging option in Service |
| debug.disableCombinedJavascripts | boolean | Service | Used for debugging option in Service |
| debug.disableCombinedCss | boolean | Service | Used for debugging option in Service |
| debug.bustJavascriptAndCssCache | boolean | Service | Used for debugging option in Service |
| debug.disableNotifications | boolean | Service | Used for debugging option in Service |
| debug.printExceptions | boolean | Service | Used for debugging option in Service |

\* when embedded in the Customer centre
