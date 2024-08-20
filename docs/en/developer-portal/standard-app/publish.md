---
title: Publish app
uid: standard-app-publish
description: Publish standard app in CRM Online environment
author: Margrethe Romnes
date: 09.07.2023
keywords: App Store
topic: howto
envir: cloud
client: online
--- 

# Publish standard app in CRM Online environment

Congratulations, your standard application is ready!

**Pre-requisites:**

* Your standard application has [passed certification][1], including Watchcom's security evaluation.
* Your commercial contact has [completed the application listing][2] for the App Store.

**Process:**

1. We will publish your application from stage to production environment and list it in the public App Store with beta status.
2. A customer clicks the green button for **Sign up** on your application listing and get redirected to your sign up.
3. The customer's administrator must sign in to SuperOffice and [give their consent][5] to allow your application to access their database tenant.
4. After the beta period, your application will transition to full status if everything is OK.

## Request application changes

You can [change the application configuration and the App Store information][3] in the Developer Portal.

## <a id="beta"></a>Beta period for standard apps

All new or updated standard applications begin with a beta status when they are listed in the SuperOffice App Store. This phase lasts until the application meets a pre-defined set of conditions.

### A soft launch to fine-tune and reduce risk

The beta phase enables application partners and SuperOffice to adjust and ensure everything works the way it should with actual customers. This is especially helpful if the setup and onboarding for customers are not yet fully automated.

During this time, we watch performance and customer behavior. Customers benefit from a gentle start. The application owner and SuperOffice benefit from identifying and mitigating risk.

### How long is the beta period?

The standard application stays in beta until it meets the following conditions:

* At least 3 customers are running the application for 30 days with no major incidents, such as performance or other faults appearing, or
* One customer is running the application for 60 days with no major incidents.

After this 30 or 60 day period, and given that there are no other issues that our certification team needs you to resolve, your standard application will receive full status. At this point, the application will be available without restrictions in the App Store, and you may start charging customers for it.

If, on the other hand, the application (or partner) fails to comply with any of the [certification requirements][4], we can resolve this in one of two ways:

* The application developer gets a period of up to 60 days to resolve the issue while remaining in beta
* Delist and convert to a [custom application][6] as a last resort

### How is beta different from full status?

Customers running the application must be informed about the beta status.

* Terms and conditions apply
* The application is free of charge

<!-- Referenced links -->
[1]: certification/certify-app.md
[2]: app-store/update-app-page.md
[4]: requirements/index.md
[3]: ../faq/update-app.md
[5]: ../provisioning/consent.md
[6]: ../custom-app/index.md
