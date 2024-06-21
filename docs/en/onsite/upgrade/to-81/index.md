---
title: Upgrade to 8.1
uid: upgrade_to_81
description: Upgrade to 8.1
author: {github-id}
keywords: upgrade
topic: howto
envir: onsite
# client:
---

# Upgrade to SuperOffice 8.1 or newer

From SuperOffice 8.1, it is required that both Sales and Service are located on the same domain, as seen from the browser. This is because the authentication is done only by Sales.

When upgrading to 8.1, you must decide which domain should be the primary domain where both Sales and Service should be located, as seen from the browser. In our examples, we use `socrm.myorganization.com/sales` and `socrm.myorganization.com/service`.

If the 2 clients are not located on the same webserver, then [Reverse proxy][1] must be set up to redirect the user to the correct location, and the reason for 2 sub-folders is that it is easier to set up a reverse proxy (ARR rules) if the clients are located in different folders.

> [!NOTE]
> Moving Sales requires a lot fewer changes than if you choose to move Service. When you move Sales, you may just run the Web client installer and after you run the client configuration all is up and running. If you choose to [move Service][2] to the new domain, you also need to apply multiple database changes.

Customers might have emails from either support or marketing that have URLs pointing to the old URL, so it is a good idea to consider setting up redirects.

**How will clients know where CRM web is installed for authentication?**

From 8.1 this preference will tell all clients where the Sales Web client is installed. This means that when an unauthorized user tries to access either Sales web client or Service, they will be automatically forwarded to the URL added to this preference and after successful authentication, they are returned to where they came from.

![x -screenshot][img3]

<!-- Referenced links -->
[1]: ../../install/iis/reverse-proxy.md
[2]: move-crm-server.md

<!-- Referenced images -->
[img3]: media/baseurl81.png
