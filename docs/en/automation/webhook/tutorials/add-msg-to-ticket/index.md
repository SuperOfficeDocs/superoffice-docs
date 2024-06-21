---
title: Using GitHub webhooks to add message to ticket
uid: add_msg_to_ticket_with_github_webhook
description: Using GitHub webhooks to add message to ticket
author: Frode Lillerud
date: 02.07.2019
keywords:
topic: tutorial
---

# Using GitHub webhooks to add message to ticket

Two of our primary tools for maintaining control when developing customizations for our customers are GitHub and SuperOffice Service, and here I'll briefly describe how we've used CRMScript to create a light integration between the 2 systems.

[!include[ALT](../../../includes/new-to-CRMScript.md)]

The jist of it is that whenever we commit code to GitHub, we can optionally include a Ticket ID in the commit message, and this will create a message in our SuperOffice.

So a commit like this:

![x -screenshot][img1]

Generates this on the correct ticket:

![x -screenshot][img2]

The first step is to create a web service in SuperOffice with a script similar to this:

[!include[ALT](includes/CRMScript.md)]

> [!TIP]
> Remember to wrap the script in the appropriate EJSCRIPT start and end tags

The 2 includes can be found in the [SuperOffice CRMScript repo][1].

The next step is to tell GitHub to post JSON to SuperOffice whenever a commit happens.

We've set the setting on the GitHub organization level by going to Settings and the WebHooks settings. Create a webhook there that points to the script.

![x -screenshot][img3]

The URL looks like this:

`https://crm.example.com/scripts/customer.fcgi?action=safeParse&includeId=github-webhooks-all&key=sec­ret`

And from then on all commits that contain the magical ID reference will end up as messages in SuperOffice.

<!-- Referenced links -->
[1]: https://github.com/SuperOffice/CRMScripts

<!-- Referenced images -->
[img1]: media/gh-commit.png
[img2]: media/ticket.png
[img3]: media/webhook-gh-settings.png
