---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: edit_template       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Edit Customer center templates # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: article               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Edit Customer center templates

This document is only meant as a short introduction to how to edit the customer templates.

The templates are located inside the Templates directory in your Service install directory. Inside this directory there can be a number of folders, each containing templates for the different customer languages. Inside the language directory there should be only one directory called *customer*, unless you have made any custom directories. This is where the templates are stored. To edit one, you simply open it in a text editor.

What the various templates do is described on [Customer Center Configuration][1] page.

The templates are composed of normal HTML code and some tags which are understood by the Service system. These tags are marked with the percent-symbol, for example: %GfxPath%. In Service jargon, these tags are called *parser variables*. When accessed through the customer module in Service, the parser variables are replaced with understandable HTML code.

All templates can be customized to your own wishes and you should be safe when just editing the HTML code and preserving the parser variables. If you are certain that you do not need a parser variable you can remove it. Parser variables can also be moved to other places in the template to fix the order of information.

The template called framework.html is the base template. This acts like a frame in normal HTML, except that it actually does not use frames. All other templates are displayed inside this, so the framework.html will form a border around them. Hence, graphical changes you want to be exposed on every customer page should go here. All the other templates are linked to one action.

You should be able to understand what the different parser variables do by looking at the various templates and the result they produce, but this document will go through some of the important constructions.

```html
IF-construction:
%IF:<test>%
%ELSE%
%ENDIF%
```

The `<test>` statement can either be a parser variable only (if it is located the test returns true), or it can be a comparison of a parser variable and a constant, for example `%IF:authenticated="true"%`.

**Looping:**

```html
%ROWSTART%
...
<parser variables>
...
%ROWEND%
```

This construction will loop over a set of parser variables. You can see an example of this in use in listTickets.html, which lists all request for a customer. Loops can not be nested. Be aware that the `%ROWSTART%` and `%ROWEND%` tag have to be placed at the beginning of a line with no spaces or tabs before it.

Two important global parser variables are `%GfxPath%` which gives the base path to the graphic directory. Example:

```html
%GfxPath%/customer/myPic.gif
```

`%Program%` will return the link for the customer module. If you for example would call the routine to register a customer, you would write:

```html
<a href="%Program%?action=registerCust">Register</a>
```

The other variables should be self-explaining if you study the templates. Be ware that all parser variables will not be accessible in every template. To see the defined variables for a template, you can use the special debug variables `%PARSER_TREE%` at the bottom of a template file. This will print out all the variables to your browser when access though the customer module. This is especially useful when you want to explicit call an extra field defined in Service. If you for example make an extra field in the request table, you have to manually code the template to show these in the customer pages.

You can also create your own custom templates, which for example can make a request in Service based on information from the web page. The following described how to make such templates.

## Creating web forms using special templates in Service

1. Create a template for the webform under the templates directory in Service.
Example: *C:\\SuperOffice\\Customer Service\\templates\\special\\mytemplate.html*

2. Access the template from the www browser using the following address *.../scripts/customer.exe?action=spec...*

3. Edit the content of the special template

4. Create a template called *ok.html* in the same location. This will be called when the customer press the **Post** button.

### A simple template example

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
Message <input type "text" name="message" size="45" value="">

<input type="hidden" name="message.alterbody" value="This is a example webform created at %%whenposted%% by %%customer.firstname%% %%customer.lastname%% with email address %%customer.email%% Message from this person: %%message%%">

<input type="hidden" name="oktemplate" value="special/ok.html">

<input type="submit" name="ok" value="Post">
</form>
</html>
```

**Description of %-tags:**

`%datetimenow%` inserts current date into the html page

`%program%` inserts the program location e.g /scripts/customer

**%-tags in message.alterbody:**

`%%customer.firstname%%` inserts the form value customer.firstname into the message body  

`%%customer.email%%` inserts the form value customer.email into the message body

`%%foobar%%` inserts the form value foobar into the message body

**To create a request in Service,set the following values:**

```html
"ticket.title" title of request
"ticket.category" which category to insert ticket to (number, not name)
"message.body" body of message in request (not used if message.alterbody exists)
"message.alterbody" if you wish to insert values from form in message use this also, remember to use an empty "message.body"
"message.author" author of message
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
"customer.extra.xxx" where xxx is an extrafield on the customertable
```

## How do I sort messages in the Customer Center?

It is not possible to do it on the site. To sort requests on Customer Center, you need to perform the actions directly on the SuperOffice database under the CONFIG table.

1. Start the database utility (for example, Microsoft SQL Management Studio).
2. Locate the SuperOffice database and CONFIG table.
3. Under the "Flags" you can add 128 to the number that is already there from before (for example, 68 +128 = 196).

## How can I update an extra table from the Customer Center?

Writing to extra tables from the Customer center is done by using the parser functions extraTableUpdate and extraTableInsert. The functions take the table ID and the values to write as parameters. In addition `extraTableUpdate` takes the ID of the row which is to be updated.

### Example extraTableUpdate

`%extraTableUpdate("7").id("1").field("y_7.x_1=test").field("y_7.x_2=aValue")%`

This call will update the entry with ID 1 in extra-table 7. The field `x_1` will be set to "test", and `x_2` will be set to "aValue".

### Example extraTableInsert

`%extraTableInsert("1").field("y_1.x_3=10").field("y_1.x_4=2002-01-01")%`

This insert will add a new row in extra table 1. The field `x_3` will be set to 10 and the field `x_4` will get the value 2002-01-01.

To facilitate input from a form it will be appropriate to use a variable starting with an underscore (\_). Form values starting with an underscore will be forwarded to the next form.

The file *subscribe.html* can then handle the writing to the extra table: `%extraTableInsert("1").field("y_1.x_2=" + _email)%`. This will result in adding a new table to extra table 1, where the field `x_2` will be set to the value specified in the form.

## How can I create drop-downs on the customer pages where you can choose the category from a hierarchical view?

Customer Center is default shipped with templates that lists the categories in a single drop-down. If you want these to show the categories in a hierarchical manner, you have to make some small changes to the templates.

In *framework.html* you have to add the following between the `<head>` tags:

`%IF:category.head% %category.head% %ENDIF%`

To use the category drop-down, you enter the following into the right templates:

`%IF:category.body% %category.body% %ENDIF%`

<!-- Referenced links -->
[1]: config.md
