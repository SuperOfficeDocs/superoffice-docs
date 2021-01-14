---
title: Reply templates
uid: crmscript_reply_template
---

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

Title...........: [[ticket.title]]
Posted by........: [[ticket.author]]
Category.........: [[ticket.category.fullname]]
Security level....: [[ticket.slevel]]
Customer........: [[ticket.custName]]
E-mail.............: [[ticket.custEmail]]
Company.......: [[ticket.custCompany]]
```

### Template components

Reply templates have the following general components:

* name
* ID
* subject
* body
* attachments

You can [look up specific fields](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-reply_template.htm) in the database reference.

### Translation

Many templates are available in several languages.

| Language  | Code (ID) |
|-----------|:---------:|
| Norwegian | 0         |
|  English  | 1         |
| German    | 2         |
| Swedish   | 3         |
| Danish    | 4         |
| Dutch     | 5         |

## Template variables

A *template variable* is a named placeholder that you can put in a document- or email template. When the template is applied, the variable is substituted with the actual value. For example, {customer.firstname} translates to the customer's 1st name. This lets you automate the personalization of content.

Use the embedded help to [look up specific template variables](https://community.superoffice.com/documentation/help/EN/CRM/8.5/UserHelp/index.htm#t=Service%2Ftopics%2FTemplate_variables.html)

> [!NOTE]
> The date and time in template variables are controlled by the PC's system clock.

### Template types and entities

| Template type              | Customer,<br/> Company | User | Ticket | Message | Config | Other |
|----------------------------|:---------:|:----:|:------:|:-------:|:------:|:-------------------|
| new request,<br/> edit request,<br/> add message | x   | x       | x      |      | x     |     |
| autoreply                  | x         |      | x      |         |        |                    |
| email filter               | x         |      | x      |         | x      |                    |
| on incoming email          | x         |      | x      |         | x      | ticket.lastMessage |
| notify: new request        | x         |      | x      | x       | x      | ticket.lastMessage |
| notify: open requests      | x         |      | x      |         | x      | ticket.lastMessage |
| notify: new message        | x         |      | x      | x       | x      |                    |
| notify activated request,<br/>escalated request,<br/>re-assigned request | x | | x | | x |     |
| new customer contacts      | x<br/> (customer only) |   |   |         |        | custPassword,<br/> to,<br/> from |
| send password<br/> to customer contacts | x<br/> (customer only) | | | | x     | to,<br/> from      |
| format FAQ questions       | x         |      | x      |         |        | faq.question,<br/> faq.answer |

[List of parser variables](https://community.superoffice.com/en/technical/documentation/older-versions/documentation-7/cs/parser-variables/) for each entity.

## How to use a reply template in CRMScript

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

Fetches the ID of all attachments. <!-- more about attachments in another context -->

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

This is where the magic happens and the template variables are substituted. The [parser](./parser.md) is described in-depth elsewhere.

```crmscript
subject = p.parseString(subject);
plainBody = p.parseString(plainBody);
htmlBody = p.parseString(htmlBody);
```
