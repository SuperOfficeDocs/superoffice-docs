---
title: Flush Cache
uid: flush-cache
description: Flush Cache
author: Eivind Fasting
date: 08.14.2024
keywords: cache, flush
content_type: concept
redirect_from: /en/api/netserver/caching/flush-cache
---

# Flush Cache

When flush is appended to the browser's URL, it triggers a procedure that initially verifies if you hold the General Admin status.
If confirmed as an [General Administrator][1], the system executes the DiagnosticsAgent FlushCaches, which purges the caches for:

* ArchiveProviderFactory
* CountryCache
* DatabaseConnection
* ExtraFieldsCache
* FreetextIncrementalIndexer
* FreetextIndexerProcessor
* FunctionRightCache
* LicenseCache
* ListItemLookupHelper
* QuoteConnectionManager
* QuoteConnections
* RelationsSearchListProvider
* RestrictionCriteriaStorage
* SoEventManager
* SoListProviderFactory
* SystemInfo
* UserGroupCache

Additionally, layouts are reconstructed through the ConfigurationAgent ClearConfigurationCache and RebuildUdefDeltas methods.

The process also:

* Clears the SuperState for all current sessions.
* Removes all items from HttpContext.Cache.
* Refreshes all language resources.

Caching on the web application may prevent new information from appearing in the client. If that is the case, send a GET request with the flush query string to flush all caches.

```http
GET https://{{env}}.superoffice.com/{{tenant}}/default.aspx?flush HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

Optionally, enter that URL into a browser and navigate to the page with the ´?flush´ query string parameter with an authenticated user.

<!-- Reference links -->
[1]: ../../admin/user-management/role/functional-rights.md
