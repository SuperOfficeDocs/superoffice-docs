---
uid: tenant-status-check
title: Check tenant status
description: How to check a tenant's state to ensure your application remains stable and responds accordingly.
author: Bergfrid Dias
so.date: 09.12.2023
keywords: tenant, status, state API
so.topic: howto
so.envir: cloud
so.client: online
---

# Check tenant status

Each tenant has a [status page][2] where you can check its state to ensure your application remains stable and responds accordingly.

## Pre-requisites

* Context identifier (CustId) is known

## To check the status

1. Send a request to the state API:
    * Set `ENVIR` to [sod, stage or online][1] depending on where your application runs.
    * Set `CONTEXTID` to your context identifier, for example, Cust00000.

    ```csharp
    GET https://ENVIR.superoffice.com/api/state/CONTEXTID
    ```

2. Parse the response. Details in the [state value reference][2].

<!-- Referenced links -->
[1]: ../../getting-started/app-envir.md
[2]: index.md#state-api
