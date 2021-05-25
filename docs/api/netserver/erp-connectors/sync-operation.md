---
title: Erp Sync engine operation
uid: erp_sync_operation
description: ERP sync engine operation
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: concept
# so.envir:
# so.client:
---

# Erp Sync engine operation

The main engine of Erp Sync has no user interface and is asynchronous, so it will not be triggered by user interaction directly.

In its most common form, it will most likely run as a SuperOffice Travel Gateway task, running at regular intervals on the Travel Gateway server. It will rely on polling the different connections (including SuperOffice) at given intervals, querying the system about any changes that have occurred since the last polling operation.

The polling operations run on a timer with a configurable interval. ERP Sync can be set to run as often as every minute (probably not recommended) or as infrequently as once every day, week, year, and so on. It’s impossible to set an ideal interval, as it will depend on anything from the frequency of actor updates to how quickly the connector web service can react and deliver its results. Transferring large amounts of data to and from a slow web service will take time.

**ERP Sync asynchronous service in its simplest form:**

![ALT][img1]

## Errors and exceptions

Although both the connector host and Erp Sync has exception handling, we ask that your connectors ensure to never throw exceptions if at all avoidable. Catching your exceptions will allow you to generate better and more readable response objects than a generic catch-all inside Erp Sync can.

Certain errors and situations require specific handling, such as if a connector cannot find the configuration data belonging to a given connection ID. In these cases, the connector will need to send back a specific error code so that Erp Sync can take steps to set things right. In the case of missing configuration data, Erp Sync can resend the latest copy of the data and then try to call the failed method once more.

<!-- Referenced images -->
[img1]: media/image010.png
