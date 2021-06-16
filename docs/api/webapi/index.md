---
title: WebAPI
uid: webapi_about
description: Web API overview
author: {github-id}
so.date: 
keywords: webapi
so.topic: concept
---

# WebAPI

The HTTP WebAPI comes in 2 parts:

* [REST WebAPI][1] - URLs describe entities like person or sale
* [Agents WebAPI][2] - the services API accessible via HTTP

The **REST** API is not as complete as the **Agents** API, but it should cover the most common use cases, and be easier to use and navigate.

## Getting started

* Get the version number and build-date from the **API endpoint**: `/api`
* Get a list of supported URLs using the version URL: `/api/v1`

## Authorization

* [Authorization types and how to configure them][3]
* [How to reuse sessions with XSRF-TOKEN][4]

## HTTP request headers

* [Accept-Language][1]
* [Content-Type][2]
* [If-Modified-Since and If-Unmodified-Since][3]

<!-- Referenced links -->
[1]: rest/index.md
[2]: agents/index.md
[3]: ../authentication/onsite-web-api/index.md
[4]: ../authentication/onsite-web-api/reuse-session.md
[5]: headers/accept-language.md
[6]: headers/content-type.md
[7]: headers/modified-unmodified.md
