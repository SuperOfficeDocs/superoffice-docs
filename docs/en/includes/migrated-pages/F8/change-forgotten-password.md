# How do I change a forgotten password in SuperOffice CRM Online?

How do I change the password I forgot in SuperOffice CRM Online?

The instructions on how to change a forgotten password depend on the identity (ID) provider, that controls the password:

* If you use SuperOffice as the Identity provider, please [click here](https://community.superoffice.com/en/support-faqs/faq/how-do-i-change-a-forgotten-password-in-superoffice-crm-online/#1)
 
* If you use Microsoft as the Identity provider, please [click here](https://community.superoffice.com/en/support-faqs/faq/how-do-i-change-a-forgotten-password-in-superoffice-crm-online/#2)
 
* If you use Google as the Identity provider, please [click here](https://community.superoffice.com/en/support-faqs/faq/how-do-i-change-a-forgotten-password-in-superoffice-crm-online/#3)

> [!NOTE]
> If you don´t know, which identity provider you use please contact your IT responsible.

### SuperOffice as the Identity provider

When SuperOffice is in charge of password, there are two ways you can change it:

  * Change the password yourself:

  1. Click on the **Forgot your password?** link in the login screen.

      ![Click the "Forgot your password?" Link][img1]

  1. You will be redirected to https://id.superoffice.com/forgot-password where you need to fill in your e-mail address and click on **Send e-mail** button to get a password reset e-mail. Please follow the instructions in the e-mail to reset your password.

      ![Enter your email to reset your password][img2]
      
  * Ask your SuperOffice system administrator to initiate password reset process for you in SuperOffice [Settings and Maintenance](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=10106):

    1. The administrator has to choose **Users** in the Navigator menu on the left and find your user account in the **Associate** tab.
        
        ![Associate tab][img3]
    
    1.  Select your user account and click on the **Task** button at the bottom of the screen, then select the **Send Reset Password email** option. Please follow the instructions in the e-mail to reset your password.

        ![Send Reset Password Email][img4]

### Microsoft as the Identity provider

When Microsoft is in charge of your password, it has to be reset via the Microsoft password reset service. [This article](https://docs.microsoft.com/en-us/office365/admin/add-users/reset-passwords?view=o365-worldwide#reset-my-office-365-tenant-admin-password) explains how to reset your password in MS Office 365.

### Google as the Identity provider

When Google is in charge of your password, it has to be reset via the Google password reset service. [This article](https://support.google.com/a/answer/33319?hl=en) explains how to reset your password in G Suit.


### More information

TechDoc: [Introduction to SuperOffice identity management](https://docs.superoffice.com/online/identity/index.html)

TechDoc: [SuperID](https://docs.superoffice.com/online/identity/superid/overview.html)

TechDoc: [Microsoft 365 and Google Workspace document integration in SuperOffice CRM](https://docs.superoffice.com/document/cloud/overview.html)


[img1]:media/SO-login.png
[img2]:media/forgot-your-password.png
[img3]:media/associate-tab.png
[img4]:media/send-reset-password-email.png