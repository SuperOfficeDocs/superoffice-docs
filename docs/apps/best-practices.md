---
uid: app_best_practices
title: Best practices
description: Best practices for SuperOffice CRM Online apps
author: Margrethe Romnes
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Best practices for SuperOffice CRM Online apps

Everyone can need a little nudge in the right direction at times. Security is paramount; configuration is key!

Test your own software not only with SuperOffice CRM Online but also with frequently used 3rd-party software.

You must implement a [polling service][1] that periodically checks for the latest events and then process accordingly. We don't support trigger-based calls from your application when events happen in SuperOffice.

* We recommend that each application either use REST or SOAP. **Don't mix multiple APIs** in the same application.

* **Check online tenant status**: All applications should leverage the [tenant status page][2] to ensure their applications successfully access tenant resources.

* Remember to **set the visibility** of new web panels. [Set the appropriate user group and heading options][3].

## Keep your application and data secure

* Ensure your application uses the latest version of SuperOffice SOAP end-points. [Request a version update][4].

* **Authenticate** with OpenID Connect. [Validate the tokens][5] you receive back from SuperOffice CRM Online.

* **Enable logging** in your application. Keep logs for a minimum of 3 months.
  * Both you and SuperOffice are required to log network communications.
  * You may be required to provide your log files for security analysis at any time.

* Deny network traffic over non-secured connections.

* **Establish secure coding practices** appropriate to the programming language and development environment being used.

## User interaction and design

### Be consistent

* Either use Microsoft Windows standard looks, or copy the SuperOffice CRM looks, but don’t mix the two.

* Avoid having different modes on the same display.

### Be action-oriented

* Use **buttons** to indicate actions.

* In dialogs, place buttons along the bottom ordered like this: **Task** \- **OK** \- **Cancel**.

* Deactivate buttons that have no effect.
  * Example: the **Save** button cannot be clicked until the user has changed something.

* Provide explanatory **tooltips** for deactivated fields and buttons.

* Prefer selecting from a drop-down list to typing in a text field.
  * Provide history or autocomplete if possible.

### Use progressive disclosure

* Use a tooltip to show additional information on a list item.

* Hide unnecessary details behind a **MORE** button.

* Hide actions that are used infrequently behind a **TASK** menu button.

* Avoid nesting tabs – multiple tab layers are confusing.

Read about [effective visual design][6].

## Stay informed and share information

* Sign up for email notifications in [the forums][7] to learn about changes that might affect your application.

* **Provide feedback** to the user if an operation takes time to complete.
  * Example: In SuperOffice CRM Online, a cogwheel indicates that a background task is running

* Offer **easy access** to a knowledge base or to support pages from your application.

* Provide SuperOffice with URLs to your application **documentation**. Links to the documentation will appear in the App Store.

<!-- Referenced links -->
[1]: tenant-status/status-page.md
[2]: tenant-status/check-status.md
[3]: https://github.com/SuperOffice/SuperOffice.DevNet.Online/blob/master/Source/SuperOffice.DevNet.Online.Provisioning/WebPanelHelper.cs#L335
[4]: https://community.superoffice.com/change-application
[5]: ../../../data-access/docs/authentication/tokens/validate-security-tokens.md
[6]: ../../../user-interface/docs/design/overview.md
[7]: https://community.superoffice.com/en/developer/forum/rooms/superoffice-product-api-group/crm-online-application/
