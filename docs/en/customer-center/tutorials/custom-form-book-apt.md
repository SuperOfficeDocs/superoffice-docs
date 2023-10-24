---
title: Custom form - book meeting
uid: custom-form-book-meeting
description: Custom form in Customer Centre to book a meeting
author: {github-id}
so.date: 09.15.2011
keywords: Customer Center, form
so.topic: tutorial
---

# Custom form - book meeting

In this example, we will create a new web page/form in the Customer Centre that allows your customers to book a meeting in the CRM calendar. There are multiple ways of creating custom pages in the Customer Centre, however, the most efficient one is probably to write is as an inline CRMScript.

## Creating our custom form

The easiest way to create our custom form, and keeping the form-data, is to create one single CRMScript that handles both the processing of the form-posted data and also the creation of the HTML result. This way, it is very simple for the script to print out the form with the posted data and an error message if the supplied data was incorrect.

When creating custom pages using these mechanisms, we are down at the HTML level. There is no abstraction level of screens and controls, such as when creating custom screens internally in the system. This means that your script needs to print HTML tags, take care of escaping string, and similar itself.

Here is the skeleton of a simple CRMScript that will print a form with two input fields and accept the form to be posted back to the script:

![x -screenshot][img6]

In the Customer Centre, it will show up like this:

![x -screenshot][img7]

To simplify the code, I’ve left out CSS, tables, and similar, which would make this look a bit nicer. This form works, but currently lacks 2 features:

* The form does not keep its data. When you click the **Post form** button, you are returned to the form with the fields cleared.

* Posting does not do anything useful.

First, I will fix missing feature 1, pointing out how we can keep the posted values:

![x -screenshot][img8]

As you can see, I first have a CRMScript section where I get the posted values of the fields by looking up their names (`name` and `message`). Secondly, inside my HTML I print out their values, calling `.htmlEncode()` on the strings that will return the contents of the string encoded so that it is HTML-compliant (escaping the '&', special characters, quotes, and such). If you try this form, it should correctly keep its values when you post it.

The second feature we should now implement is the actual business logic of this form: what should happen when you click the button. First, I will show how to catch the posting and check for validity:

![x -screenshot][img9]

The new section has a Bool that is set to true if the form was posted (there is a non-empty CGI-parameter named `ok`), and then we check that both name and message are not empty. If anyone of them is empty, we print out an error message and let the rest of the form be printed as normal.

Finally, we can implement our business logic. In this case, I will use NetServer to create a default appointment for a given associate in the calendar:

![x -screenshot][img10]

As can be seen from this snippet, we use `NSAppointmentAgent` and `NSAppointmentEntity` to create the appointments. These are standard methods from NetServer. A better implementation would perhaps use a dropdown to choose the associate, or find the first available time and return the chosen time to the user.

<!-- Referenced images -->
[img6]: media/image006.png
[img7]: media/image007.png
[img8]: media/image008.png
[img9]: media/image009.png
[img10]: media/image010.png
