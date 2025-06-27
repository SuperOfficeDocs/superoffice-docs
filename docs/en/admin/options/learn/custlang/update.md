---
uid: help-en-languages-add
title: Work with customer languages
description: Learn how to set up Customer languages in this how-to guide.
author: SuperOffice RnD
date: 06.29.2022
keywords: language
content_type: howto
language: en
---

# How to create and edit customer languages

## How to add customer languages

1. [!include[Go to Options](../includes/open-options.md)]

2. Select the **Customer languages** tab.

3. Click the **New customer language** button. This takes you to the **Customer language properties** screen.

    ![You can set up a new language in the Customer language properties dialog -screenshot][img1]

4. In the **Name** field, enter the name of the language to use as label in language-selection fields.

5. In the **Language code** field, enter a short code for the relevant language (or equivalent). The international, two-letter abbreviations are normally used (for example DE, DK, EN, NL, NO and SE). See a complete list at the end of this page.

6. In the **Virtual domain** field, enter the domain address that provides access to SuperOffice Customer Centre for the language in question, for example germany.liberty.com. Such domains must be set up in advance.

7. In the **Email domains** field, enter a list of email domains (comma-separated), such as: no, se, co.uk. If a new contact is registered automatically (by importing an email) and that contact has an email address that contains one of these domains, then the appropriate language is set for that contact.

8. In the **FAQ folder** field, select which FAQ folder should be the top-level folder in the FAQ hierarchy for SuperOffice Customer Centre visitors for the language in question. In other words, the FAQ hierarchy can be divided into several different language sections and then filtered by language. This gives better search results and only FAQs in the relevant language are shown to the user.

9. Check **Use as default** if you want this to be the default language. This means that this language is used when none of the other customer languages match the criteria or if no language is defined for a customer.

10. Click **OK**. The customer language is created and you have the option of creating [external categories][1].

    > [!TIP]
    > It is possible to use customer language for things other than language, if you have operations only in one country for example. One option is to create different departments, industry sections or trades, such as Building & Construction, Bathrooms, Interiors and Gardens. Then SuperOffice Customer Centre, the FAQ hierarchy and the reply templates can reflect the sector that is relevant for particular customers. The abbreviation that is used for the department must reflect the folder name in the folder \\templates. For example: Building & Construction = BC.

## Language codes

[!include[Language codes](includes/language-codes.md)]

## What would you like to find out more about?

* [Work with external categories][1]
* [How SuperOffice selects the customer language for new contacts][2]

<!-- Referenced links -->
[1]: external-categories.md
[2]: select-language.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/customer-centre-language.png
