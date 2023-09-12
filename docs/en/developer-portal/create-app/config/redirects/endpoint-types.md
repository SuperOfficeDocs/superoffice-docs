---
title: Endpoint types
uid: redirect_endpoint_types
description: Types of redirection endpoints
author: {github-id}
keywords: URL
so.topic: reference
so.envir: cloud
so.client: online
---

# Types of redirection endpoints

## Login callback URL

* The SuperOffice login page will post the claims and login results to this page
* Can be configured as POST or GET request, depending on what you prefer
  * POST is considered more secure because the parameters are not exposed to proxies or browser caches
  * Example: `https://app.partner.com/app/LoginRedirect.aspx`

## Application install URL

* Where the App Store will link to when the user clicks **Buy**

## Application configure URL

* Where the App Store will link to when the user clicks **Configure**

## Application uninstall URL

* Where the App Store will link to when the user clicks **Uninstall**
  * This will not [revoke app authorization][1] for the tenant.

## Custom error callback URL

* Where users are sent if the sign-in is unsuccessful.

## Additional whitelisted URL

* All URLs called by your application must be whitelisted. Otherwise, the call will return an error.

## Post logout redirect URL

* Where users are sent after successful sign-out.

## CORS URL

* All URLs for cross-origin resource sharing must be whitelisted

## Database mirroring URL

* Where the [SuperOffice Mirroring Task][3] sends data.

## ERP Sync URL

## Quote connector URL

## Custom State Change URL

* Where we send [notifications when a tenant changes status][2]. Mandatory for standard applications.

<!-- Referenced links -->
[1]: ../../../provisioning/revoke.md
[2]: ../../../best-practices/tenant-status/index.md#notify
[3]: ../../../../mirroring/mirroring-task.md
