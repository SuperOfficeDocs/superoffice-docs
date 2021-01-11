---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: send_welcome_emails       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Send welcome emails to new users  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                     # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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

    ![Send welcome email - admin client][img1]

### ...to SCIM users

1. Sign in to the [SuperOffice Identity Manager][1].
2. Turn on the **Send Welcome Email** setting in the upper right corner.

    ![Send welcome email - SCIM][img2]

## Resend welcome email

The sign-in link in the welcome email can only be used once. If the user has not signed in yet, and can't find the email in their inbox, an administrator can manually send a new welcome email.

**After the 1st sign-in, the welcome email can no longer be sent.** The user must instead [reset their password][2] if unable to sign in.

**To send a welcome email to 1 user:**

1. Sign in to the SuperOffice Admin client.

2. Go to the **Users** page.

3. Select the user from the **Associates** list.

4. Click the **Task** button and then select **Send welcome email**.

    ![Send welcome email][img3]

### Why has the user not clicked the link in the welcome email yet?

* The user did read the email but didn't take action.

* The user didn't see the email in their inbox, either because they skipped it or it was labeled as spam.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/provision-users-with-scim/sign-in-to-scim/
[2]: reset-password.md

<!-- Referenced images -->
[img1]: media/soadm-send-welcome-email.png
[img2]: media/scim-send-welcome-email.png
[img3]: media/task-send-welcome-email.png