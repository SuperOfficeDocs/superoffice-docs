---
uid: tenant-status
title: Tenant status
description: "SuperOffice offers both a pull and a push approach to get tenant status."
author: Bergfrid Dias
so.date: 09.12.2023
keywords: status, monitor, tenant, State Change URL, state API, availability
so.topic: concept
so.envir: cloud
so.client: online
---

# Tenant status

Applications should ensure they don't attempt to connect to a particular tenant when the tenant is unavailable. SuperOffice offers both a pull and a push approach to get tenant status.

When a tenant installation experience state changes, the application should pause and resume according to the tenant's availability.

## <a id="state-api"/>Status page (pull)

Each tenant has a status page where you can [check its state][1] to ensure your application remains stable and responds accordingly. The URL is environment-specific and contains the context identifier. For example:

`https://**sod**.superoffice.com/api/state/**Cust00000**`

The information listed by the state API:

* Context identifier
* Endpoint
* Functional state
* Whether the tenant is running
* When the tenant information expires

```javascript
{
    "ContextIdentifier": "Cust37911",
    "Endpoint": "https://sod2.superoffice.com/Cust37911",
    "State": "Running",
    "IsRunning": true,
    "ValidUntil": "2020-10-05T09:52:01.9342965Z",
    "Api": "https://sod2.superoffice.com/Cust37911/api"
}
```

### ContextIdentifier

Context identifier, for example, Cust00000

### Endpoint

The root path of customer installation.

This path **will change** routinely to balance the load. Changes may also occur under special circumstances such as incidents.

For example, `https://``**sod2**``.superoffice.com:443/Cust00000` may shift to `https://``**sod3**``.superoffice.com:443/Cust00000`.

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

### IsRunning

This indicates whether the tenant is up and running.

**Values:**

* Running
* OnlineMaintenance

### ValidUntil

When to check next time if an updated state is needed.

### API

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

## <a id="notify" />Notifications (push)

When a tenant installation changes, SuperOffice sends a notification to each approved application.

To [receive notifications][4], application vendors must provide a **State Change URL** that specifies where SuperOffice sends notifications. For example:

`https://www.awesomeapp.com/NotifyCustomerStateChange`

> [!TIP]
> Notifications offer the ability to mitigate any potential errors that might occur due to state changes.

Notifications ensure that vendors are aware when the states of their customers change, for example, their SuperOffice subscription and that they know when tenants are unable to respond to requests.

When SuperOffice upgrades a tenant, for example, SuperOffice looks at each application approved by the tenant and sends out a notification to each one to indicate that the tenant is about to be upgraded. This provides the application an opportunity to know when a tenant going to be unavailable and why communications with that tenant cease until further notice.

You need to [register to get notifications][1].

### Payload

The JSON payload contains the following information:

* Tenant context identifier
* The change type
* A text representation of the installation version
* The version of the file set
* A JWT to verify it was sent by SuperOffice

```javascript
{
  "ChangeType": 0,
  "ContextIdentifier": "Cust12345",
  "VersionName": "Release 8.4 R08",
  "FileVersion": "8.4.12.1234",
  "Token": "ejy234ASD...1234#"
}
```

### Change type

The **change type** is a number value that corresponds to the operation performed on the tenant. The possible change types are:

| Type | Name | Description |
|:----:|------|-------------|
| 0 | Upgrade | Occurs when a tenant installation is upgraded to a new version of SuperOffice |
| 1 | BackupRestored | Occurs when a tenant installation is restored from a backup. |
| 2 | Suspend | Occurs when a tenant installation is placed in suspension. |
| 3 | Resume | Occurs when a tenant installation is resumed from another operation. |
| 4 | Delete | Occurs when a tenant installation is deleted. |

<!-- Referenced links -->
[1]: check-status.md
[4]: get-notifications.md
