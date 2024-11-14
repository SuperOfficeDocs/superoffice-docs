---
uid: help-en-sign-in-to-superoffice
title: Log in
description: Log in to activate your SuperOffice CRM account using a SuperOffice CRM password or a single sign-on option.
author: SuperOffice RnD
date: 08.28.2023
keywords: CRM, sign in, login, password, single sign-on
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Log in

SuperOffice is a web-based system. This means you must be connected to the internet before you log in.

When you start SuperOffice CRM or Service, you will see a login screen where you must enter a user ID and password to open the program.

1. Enter your user ID and password.
2. Select **Log in**. Wait a moment while the program starts up.

To use SuperOffice CRM, you must be assigned a user account that is unique for you. This user account contains your user identification and a password known only to you and the system, commonly referred to as your *user credentials*. Your user credentials allow the system to verify that you are you, which is necessary before allowing you to access your company's CRM solution.

## What is my user ID?

For online and web users, the user ID is your email address.

Windows users must use their assigned user name.

## Activate account

There are two ways you can log in to activate your SuperOffice CRM account for the first time. How you log in depends on your company's preference.

* By using a SuperOffice CRM password that is unique when you log in to SuperOffice CRM.

* By using a single sign-on system where you log in to SuperOffice CRM using your username and password from another solution, such as Microsoft 365 or Google Workspace.

### Log in with a SuperOffice password

1. After your administrator adds you as a user to your SuperOffice CRM solution, you will receive an email asking to you activate your account.

    ![Activation email -screenshot][img5]

1. Click the **Activate now** link in the email.In the SuperOffice CRM login screen, enter your own password.

    ![Enter password -screenshot][img6] ![Password strength -screenshot][img3]

1. After you have activated your account, you will enter SuperOffice CRM and can start using it.

1. After the first login, you can re-login using your user identification and the password you just set.

    ![Log in -screenshot][img4]

    * If you have problems activating your account, [contact our support][1].

    * If you do not immediately get the option to create a SuperOffice password, then it is likely that your company is using a [single sign-on system][7] to manage your user credentials. See below to learn how to activate your account using the single sign-on option.

### Log in with single sign-on

1. If your company uses Microsoft 365, Active Directory, or Workspace from Google for user authentication, these can be connected to SuperOffice CRM so that the same system verifies you across all your different services. This is often referred to as single sign-on.

1. After your administrator adds you as a user to your SuperOffice CRM solution, you will receive an activation email.

    ![Activation email -screenshot][img5]

1. Click the **Activate now** link in the email and you will get the option to enter your email address.

    ![Enter password -screenshot][img6] ![Password strength -screenshot][img3]

    SuperOffice will indicate whether you choose a strong or a weak password. We advise you to choose a strong password.

1. After you enter your login details, your account is activated and SuperOffice CRM will open. As long as you are logged in to your Microsoft 365 or Google Workspace, you will not be asked to enter your user credentials in order to log in to SuperOffice CRM.

When you are no longer signed in with your Microsoft 365 or Google Workspace user credentials, SuperOffice CRM will ask you to verify who you are via your Microsoft 365 or Google Workspace account.

**Microsoft 365:**

![Log in Microsoft -screenshot][img4] ![Log in Microsoft -screenshot][img9]

**Google Workspace:**

![Log in Google -screenshot][img7] ![Log in Google -screenshot][img8]

> [!NOTE]
> If you have problems accessing SuperOffice CRM via your managed single sign-on system, you need to contact your company's IT support for help.

## Log in to Settings and maintenance

When you start Settings and maintenance, you will see a login screen where you must enter a user ID and password to open the program.

* Enter your user ID and password and click **OK**.

> [!NOTE]
> Onsite: The first time you run Settings and maintenance, a dialog displays an amendment to the Terms of Service. Please read this important information and click **Accept** and **OK** to continue using Settings and maintenance. This dialog will not be displayed again.

You must belong to the *User level 0* role or another role that gives you login rights for Settings and maintenance. User IDs, passwords and user levels are all defined in the [Users screen][2].

> [!TIP]
> You can also open Settings and maintenance via the **File** menu in SuperOffice CRM for Windows, or from the main menu in SuperOffice CRM for Web.

## How to change your password

1. Select <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal Settings** > **Change password**.
2. Enter the new password in the **New password** field.
3. Enter it again in the **Repeat password** field to ensure you entered it correctly first time round.
4. Click **OK**.

> [!NOTE]
> Multiple authentication methods are available, so it depends of what authentication method your user is set up with and if you can change the password here.

## Troubleshooting

There could be several reasons why you are unable to log in to SuperOffice CRM.

### If you have never logged in before

If your SuperOffice installation uses SuperID authentication, check your inbox for an invitation email. You need to click the activation link to activate the SuperOffice user. If you cannot find the email in the main inbox, check a Spam folder or ask your administrator to resend the welcome email.

Still cannot log in for the first time? Contact your SuperOffice administration and ask them to confirm that when your [user was created][3], a user plan was selected and that your contact card has the same email address as your user card in Settings and maintenance.

### If you were able to log in to SuperOffice Online earlier

1. First, make sure you did not make any spelling mistakes, CapsLock is not On, and NumLock is on if you used numbers in your password.

1. Try to log in to SuperOffice Online using a different browser. If that works, you need to [delete cookies of the browser you usually use][12].

1. Does your contact have more than one email address in the contact card? Try to delete the email address you do NOT use to log in.

### <a id="forgot-password"></a>Forgot your password?

People often forget their credentials, especially their password. Therefore, it might come in handy to know how to change or reset your SuperOffice CRM password. Follow the instructions for your version of SuperOffice to change your password.

#### Online

1. Click the **Forgot your password?** link in the Login screen.
2. Enter you email address.
3. Click **Reset Password**.

You will receive an email that allows you to change your password.

> [!NOTE]
> When **Microsoft** is in charge of your password, it has to be reset via the [Microsoft password reset service][10].
> When **Google** is in charge of your password, it has to be reset via the [Google password reset service][11].
> If you do not know, which identity provider you use please contact your IT responsible.

#### Onsite

Contact your SuperOffice administrator to receive a new password.

## Related content

* [Options in the Personal settings menu][6]
* [What to do when a newly created user cannot log in to SuperOffice CRM][4]
* [Introduction to SuperOffice identity management][8]
* [SuperID][9]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/support-faqs/
[2]: ../../admin/user-management/learn/index.md
[3]: ../../admin/user-management/learn/add-associate.md
[4]: ../../admin/user-management/learn/add-associate.md#troubleshooting
[6]: preferences.md#options
[7]: ../../../en/identity-management/single-sign-on/index.md
[8]: ../../../en/identity-management/overview.md
[9]: ../../../en/identity-management/superid/overview.md
[10]: https://docs.microsoft.com/en-us/office365/admin/add-users/reset-passwords?view=o365-worldwide#reset-my-office-365-tenant-admin-password
[11]: https://support.google.com/a/answer/33319?hl=en
[12]: http://www.digitaltrends.com/computing/how-to-delete-cookies-in-chrome-firefox-safari-and-ie/

<!-- Referenced images -->
[img3]: ../../../media/loc/en/learn/create-password-strenght-indicator.png
[img4]: ../../../media/loc/en/learn/login-screen.png
[img5]: ../../../media/loc/en/learn/activate-now-email.png
[img6]: ../../../media/loc/en/learn/create-password.png
[img7]: ../../../media/loc/en/learn/login-screen-google.png
[img8]: ../../../media/loc/en/learn/login-screen-google-password.png
[img9]: ../../../media/loc/en/learn/login-screen-microsoft-password.png
