---
uid: api-ws-document
title: Documents API options
description: Working with documents via SuperOffice APIs.
keywords: document, API
author: Bergfrid Skaara Dias
date: 07.11.2024
version: 10
content_type: concept
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/document/howto/index
  - /en/document/howto/agents-web-api/index
  - /en/document/howto/rest/index
  - /en/document/howto/services/index
  - /en/api/netserver/web-services/howto/document/index
---

# Document API options

In this section, the focus will be on how to create, as well as edit, and upload a modified document.

## Available samples

### RESTful REST and HTTP RPC Agent APIs

* [Add document template][4]
* [Generate document][5]

### Services88 DocumentAgent

* [Create a new document][1]
* [Download an existing document][2]
* [Configuring document access][3]

## Documents vs. other entities

When working with documents, data will often intersect with the following entities:

* [company][17] (contact table)
* [contact][18] (person table)
* [follow-up][19] (appointment table)
* [project][11]
* [sale][10]

<!-- Referenced links -->
[1]: services-create.md
[2]: services-update.md
[3]: services-configure-access.md
[4]: rest-add-document-template.md
[5]: rest-generate-document.md
[10]: ../../../../sale/index.yml
[11]: ../../../../project/index.yml
[17]: ../../../../company/index.yml
[18]: ../../../../contact/index.yml
[19]: ../../../../diary/index.yml
