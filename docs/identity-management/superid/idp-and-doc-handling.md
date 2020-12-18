---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: idp_and_document_handling       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Identity providers and document handling  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: IdP
so.topic: concept                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
so.client: online                   # online, web, win, pocket, or mobile
---

# Identity providers and document handling

Let's look at how SuperID changes how you use and set up identity providers and document handling.

## Before SuperID

* Microsoft and Google IdP require Cloud Office.

* Other identity providers are not available.

* SharePoint and G-suite integration must be set up manually by R&D services.

## With SuperID

* Microsoft or Google IdP is supported. We offer self-service + advanced additional configuration that can be set up by R&D services. For example, sub-domains and custom domains.

* Other identity providers are available on request if they support OpenID Connect.

* [G-suite integration][1] is self-service.

* [Office 365 integration][2] must be set up manually for the time being, but self-service is planned for upcoming releases.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/prepare/crm-online/office-365-google-apps/g-suite-setup/
[2]: https://community.superoffice.com/en/technical/documentation/prepare/crm-online/office-365-google-apps/setup---o365-integration/