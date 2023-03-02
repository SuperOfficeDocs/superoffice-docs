---
uid: help-en-sign-in-to-superoffice
title: Logging in
description: Log in to activate your SuperOffice CRM account using a SuperOffice CRM password or a single sign-on option.
author: SuperOffice RnD
so.date: 03.02.2023
keywords: CRM, sign in, login
so.topic: howto
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

    ![Enter password -screenshot][img6]

    ![Password strength -screenshot][img3]

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

    ![Enter password -screenshot][img6]

    ![Password strength -screenshot][img3]

    SuperOffice will indicate whether you choose a strong or a weak password. We advise you to choose a strong password.

1. After you enter your login details, your account is activated and SuperOffice CRM will open. As long as you are logged in to your Microsoft 365 or Google Workspace, you will not be asked to enter your user credentials in order to log in to SuperOffice CRM.

When you are no longer signed in with your Microsoft 365 or Google Workspace user credentials, SuperOffice CRM will ask you to verify who you are via your Microsoft 365 or Google Workspace account.

**Microsoft 365:**

![Log in Microsoft -screenshot][img4]

![Log in Microsoft -screenshot][img9]

**Google Workspace:**

![Log in Google -screenshot][img7]

![Log in Google -screenshot][img8]

> [!NOTE]
> If you have problems accessing SuperOffice CRM via your managed single sign-on system, you need to contact your company's IT support for help.

## <a id="forgot-password" />Forgot your password?

People often forget their credentials, especially their password. Therefore, it might come in handy to know how to change or reset your SuperOffice CRM password. Follow the instructions for your version of SuperOffice to change your password.

### Online

1. Click the **Forgot your password?** link.
2. Enter you email address.
3. Click **Reset Password**.

You will receive an email that allows you to change your password.

### Onsite

Contact your SuperOffice administrator to receive a new password.

## Log in to Settings and maintenance

When you start Settings and maintenance, you will see a login screen where you must enter a user ID and password to open the program.

* Enter your user ID and password and click **OK**.

<!-- onsite-->
> [!NOTE]
> The first time you run Settings and maintenance, a dialog displays an amendment to the Terms of Service. Please read this important information and click **Accept** and **OK** to continue using Settings and maintenance. This dialog will not be displayed again.

You must belong to the *User level 0* role or another role that gives you login rights for Settings and maintenance. User IDs, passwords and user levels are all defined in the [Users screen][2].

> [!TIP]
> You can also open Settings and maintenance via the **File** menu in SuperOffice CRM for Windows, or from the main menu in SuperOffice CRM for Web.

## How do I get to Service?

1. Click ![icon][img2] **Service** in the navigator on the left side of the screen.

1. Click **Log in**. This takes you to the dashboard in SuperOffice Service.

> [!TIP]
> To log out of SuperOffice Service, click the ![icon][img1] Personal settings icon at the top of the screen, and select **Log out**.

In SuperOffice Service you can also log in as the same user in several browsers / multiple sessions.

## Related content

Have trouble logging in? [Check our FAQs][1] for different log-in issues for help.

* [What to do when I cannot login to SuperOffice CRM Online?][3] - FAQ
* [What to do when a newly created user cannot log in to SuperOffice CRM?][4] - FAQ
* [How do I change the password I forgot in SuperOffice CRM Online?][5] - FAQ
* [Options in the Personal settings menu][6]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/support-faqs/
[2]: ../../admin/user-management/learn/index.md
[3]: https://community.superoffice.com/en/support-faqs/faq/what-to-do-when-i-cannot-login-to-superoffice-crm-online/
[4]: https://community.superoffice.com/en/support-faqs/faq/what-to-do-when-a-newly-created-user-cannot-log-in-to-superoffice-crm/
[5]: https://community.superoffice.com/no/support-faqs/faq/how-do-i-change-a-forgotten-password-in-superoffice-crm-online/
[6]: preferences.md#options
[7]: ../../identity-management/single-sign-on/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/personal-settings-small.png
[img2]: ../../../../common/icons/nav-cs.png
[img3]: media/create-password-strenght-indicator.png
[img4]: media/login-screen.png
[img5]: media/activate-now-email.png
[img6]: media/create-password.png
[img7]: media/login-screen-google.png
[img8]: media/login-screen-google-password.png
[img9]: media/login-screen-microsoft-password.png
