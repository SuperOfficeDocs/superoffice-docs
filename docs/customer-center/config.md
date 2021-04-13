---
title: Configuration
uid: customer_senter_config
description: Customer center configuration
author: {github-id}
keywords:
so.topic: reference
---

# Customer center configuration

The templates in the customer care center are also built up using the [parser variables][1]. Simple changes can be done using the parser variables, but if you are to do more advanced changes, you should consider using CRMScript which is far more powerful and can coexist with parser variables.

The Customer Center is built up of different [templates][2].

## Common parser variables

The following parser variables are common for all the templates:

"AuthProgramAll" contains the URL used for accessing this page, with the session key added

"AuthProgramUnderscore" contains the path to customer.exe with the session key and any cgi variables starting with underscore

"AuthProgram" contains the same as AuthProgramUnderscore, except that it does not pay attention to cgi variables with underscore

"CustSessionKey" contains the session key

"authenticated" contains true if the customer has been authenticated, false if not

"chat" contains true of the chat module is available

"faq" contains true of the FAQ module is available

"WwwRoot" contains the subdirectory which Customer Service might be installed to. Normally this will just be

"/", but if installed in a subdirectory you must pay attention to this when referencing for example the graphic files.

"GfxRoot" contains the virtual path to the graphic files

"GfxPath" contains the virtual path to the language dependent graphic files. This variable pays attention to the language of the customer

"config.browser" contains the browser type used

"GfxBase" is the same as "GfxPath" but it might include the full URL if absolute URLs are used and configured

"GfxUrl" is the same as GfxRoot but it might include the full URL if absolute URLs are used and configured

"Program" contains the URL to the customer.exe program. Use this if you use cookies for storing the session key of the customer.

"contentFile" contains the name of the template that will match the chosen action. See also "framework.html".

## addMessage.html

This is the template used when adding a message to an existing request. The following parser variables are available:

* Ticket
* Company
* Customer

In addition, the following parser variables are available:

* "mailCc" will hold the cc mail addresses when doing a post
* "message" will hold the message when doing a post
* "attachments" will hold the attachment ids when doing a post
* changeCust.html

This is the template used when a customer changes their information. The following parser variables are available:

* Company
* Customer

In addition, the following parser variables are available:

"cellphone" contains the value in the cellphone field

"phone" contains the value in the phone field

"lastname" contains the value in the lastname field

"firstname" contains the value in the firstname field

## doneRegister.html

This is the template used to display a welcome message when a new customer has registered. The following parser variables are available:

* Company
* Customer

In addition the following parser variables are available:

"custPassword" contains the password for the new customer. This might be in encrypted form if turned on

"custUsername" contains the username for the new customer.

## framework.html

This is a special template. The framework.html is the framework that will surround all the other templates. In this way, you do not need to style all the other templates.

You can use the same parser variables in this file as with the other files. It is actually the chosen action that determines what is available here, so only use parser variables that you are certain will exist.

Pay attention to the parser command %INCLUDE\_VAR:contentFile%. As explained earlier, each chosen action will result in a parser variable called "contentFile". This parser variable will contain the name of the template matching the action. The command INCLUDE\_VAR will simply insert this file into the framework.html file.

## listSimilarKbEntries.html

This template is used to list similar FAQ entries when using the wiki functionality of the FAQ.

The FAQ entry hits are placed in the following parser variables. This is an array, so you must use

%ROWSTART% and %ROWEND% to loop over them.

"kbEntry.url" contains the URL to the FAQ entry in HTML format (so no need to add the tag), with the correct name

"kbEntry.urlTarget" contains the URL to the FAQ entry

"kbEntry.urlTitle" contains the name for the URL

In addition the following parser variables are available:

"numEntries" contains the number of entries found

"originalEntry" contains the name of the original wiki link that was clicked

## listTicket.html

This template is used to display one single request.

* Message, but not that this will be an array, so you need to use %ROWSTART% and %ROWEND% to loop over them.
* Message where is the number of the message starting from 0. This makes each message accessible as a single parser object.
* Company
* Customer
* Ticket

"message.attachmentsAlt" is an array containing complete HTML code for displaying all attachments for a single message. That means that each element in the array contains all the attachments for this message. Attachment will be displayed in a new window if clicked.

"message.attachments" contains the same as the above, except that the attachment will be opened in the same window.

## listTickets.html

This template is used to list all the request which the customer has access to.

* Ticket

In addition the following parser variables are available:

"pageNumbers" is an array which contains the number of each page. This is convenient to use in conjunction with %ROWSTART%%ROWEND% to print the page selector.

"nextPage" indicates that there exist a next page. If this parser variable is missing, there is no next page. The value of the variable is "true" when there is a next page

"prevPage", same as above, but in the opposite direction

"direction" will contain the sort order. When clicking a column header you can sort on this column. Clicking again will reverse the order. "direction" will contain "asc" or "desc" depending on the direction, or empty if no direction is selected. See also "orderBy" bellow.

"searchText" will contain the text searched for. Will be empty if no search has been done.

"filterBy" will contain the filtering value. It is possible to reduce the request shown by filtering them.

This should be set in the URL for this page, and the parser variable "filterBy" will contain this value so you can use them in other URLs. Legal values are "open", "own" and "closed".

"orderBy" will contain the "order by" clauses used, so you can preserve the order in other URLs. The value should be set in the URL to make the customer care center use the order for the request list. The field should be separated with comma. Legal values are "status", "id", "title", "created", "category",

"priority". At the end of the list you should append the direction.

"pageLength" will contain the number of request in each page. This should be set in the URL, and the parser variable will contain the chosen length.

"numPages" contains the total number of pages.

"currentPage" contains the number of the current page

"numTickets" contains the total number of requests.

## welcome.html

This template contains the welcome message that is displayed when a customer logs in. The following parser variables are available:

* Company
* Customer

## loggedOut.html

This template contains the message that is displayed when a customer logs out. The following parser variables are available:

* Company
* Customer

## login.html

This template contains the login screen. The following parser variables are available:

"username" contains the value entered in the username field.

## newTicket.html

This template contains the new request screen. The following parser variables are available:

* Company
* Customer

"category" contains the HTML code to display the external categories in one single list (flattened)

"category.body" contains the HTML code to display the external categories in a hierarchy

"category.externalName" contains the names of the external categories (array)

"category.name" contains the internal names of the external categories (array)

"category.id" contains the id of the external categories (array)

"category.parentId" contains the partent id of the external categories (array)

"category.selected" contains "selected" for those elements in the category array that are selected

"custPhone" contains the value of the customer phone field (if existing)

"title" contains the value of the title/subject field

"custEmail" contains the value of the customer email field. Normally only displayed when not authorized

"custName" contains the value of the customer name field. Normally only displayed when not authorized

"mailCc" contains the value of the CC field (if existing)

"attachments" contains the id of the attachments

## noAccess.html

This template is displayed if trying to access a screen that the customer do not have access for (for example trying to view a request that he/she does not own).

The following parser variables are available:

* Company
* Customer

## passwordSent.html

This template is displayed after submitting the email address in the "forgotten password" screen. No other than the standard variables are available.

## registerCust.html

This template is displayed when a customer is trying to register. The following parser variables are available:

"cellphone" contains the value of the cell phone field

"phone" contains the value of the phone field

"password" contains the value of the password field

"password2" contains the value of the repeat password field

"email" contains the value of the email field

"firstname" contains the value of the first name field

"lastname" contains the value of the last name field

## sendPassword.html

This template is displayed when the customer has clicked the "Forgotten password" button. No other than the standard variables are available.

## ticketPosted.html

This template is displayed when a customer has posted a new request. The following parser variables are available:

* Company (if authenticated)
* Customer (if authenticated)

"category.externalName" contains the names of the external categories (array)

"category.name" contains the internal names of the external categories (array)

"category.id" contains the id of the external categories (array)

"category.parentId" contains the partent id of the external categories (array)

"category.selected" contains "selected" for those elements in the category array that are selected

"ticket.id" contains the id of the new request

"message" contains the message text of the new request

## viewKbCategory.html

This template is displayed when viewing a FAQ category. The following parser variables are available:

* Company (if authenticated)
* Customer (if authenticated)

"entry.answerPlainBr" contains all the answer sections for entries in the current category. All newlines will be replaced by the tag. All URLs will be made clickable and opened in a new window (array).

"entry.answerPlain", same as above except that newlines will not be modified.

"entry.answer", same as above except that URLs will not automatically be made clickable.

"entry.score" contains the score given to the entry (array).

"entry.questionHtml contains the question part (array)

"entry.questionParsed", same as above, except that the question is run through the parser

"entry.question", same as "entry.questionHtml", except that newlines and tabs are removed, and the lines are chopped at 70 characters length. In addition the question is checked with the legal HTML tags configured in the system (other tags will be removed).

"entry.link" contains the link to the entry (array)

"entry.name" contains the name of the entry (array)

"entry.id" contains the id of the entry (array)

"category.description" contains the description of the next level of sub categories (array)

"category.name" contains the name of the next level of sub categories (array)

"category.id" contains the id of the next level of sub categories (array)

"depth" indicates which category depth you are on, where top category is 0

"categoryId" contains the id of the current category

## viewKkEntry.html

This template is displayed when viewing a FAQ entry. The following parser variables are available:

* Company (if authenticated)
* Customer (if authenticated)

"noHits" is set to 1 if this entry does not contain any links or attachments

"entry.score" contains the score given to the entry

"entry.question" contains the question part of the entry

"entry.questionParsed" contains a parsed version of the entry. This is only available if the system is

configured to allow parsing of FAQ. This is controlled in the Registry table by setting "value" to 0 where reg\_id= 64.

"entry.answer" contains the answer part of the entry

"entry.answerPlain" contains the answer part of the entry, where all URLs are made clickable

"entry.answerPlainBr" contains the same as above, except that all newlines will be converted to the HTML tag

"entry.answerParsed" contains a parsed version of the entry. This is only available if the system is configured to allow parsing of FAQ. This is controlled in the Registry table by setting "value" to 0 where reg\_id= 64.

"entry.title" contains the title of the entry

"entry.id" contains the id of the entry

"ticket.id" will contain the id of the request if the customer was redirected here using the auto FAQ suggestion on email filters. This is normally used to create a button that the customer can click to close the request.

## viewKbSearch.html

This template is used to display entries and categories that match a search done by the customer. The following parser variables are available:

"searchString" contains the text that the customer searched for

"category.score" is a number between 0 and 100, indicating how good match this is (array)

"category.description" contains the description of the category (array)

"category.link" contains the URL to the category (array)

"category.name" contains the name of the category (array)

"category.id" contains the id of the category (array)

"entry.score" is a number between 0 and 100, indicating how good match this is (array)

"entry.question" contains the question part of the entry (array)

"entry.link" contains the URL to the entry (array)

"entry.name" contains the name of the entry (array)

"entry.id" contains the id of the entry (array)

## Welcome.html

This template is displayed when entering the Customer Care Center.

No other than the standard parser variables are available.

<!-- Referenced links -->
[1]: ../reply-templates/index.md
[2]: templates.md
