---
title: Add a user
uid: add_user_in_admin_client
description: Add a user in the Admin client
author: Bergfrid Dias
keywords:
content_type: howto
index: true
---

# Add a user in the Admin client

Administrators can add users one by one in the Admin client.

**Pre-requisites:**

* You have an admin account for SuperOffice CRM Online.

**Procedure:**

1. Sign in to the SuperOffice Admin client
2. Select **Users** from the Navigator and then select the **Associates** tab.

3. Click **Add** to open the **Contact** dialog and enter information:

    * Make sure the SuperOffice **User name** is equal to the username (UPN) in your IdP system if using [federated sign-in][1]] for this domain.

    * Assign groups and a [role][2].

    * Select the licenses (user plans) you want to assign.

        ![Add user -screenshot][img1]

4. Click **Save**. Users will receive an invitation email in their inbox and need to click the activation link to enable the account.

    ![invite Google -screenshot][img2]
    ![invite Microsoft 365 -screenshot][img3]

<!-- Referenced links -->
[1]: ../superid/sign-in-services.md
[2]: index.md

[img1]: media/soadm-add-user.png
[img2]: media/googleinvite.png
[img3]: media/o365invite.png
