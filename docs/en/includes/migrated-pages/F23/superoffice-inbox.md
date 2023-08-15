# How do I start using the SuperOffice Inbox?

How do I start using the SuperOffice Inbox?

To start using SuperOffice Inbox for reading, sending and archiving emails directly from SuperOffice CRM, please follow the steps below:

[Step 1. Confirm that your e-mail account has met prerequisites](https://community.superoffice.com/no/support-faqs/faq/how-do-i-start-using-the-superoffice-inbox/#1)

[Step 2. Set up SuperOffice as preferred email client](https://community.superoffice.com/no/support-faqs/faq/how-do-i-start-using-the-superoffice-inbox/#2)

[Step 3. Configure SuperOffice Inbox with your email account details](https://community.superoffice.com/no/support-faqs/faq/how-do-i-start-using-the-superoffice-inbox/#3)

### Step 1. Confirm that your e-mail account has met prerequisites

To be able to use an email with SuperOffice Inbox the IMAP protocol has to be enabled on the account/mailbox. Please use the resources below if you use Gmail or Office 365 e-mail.

* [How to enable IMAP on Gmail account](https://support.google.com/mail/answer/7126229?hl=en)

* [How to enable IMAP on Office 365 account](https://support.microsoft.com/en-au/help/2416434/how-to-enable-or-disable-pop3,-imap,-mapi,-outlook-web-app-or-exchange-activesync-for-a-mailbox-in-office-365)

Please check [this article](https://community.superoffice.com/en/technical/documentation/prepare/system-requirement/) for other SuperOffice requirements.

Step 2. Set up SuperOffice as preferred email client

When you log into SuperOffice CRM for the first time, the Web Tools installation dialog appears. There you can select which email client should be the default one.

If you haven't selected that SuperOffice should be the default email client before, please follow these steps:

1. Click on ![][img1] and from the drop-down menu select **Local settings**.
  
    ![Local Settings][img2]

1. Make sure that *SuperOffice CRM* is selected in the **E-mail client** (1) field and then click **OK** (2).
    
    ![SuperOffice CRM][img3]

### Step 3. Configure SuperOffice Inbox with your email account's details

Click the **Inbox** (1) button in the navigator. Enter the login form the **email address** (2) you want to configure with the SuperOffice inbox and the **password** (3) to access this email account and click **Save** (4).

![Create Password][img4]

If SuperOffice recognizes the e-mail provider (such as Gmail), the server settings will be set up automatically and the inbox will load. If not, the more settings screen will be displayed and you must fill in the required fields.

To make sure your emails are imported to SuperOffice Inbox please fill in:

* E-mail server: your IMAP server details

* User name: your user name, which is most of the time your full e-mail address

* Password: your e-mail account password

* SSL: depending on your e-mail provider's settings it can be on or off

![Account Details][img5]

To make sure you can send out emails from SuperOffice Inbox please fill in:

* Outgoing server name: your SMTP server details

* User name: your user name, which is most of the time your full e-mail address

* Password:  your e-mail account password

* SSL: depending on your e-mail provider's settings it can be on or off

Then click on **Login**. 

![Login][img6]

**Note!**

1. If you work on SuperOffice Onsite and the port has to be specified to access the e-mail server, please use a colon ":" after the email server name E.g.: "my.mail.server:80". 
 
1. SuperOffice automatically imports to database all e-mails, which were created in the last 30 days if you work on SuperOffice Online and last 180 days if you work on SuperOffice Onsite. This can be changed in the web.config < Component > section < add key="NumberOfDaysToDownload" > line. If you work with SuperOffice Online, please [contact SuperOffice support](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113431).

If you want to change your e-mail account, please follow the steps below:

1. Click on ![][img1] and then choose E-mail options.

    ![Email-Options][img7]

1. Select **E-mail account** (1) tab, press **Edit/remove** (2) button and then **OK** (3) to finish.

    ![Edit/remove][img8]

---
Please follow [this FAQ](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=10105), if you use SuperOffice Onsite 8 or any previous version.
---


[img1]:media/icon-pfp.png
[img2]:media/local-settings.png
[img3]:media/EMC.png
[img4]:media/password-save.png
[img5]:media/account-details.png
[img6]:media/login.png
[img7]:media/email-options.png
[img8]:media/email-account.png