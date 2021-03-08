---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: inline_crmscript_and_custom_form       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Inline ejScript and custom forms in Customer Centre # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
so.date: 09.15.2011
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Inline ejScript and custom forms in Customer Centre

> [!NOTE]
> Since this page was written, ejScript has been renamed to CRMSCript.

The Customer Centre in SuperOffice CRM is an out-of-the-box support portal, allowing your customers or partners to log in and interact with your support processes. They can post new requests, access their existing requests, modify their personal preferences, and access the Frequently Asked Questions database. All of this is standard functionality, with a visual look and feel which can easily be modified by changing the *framework.html* file.

However, the Customer Centre is also a platform for building more web pages, which allow you to expose parts of your CRM data to your customers and let them interact with them. By including your customers in your CRM processes, you can increase the efficiency of your organization. Instead of having your customers contact you by phone and email, and then updating your CRM data manually, you can save time by letting your customers access a subset of the data directly themselves. Pay attention, this is not out-of-the-box functionality, but rather something you can achieve by customizing your installation.

In this example, we will create a new web page/form in the Customer Centre which allows your customers to book an appointment in the CRM calendar. There are multiple ways of creating custom pages in the Customer Centre, however, the most efficient one is probably to write is as an inline ejScript.

## Inline ejScript

 Inline ejScript is our parallel to ASPX or PHP, where ejScript is inlined into an HTML document. This allows for large portions of the document to be pure HTML (without having to use print-statements), and then inlining ejScript using a special tag to "switch mode" between HTML and ejScript. Here is an example of a very simple inlined ejScript:

![x][img1]

The leading `%EJSCRIPT_START%` and matching `%EJSCRIPT_END%` tells the Parser that what is between is inline ejScript. If you want to, you can also have plain HTML outside these tags. Immediately inside these tags, we are in Parser-mode, which basically means we will output everything directly, but also look for Parser-variables, such as `%customer.name%`. When we encounter a `<%`, we switch into ejscript mode, which we keep until we see an `%>`. This is completely analogous to PHP’s `""`. In this mode, we will execute the ejScript, and you use `print()` to output HTML code. Note: you can have many ejScript-blocks in the document, and they will be merged together before parsing and execution. This means that you can start a loop in one block, then switch back to HTML-mode to print a lot of stuff, and then switch back to ejScript-mode to finish the loop:

![x][img2]

## Accessing the script from the Customer Centre

When you create a script (under **System design > Scripts**), there are two fields that allow you to access the script from the Customer Centre: **Include name** and **Key**. They will allow you to identify and authenticate access to the script. The idea is that by knowing these two values, you are allowed to execute the script in the Customer Centre with this URL:

![x][img3]

![x][img4]

As you can see, there are some important parameters to customer.exe:

* `action=safeParse` – This parameter specifies the main method of the Customer Centre, which in this case tells it that we want to execute a custom script.

* `includeId=ejscript-1` – This parameter specifies that we want to execute the script with `Include name` equals *ejscript-1*.

* `key=mySecretKey` – This parameter specifies that the secret key of the script is *mySecretKey*. If it does not match the key of the script, an error will be returned.

* Optionally, you can include `withFrame=1`. This will make the page a part of the Customer Centre default visual look by placing the returned contents inside *framework.html*, just like the other Customer Centre pages.

Additionally, you can include any parameters of your choice in the URL. You can retrieve them inside your ejScript by calling the `getCgiVariable` method. This method will also retrieve any fields sent to this script by any form POST methods, which is what we will use for our custom form.

## The nature of a web form

Web forms, in contrast to Windows program’s dialogs, are stateless. This means that between the initial form is sent to the client (browser), and the filled out form is sent back to the server, there is no process which is waiting with all its variables in memory. This means that the form must contain all variables and parameters which are required to process it. If any of the fields contain an illegal value, we need to redisplay the form (with the fields filled out with supplied values) with an error message. Finally, when the form is posted with correct data, we should display a response or redirect the browser to somewhere else. This process can be illustrated like this:

![x][img5]

As explained, the processes executed on the server (the black box) in this drawing are not connected in any way. Whatever state-like information we want to keep through this pipeline must be a part of the blue or red lines (the form posts and HTML pages returned).

## Creating our custom form

The easiest way to create our custom form, and keeping the form-data, is to create one single ejScript which handles both the processing of the form-posted data and also the creation of the HTML result. This way, it is very simple for the script to print out the form with the posted data and an error message if the supplied data was incorrect.

When creating custom pages using these mechanisms, we are really down at the HTML-level. There is no abstraction level of screens and controls, such as when creating custom screens internally in the system. This means that your script needs to print HTML-tags, take care of escaping string, and similar itself.

Here is the skeleton of a simple ejScript which will print a form with two input fields and accept the form to be posted back to the script:

![x][img6]

In the Customer Centre, it will show up like this:

![x][img7]

To simplify the code, I’ve left out css/tables/etc which would make this look a bit nicer. This form works, but currently lacks two features:

* The form does not keep its data. When you click the **Post form** button, you are returned to the form with the fields cleared.

* Posting does not really do anything useful.

First, I will fix missing feature 1, pointing out how we can keep the posted values:

![x][img8]

As you can see, I first have an ejScript section where I get the posted values of the fields by looking up their names (`name` and `message`). Secondly, inside my HTML I print out their values, calling `.htmlEncode()` on the strings which will return the contents of the string encoded so that it is HTML-compliant (escaping the '&', special characters, quotes, and such). If you try this form, it should correctly keep its values when you post it.

The second feature we should now implement is the actual business logic of this form: what should happen when you click the button. First, I will show how to catch the posting and check for validity:

![x][img9]

The new section has a Bool which is set to true if the form was posted (there is a non-empty cgi-parameter named `ok`), and then we check that both name and message are not empty. If anyone of them is empty, we print out an error message and let the rest of the form be printed as normal.

Finally, we can implement our business logic. In this case, I will use NetServer to create a default appointment for a given associate in the calendar:

![x][img10]

As can be seen from this snippet, we use `NSAppointmentAgent` and `NSAppointmentEntity` to create the appointments. These are standard methods from NetServer. A better implementation would perhaps use a dropdown to choose the associate, or find the first available time and return the chosen time to the user.

<!-- Referenced images -->
[img1]: media/image001.gif
[img2]: media/image002.gif
[img3]: media/image003.gif
[img4]: media/image004.gif
[img5]: media/image005.jpg
[img6]: media/image006.gif
[img7]: media/image007.gif
[img8]: media/image008.gif
[img9]: media/image009.gif
[img10]: media/image010.gif
