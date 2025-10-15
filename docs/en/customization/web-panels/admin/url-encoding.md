---
uid: help-en-url-encoding
title: Url encoding
description: URL encoding in web panels
keywords: web panel, URL encoding
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: en
index: true
redirect_from: /en/ui/web-panels/url-encoding.html
---

# Url encoding

Browsers request pages from web servers by using a URL - the **address of a webpage**.

These URLs can only be sent over the Internet as ASCII characters. However, they will often contain non-ASCII characters, for example, *space*.

**URL encoding** converts the original URL to the correct format. When you add new web panels, you may choose URL encoding directly in a drop-down menu.

## ANSI

Conversion replaces unsafe characters with a percent (%) followed by 2 hexadecimal digits. For example, space becomes *%20*. Thus:

* Characters up to 0x7F (127) are passed along unmodified
* Characters from 0x7F to 0xFF are encoded

## Unicode

Conversion transforms all characters to UTF-8 and then prefixes each character's 1–3 byte hexadecimal value with % according to RFC 2279.

<!-- Referenced links -->