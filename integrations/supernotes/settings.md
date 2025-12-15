---
uid: supernotes-settings
title: Settings
description: Common questions about Supernotes settings and configuration
keywords: Supernotes, settings, auto schedule, retention, vocabulary
author: Brede Kristensen
date: 12.15.2025
content_type: reference
category: integration
topic: Supernotes
language: en
---

# Settings

Find answers to common questions about configuring Supernotes.

## What does "Auto Schedule" do?

This setting controls whether Supernotes automatically joins your meetings:

| Setting  | Behavior                                                                                             |
| -------- | ---------------------------------------------------------------------------------------------------- |
| Enabled  | Supernotes automatically joins all meetings. You can exclude individual meetings from the dashboard. |
| Disabled | Supernotes doesn't automatically join. You manually select which meetings Supernotes should attend.  |

Find this in **Settings → Profile**

## How do I control which meetings Supernotes joins?

You have several options:

### Per-meeting toggle

On any meeting card, use the **"Supernotes is attending"** toggle to include or exclude that specific meeting.

### Auto Schedule setting

In **Settings → Profile**, toggle **"Auto Schedule"** to control the default behavior for all meetings.

### Internal Meetings setting

Separately control whether Supernotes joins internal meetings (within your organization).

## What are the recording retention options?

Recording retention controls how long audio/video files are stored:

| Option  | Description                                                   |
| ------- | ------------------------------------------------------------- |
| 30 days | Recordings stored for 30 days before automatic deletion       |
| 7 days  | Recordings stored for 7 days before automatic deletion        |
| 0 days  | Recordings deleted immediately after transcription processing |

> [!NOTE]
> Text transcriptions are stored as long as your account exists, regardless of this setting.

## How do I control meeting summary email distribution?

The "Meeting Summary Email Preference" setting controls how summaries are distributed:

| Option                         | Description                                                      |
| ------------------------------ | ---------------------------------------------------------------- |
| Send to all internal attendees | All internal participants receive email summaries automatically  |
| Save only in Supernotes        | Summaries are stored in Supernotes but not automatically emailed |

You can always manually share summaries using the shareable link feature.

## What is custom vocabulary and how do I use it?

Custom vocabulary helps improve transcription accuracy for organization-specific terms. Add words that:

- Are specific to your organization or industry
- Are commonly mispronounced or misheard
- Are technical terms, acronyms, or jargon
- Are names of products, projects, or people

### To add custom vocabulary:

1. Go to **Settings → Custom Vocabulary**
2. Add your organization-specific terms
3. Supernotes will prioritize these spellings during transcription

## How do I set my default meeting type?

The default meeting type determines the template used for generating summaries:

1. Go to **Settings → Profile**
2. Find **"Default Meeting Type"**
3. Select from available templates

### Available types typically include:

- General
- Customer meeting
- Internal meeting
- Custom templates you've created
