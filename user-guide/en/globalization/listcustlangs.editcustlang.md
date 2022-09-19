---
uid: help-en-admin-listcustlangs-editcustlang
title: admin listCustLangs editCustLang
description: admin listCustLangs editCustLang
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Work with customer languages

In this topic, you can find out how to create and edit customer languages.

## How to add customer languages

To create a new customer language:

1. Select ![icon][img1] **System settings** &gt; **Customer languages**.

2. Click the **New customer language** button. This takes you to the **Customer language properties** screen.

3. In the **Name** field, enter the name of the language. This is the name that appears in list boxes where you can select a language.

4. In the **Language code** field, enter a short code for the relevant language (or equivalent). The international, two-letter abbreviations are normally used (for example DE, DK, EN, NL, NO and SE). <!-- Fix reuse ID=a1 -->

    | Language | Code |
    |---|:-:|
    | Chinese (simplified) | CN |
    | Czech | CZ |
    | Danish | DA (not DK) |
    | Dutch | NL |
    | English | EN |
    | Finnish | FI |
    | French | FR |
    | German | DE |
    | German (Switzerland) | CH |
    | Italian | IT |
    | Korean | KO |
    | Norwegian | NO |
    | Polish | PL |
    | Portuguese (Brazil) | BR |
    | Russian | RU |
    | Spanish | ES |
    | Swedish | SE (not SV) |
    | Ukrainian | UK |
    | Vietnamese | VI |

5. In the **Virtual domain** field, enter the domain address that provides access to SuperOffice Customer Centre for the language in question, for example germany.liberty.com. Such domains must be set up in advance.

6. In the **E-mail domains** field, enter a list of e-mail domains (comma-separated), such as: no, se, co.uk. If a new contact is registered automatically (by importing an e-mail) and that contact has an e-mail address that contains one of these domains, then the appropriate language is set for that contact.

7. In the **FAQ folder** field, select which FAQ folder is to be the top-level folder in the FAQ hierarchy for SuperOffice Customer Centre visitors for the language in question. In other words, the FAQ hierarchy can be divided into several different language sections and then filtered by language. This gives better search results and only FAQs in the relevant language are shown to the user.

8. Check **Use as default** if you want this to be the default language. This means that this language will be used when none of the other customer languages match the criteria or if no language has been defined for a customer.

9. Click **OK**. The customer language is created and you have the option of creating [external categories][1].

    > [!TIP]
    > It is possible to use customer language for things other than language, if you only have operations in one country for example. One option is to create different departments, industry sections or trades, such as Building & Construction, Bathrooms, Interiors and Gardens. Then SuperOffice Customer Centre, the FAQ hierarchy and the reply templates can reflect the sector that is relevant for particular customers. The abbreviation that is used for the department must reflect the folder name in the folder \\templates. For example: Building & Construction = BC.

## What would you like to find out more about?

* [Work with external categories][1]
* [How SuperOffice Service selects the customer language for new contacts][2]

<!-- Referenced links -->
[1]: listCustLangs.workWithExternaCategories.md
[2]: listCustLangs.selectlanguage.md

<!-- Referenced images -->
[img1]: ../../media/icons/globalmenu-settings-small.png
