---
title: Partner licenses
description: Partners can issue their own licenses
author: xt1
date: 12.03.2026
keywords: License, partners 
content_type: concept
---

# Partner Licenses

Partners can host their own license server and install their own licenses alongside the SuperOffice licenses.

This involves:

0. Building a license server that conforms to the SOAP API used for license servers.
1. Generating a public + private key using our key tool.
2. Sending in the public key to get signed by SuperOffice.
3. Installing the signed public key and the private key into your license server.
4. Start your license server
5. Download a license for a given serial number + company name.
6. Install the downloaded license into the tenant using the Agent or REST API.

At this point the new licenses will appear as a new panel in admin, alongside the SUPEROFFICE tab.

You can check for your own licenses in the same way as SuperOffice licenses.
