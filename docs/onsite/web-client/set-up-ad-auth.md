---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: set_up_ad_auth       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to setup AD autentication # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client: win              # online, web, win, pocket, or mobile
---

# Active Directory authentication

SuperOffice uses a plugin-based, open-ended authentication system. By default we deliver an Active Directory authentication plugin and the SuperOffice authentication type. To be able to change and add users you need the functional right General administrator or User administrator.

SuperOffice integrates well with existing Active Directory infrastructure allowing users to easily log in using their existing domain credentials. This is a user-friendly and secure way to integrate SuperOffice into your environment and it does not impose new credentials for your users to remember. Another advantage is that the existing password policy is enforced making sure that users have strong passwords

From SuperOffice 8.1 all user authentication is done by the Web client. In earlier versions both Web and Service had their own login making AD authentication a bit more difficult than from 8.1.

If you have users from different domains, then make sure that the domain you want to add users from is set up in the [SuperOffice Web configurator][1] when you add users.

> [!NOTE]
> Our [recommended installation scenario #2][2] is to use [Reverse Proxy][3] in the DMZ. To get the Single Sign-on experience where the user does not get the login dialog at all, it would require that the Active Directory is exposed to the DMZ. This is NOT a recommended scenario and we strongly advise against that.

## How to setup AD autentication

You need to enable and setup AD authentication in Netserver:

1. Open the **Product configuration** application.

2. Click on the **AD integration** section.

![AD in NS.png][4]

3. Tick the Enable AD Authentication checkbox

4. Fill in the correct AD Domain, Username, Password and Container. Container is the root node in AD from where the lookup procedure will start looking for AD users when linking them to SuperOffice users.

5. Click on the **Validate** button to confirm that your AD user can authenticate.

## Troubleshooting

### SuperOffice NetServer server is not in your Active Directory domain

The Settings and Maintenance (Administration) module in SuperOffice 8 is entirely Web based, which means that the module totally relies on the NetServer. To find and import Active Directory users your SuperOffice NetServer server has to be in the Active Directory domain.

### SuperOffice user and Active Directory link has been lost or corrupted in the database

SuperOffice CRM uses SID (security identifier) value to link an Active Directory identity to SuperOffice user. If for some reason SID has been changed, user won't be able to login and you won't find it in the AD user list. We recommend to follow the steps below to troubleshoot this situation:

1. Make sure that the user object in Active Directory was populated with First Name, Last Name and Display Name attributes.

2. Checked that the Security pane on the user object have "Allow inheritance" ticked on - on the actual object and all the corresponding OU's. (reqired for Active Directory authentication to work)

3. Open user object and take a note of SID of the user in question.

4. In SuperOffice database look up the associate\_id in the ASSOCIATE table

5. In CREDENTIALS table, make a search for the SID or check which SID associate has.

6. If it is different, delete the row of this user in CREDENTIALS table and re-link the user in SuperOffice administration client.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/install-upgrade/web/Install-web/
[2]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/deployment-scenarios/
[3]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/setting-up-a-reverse-proxy-on-iis8/
[4]: https://community.superoffice.com/contentassets/7dac40439a4444019802b6d181de8562/ad-in-ns.png