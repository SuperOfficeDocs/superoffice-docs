---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: replace_test_envir # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SuperOffice Operation Center for customer administrators with test environment # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id} # Your GitHub alias.
keywords:
so.topic:     # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud     # cloud or onsite
so.client: online   # online, web, win, pocket, or mobile
---

# SuperOffice Operation Center for customer administrators with test environment

As a CRM Online customer with a registered test environment you may request to replace the test environment with a new fresh copy of the production database.

As a SuperOffice administrator (with access to Settings and Maintenance client) you may log in to the [SuperOffice Operation Center][1].

You will be able to access all [tenants][2] you have access too. If you want to replace your test environment (cust34506) with a fresh copy of the production environment (cust21513) this have been made into a self-service task here.

![imaget39w.png][img1]

Before you start the replacement, take a close look at the **Database Size*. under **Metered Services.*. The database  size will influence how long some of the steps in the process takes, and in this first version we do not give feedback on how long each tasks takes.

## Start process to replace test environment

1. Choose the test environment you want to replace in the drop-down.
![imagezzpup.png][img2]

2. The tile **Test Environment Info** will assist you through the cloning process. To start click anywhere marked as yellow in the screenshot above. The link to Source will just take you back to that tenant.

3. To start click **Replace**
![imageclhp.png][img3]

4. Assign users that should have access to the test environment. It will automatically add those who have a login
![Replace1.PNG][img4]

5. To reduce the risk of sending emails from the test environment we by default invalidate all email addresses.Invalidate email address will take **jenny@company.com** and change to **jenny\_company.com@mailinator.com**You may specify another email domain, **default is mailinator.com**.
![Replace2.PNG][img5]

6. Default no documents will be copied to the test environment. Choosing to copy all or some will be time-consuming
![Replace3.PNG][img6]

7. Service attachement folder may be huge, excluding all attachments from Service requests is recommended.
![Replace4.PNG][img7]

8. Scheduled tasks will be stopped, but you may enable them by ticking the box.
![Replace5.PNG][img8]

9. Set test environment as running after cloning is done is ticked by default.
![Replace6.PNG][img9]

10. Last step - confirm by checking the box that you really want to replace the existing test environment. There is no going back.
![Replace7.PNG][img10]

11. Now when you click **Confirm*. the process starts. This may take a lot of time and the first step is time-consuming, see [list of steps][3].
![image9vgqg.png][img11]

12. When the dialog disappears your test environment is ready with a fresh new copy from source.

## Is the test environment identical to production?

Yes, almost. All the customer data, like company, contact, sale, and project are there, but when we copied your production database into the test environment we removed some personal information.

* We removed all login information and emails from email accounts set up by your users that use the SuperOffice inbox.
* We also removed all email account set up to use with Service and created a new for this environment only.
* We close any open ticket in Service.
* Any web panel referring to Service functionality using full path like *online**X**.superoffice.com/custXXX/CS/Scripts/xxxx* have been replaced with a template variable:
  * csti - URL to *ticket.fcgi*
  * csrm - URL to *rms.fcgi*
  * cscu - URL to *customer.fcgi*
  * csbl - URL to *blogic.fcgi*

![imageu533bo.png][img12]

* All scheduled tasks has been marked as disabled unless you chose to enable them in the wizard
* Also - any SuperOffice App Store app that was authorized on your production database will not work in the test environment and you will have to sign up again if you want to use it in the test environment. The authorization/approval for the app to access a specific installation is a one-to-one link.

If you have ERP sync apps in production you should log in to Settings and Maintenance and turn off automatic syncing. Since these apps are not authorized on the test tenant it will not sync, just generate errors.

![imagemvheo.png][img13]

> [!NOTE]
> Any data that was created by the app will still be in your test environment, like the web panels that were automatically set up by the app. You may hide them in the test environment admin under.

[Lists - GUI Web panel][4]

<!-- Referenced links -->
[1]: https://online.superoffice.com/oc2
[2]: index.md
[3]: clone-to-test-envir.md
[4]: https://community.superoffice.com/documentation/help/en/crm/8.4/webhelpadmin/chap08/Webpanel.htm

<!-- Referenced images -->
[img1]: media/imaget39w.png
[img2]: media/imagezzpup.png
[img3]: media/imageclhp.png
[img4]: media/replace1.png
[img5]: media/replace2.png
[img6]: media/replace3.png
[img7]: media/replace4.png
[img8]: media/replace5.png
[img9]: media/replace6.png
[img10]: media/replace7.png
[img11]: media/image9vgqg.png
[img12]: media/imageu533bo.png
[img13]: media/imagemvheo.png
