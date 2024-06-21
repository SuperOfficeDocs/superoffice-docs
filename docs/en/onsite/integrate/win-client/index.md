---
uid: api_scenario_win
title: Integration in the Windows client
description: Integration in the Windows client
author: Tony Yates
date: 11.25.2021
keywords: api, integration point, Windows
topic: reference
envir: onsite
client: win
---

# Integration scenarios: Window client

A flagship CRM platform, the SuperOffice CRM client has been the leading SuperOffice CRM product since 1989. SuperOffice CRM was created to support the needs of the salesperson by making his everyday life easier – and make it so user-friendly and elegant that the user would want to use it.

The Windows client exposes many hooks that make it easy for vendors to create a seamless experience with their applications. Integrations have full-duplex type communications, providing integrations the ability to receive notifications when users perform actions, immediately process the data concerned, and even switch the user's context and show important relevant information related to that action.

## Integration points

* COM API
* Automation Engine (vbScript and JScript scripts)
* Event-driven interaction (internal scripts and external COM subscriptions)
* Access current values
* Web panels
* Buttons to launch external applications
* Custom tables and fields
* Document Plugin (NetServer-based since version 8)
* Sentry Plugin (COM)
* Email Plugin (COM)

## Related SDK

* [IApplicationCOM API][5]
* [IDatabaseCOM API][6]

<!-- Referenced links -->
[5]: https://github.com/SuperOffice/SDK-Doc/tree/master/COM.IApplication
[6]: https://github.com/SuperOffice/SDK-Doc/tree/master/COM.IDatabase

<!-- Referenced images -->
