---
uid: google-workspace-setup
title: Set up Google Workspace Document Integration
description: How to set up Google Workspace Document Integration for SuperOffice.
keywords: Google Workspace, document integration, Google-account, Google Authentication
author: Frode B, Martin Pavlas, Bergfrid Dias
date: 07.12.2024
topic: howto
envir: cloud
client: online
---

# Set up Google Workspace Document Integration

This article will help you set up the Google Workspace part of the integration between Google Workspace and SuperOffice CRM Online.

Setting up Google Workspace Document Integration has 2 parts:

* **Part 1:** Set up Google Workspace to integrate to CRM Online:

  * Prepare your SuperOffice CRM Online for the integration (step 1)
  * Prepare your Google Workspace (step 2)
  * Connect your Google Workspace and your SuperOffice CRM Online (step 3)

* **Part 2:** Configure the integration for use (user authentication + document handling)

## Before you begin

Ensure you meet the [prerequisites][1] and read the [security considerations][2].

Due to the requirements of recycling the site, it is best practice to plan ahead:

* Connecting your Google Workspace and your SuperOffice CRM Online requires recycling the site.

* Registering your IDP can be completed in advance at any time.

* Creation of the "service account" in Google Workspace can be completed in advance at any time.

* All usernames in CRM Online must match the Google domain username, and can be set in advance at any time. Remember to notify users of any change to their username.

## Step 1 – Prepare your SuperOffice installation

### 1. Update usernames in SuperOffice Settings and maintenance

All SuperOffice usernames must match the email address of a Google-account that belongs to `<customerdomain.com>`.

> [!NOTE]
> The login process of CRM Online communicates with Google Authentication and uses the CRM Online username. For Google to be able to identify and validate users, and for SuperOffice CRM Online to be able to use the credentials received from Google - **usernames in CRM Online and Google must match**.

When Google Workspace integration has been enabled in step 3, all users will be required to have a Google account and use this to log onto SuperOffice CRM Online and use the integration.

Make sure the user's username in SuperOffice CRM Online is what the their username is in Google:

![Verify matching username -screenshot][img1]

You see the Google usernames here: [https://admin.google.com/ac/users][4]

### 2. Make sure you have registered your IDP for your domain

Read how-to here: [How to configure IDP][3]

## Step 2 - Create a Google Workspace "service-account" (recommended)

[!include[recommendation](./includes/g-suite-service-account-recommended.md)]

To create a Google Google Workspace service-account for SuperOffice in your Google Workspace domain:

1. Log into your Google Workspace installation as a Google Workspace administrator. In a browser, go to `http://admin.google.com` and navigate to the ['users' section.][4]

2. Add a new user.

3. Fill in the form with suitable information.

    * Bear in mind that the name for this user will be visible for users when they see a shared document in their Google Drive folder.

    * Do also fill in a sufficiently complex password, document it, and remember it. You will need to sign into this account later.

4. Log out of your Google Workspace Admin account. Access the logout button from the top-right corner.

5. Log into your new Google Workspace Service-account to validate the account.

    * Go to [https://accounts.google.com][5].
    * Log in using the details you used to create the service-account in the previous step. (Do not log in using your Google Workspace Admin account).

If successful, you should be brought to a page that shows you information about your current account.

## Step 3 – Connect Google Workspace and SuperOffice CRM Online

To connect Google Workspace and CRM Online - you may use standard setup (Root folder in Drive) or choose to specify where in the Drive folder structure to store the templates and documents.

You may also choose if you want to use SuperOffice standard folder rights (Access to all in `<customerdomain.com>`), or use inherited folder rights by choosing "Use inherited permission".

> [!CAUTION]
> Your site must be **recycled** to get the new configurations! All users on this site will be logged out when you click **Configure SuperOffice** in the step below. The users may log in again right afterward, but they might loose unsaved work.

To connect your SuperOffice Online installation to Google:

1. Ensure you logged into your SuperOffice CRM Online installation.

2. Go to [https://cloudintegration.superoffice.com/app][6]. You will be asked to authorize SuperOffice and grant it access to your Google Workspace service-accounts data.

3. Supply your new Google Workspace Service-account (created in step 2 above).

    Ensure that you are approving on behalf of the service-account and not your regular user-account by checking the account chosen!

    ![Enter Google Workspace Service-account -screenshot][img2]

4. Click **Continue**.

    * If you are not logged into the Google Workspace account - you will be redirected to do so.

    * If you have failed to register IDP correctly before this, you may get a warning both "This app has not been verified by google" and "SuperOffice.com wants to access your Google account". You may approve and continue.

5. Review the settings: Either leave settings as is - or change them to your preference.

    ![Review settings -screenshot][img3]

6. Click **Configure SuperOffice**.

    If the linking of SuperOffice and Google is successful this will be reported. (If the linking fails - please contact SuperOffice Support.)

    ![SuperOffice and Google successfully linked -screenshot][img4]

Your SuperOffice Online installation is now able to talk to Google Workspace and use your service account's Google Drive as a document-storage backend.

## Step 4 – Update document template storage location in SuperOffice

Follow the instructions to [link document templates][7]. This will store the template in the Google cloud, and when the user uses this template - the document created will also be saved in the Google cloud and opened with Google Drive.

For Google Workspace specifically:

* Set **Store template in** to "Google".

    ![Edit template item -screenshot][img5]

* Set **Document stored in** to "Google".

    ![Document stored in -screenshot][img6]

> [!NOTE]
> All documents written in SuperOffice will be stored in the Google cloud if the template is set up for it, and available to open and edit in SuperOffice CRM Online.

* If you want to use your Google Workspace account to edit SuperOffice templates, the SuperOffice templates need to be moved from SuperOffice to your Google Workspace account. If this is not a requirement, the template can stay put in CRM Online storage (SO Archive) if you like.

* Old documents will not automatically be moved from SuperOffice to Google Workspace.

* Moving existing documents or templates to or from SuperOffice and the is not offered as a service. A SuperOffice consultant might be able to assist you in a manual transition.

<!-- Referenced links -->
[1]: requirements.md
[2]: security.md
[3]: ../../../identity-management/superid/howto/register-idp.md
[4]: https://admin.google.com/ac/users
[5]: https://accounts.google.com/
[6]: https://cloudintegration.superoffice.com/app
[7]: ../../templates/admin/link-template.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/image58qub.png
[img2]: ../../../../media/loc/en/document/image0ox0s.png
[img3]: ../../../../media/loc/en/document/image5avtq.png
[img4]: ../../../../media/loc/en/document/imageu3rda.png
[img5]: ../../../../media/loc/en/document/template3.png
[img6]: ../../../../media/loc/en/document/template3b.png
