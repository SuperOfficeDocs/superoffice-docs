---
title: Reply templates
uid: reply-template
description: A reply template is a blueprint for an email. It consists of regular text and template variables.
author: Bergfrid Dias
date: 05.30.2023
keywords: reply template, request, ticket, parse
topic: concept
---

# Service reply templates

A *reply template* is a blueprint for an email. It consists of regular text and template variables.

**Example email confirmation template:**

```text
Hi [[fullname]]

Thank you for registering on our Customer Centre.

Please click on the following link to complete registration.

[[confirmUrl]]

Best regards
[[config.companyName]]
```

**Example new request assignment template:**

```text
You have been assigned request no. [[ticket.id]]. The URL of the request is:

[[ticket.url]]

Title............: [[ticket.title]]
Posted by........: [[ticket.author]]
Category.........: [[ticket.category.fullname]]
Security level...: [[ticket.slevel]]
Customer.........: [[ticket.custName]]
E-mail...........: [[ticket.custEmail]]
Company..........: [[ticket.custCompany]]
```

[!include[License requirement](../../../../common/includes/req-service-essentials.md)]

## Template components

Reply templates have the following general components:

* Name
* ID
* Subject
* Body
* Attachments

You can [look up specific fields][6] in the database reference.

### Translation

If customer languages are configured it is possible to create language versions of each reply template. More information about this can be found in embedded help under [working with customer languages][5]

## Template variables

A *template variable* is a named placeholder that you can put in a document- or email template. When the template is applied, the variable is substituted with the actual value. For example, {customer.firstname} translates to the customer's first name. This lets you automate the personalization of content.

[Complete list of all standard fields][3] (does not cover your user-defined fields)

> [!NOTE]
> The date and time in template variables are controlled by the PC's system clock.

Each incoming email box can be configured to send an automatic answer back to the customer using a reply template. In addition, you have a parser variable called `ticket.lastMessage` which will contain the last message on the request, normally the text the customer wrote.

You can also extract anything from the email using [Find regular expressions][4], and those matches will be available as parser variables (see the help for syntax).

> [!NOTE]
> A parser variable may be available even if it has no value. One example is when creating a new request. If you use a reply template with the parser variable `ticket.id`, it will contain no value since the request does not exist yet.

## Syntax

The syntax for a parser variable is the name of the variable enclosed by the tags `<cs:parser> </cs:parser>`.

To get a complete overview of template variables available for your database, [create a new reply template][1] with the plain text body `%PARSER_TREE%` (case sensitive).

When this reply template is used in a request, you will get a list of all available template variables by using the parser tree variable. `%PARSER_TREE%` is especially useful when you want to debug why something is not working.

<!-- Referenced links -->
[1]: learn/create.md
[3]: learn/template-variables.md
[4]: ../../admin/lists/learn/add-email-template.md
[5]: ../../admin/options/learn/custlang/index.md
[6]: ../../database/tables/reply-template.md
