---
title: Replace sandbox
uid: replace_prod_sandbox
description: SuperOffice Operation Center for customer administrators with a production sandbox
author: Bergfrid Dias
date: 12.06.2021
keywords: production sandbox, test environment, OC, clone
topic: howto
envir: cloud
client: online
---

# SuperOffice Operation Center for customer administrators with a production sandbox

As a CRM Online customer with a registered [production sandbox][2], you can request to replace the current copy with a new fresh copy of the production database.

We offer this as a self-service task in the [SuperOffice Operation Center][1] (OC).

## Before you begin

* Sign in to OC with your SuperOffice administrator user.

* Take a close look at the **Database Size** on the **Metered Services** tile. The database size will influence how long some of the steps in the process will take, and in this first version, we do not give feedback on how long each task takes.

## Replace a sandbox environment

In the following example, cust34506 is the sandbox environment, cust21513 is the production environment.

1. Choose the tenant you want to replace in the drop-down. You can access all tenants you have access to.

    ![OC select tenant -screenshot][img1]

2. Locate the **Test Environment Info** tile and click anywhere marked as yellow in the screenshot below.

    ![OC Test Environment Info tile -screenshot][img2]

    The **Source** link will just take you back to that tenant.

3. Click **Replace** to start the wizard.

    ![OC Replace sandbox -screenshot][img3]

4. Assign users that should have access to the sandbox. It will automatically add those who have a login.

    ![OC Replace sandbox, map users and licenses -screenshot][img4]

5. To reduce the risk of sending emails from the sandbox, we invalidate all email addresses by default. For example, jenny@company.com is change to jenny_company.com@mailinator.com. You may specify another email domain, **default is mailinator.com**.

    ![OC Replace sandbox, invalidate email addresses -screenshot][img5]

6. By default, no documents will be copied to the production sandbox. Choosing to copy all or some will be time-consuming.

    ![OC Replace sandbox, documents -screenshot][img6]

7. The Service *attachment* folder might be huge, excluding all attachments from Service requests is recommended.

    ![OC Replace sandbox, attachments -screenshot][img7]

8. **Scheduled tasks** will be stopped, but you can enable them by ticking the box.

    ![OC Replace sandbox, scheduled tasks -screenshot][img8]

9. Select **running mode**. The checkbox is marked by default, meaning the sandbox will be set to running when the cloning completes.

    ![OC Replace sandbox, running mode -screenshot][img9]

10. Last step - mark the checkbox to confirm that you want to replace the existing copy. **There is no going back.**

    ![OC Replace sandbox, confirm -screenshot][img10]

11. Click **Confirm** to start the process. This may take a lot of time and the first step is time-consuming, see [list of steps][3].

    ![OC Replace sandbox, start -screenshot][img11]

12. When the dialog disappears, your production sandbox is ready with a fresh new copy from the source.

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
