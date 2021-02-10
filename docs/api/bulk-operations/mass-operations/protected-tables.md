---
title: Protected Mass Operation Tables
description: Lists tables that cannot be used for mass operations.
author: AnthonyYates             # Your GitHub alias.
so.date: 01.02.2021
keywords: data-access, bulk-update, mass-operations
---

# Protected Mass Operation Tables

These tables are protected and therefore cannot be used by the mass operations API. An `SoDbAccessException` is thrown if any of these tables are targeted.

## Tables List

| Area                        | Tables                                                                 |
|-----------------------------|------------------------------------------------------------------------|
|Users                        |associate,ejuser, credentials                                           |
|Licenses                     |modulelicense, modulelicenselink,moduleowner, licenseassoclink          |
|Roles and rights             |functionright, role, functionrightrolelink, userrolelink                |
|Service and Customer Center  |registry, config, user_candidate, user_attribute, login,login_customer,locking|
|ERP sync                     |erpconfiguration, erpconnection, erpconnector, erpconnectionaccess      |
|General                      |travelcurrent, batch task                                               |
|Email configuration          |email_account                                                           |
|Database model               |databasemodel, sequence                                                 |

