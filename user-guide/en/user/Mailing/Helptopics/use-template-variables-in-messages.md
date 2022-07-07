---
uid: help-en-use-template-variables-in-messages
title: Use template variables in messages
description: Use template variables in messages
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Use merge tags in messages

In order to give the message a more personal touch, you can use <!-- Fix reuse ID=a3 -->(merge tags are the same as template variables) to insert customer-specific information. This might be the customer's first name, for example. In this way, you can customise the content for each individual customer.

<!-- Fix reuse ID=a2 -->

Imported recipients that ARE NOT found in the SuperOffice database, will only consist of a name and an e-mail address (or just an e-mail address). This means that only the merge tags **\[\[customer.name\]\]** and/or **\[\[customer.email\]\]** will work for these recipients. To avoid empty merge tags in your mailings, make sure to [preview the mailing](test-mailing.md) first.

There are several types of merge tags:

* Merge tags linked to contacts; e.g. **\[\[customer.name\]\]**, which inserts the contact's full name.
* Merge tags linked to companies; e.g. ****\[\[company.name\]\]**, which inserts the name of the company the contact belongs to.**

<!-- Fix reuse ID=a1 -->
[!include[Mailing example with template variables](../../includes/mailing-tempvar-example.md)]

**To enter merge tags into your message:**

1. Select a text in the message.

2. Type, for example "Dear ".

3. Position the mouse pointer after the text and click **Merge tags** in the toolbar.

4. In the list that appears, select **Contact** and **First name**.

    ![icon](../media/Loc/neweditor-templatevar.png)

5. Continue entering text and inserting the merge tags you require.

> [!TIP]
> Before you send out a mailing, you should test that the customer data is correctly inserted in the message.**

## What would you like to find out more about?

[Template variables](../../Service/template-variables.md) (merge tags)
