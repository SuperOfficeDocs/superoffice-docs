---
title: Sync manually (debug)
uid: sync_mirror_manually
description: How to manually initiate synchronization of a mirrored database
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# How to manually initiate synchronization of a mirrored database

The real-world way to begin invocations is by installing your application from the SuperOffice App Store, but how do you do this without your application being listed in the store, or you just want to debug it?

It's time to signal SuperOffice that your application is ready to be called.

## Pre-requisites

* your application is registered
* you have a publicly available working service
* you are testing this in SOD

> [!NOTE]
> This procedure is intended for **debug** purposes and **mocks** a customer installing your application.

## Procedure

1. Enter the following URL in a browser, using your own **client ID**:

    `https://sod.superoffice.com/login/?app_id=YOUR_APPLICATION_ID`

2. If the application has not yet been approved (in SOD), the SuperOffice Online sign-in page is shown. Sign in and approve the application with your SOD tenant credentials.
    1. If you defined a [Redirect URL][1] for your application, you will be redirected to that URL.

    2. If you did not specify a redirect URL, you will instead be redirected to your SuperOffice tenant installation.

3. Shortly thereafter, the [Mirroring Task][2] will send an authentication request, which your client must respond to. After successful authentication, SuperOffice will begin to deliver periodic updates to your mirroring service.

## Placing breakpoints and debugging

The key here is to successfully sign and send an **AuthenticationResponse** to the **AuthenticationRequest** back to the Mirroring Task. To do that, you must get the client ID and your encryption key.

* `GetApplicationIdentifier` method
* `GetPartnerKey` method

If this process fails for any reason, `ResolveConnection()` will not be called and no data will be synchronized.

> [!NOTE]
> Because there is no GUI to check data in a mirror, **SQL Server Management Studio** must be used. Generally, it should be possible to do `select * from <sometable>` in both the customer table and the mirror, and get the same result.

<!-- Referenced links -->
[1]: ../../apps/redirects/index.md
[2]: ../mirroring-task.md
