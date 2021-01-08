---
title: provisioning       
description: Provisioning
author: {github-id}             # Your GitHub alias.
keywords:
---

# Provisioning

Applications that compliment SuperOffice with additional functionality generally need to (automatically) set up a presence inside SuperOffice. This initialization step is referred to as provisioning your application in SuperOffice.

When the customer clicks **I approve,** it should automatically set up your [application][1]. This is accomplished by a [tenant administrator][2] user installing the application and interacting with its provisioning routines:

1. The user successfully signs into SuperID, is then forward to the application's installation pages, and the application begins to use the administrative credentials it received from SuperID to access and set up the tenant via the APIs.
2. The application creates whatever it needs to exist and function inside SuperOffice (such as web panels, buttons, lists, and list items).

Provisioning a partner application may involve configuration or settings in both SuperOffice and the other partner service depending on what the application actually does.

## Automatic or manual provisioning?

Provisioning must be as automatic as possible. In some cases, it can include manual instructions with the intent of automating this later.

For example, if the application requires new web panels in the SuperOffice solution, it should ideally create the web panels for the customer during provisioning. The alternative is for the customer to manually follow a set of instructions for how to create these themselves, which will open up for errors.  

### Benefits of automation

> [!TIP]
> Automating provisioning improves the customer's experience and is more scalable.

If and when you include instructions, make sure they are as clear and fail-proof as possible (simple recipes that non-technical people can follow).

If you don't offer automatic provisioning from day 1, be prepared to do so soon after.

### Risk when provisioning manually

Manual provisioning might introduce potential errors. You also run the risk of the customer never getting the application going.

<!-- Referenced links -->
[1]: ../online/apps/index.md
[2]: ../tenants/index.md
