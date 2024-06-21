---
title: Localization requirements
uid: app-localization-requirements
description: "Localization and language support requirements for certifying standard applications."
author: Margrethe Romnes
date: 02.02.2022
keywords: certification, apps
topic: reference
envir: cloud
client: online
---

# Requirements for localization and language support

Building localization features into the basic architecture of your product is essential to effective distribution, deployment, and future maintenance.

SuperOffice CRM has users all over the world. These users are used to running SuperOffice CRM in their native language.

Localization requirements are only relevant if your application supports more than one language and has a user interface.

## Requirements

* The application should be **multi-language compatible**:
  * The application shall handle common data, for example, lists, according to language encoding for each supported language.
  * List values such as **NO: "Bil", US: "Car"** must be parsed and presented correctly.
* All parts of the system (such as dialogs, messages, standard reports, import data, and document templates) shall be **translated** into each supported language.
* Your application's setup guide shall be available in English.
  * It is optional to make it available in additional languages.
* Your application should follow the SuperOffice language settings.

## Guidance

The application should support the **SuperOffice core languages** in [group A][1].

We recommend using a professional agency for translation. SuperOffice AS can offer partners access to the agency we use.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/product-releases/product-info/language-support/
