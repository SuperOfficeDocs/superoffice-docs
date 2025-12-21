---
uid: supernotes-workspaces
title: Workspaces
description: Common questions about workspaces in Supernotes
keywords: Supernotes, workspaces, teams, collaboration, sharing
author: Brede Kristensen
date: 12.15.2025
content_type: reference
category: integration
topic: Supernotes
language: en
---

# Workspaces

Find answers to common questions about workspaces and team collaboration in Supernotes.

## What is a workspace?

A workspace is a shared environment that connects team members within Supernotes. Think of it as your company's private space where:

* **Meeting summaries are automatically shared:** with colleagues who attended.
* **Only one AI note-taker joins each meeting:** no duplicates.
* **Administrators can manage:** team access and settings.
* **Usage is tracked collectively:** for billing purposes.

Every Supernotes user must be part of a workspace. This is enforced during onboarding because it's critical for the product to work correctly.

## Why are workspaces so important?

Workspaces solve a critical problem: preventing duplicate bots in meetings.

### Without workspaces

* If five colleagues in the same meeting all have Supernotes enabled, five separate bots would join.
* This creates confusion for meeting participants.
* Results in wasted resources and multiple duplicate summaries.

### With workspaces

* Supernotes knows which users are colleagues.
* Only one bot joins each meeting.
* The summary is automatically shared with all workspace members who attended.

This is why joining your workspace is the first and most important step during onboarding.

## How do I join a workspace?

There are two ways to join a workspace:

### Automatic workspace detection

Supernotes automatically detects workspaces based on your email domain. If you sign up with john@acme.com and a workspace exists with domain acme.com, you'll be prompted to join that workspace.

### Invitation-based joining

If domain-based access is disabled, you'll need an invitation:

1. Your admin sends an invite to your email.
2. You receive an email with a join link.
3. Click the link and complete signup.
4. You're automatically added to the workspace.

> [!TIP]
> If you see multiple workspace options (common for large organizations), choose the one that matches your actual team or department.

## How do I create a workspace?

Create a new workspace when:

* You're the first person from your company to use Supernotes.
* Your team needs a separate workspace from other departments.
* You're setting up Supernotes for a new client or project.

### Creation process

1. During onboarding, select **Create new workspace**.
2. Enter your workspace name (usually your company name).
3. Configure initial settings like domain-based access and workspace branding.
4. Complete your personal setup (calendar connection, etc.).

When you create a workspace, you automatically become its administrator with full control over member management, workspace settings, and access policies.

## How do I manage my workspace as an administrator?

As a workspace administrator, you can:

* **Invite new members:** by email.
* **Remove members:** to revoke access.
* **Enable/disable domain-based access:** allow anyone with your company email domain to join automatically.
* **Configure branding:** and bot avatar.
* **View workspace usage.**

### To invite members

1. Go to **Settings** > **Workspace**.
2. Click **Invite Members**.
3. Enter email addresses of people to invite.
4. Click **Send Invite**.

> [!TIP]
> For large teams, a bulk invite feature (CSV/Excel upload) is available for adding many users at once.

## What is domain-based access?

When enabled, anyone with a matching email domain can join your workspace automatically without an invite.

**Example:** If your workspace domain is acme.com, then jane@acme.com and bob@acme.com can join automatically, but external@gmail.com cannot join without an invite.

### Advantages

* Easy onboarding for large teams.
* No manual invites needed.
* Reduces admin workload.

### Considerations

* Less control over who joins.
* May include contractors or temps with company email.

**Recommendation:** For large organizations (50+), enable domain access for easier scaling. For small teams, use invite-only for tighter control.

## What gets shared within a workspace?

When you're in a workspace, certain things are shared with colleagues who attended the same meeting:

### Shared with attendees

* Meeting summary.
* Full transcription.
* Action items.
* Participant list.

### NOT shared

* Meetings you attended alone.
* Your personal settings.
* Meetings with only external participants.
* Your calendar details.

> [!NOTE]
> Your past meetings are NOT shared when you join a workspace. Only meetings that happen AFTER you join the workspace, where other workspace members are participants, are shared.

## Why are multiple bots joining my meeting?

If multiple bots are joining your meeting, the participants aren't in the same workspace (or no workspace).

### To fix this

1. Identify who has Supernotes but isn't in your workspace.
2. Have your admin invite them to the workspace.
3. They need to accept the invitation and join the shared workspace.
4. Future meetings will only have one bot.

### To prevent this issue

* **Communicate before rollout:** let employees know about Supernotes before inviting them.
* **Use bulk invites:** more efficient for large teams.
* **Consider enabling domain-based access:** for your organization.
