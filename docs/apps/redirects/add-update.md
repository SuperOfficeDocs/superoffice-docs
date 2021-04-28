---
title: add_update_redirect
description: Add or update redirection endpoints
author: {github-id}
keywords:
so.topic: howto
# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Add or update redirection endpoints

The redirection endpoints are specified and whitelisted when you register the application idea.

All changes to whitelisted URLs have to go through SuperOffice.

## Pre-requisite

* You have registered your application idea
* You are (or will be) handling web service requests at the new endpoints

## To update

[Submit a change request][1] (form).

* We ask for the [Client ID][2] (AppId)
* Which environment do you want the change for ([SOD, stage, or production][3])
* For each URL:
  * is it new or replacing an existing redirect? (specify old URL)
  * is whitelisting sufficient or is it a CORS redirect?

> [!CAUTION]
> If you add database mirroring or webhooks, the tenant administrator must [renew the consent][4] to your application. **Users will be locked out from when the change happens until the consent has been given.**

<!-- Referenced links -->
[1]: https://community.superoffice.com/change-application
[2]: ../terminology.md
[3]: ../getting-started/app-envir.md
[4]: ../provisioning/get-consent.md
