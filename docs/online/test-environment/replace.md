---
title: Replace test environment 
uid: replace_test_envir
description: SuperOffice Operation Center for customer administrators with test environment
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# SuperOffice Operation Center for customer administrators with test environment

As a CRM Online customer with a registered test environment, you may request to replace the test environment with a new fresh copy of the production database.

As a SuperOffice administrator (with access to Settings and Maintenance client) you may log in to the [SuperOffice Operation Center][1].

You will be able to access all [tenants][2] you have access to. If you want to replace your test environment (cust34506) with a fresh copy of the production environment (cust21513) this has been made into a self-service task here.

![imaget39w.png -screenshot][img1]

Before you start the replacement, take a close look at the *Database Size* under *Metered Services*. The database size will influence how long some of the steps in the process will take, and in this first version, we do not give feedback on how long each task takes.

## Start the process to replace test environment

1. Choose the test environment you want to replace in the drop-down.

    ![imagezzpup.png -screenshot][img2]

2. The tile **Test Environment Info** will assist you through the cloning process. To start click anywhere marked as yellow in the screenshot above. The link to Source will just take you back to that tenant.

3. To start click **Replace**

    ![imageclhp.png -screenshot][img3]

4. Assign users that should have access to the test environment. It will automatically add those who have a login.

    ![Replace1.PNG -screenshot][img4]

5. To reduce the risk of sending emails from the test environment we by default invalidate all email addresses. Invalidate email address will take jenny@company.com and change to jenny_company.com@mailinator.com. You may specify another email domain, **default is mailinator.com**.

    ![Replace2.PNG -screenshot][img5]

6. Default no documents will be copied to the test environment. Choosing to copy all or some will be time-consuming

    ![Replace3.PNG -screenshot][img6]

7. The Service *attachment* folder may be huge, excluding all attachments from Service requests is recommended.

    ![Replace4.PNG -screenshot][img7]

8. Scheduled tasks will be stopped, but you may enable them by ticking the box.

    ![Replace5.PNG -screenshot][img8]

9. Set test environment as running after cloning is done is ticked by default.

    ![Replace6.PNG -screenshot][img9]

10. Last step - confirm by checking the box that you really want to replace the existing test environment. There is no going back.

    ![Replace7.PNG -screenshot][img10]

11. Now when you click **Confirm** the process starts. This may take a lot of time and the first step is time-consuming, see [list of steps][3].

    ![image9vgqg.png -screenshot][img11]

12. When the dialog disappears your test environment is ready with a fresh new copy from the source.

<!-- Referenced links -->
[1]: https://online.superoffice.com/oc2
[2]: index.md
[3]: clone-to.md

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
