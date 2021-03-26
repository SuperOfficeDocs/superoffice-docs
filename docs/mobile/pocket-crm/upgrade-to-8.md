---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: upgrade_to_8       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:  howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
so.client: pocket              # online, web, win, pocket, or mobile
---

# Upgrade to SuperOffice 8

You may update CRM Pocket clients automatically if you currently run Pocket Server 7.3.1 (or higher).

From SuperOffice 8.0 Pocket CRM clients have a NetServer connection only and the Pocket server is obsolete.

To automatically move users from using Pocket Server to NetServer, you have to manually change a text file in the Pocket CRM Server installation.

1. Open the *Server.PROPERTIES* file in the Pocket server configuration. The default location for this file is:

`C:\Program Files (x86)\SuperOffice Pocket CRM\Tomcat 6.0\webapps\pocketcrm\WEB-INF\classes\server.properties`

2. In the file, locate the server's hostname and the path to the */services80* folder. Added the following to the **netserverUrl** property. Adjust for your endpoint version.

```text
CLIENT_CONFIGURE=soprotocol://?netserverUrl=https://socrm.myoganization.com/netserver/services80
```

3. Restart Tomcat. Normally this can be done by restarting **PocketCRM** in Local services.

![x][img1]

Now when you navigate to the Pocket configuration screen on your browser, you will see something like this:

![x][img2]

Pocket users will then be redirected immediately they restart the Pocket application.

It may be wise to let the Pocket server run for a while to be sure that all users have been "moved".

For the Pocket user it is possible to verify the redirection by checking **Task - Settings - About Pocket CRM**.

> [!NOTE]
> Server URLs must end with the correct *ServicesXX* folder.

[!include[ALT](../../onsite-setup/includes/services-end-points.md)]

![x][img3]

<!-- Referenced images -->
[img1]: media/pocketservice.jpg
[img2]: media/pocketreconfigure.png
[img3]: media/pocket-netserver.png
