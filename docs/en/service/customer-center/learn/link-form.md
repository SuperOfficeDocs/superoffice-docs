---
uid: help-en-customer-centre-form
title: How to link a web form to the Customer centre
description: In this how-to guide you’ll learn how to use a web form.
author: Bergfrid Dias
so.date: 02.22.2023
keywords: form, customer center
so.topic: howto
language: en
---

# Use web forms in your Customer centre

You can use integrated web forms to capture information from the customers who visit your Customer centre and automatically save this information in SuperOffice CRM.

By adding the chat widget to the Customer centre, you can facilitate your customers to ask for help and get the answer they are looking for instantly.

## Before you begin

You need to [create a web form][3] before you add it to your Customer centre.

It’s important to remember that when you create a new web form, you need to add one of the three request elements – title, category and message. Otherwise, you won’t be able to add the form to your Customer centre.

![To add a new web form to the Customer centre, add one of these request elements. You can find the Request fields in the SuperOffice elements tab. -screenshot][img1]

## Steps

To use a web form in your Customer centre you need to either log into the Settings and maintenance module in SuperOffice CRM or open the Customer centre config page in the System settings menu in the SuperOffice Service module.

1. Once you are in the Customer centre page, open the **Options** tab.

2. Scroll down the list of options and check the Use custom “Contact us” form box.

    ![In the customer centre page, go to options and check the Use custom "contact us" form box -screenshot][img2]

3. Choose the web form you wish to use by clicking on the drop-down on Form. You’ll see the folder structure that you’ve created in the Forms section in Marketing containing all the web forms.

    ![Choose the web form you want to use from the form folder -screenshot][img3]

4. Click Save to save your settings. The web form you’ve added will now be available on the Contact us page.

When a customer completes this form, the information and details will automatically be saved in SuperOffice Service as a request under the category and the priority you have defined for this form.

![Web form on the Contact us page -screenshot][img4]

## Related topics

* [Configure customer center][2]
* [Work with forms][1]

<!-- Referenced links -->
[1]: ../../../marketing/forms/learn/index.md
[2]: config.md
[3]: ../../../marketing/forms/learn/create.md

<!-- Referenced images -->
[img1]: media/form-element.png
[img2]: media/custom-form.png
[img3]: media/CustCentre-choose-form.png
[img4]: media/web-form-on-the-contact-us-page.jpg
