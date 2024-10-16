---
uid: crmscript-reply-template
title: Reply templates
description: How to use a reply template in CRMScript.
keywords: crmscript, reply template, service, template, load, parse
author: Bergfrid Skaara Dias
date: 05.30.2023
version: 10
topic: howto
---

# How to use a reply template in CRMScript

1. Declare and load the template
2. Set up subject, body, and attachments in the selected language
3. Bring in data values
4. Run it through the parser

You can either use a built-in template or define your own.

## Load template

To get started, you need to know the ID of the template to use. The available templates and their ID are specific to your tenant. Here's how to see what's available and find the ID:

1. Sign in to SuperOffice Service.
2. Click **Knowledge Base** in the main menu and select **Reply templates**.
3. Select a template to view more info.
4. While viewing the template you wish to use, get the ID from the URL. For example, `ReplyTemplate&id=2`.

### Bool load(Integer id)

Retrieves the reply template with the given ID and loads it into the object.

```crmscript!
ReplyTemplate rt;
rt.load(2);
print(rt.getName());
```

The `getName()` method simply returns the name of the loaded template.

## Set up subject, body, and attachments

Before you can substitute variables for values, you must set up at least the subject and body. The body is available in 3 variants: plain, HTML, and SMS. The subject is plain text only.

### String getSubject(Integer language)

Fetches the subject string in the selected language.

```crmscript
String subject = rt.getSubject(2);
```

### String getPlainBody(Integer language)

Fetches the body string in the selected language as plain text.

```crmscript
String plainBody = rt.getPlainBody(2);
```

### String getHtmlBody(Integer language)

Fetches the body string in the selected language as HTML.

```crmscript
String htmlBody = rt.getHtmlBody(2);
```

### String getSmsBody(Integer language)

Fetches the body string in the selected language suitable for SMS.

### Integer[] getAttachments(Integer language)

Fetches the ID of all attachments.

## Bring in data values

Unlike all the other steps, this step depends on the individual template and which data it requires you to provide.

Let's say we need a ticket and a customer:

```crmscript
Ticket t;
t.load(getVariable("ticketId").toInteger());
t.toParser(p);

Customer c;
c.load(t.getValue("custId").toInteger());
c.toParser(p);
```

## Run template through the parser

This is where the magic happens and the template variables are substituted. The [parser][4] is described in-depth elsewhere.

```crmscript
subject = p.parseString(subject);
plainBody = p.parseString(plainBody);
htmlBody = p.parseString(htmlBody);
```

<!-- Referenced links -->
[4]: ../../parser.md
