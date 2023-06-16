---
uid: enum-emailreplytotype
title: Enum values for EmailReplyToType
description: Lists the enum values for EmailReplyToType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# EmailReplyToType Enum

Email/Mailing Reply-To field address algorithm

| Name | Value | Description |
|------|-------|-------------|
|ReplyToOnlySpecified|0|ReplyToOnlySpecified|
|ReplyToSalesContact|1|ReplyToSalesContact|
|ReplyToSupportContact|2|ReplyToSupportContact|
|ReplyToEmpty|3|ReplyToEmpty (skip reply-to header, email agents will use from instead)|

## Usage

* [email_flow](../email-flow.md).reply_to_type - A set of properties related to the email workflow.
