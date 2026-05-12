---
uid: teams-troubleshooting
title: Troubleshooting SuperOffice for Teams
description: Solutions to common issues in SuperOffice for Teams.
keywords: SuperOffice for Teams, Teams, troubleshooting, errors, sign-in, consent
author: Andrea Schilde
date: 07.05.2026
version:
content_type: troubleshooting
category: integration
topic: SuperOffice for Teams
language: en
---

# Troubleshooting

## "Save files" button is disabled

SuperOffice for Teams didn't detect any files in the selected conversation. Make sure you're in a standard channel and that the file is still accessible.

## "You are not signed in"

Click the **Open Chat** button to go to the bot chat, then click **Sign In**. If the sign in button is missing, type **Sign In** or **Help** in the bot chat to trigger it.

## "Action was forbidden. Make sure to add SuperOffice for Teams to the apps of the Team."

SuperOffice for Teams has to be added to a team (channel) to work. If the application was not found in the team, this message is shown.

## SuperOffice for Teams is missing from the message menu

Teams blocks app usage in certain contexts, including private channels, shared channels, and 1:1 chats with unmanaged personal accounts.  [compatibility overview][1] to confirm whether SuperOffice for Teams is supported in the conversation you are using.

SuperOffice for Teams can also be hidden from the message menu when a message was sent as a reply to both a thread and the channel. If you right-click that message from the channel view, SuperOffice for Teams may not appear. This happens because the message is technically stored as a child message in the thread, not as a standalone channel message.

To use SuperOffice for Teams in this case, open the thread and right-click the message from inside the thread instead.


## Consent or permission errors

Ask your Microsoft 365 administrator to verify that tenant-level consent was granted and that no permissions have been revoked. See [Deploy SuperOffice for Teams][2].

## "Generate Summary" is disabled

AI Labs must be activated for your SuperOffice tenant. Contact your SuperOffice administrator.

<!-- Referenced links -->
[1]: index.md
[2]: deploy.md

<!-- Referenced images -->
[img1]: media/teams-not-signed-in.png