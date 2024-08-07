---
uid: tenant-status-check
title: Check tenant status
description: How to check a tenant's state to ensure your application remains stable and responds accordingly.
author: Eivind Fasting
date: 05.08.2024
keywords: tenant, status, state API
topic: howto
envir: cloud
client: online
---

# Check tenant status

The following parameters are required to send a request to the state API:

* Set `ENVIR` to [sod, stage or online][1] depending on where your application runs.
* Set `CONTEXTID` to your context identifier, for example, Cust00000.

```csharp
GET https://ENVIR.superoffice.com/api/state/CONTEXTID
```

## Request example

```csharp
GET https://online.superoffice.com/api/state/Cust12345
```

### Response example

```json
{
    "ContextIdentifier": "Cust12345",
    "Endpoint": "https://online.superoffice.com/Cust12345",
    "State": "Running",
    "IsRunning": true,
    "ValidUntil": "2020-10-05T09:52:01.9342965Z",
    "Api": "https://online.superoffice.com/Cust12345/api"
}
```

#### ContextIdentifier

Context identifier, for example, Cust00000

#### Endpoint

The root path of customer installation.

This path **will change** routinely to balance the load. Changes may also occur under special circumstances such as incidents.

For example, `https://``**sod2**``.superoffice.com:443/Cust00000` may shift to `https://``**sod3**``.superoffice.com:443/Cust00000`.

> [!NOTE]
> From November 17. 2023, calls to the wrong public endpoint return **HTTP status code 421 - Misdirected request** with an additional error description saying "Wrong subdomain used to access tenant". Subdomains without a number identifier, such as `sod.superoffice.com` and `online.superoffice.com`, are reserved for authentication. Use the tenant-specific endpoint (with a number) for API calls. For example, `sod2.superoffice.com` or `online3.superoffice.com`. Because the subdomain part of the endpoint changes, and the application should respond to these changes, we recommend that you do not hardcode the path.

### State

| Value | Description |
|-------|-------------|
| Unknown (0) | The customer tenant is unknown, or there is something wrong with the environment.  If the customer was previously in another state, we probably have an incident of sorts. |
| Provisioning (1) | We are in the state of provisioning the customer.  Should be ready in a short time. |
| Running (2) | The customer tenant is running. All is good. |
| Deleted (3) | The customer tenant has been deleted, forget all about it. |
| Suspended (4) | The customer tenant is in termination.  APIs are not available, and the customer can still take action to reactivate his subscription.  Resuming a customer in termination typically occurs at night or by manual activation by the sales team. |
| OnlineMaintenance (5) | We are performing background tasks, but nothing preventing customers from performing normal operations.  API is available.  Background tasks might take some time before they start. |
| OfflineMaintenance (6) | The customer tenant is offline for maintenance.  This typically happens during an upgrade.  It usually takes minutes for the customer to be online again.  APIs are not available. |
| ProvisioningFailed (8) | Provisioning has failed.  |
| Deleting (10) | We are in the process of deleting the customer.  Expect the customer to be deleted shortly. |
| DeleteFailed (11) | Deleting the customer failed.  Expect the customer to be deleted in a while. |
| MigrationPending (12) | This is a new migration to online that has not yet been completed.  Expect the customer to be running at a later time.  Customers are often in state MigrationPending for days or weeks. |

#### IsRunning

This indicates whether the tenant is up and running.

**Values:**

* Running
* OnlineMaintenance

#### ValidUntil

When to check next time if an updated state is needed.

#### API

Link to more information about API version details. Example:

```javascript
{
    "v1": "https://sod.superoffice.com:443/Cust37911/api/v1/",
    "NetServerVersion": "9.1.7583.012",
    "NetServerAssembly": "9.1.0.0",
    "NetServerDate": "2020-10-05",
    "NetServerLabel": "Release9_C-2020.10.05-01",
    "NetServer": "SuperOffice 9.1 R3 NetServer 9.1 Release (Build: Release9_C-2020.10.05-01)",
    "Services": "Services87",
    "ServicesCurrent": "Services88",
    "Version": "v1"
}
```
<!-- Referenced links -->
[1]: ../../getting-started/app-envir.md
