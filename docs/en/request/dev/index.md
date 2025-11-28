---
uid: request-overview
title: Requests
description: How to manage requests and enquiries in SuperOffice - create internal and external requests; respond to incoming enquiries; obtain an overview of the statuses of all requests in the CRM system.
keywords: Service, ticket, request, inquiry, tag, category, priority, escalation, reply template, parse
author: digitaldiina
date: 11.28.2025
version: 11.7
content_type: concept
index: true
redirect_from: /en/request/overview
---

# Requests

[!include[License requirement](../../../../common/includes/req-service-essentials.md)]

* Manage requests and inquiries already in the system
* Create internal and external requests
* Respond to incoming inquiries
* Obtain an overview of the statuses of all requests in the system

## Terminology

A **request** is a form of communication where a (potential) customer, client, or business partner seeks information or assistance. For example, support issues, questions about the product and services, questions about invoices, or feedback regarding their experience with interaction with the company.

The terms *request* and *ticket* are often used interchangeably in SuperOffice. For example, you'll see the **Request** screen in the SuperOffice user interface, the `ticket` database table, and the `Ticket` CRMScript class. In the context of CRM, not to be confused with API requests (such as GET, POST, PUT, DELETE) or authorization credentials (such as system user ticket).

## Request handling

Requests can be linked to [contacts][2], who in turn can belong to a [company][3]. This means that requests cannot be linked directly to companies (only indirectly via contacts).

Companies employ varying procedures for handling requests and may utilize SuperOffice in diverse manners. Here are two common scenarios:

### Scenario 1: The customer submits the request by email

1. The customer emails `support@company.com` or fills out a form in a user-support portal.
1. The customer gets an **automatic reply** letting them know the inquiry is received.
1. The system automatically **turns the inquiry into a request** in SuperOffice.
1. The request goes to a request handler, who reads through it.
1. The request handler sends a response to the customer.
1. The request handler closes the request and proceeds to deal with other requests.

### Scenario 2: The customer calls the request handler

1. The customer has a problem with a product and calls user-support.
1. The request handler who answers the call **registers the request**.
1. The request handler sends a response to the customer.
1. The request handler closes the request and proceeds to deal with other requests.

In both scenarios, if the request handler is unable to fulfill the request on their own, they can either:

* Ask a colleague.
* Or, get help from outside the organization, for example for a sub-contractor or supplier.

## Status

A request has one of the following statuses:

* Active
* Closed
* Postponed
* Deleted
* Merged

The status will change as the request flows through the support system. You can [create additional request statuses][4].

## Request category

All requests belong to a category, and each category has its own rules that define how requests are processed in the system. The request categories are arranged in a tree structure. Users can be added as members in the categories individually or via the user groups they belong to. You can [create additional request categories][5].

[Tags][6] are a more flexible alternative to request categories. You can create tags on the fly and tag any request with as many tags as you want.

## Priority

The priority of a request reflects the importance of the enquiry, such as high, medium, or low. After a request is assigned a priority, the priority can be used to control any escalation of the request.

Priority is tied to:

* Deadline
* Read status
* Actions and escalation chain

You can [add new priorities][7] and edit the settings of existing priorities.

## Escalation

The escalation chain has multiple levels. Each level has its own settings, such as:

* Priority
* Alert level (strictly ascending number)
* Time (in minutes) before the ticket is escalated to the next level
* Action (what should be done when escalating to this level)
* If and who the ticket should be delegated to on escalation
* The ID of a [CRMScript][1] to run when the ticket alert goes off

[!include[License requirement](../../../../common/includes/req-service-prem.md)]

You can [define additional escalation levels][8] for each priority.

## Response time and time spent

`ticket.replied_at` is set (if empty) based on the time of action (selecting **Reply/Reply all**).

All other calculations run in the background. We use `time_counter` to mark which field in the ticket to count time spent on (queue, internal, external).

## <a id="reply-templates"></a>Service reply templates

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

### Template components

Reply templates have the following general components:

* Name
* ID
* Subject
* Body
* Attachments

You can [look up specific fields][16] in the database reference.

### Translation

If customer languages are configured it is possible to create language versions of each reply template. More information about this can be found in embedded help under [working with customer languages][15]

### Template variables

A *template variable* is a named placeholder that you can put in a document- or email template. When the template is applied, the variable is substituted with the actual value. For example, {customer.firstname} translates to the customer's first name. This lets you automate the personalization of content.

[Complete list of all standard fields][13] (does not cover your user-defined fields)

> [!NOTE]
> The date and time in template variables are controlled by the PC's system clock.

Each incoming email box can be configured to send an automatic answer back to the customer using a reply template. In addition, you have a parser variable called `ticket.lastMessage` which will contain the last message on the request, normally the text the customer wrote.

You can also extract anything from the email using [Find regular expressions][14], and those matches will be available as parser variables (see the help for syntax).

> [!NOTE]
> A parser variable may be available even if it has no value. One example is when creating a new request. If you use a reply template with the parser variable `ticket.id`, it will contain no value since the request does not exist yet.

### Syntax

The syntax for a parser variable is the name of the variable enclosed by the tags `<cs:parser> </cs:parser>`.

To get a complete overview of template variables available for your database, [create a new reply template][11] with the plain text body `%PARSER_TREE%` (case sensitive).

When this reply template is used in a request, you will get a list of all available template variables by using the parser tree variable. `%PARSER_TREE%` is especially useful when you want to debug why something is not working.

## <a id="system-templates"></a>System templates

Not all parser variables are available in every context in SuperOffice Service. The following tables show which parser variables are available in which reply templates.

### Standard variable

The standard variables are Message, Company, Customer, Ticket, and Config.

| Template type              | [Customer][21],<br> [Company][22] | [User][23] | [Ticket][24] | Message | [Config][25] | Other |
|----------------------------|:---------:|:----:|:------:|:-------:|:------:|:-------------------|
| new request,<br> edit request,<br> add message |       | x       | x      |      | x     |     |
| autoreply                  | x         |      | x      |         |        |                    |
| email filter               | x         |      | x      |         | x      |                    |
| on incoming email          | x         |      | x      |         | x      | ticket.lastMessage |
| notify: new request        | x         |      | x      | x       | x      | ticket.lastMessage |
| notify: open requests      | x         |      | x      |         | x      | ticket.lastMessage |
| notify: new message        | x         |      | x      | x       | x      |                    |
| notify activated request,<br>escalated request,<br>re-assigned request | x | | x | | x |     |
| new customer contacts      | x<br> (customer only) |   |   |         |        | custPassword,<br> to,<br> from |
| send password<br> to customer contacts | x<br> (customer only) | | | | x     | to,<br> from      |
| format FAQ questions       | x         |      | x      |         |        | faq.question,<br> faq.answer |

### Other parser variables

| Variable | Description |
|---|---|
| ticket.lastMessage | The last message on the request |
| custPassword | The un-encrypted version of the password only if this customer was generated at the same time as the "new customer" email was sent and encryption is turned on |
| from |  The sender email address |
| to | The recipient address |
| faq.question | The first message in the request that "publish" was called from |
| faq.answer | The last message in the request that "publish" was called from |

Some parser variables that exist will not be described. These are present only for backward compatibility.

<!-- Referenced links -->
[1]: ../../automation/crmscript/overview/index.md
[2]: ../../contact/dev/index.md
[3]: ../../company/dev/index.md
[4]: ../admin/status/create.md
[5]: ../admin/category/create.md
[6]: ../learn/tags.md
[7]: ../admin/priority/create.md
[8]: ../admin/priority/escalation-levels.md

[11]: ../../knowledge-base/learn/reply-templates/create.md
[13]: ../../knowledge-base/learn/reply-templates/template-variables.md
[14]: ../../email/admin/add-email-template.md
[15]: ../../localization/learn/customer-languages.md
[16]: ../../database/tables/reply-template.md

[21]: ../../knowledge-base/learn/reply-templates/template-variables.md#customer
[22]: ../../knowledge-base/learn/reply-templates/template-variables.md#company
[23]: ../../knowledge-base/learn/reply-templates/template-variables.md#user
[24]: ../../knowledge-base/learn/reply-templates/template-variables.md#ticket
[25]: ../../knowledge-base/learn/reply-templates/template-variables.md#config
