---
title: Reply templates
uid: reply-templates
description: Reply templates in SuperOffice
author: Bergfrid Dias
so.date: 03.16.2023
keywords: reply template
so.topic: concept
---

# Service reply templates

Template variables, also known as parser variables, are used to dynamically insert data into a text like a reply template. The syntax for a parser variable is the name of the variable enclosed by the tags `<cs:parser> </cs:parser>`.

To get a complete overview of template variables available for your database, [create a new reply template][1] with the plain text body `%PARSER_TREE%` (case sensitive).

When this reply template is used in a request, you will get a list of all available template variables by using the parser tree variable.

[Complete list of all standard fields][3] (does not cover your user-defined fields)

## Parser availability

Not all parser variables are available in every context in SuperOffice Service. This section will describe which of the variables are available where in the solution. If you ever wonder which variables are available and the value of them, you can always use the special parser code `%PARSER_TREE%`. This will be exchanged with all available variables and the values. This is especially useful when you want to debug why something is not working.

> [!NOTE]
> A parser variable may be available even if it has no value. One example is when creating a new request. If you use a reply template with the parser variable `ticket.id`, it will contain no value since the request does not exist yet.

Some parser variables that exist will not be described. These are present only for backward compatibility.

## Reply templates

It really depends on where the reply template is being used. Below the most common places to use them will be listed.

[!include[License requirement](../../../../common/includes/req-service-essentials.md)]

### Request

The same parser variables are available for new requests, edit requests, and add messages.

* User
* Company
* Customer
* Ticket
* Config

### Reply templates on incoming email

Each incoming email box can be configured to send an automatic answer back to the customer using a reply template. The following parser variables are available:

* Company
* Customer
* Ticket
* Config

In addition, you have a parser variable called `ticket.lastMessage` which will contain the last message on the request, normally the text the customer wrote.

### Email filter

Here you may send a reply template to the customer or another email address. The following parser variables are available:

* Company
* Customer
* Ticket
* Config

You can also extract anything from the email using [Find regular expressions][4], and those matches will be available as parser variables (see the help for syntax).

<!-- Referenced links -->
[1]: learn/create.md
[3]: learn/template-variables.md
[4]: ../../admin/lists/learn/add-email-template.md
