---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: check_tenant_status       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Check tenant status

Each tenant has a status page where you can check its state to ensure your application remains stable and responds accordingly.

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
[1]: ../apps/app-envir.md
[2]: tenant-status/.md