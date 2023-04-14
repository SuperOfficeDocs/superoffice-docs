---
title: Custom objects
uid: help-en-custom-objects
description: Custom objects
author: Bergfrid Dias
so.date: 02.23.2023
keywords: custom object
so.topic: concept
language: en
so.user: admin
so.user.tooltip: Settings and maintenance
---

# Custom objects

## User defined fields

All companies and organizations have their own requirements for the information they need to register concerning their contacts, sales, projects, contracts, and so on. You can enter your own fields for SuperOffice CRM in the **Fields** screen. This way, you can customize the type of information that can be registered concerning companies, contacts, projects, sales, documents and follow-ups.

## Custom fields and tables

A good example of a custom field you can use on the **Contact** card is a field called "Satisfied customer", where the value of the field is Yes or No.

For example, you can send your contacts a mailing (with link actions) where they can state whether they are satisfied with your services. This will give you valuable insight into the general customer satisfaction rate.

Of course, you can add a wide range of tables and fields to SuperOffice to save any information your customer service agents need.

![In the Tables screen, you can either choose to (a) create an extra field or (b) create a new table -screenshot][img1]

### Extra tables

* [Introduction to extra tables][3]
* [Define a table][4]

### Custom fields

All companies and organizations have their own requirements for the information they need to register. This could be for companies, contacts, sales, projects, and so on. As an administrator, you can add your own fields in Settings and maintenance.

* [User-defined fields][1]
* [Extra fields][2]

#### The benefits of adding fields

Using the Find function, you can search for the information you register in these fields and make selections.

For example, if you register the expiry date of the maintenance agreement that you have with contacts, you can create a dynamic selection that shows the contacts for which the agreement expires in less than one month.

You can reuse the information from these fields in documents and emails using template variables. Each field that you add gets its own unique ID (Prog ID), which can be used in documents to merge contact-specific information.

So, if you want to send an email to your contacts that says that their maintenance agreement will expire soon, you can use the template variable for expiry date to show the correct expiry date of their agreement in the message.

#### Positioning

Any custom screen layouts (created in the Screen Designer) using screen designer may override the settings on fields.

If you do not have license to Configurable Screens, use the rank of the different fields.

## Related content

* [The screen designer][5]

<!-- Referenced links -->
[1]: udef/index.md
[2]: extra-field/create.md
[3]: extra-table/index.md
[4]: extra-table/create.md
[5]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: media/create-extra-tables-and-fields.png
