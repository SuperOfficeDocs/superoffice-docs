---
uid: help-en-document-supported-languages
title: Language support for documents
description: Language support for documents
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: concept
language: en
---

# Language support for documents

## How SuperOffice CRM selects the correct language template

In SuperOffice CRM, you will find multiple default templates. These are available in 12-16 languages depending on the template type. This includes email templates and GDPR templates (12 languages).

To ensure that you can communicate with your clients in their own language (where possible), SuperOffice CRM will automatically perform a language check to determine which language temple to use. This is relevant when sending out invitation e-mails, and when notifying new contacts that their details have been saved. For GDPR related communication, this is also an requirement.

SuperOffice CRM will perform the language check in the following order:

1. Check if a preferred language has been set for the contact, and check if a template is available in this language.
2. Check if the contact's country can be mapped to a corresponding language.
3. Check the preferred document language for the logged-in user, and check if a template is available in this language.
4. Check the user interface language for the logged-in user, and check if a template is available in this language.
5. If no language is found, the English template will be used.
