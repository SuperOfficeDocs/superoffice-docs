---
title: Url encoding
uid: web_panels_url_encoding
description: URL encoding in web panels
author:
so.date:
keywords:
so.topic: concept
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

Conversion transforms all characters to UTF-8 and then prefixes each character's 1–3 byte hexadecimal value with % according to [RFC 2279][3].

<!-- Referenced links -->
