---
title: Send welcome emails
uid: send_welcome_emails
description: Send welcome emails to new users
author: Bergfrid Dias
keywords:
content_type: howto
index: true
---

# Send welcome emails to new users

The administrator can choose whether or not new users shall receive a welcome email with sign-in info when their account is created.

Enable automatic welcome emails from SuperOffice **if you don't plan to handle it yourself**.

## Send automatic welcome emails

### ...to users added in the Admin client

1. Sign in to the SuperOffice Admin client.

2. Go to the **Preferences** page and select the **Global preferences** tab.

3. Scroll down to the **System** settings group and set **Send login emails to new users** to *Yes*.

4. Click **Save**.

    ![Send welcome email - admin client -screenshot][img1]

### ...to SCIM users

1. Sign in to the [SuperOffice Identity Manager][1].

2. Turn on the **Send Welcome Email** setting in the upper right corner.

    ![Send welcome email - SCIM -screenshot][img2]

## Resend welcome email

The sign-in link in the welcome email can only be used once. If the user has not signed in yet, and can't find the email in their inbox, an administrator can manually send a new welcome email.

**After the 1st sign-in, the welcome email can no longer be sent.** The user must instead [reset their password][2] if unable to sign in.

**To send a welcome email to 1 user:**

1. Sign in to the SuperOffice Admin client.

2. Go to the **Users** page.

3. Select the user from the **Associates** list.

4. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) and then select **Send welcome email**.

    ![Send welcome email -screenshot][img3]

### Why has the user not clicked the link in the welcome email yet?

* The user did read the email but didn't take action.

* The user didn't see the email in their inbox, either because they skipped it or it was labeled as spam.

<!-- Referenced links -->
[1]: ../scim/sign-in-to-scim.md
[2]: reset-password.md

<!-- Referenced images -->
[img1]: media/soadm-send-welcome-email.png
[img2]: media/scim-send-welcome-email.png
[img3]: media/task-send-welcome-email.png
