---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: g_suite_set_up       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Setup - G Suite Document Integration # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Setup - G Suite Document Integration

This article will help you set up the G Suite part of the integration between G Suite and SuperOffice CRM Online.

Setting up G Suite Document Integration has 2 parts:

* Set up G Suite to integrate to CRM Online:
  * Prepare your SuperOffice CRM Online for the integration (step 1)
  * Prepare your G Suite (step 2)
  * Connect your G Suite and your SuperOffice CRM Online (step 3)
* Configure the integration for use (user authentication + document handling)

## Before you begin

Ensure you meet the [prerequisites][1] and read the [security considerations][2].

Due to the requirements of recycling the site, it is best practice to plan ahead:

* Connecting your G Suite and your SuperOffice CRM Online requires recycling the site
* Registering your IDP can be completed in advance at any time
* Creation of the "service account" in Google G Suite can be completed in advance at any time
* All usernames in CRM Online must match the Google domain username, and can be set in advance at any time. Remember to notify users of any change to their username.

## Step 1 – Prepare your SuperOffice installation

### 1. Update usernames in SuperOffice CRM Online Admin

All SuperOffice user names must match the email address of a Google-account that belongs to `<customerdomain.com>`.

> [!NOTE]
> The login process of CRM Online communicates with Google Authentication and uses the CRM Online username. For Google to be able to identify and validate users, and for SuperOffice CRM Online to be able to use the credentials received from Google - user names in CRM Online and Google must match.

When Google G Suite integration has been enabled in step 3, all users will be required to have a Google account and use this to log onto SuperOffice CRM Online and use the integration.

Make sure the user's user names in SuperOffice CRM Online is what the user's user name is in Google:

![image58qub.png][img1]

You see the Google user names here: [https://admin.google.com/ac/users][4]

### 2. Make sure you have registered your IDP for your domain

Read how-to here: [How to configure IDP][3]

## Step 2 - Create a Google G Suite "service-account" (recommended)

[!include[recommendation](./includes/g-suite-service-account-recommended.md)]

To create a Google G Suite service-account for SuperOffice in your Google G Suite domain:

1. Log into your Google G Suite installation as a Google G Suite administrator. In a browser, go to `http://admin.google.com` and navigate to the ['users' section.][4]

2. Add a new user.

3. Fill in the form with suitable information.

    * Bear in mind that the name for this user will be visible for users when they see a shared document in their Google Drive folder.
    * Do also fill in a sufficiently complex password, document it, and remember it. You will need to sign into this account later.

4. Log out of your Google G Suite Admin account. Access the logout button from the top-right corner.

5. Log into your new Google G Suite Service-account to validate the account.

    * Go to [https://accounts.google.com][5].
    * Log in using the details you used to create the service-account in the previous step. (Do not log in using your Google G Suite Admin account).

If successful, you should be brought to a page that shows you information about your current account.

## Step 3 – Connect Google G Suite and SuperOffice CRM Online

To connect Google G Suite and CRM Online - you may use standard setup (Root folder in Drive) or choose to specify where in the Drive folder structure to store the templates and documents.  
You may also choose if you want to use SuperOffice standard folder rights (Access to all in `<customerdomain.com>`), or use inherited folder rights by choosing "Use inherited permission".

> [!NOTE]
> Your site must be ‘recycled’ to get the new configurations! All users on this site will be logged out when you click “Configure SuperOffice” in the step below. The users may log in again right afterward, but they might loose unsaved work.

To connect your SuperOffice Online installation to Google:

1. Ensure you logged into your SuperOffice CRM Online installation

2. Go to [https://cloudintegration.superoffice.com/app][6]

You will then be asked to authorize SuperOffice and grant it access to your Google G Suite service-accounts data.

Ensure that you are approving on behalf of the service-account and not your regular user-account by checking the account chosen!

Supply your new Google G Suite Service-account (created in step 4 above)

Click **Continue**.

![image0ox0s.png][img2]

If you are not logged into the G Suite account - you will be redirected to do so.

If you have failed to register IDP correctly prior to this, you may get a warning both "This app has not been verified by google" and "SuperOffice.com wants to access your Google account". You may approve and continue.

![image5avtq.png][img3]

Either leave settings as is - or change them to your preference.

Click **Configure SuperOffice**.

![imageu3rda.png][img4]

If the linking of SuperOffice and Google is successful this will be reported. (If the linking fails - please contact SuperOffice Support.)

Your SuperOffice Online installation is now able to talk to Google G Suite and use your service-accounts Google Drive as a document-storage backend.

## 4 – Update document template storage location in SuperOffice Admin

This step is the same for both MS Office 365 and Google G Suite document integration.

[Configure Cloud Office document handling][7].

<!-- Referenced links -->
[1]: requirements.md
[2]: security.md
[3]: ../../identity-management/superid/register-idp.md
[4]: https://admin.google.com/ac/users
[5]: https://accounts.google.com/
[6]: https://cloudintegration.superoffice.com/app
[7]: ../configure-cloud-document-handling.md

<!-- Referenced images -->
[img1]: media/image58qub.png
[img2]: media/image0ox0s.png
[img3]: media/image5avtq.png
[img4]: media/imageu3rda.png
