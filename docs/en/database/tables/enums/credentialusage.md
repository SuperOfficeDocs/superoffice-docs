---
uid: enum-credentialusage
title: Enum values for CredentialUsage
description: Lists the enum values for CredentialUsage.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# CredentialUsage Enum

What kind of usage are these credentials for; see enum CredentialUsage for details

| Name | Value | Description |
|------|-------|-------------|
|Outbound|0|Credentials saved on behalf of an external system, not for authentication into NetServer|
|Inbound|1|Credentials to be used for authentication into NetServer, by a related plugin|
|Session|2|Session ticket, for re-authentication of an existing session (automatically purged at first full authentication after validity expiration)|

## Usage

* [Credentials](../credentials.md).isActive - Alternative credentials
