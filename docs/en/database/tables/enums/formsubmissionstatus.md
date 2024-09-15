---
uid: enum-formsubmissionstatus
title: Enum values for FormSubmissionStatus
description: Lists the enum values for FormSubmissionStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# FormSubmissionStatus Enum

What is the status of this submission

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown status|
|InProgress|1|In progress, the customer has started filling out fields but has not yet submitted|
|EmailVerification|2|EmailVerification, the customer has submitted but we are waiting for click from sent email|
|Submitted|3|Submitted, the form is submitted but has not yet been executed|
|Processed|4|Processed, the actions of the form have been executed|
|Failed|5|Failed, there was an error when processing the form|

## Usage

* [form_submission](../form-submission.md).status - A form submission
