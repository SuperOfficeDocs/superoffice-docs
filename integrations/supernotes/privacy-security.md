---
uid: supernotes-privacy-security
title: Privacy and security
description: Common questions about data privacy and security in Supernotes
keywords: Supernotes, privacy, security, GDPR, data, storage
author: BredeYabo
date: 02.04.2026
content_type: reference
category: integration
topic: Supernotes
language: en
---

# Privacy and security

Find answers to common questions about how Supernotes handles your data.

## What data does Supernotes access?

Supernotes is built with a "minimal access" approach:

| Data Type | Access |
| --- | --- |
| Calendar | Meeting details only (name, participants, date, time, link) |
| Email address | Read only (for login and identification) |
| Email content | No access |
| Teams files | No access |
| Google Drive | No access |
| Other documents | No access |

## Where is my data stored?

All data is handled within the EU/EEA region:

* **Speech-to-text:** Processed by Gladia (France).
* **AI summaries:** Generated via OpenAI through Azure (EU).
* **Storage:** Encrypted and stored securely in EU.

### Security measures

* Fully encrypted in transit and at rest.
* PEN tested and approved by Telenor Cyber Defence, Google, and Microsoft.
* GDPR compliant.

## How long are recordings kept?

Recording retention depends on your settings:

| Content type | Retention |
| --- | --- |
| Audio/video recordings | Automatically deleted after 30 days (configurable to 7 days or 0 days) |
| Text transcriptions | Stored as long as your account exists |
| Meeting summaries | Stored as long as your account exists |

For configuration options, see [What are the recording retention options?][4]

## Is my data used to train AI models?

**No, your data is never used to train AI models.**

Supernotes uses AI services to process your meetings, but:

* Your data is only used to provide the service to you.
* It is not shared with third parties for training.
* It is not used to improve AI models.
* Your conversations remain private and confidential.

## What is Supernotes's environmental impact?

Supernotes is developed with a focus on responsible and sustainable AI. Here's what you should know about the environmental footprint:

### Energy consumption

Transcription uses approximately 21 Wh (0.021 kWh) per hour of asynchronous transcription. To put this in perspective:

* Equivalent to charging a mobile phone once.
* Same as running 2 LED light bulbs for 3 hours.

### Carbon footprint

CO2 emissions per hour of transcription: 5-20 grams, depending on the data center's energy mix.

*Energy data provided by Gladia + MDPI 2025 study.*

## Related content

* [Getting started][1] - Setup and basic usage
* [Settings][2] - Configuration options
* [Workspaces][3] - Team collaboration and workspace management

<!-- Referenced links -->
[1]: getting-started.md
[2]: settings.md
[3]: workspaces.md
[4]: settings.md#retention-options
