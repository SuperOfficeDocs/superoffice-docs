---
uid: partner-licenses-technical-details
title: Partner licenses
description: Partners can issue their own licenses.
keywords: partner license, license
author: xt1
date: 04.20.2026
version: 11.12
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
---

# Partner licenses

Partners can host their own license server and install their own licenses alongside the SuperOffice licenses.

This involves:

1. Building a license server that conforms to the SOAP API used for license servers.
1. Generating a public + private key using our key tool.
1. Sending in the public key to get signed by SuperOffice.
1. Installing the signed public key and the private key into your license server.
1. Start your license server.
1. Download a license for a given serial number + company name.
1. Install the downloaded license into the tenant using the Agent or REST API.

At this point the new licenses will appear as a new panel in admin, alongside the SuperOffice tab.

You can check for your own licenses in the same way as SuperOffice licenses.
