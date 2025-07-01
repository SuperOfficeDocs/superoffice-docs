---
title: Create web form with template
uid: create-webform-with-special-template
description: How to create web forms using special templates in Service
author: SuperOffice Product and Engineering
date: 03.16.2023
keywords: Customer Center, CEP, web form
content_type: howto
audience: settings
deployment: onsite
---

# Creating web forms using special templates in SuperOffice

1. Create a template for the web form under the templates directory in SuperOffice.

    Example: *C:\SuperOffice\Customer Service\templates\special\mytemplate.html*

1. Access the template from the www browser using the following address *.../scripts/customer.exe?action=spec...*

1. Edit the content of the special template

1. Create a template called *ok.html* in the same location. This will be called when the customer press the **Post** button.

## Example

```html
<html>
<form method="post" enctype="multipart/form-data" action="%Program%?action=specialForm">

<input type="hidden" name="ticket.title" value="Request from special form">
<input type="hidden" name="ticket.category" value="1">
<input type="hidden" name="message.author" value="Web form1">
<input type="hidden" name="message.body" value="">

When posted <input type="text" name="whenposted" size="18" value="%datetimenow%">
<br>
First name <input type="text" name="customer.firstname" size="45" value="">
<br>
Last Name <input type="text" name="customer.lastname" size="45" value="">
<br>
Email <input type="text" name="customer.email" size="45" value="">
<br>
Message <input type="text" name="message" size="45" value="">

<input type="hidden" name="message.alterbody" 
       value="This is a example web form created at %%whenposted%% by %%customer.firstname%% %%customer.lastname%% with email address %%customer.email%% Message from this person: %%message%%">

<input type="hidden" name="oktemplate" value="special/ok.html">

<input type="submit" name="ok" value="Post">
</form>
</html>
```

**Description of %-tags:**

`%datetimenow%` inserts the current date into the HTML page

`%program%` inserts the program location, for example, /scripts/customer

**%-tags in message.alterbody:**

`%%customer.firstname%%` inserts the form value `customer.firstname` into the message body
`%%customer.email%%` inserts the form value `customer.email` into the message body

`%%foobar%%` inserts the form value foobar into the message body

**To create a request in SuperOffice, set the following values:**

```html
"ticket.title" title of request
"ticket.category" which category to insert the ticket to (number, not name)
"message.body" body of the message in request (not used if message.alterbody exists)
"message.alterbody" if you wish to insert values from form in message use this also, remember to use an empty message.body
"message.author" author of the message
```

**To connect a request to a user, set the following values:**

```html
"customer.firstname"
or
"customer.email"
optional
"customer.lastname"
"customer.phone"
"customer.cellphone"
"customer.note"
"customer.username"
"customer.password"
"customer.extra.xxx" where xxx is an extra-field on the customer table
```
