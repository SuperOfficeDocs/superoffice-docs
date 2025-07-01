---
uid: customer-center-template
title: Customer center templates
description: Customer center templates
keywords: Customer Center, CEP
author: SuperOffice Product and Engineering
date: 07.10.2024
content_type: howto
audience: settings
deployment: onsite
---

# Customer center templates

The templates are located inside the SuperOffice database. To edit one, you simply open it in a text editor. What the various templates do is described in the [Customer Center configuration][1].

The templates are composed of normal HTML code and some tags that are understood by SuperOffice. These tags are marked with the percent symbol. For example, %GfxPath%. In SuperOffice jargon, these tags are called *parser variables*. When accessed through the customer module in SuperOffice, the parser variables are replaced with understandable HTML code.

All templates can be customized to your own wishes and you should be safe when just editing the HTML code and preserving the parser variables. If you are certain that you do not need a parser variable you can remove it. Parser variables can also be moved to other places in the template to fix the order of information.

The template called framework.html is the base template. This acts like a frame in normal HTML, except that it does not use frames. All other templates are displayed inside this, so the framework.html will form a border around them. Hence, graphical changes you want to be exposed on every customer page should go here. All the other templates are linked to one action.

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

This construction will loop over a set of parser variables. You can see an example of this in use in *listTickets.html*, which lists all requests for a customer. Loops can not be nested. Be aware that the `%ROWSTART%` and `%ROWEND%` tags have to be placed at the beginning of a line with no spaces or tabs before it.

Two important global parser variables are `%GfxPath%` which gives the base path to the graphic directory. Example:

```html
%GfxPath%/customer/myPic.gif
```

`%Program%` will return the link for the customer module. If you for example would call the routine to register a customer, you would write:

```html
<a href="%Program%?action=registerCust">Register</a>
```

The other variables should be self-explaining if you study the templates. Be aware that all parser variables will not be accessible in every template. To see the defined variables for a template, you can use the special debug variables `%PARSER_TREE%` at the bottom of a template file. This will print out all the variables to your browser when access through the customer module. This is especially useful when you want to explicitly call an extra field. If you for example make an extra field in the request table, you have to manually code the template to show these in the customer pages.

You can also create your own custom templates, which for example can make a request based on information from the webpage. The following described how to make such templates.

## How can I create category drop-downs on the customer pages?

Customer Center is default shipped with templates that lists the categories in a single drop-down. If you want these to show the categories in a hierarchy, you have to make some small changes to the templates.

In *framework.html* you have to add the following between the `<head>` tags:

`%IF:category.head% %category.head% %ENDIF%`

To use the category drop-down, you enter the following into the right templates:

`%IF:category.body% %category.body% %ENDIF%`

## See also

* [Create web forms with special templates][2]
* [How do I sort messages in the Customer Center?][3]
* [Update extra table][4]

<!-- Referenced links -->
[1]: config.md
[2]: create-webform-with-template.md
[3]: overview.md
[4]: update-extra-table.md
