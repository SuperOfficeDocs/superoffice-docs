---
title: Active Directory authentication
uid: set_up_ad_auth
description: How to setup AD authentication
author: SuperOffice Product and Engineering
keywords:
content_type: howto
deployment: onsite
platform: web
index: true
---

# Active Directory authentication

SuperOffice uses a plugin-based, open-ended authentication system. By default, we deliver an Active Directory authentication plugin and the SuperOffice authentication type. To be able to change and add users you need the functional right General administrator or User administrator.

SuperOffice integrates well with an existing Active Directory infrastructure allowing users to easily log in using their existing domain credentials. This is a user-friendly and secure way to integrate SuperOffice into your environment and it does not impose new credentials for your users to remember. Another advantage is that the existing password policy is enforced making sure that users have strong passwords

From SuperOffice 8.1 all user authentication is done by the Web client. In earlier versions both Web and Service had their own login making AD authentication a bit more difficult than from 8.1.

If you have users from different domains, then make sure that the domain you want to add users from is set up in the [SuperOffice Web config][1] when you add users.

> [!NOTE]
> Our [recommended installation scenario #2][2] is to use [Reverse Proxy][3] in the DMZ. To get the Single Sign-on experience where the user does not get the login dialog at all, it would require that the Active Directory is exposed to the DMZ. This is NOT a recommended scenario and we strongly advise against that.

## How to setup AD authentication

You need to enable and set up AD authentication in NetServer:

1. Open the **Product configuration** application.

2. Click on the **AD integration** section.

    ![AD in NS.png -screenshot][img1]

3. Tick the Enable AD Authentication checkbox

4. Fill in the correct AD Domain, Username, Password, and Container. *Container* is the root node in AD from where the lookup procedure will start looking for AD users when linking them to SuperOffice users.

5. Click on the **Validate** button to confirm that your AD user can authenticate.

## Troubleshooting

### SuperOffice NetServer server is not in your Active Directory domain

The Settings and maintenance (Administration) module in SuperOffice 8 is entirely web-based, which means that the module totally relies on the NetServer. To find and import Active Directory users your SuperOffice NetServer server has to be in the Active Directory domain.

### SuperOffice user and Active Directory link has been lost or corrupted in the database

SuperOffice CRM uses SID (security identifier) value to link an Active Directory identity to SuperOffice user. If for some reason SID has been changed, the user won't be able to log in and you won't find it in the AD user list. We recommend following the steps below to troubleshoot this situation:

1. Make sure that the user object in Active Directory was populated with First Name, Last Name, and Display Name attributes.

2. Checked that the Security pane on the user object has **Allow inheritance** ticked on - on the actual object and all the corresponding OUs. (required for Active Directory authentication to work)

3. Open the user object and take a note of the SID of the user in question.

4. In the SuperOffice database, look up the `associate_id` in the `ASSOCIATE` table

5. In the CREDENTIALS table, make a search for the SID or check which SID associate has.

6. If it is different, delete the row of this user in the CREDENTIALS table and re-link the user in the SuperOffice administration client.

<!-- Referenced links -->
[1]: ../../../onsite/install/web-client/index.md
[2]: ../../../onsite/security/deployment-scenarios.md
[3]: ../../../onsite/install/iis/reverse-proxy.md

<!-- Referenced images -->
[img1]: media/ad-in-ns.png
