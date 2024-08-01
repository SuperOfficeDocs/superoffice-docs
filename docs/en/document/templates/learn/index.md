---
uid: help-en-document-template
title: Document templates
description: Introduction to document templates
keywords: document template, document, template
author: Bergfrid Dias
date: 07.11.2024
version: 10.3
topic: concept
language: en
---

# Document templates

It is important for an organization's profile that letters, faxes and other documents have a distinctive and consistent appearance. This means that all documents sent out by the organization should use the same fonts, margins, logos and so on. By creating templates that are customized to your organization you ensure that your contacts can easily recognize your correspondence.

The templates can contain variables that extract information from the SuperOffice database and enter it into the document automatically.

SuperOffice CRM has a set of [standard templates][2] that you can use immediately after installing the program. These templates are used when you create documents from SuperOffice CRM.

You can edit the templates that are supplied with SuperOffice CRM.

You can also create your own templates in the applications you have chosen to use in conjunction with SuperOffice CRM. You do this by entering [template variables][1] in the template documents.

## Benefits of creating document templates

* Everyone saves time whenever they create a new document, because they do not have to enter information that is typically repeated in each document, such as customer name and address. By using template variables, SuperOffice CRM will automatically add the customer's information when you create your next document.

* You make sure that your contacts receive documents that have a unified, professional look, including your logo and corporate identity.

* You ensure that all users can access and use legal text that is important to your business, such as terms and conditions and similar.

* You can even create lists and find companies that have a document template in common.

## How SuperOffice CRM selects the correct language template

SuperOffice CRM has multiple default templates available in 12-16 languages depending on the template type. This includes email templates and GDPR templates (12 languages).

To ensure that you can communicate with your clients in their own language (where possible), SuperOffice CRM will automatically perform a language check to determine which language temple to use. Relevant when sending out invitation emails, and when notifying new contacts that their details were saved. For GDPR related communication, this is also an requirement.

**Steps:**

1. Is a preferred language set for the contact? Is a template is available in this language?
2. Can the contact's country be mapped to a corresponding language?
3. What is the preferred document language for the logged-in user, and is a template available in this language?
4. What is the user interface language for the logged-in user, and is a template available in this language?
5. If no language is found, the English template is used.

## How to add a template document

1. [Add and define the document template][6] in Settings and maintenance.
1. [Specify user groups][5] for the document template.

## Related content

* [Edit or replace a template][2]
* [Create a template document][4]
* [Look at template variables][1]
* [Reply template variables (Service)][8]
* [Quote templates][7]

<!-- Referenced links -->
[1]: template-variables.md
[4]: create.md
[2]: ../admin/update-template.md
[6]: ../admin/link-template.md
[5]: ../../../admin/lists/learn/organize/user-group-filtering.md
[7]: quote-templates.md
[8]: ../../../request/reply-templates/learn/template-variables.md

<!-- Referenced images -->
