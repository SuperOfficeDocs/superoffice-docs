# What to do when a newly created user cannot log in to SuperOffice CRM?

I have created a new user in SuperOffice CRM, but it cannot log in. Why does it happen and how do I fix it?

There are some known reasons why newly created user can not log in. The solutions depend on the type of SuperOffice CRM that is used:

* If you use SuperOffice CRM Online, [click this section](https://community.superoffice.com/en/support-faqs/faq/what-to-do-when-a-newly-created-user-cannot-log-in-to-superoffice-crm/#1)

* If you use SuperOffice CRM Onsite, [click this section](https://community.superoffice.com/en/support-faqs/faq/what-to-do-when-a-newly-created-user-cannot-log-in-to-superoffice-crm/#2)

### A newly created user cannot log in to SuperOffice Online

There are two common situations when a new user cannot log in:

1. When a new user was created without an e-mail address, the user name is not an e-mail address or the e-mail address that has been used is not valid. Please follow the steps below to confirm that the e-mail address is correctly filled in:

    1. Log in to [Settings & Maintenance](https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=10106).

    1. Click on **Users** (1) and in the list of users select the user, which cannot log in (2).

        ![Select User][img1]
    
    1. Please make sure that the user has a valid e-mail address filled in because this e-mail address will receive an activation e-mail.

        ![Make sure the email is filled in for recieving activation email][img2]

1.  When the new user's account is not activated. Please make sure that the user has received the activation e-mail, that the activation link has been pressed within 48 hours.

    ![Activation Email][img3]

> [!NOTE]
> Please make sure that the user has followed instructions on how to log in to SuperOffice CRM, please refer to [this article](https://community.superoffice.com/en/learning/user-guide/get-started/login-and-activation/) for more information.

### A newly created user cannot log in to SuperOffice Onsite

The most common situation when a new user cannot log in is when a SuperOffice licence is properly assigned during the creation process.

If you use SuperOffice 9, please confirm that the user has a licence (1) assigned and **Can log** in (2) toggle is enabled. If that was in place already, please try to remove the licence, **Save** (3) the user. Then give a licence and toggle login again.

![Give Licence][img4]


If you use SuperOffice 8, please follow the steps below:

1. Begin by removing a licence. Click on the user (1) which cannot log in, deselect **Active user** (2), and clicking on the **Save** button (3).

    ![Deselect Active User][img5]

1. Then, again assign the licence. Make sure that the same user is selected (1), then add a tick next to **Active user** (2), select the user license from the right side list (3), and click **Save** (4).

    ![Select Active User][img6]

> Note! 
>If a new user still cannot log in, you can try to update the SuperOffice CRM license, [by following the steps in this FAQ](https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113003).

[img1]:media/select-user-login.png
[img2]:media/filled-in-email.png
[img3]:media/activation-email.png
[img4]:media/give-licence-9.png
[img5]:media/deselect-active-user.png
[img6]:media/select-active-user.png