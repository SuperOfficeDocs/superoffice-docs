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

# Use template variables in messages

In order to give the message a more personal touch, you can use template variables to insert customer-specific information. This might be the customer's first name, for example. In this way, you can customise the content for each individual customer.

<!-- Fix reuse ID=a2 -->

Imported recipients that ARE NOT found in the SuperOffice database, will only consist of a name and an e-mail address (or just an e-mail address). This means that only the template variables **\[\[customer.name\]\]** and/or **\[\[customer.email\]\]** will work for these recipients. To avoid empty variables in your mailings, make sure to [preview the mailing](../test_mailing.md) first.

There are several types of template variables:

* Template variables linked to contacts; e.g. **\[\[customer.name\]\]**, which inserts the contact's full name.
* Template variables linked to companies; e.g. ****\[\[company.name\]\]**, which inserts the name of the company the contact belongs to.**

<!-- Fix reuse ID=a1 -->

Instead of this text:

"Dear Customer. Would you like to know more about how our product can help your company win new customers? Please call us at SuperShop."

you can send this one:

"Dear Chris. Would you like to know more about how our product can help Car Care Ltd win new customers? Please call Ryan Webster at SuperShop."

The text you enter will look like this:

"Dear **\[\[customer.firstname\]\]**. Would you like to know more about how our product can help **\[\[company.name\]\]** win new customers? Please call **\[\[company.ourSalesContact.name\]\]** at SuperShop."

**To enter template variables into your message:**

1. **Click the **Edit paragraph** ( ![icon](../../media/btn_editor_edit.png) ) button in the paragraph you wish to edit.**

2. **Select the **Heading** tab.**

3. **Type, for example "Dear ".**

4. **Position the mouse pointer after the text and click ![icon](../../media/btn_Variable.png)**Template variables**.**

5. **In the dialog that appears, select **First name** in the **Add template variable** list.**

    **![icon](../../media/Loc/editor_templatevar.jpg)**

6. **Click **OK**. The **\[\[customer.firstname\]\]** template variable is inserted with a yellow background.**

7. **Select the **Body** tab.**

8. **Continue entering text and inserting the template variables you require.**

**> [!TIP]
> Before you send out a mailing, you should test that the customer data is correctly inserted in the message. See [Test mailing](../test_mailing.md).**

## What would you like to find out more about?

[Template variables](../../../Service/topics/Template_variables.md)
