---
title: Configuration
uid: customer-senter-config
description: Customer center configuration
author: SuperOffice Product and Engineering
date: 03.16.2023
keywords: Customer Center, CEP, parser variable
audience: settings
content_type: reference
index: true
---

# Customer center configuration

The templates in the customer care center are also built up using the [parser variables][1]. Simple changes can be done using the parser variables, but if you are to do more advanced changes, you should consider using CRMScript, which is far more powerful and can coexist with parser variables.

The Customer Center is built up of different [templates][2].

## Common parser variables

The following parser variables are common for all the templates:

| Variable | Description |
|---|---|
| AuthProgramAll | The URL used for accessing this page, with the session key added |
| AuthProgramUnderscore | The path to customer.exe with the session key and any CGI variables starting with an underscore |
| AuthProgram | The same as `AuthProgramUnderscore`, except that it does not pay attention to CGI variables with an underscore |
| CustSessionKey | The session key |
| authenticated | True if the customer has been authenticated, false if not |
| chat | True if the chat module is available |
| faq | True if the FAQ module is available |
| WwwRoot | The subdirectory that Customer Service might be installed to. Normally this will just be "/", but if installed in a subdirectory you must pay attention to this when referencing for example the graphic files |
| GfxRoot | The virtual path to the graphic files |
| GfxPath | The virtual path to the language-dependent graphic files. This variable pays attention to the language of the customer |
| config.browser | The browser type used |
| GfxBase | The same as `GfxPath` but it might include the full URL if absolute URLs are used and configured |
| GfxUrl | The same as `GfxRoot` but it might include the full URL if absolute URLs are used and configured |
| Program | The URL to the customer.exe program. Use this if you use cookies for storing the session key of the customer |
| contentFile | The name of the template that will match the chosen action. See also **framework.html**. |

## addMessage.html

This is the template used when adding a message to an existing request. The following parser variables are available:

* Ticket
* Company
* Customer

In addition, the following parser variables are available:

| Variable | Description |
|---|---|
| mailCc | The cc mail addresses when doing a post |
| message | The message when doing a post |
| attachments | The attachment ids when doing a post |

## changeCust.html

This is the template used when a customer changes their information. The following parser variables are available:

* Company
* Customer

In addition, the following parser variables are available:

| Variable | Description |
|---|---|
| cellphone | The value in the `cellphone` field |
| phone | The value in the `phone` field |
| lastname | The value in the `lastname` field |
| firstname | The value in the `firstname` field |

## doneRegister.html

This is the template used to display a welcome message when a new customer has registered. The following parser variables are available:

* Company
* Customer

In addition, the following parser variables are available:

| Variable | Description |
|---|---|
| custPassword | The password for the new customer. This might be in encrypted form if turned on |
| custUsername | The username for the new customer |

## framework.html

This is a special template. The framework.html is the framework that will surround all the other templates. In this way, you do not need to style all the other templates.

You can use the same parser variables in this file as with the other files. It is the chosen action that determines what is available here, so only use parser variables that you are certain will exist.

Pay attention to the parser command `%INCLUDE_VAR:contentFile%`. As explained earlier, each chosen action will result in a parser variable called **contentFile**. This parser variable will contain the name of the template matching the action. The command `INCLUDE_VAR` will simply insert this file into the *framework.html* file.

## listSimilarKbEntries.html

This template is used to list similar FAQ entries when using the wiki functionality of the FAQ.

The FAQ entry hits are placed in the following parser variables. This is an array, so you must use `%ROWSTART%` and `%ROWEND%` to loop over them.

| Variable | Description |
|---|---|
| kbEntry.url | The URL to the FAQ entry in HTML format (so no need to add the tag), with the correct name |
| kbEntry.urlTarget | The URL to the FAQ entry |
| kbEntry.urlTitle | The name for the URL |

In addition, the following parser variables are available:

| Variable | Description |
|---|---|
| numEntries | The number of entries found |
| originalEntry | The name of the original wiki link that was clicked |

## listTicket.html

This template is used to display one single request.

* Message, but not that this will be an array, so you need to use `%ROWSTART%` and `%ROWEND%` to loop over them.
* Message where is the number of the message starting from 0. This makes each message accessible as a single parser object.
* Company
* Customer
* Ticket

| Variable | Description |
|---|---|
| message.attachmentsAlt | An array containing complete HTML code for displaying all attachments for a single message. That means that each element in the array contains all the attachments for this message. The attachment will be displayed in a new window if clicked. |
| message.attachments | The same as the above, except that the attachment will be opened in the same window. |

## listTickets.html

This template is used to list all the requests that the customer has access to.

* Ticket

In addition, the following parser variables are available:

| Variable | Description |
|---|---|
| pageNumbers | An array that The number of each page. This is convenient to use in conjunction with `%ROWSTART%%ROWEND%` to print the page selector. |
| nextPage | indicates that there is a next page. If this parser variable is missing, there is no next page. The value of the variable is *true* when there is a next page |
| prevPage | The same as above, but in the opposite direction |
| direction | The sort order. When clicking a column header you can sort on this column. Clicking again will reverse the order. Will contain "asc" or "desc" depending on the direction, or empty if no direction is selected. See also **orderBy** below. |
| searchText | The text searched for. Will be empty if no search has been done. |
| filterBy | The filtering value. It is possible to reduce the request shown by filtering them. This should be set in the URL for this page, and the parser variable `filterBy` will contain this value so you can use them in other URLs. Possible values: "open", "own" and "closed". |
| orderBy | The ORDERBY clauses used, so you can preserve the order in other URLs. The value should be set in the URL to make the customer care center use the order for the request list. The field should be separated with a comma. Possible values: "status", "id", "title", "created", "category", "priority". At the end of the list, you should append the direction. |
| pageLength | The number of requests on each page. This should be set in the URL, and the parser variable will contain the chosen length. |
| numPages | The total number of pages. |
| currentPage | The number of the current page |
| numTickets | The total number of requests. |

## welcome.html

This template The welcome message that is displayed when a customer logs in. The following parser variables are available:

* Company
* Customer

## loggedOut.html

This template The message that is displayed when a customer logs out. The following parser variables are available:

* Company
* Customer

## login.html

This template The login screen. The following parser variables are available:

"username" The value entered in the username field.

## newTicket.html

This template The new request screen. The following parser variables are available:

* Company
* Customer

| Variable | Description |
|---|---|
| category | The HTML code to display the external categories in one single list (flattened) |
| category.body | The HTML code to display the external categories in a hierarchy |
| category.externalName | The names of the external categories (array) |
| category.name | The internal names of the external categories (array) |
| category.id | The ID of the external categories (array) |
| category.parentId | The parent ID of the external categories (array) |
| category.selected | Contains "selected" for those elements in the category array that are selected |
| custPhone | The value of the customer phone field (if existing) |
| title | The value of the title/subject field |
| custEmail | The value of the customer email field. Normally only displayed when not authorized |
| custName | The value of the customer name field. Normally only displayed when not authorized |
| mailCc | The value of the CC field (if existing) |
| attachments | The ID of the attachments |

## noAccess.html

This template is displayed if trying to access a screen that the customer does not have access to (for example trying to view a request that he/she does not own).

The following parser variables are available:

* Company
* Customer

## passwordSent.html

This template is displayed after submitting the email address in the "forgotten password" screen. No other than the standard variables are available.

## registerCust.html

This template is displayed when a customer is trying to register. The following parser variables are available:

| Variable | Description |
|---|---|
| cellphone | The value of the cell phone field |
| phone | The value of the phone field |
| password | The value of the password field |
| password2 | The value of the repeat password field |
| email | The value of the email field |
| firstname | The value of the first name field |
| lastname | The value of the last name field |

## sendPassword.html

This template is displayed when the customer has clicked the **Forgotten password** button. No other than the standard variables are available.

## ticketPosted.html

This template is displayed when a customer has posted a new request. The following parser variables are available:

* Company (if authenticated)
* Customer (if authenticated)

| Variable | Description |
|---|---|
| category.externalName | The names of the external categories (array) |
| category.name | The internal names of the external categories (array) |
| category.id | The ID of the external categories (array) |
| category.parentId | The parent ID of the external categories (array) |
| category.selected | Contains "selected" for those elements in the category array that are selected |
| ticket.id | The ID of the new request |
| message | The message text of the new request |

## viewKbCategory.html

This template is displayed when viewing a FAQ category. The following parser variables are available:

* Company (if authenticated)
* Customer (if authenticated)

| Variable | Description |
|---|---|
| entry.answerPlainBr | All answer sections for entries in the current category. All newlines will be replaced by the tag. All URLs will be made clickable and opened in a new window (array). |
| entry.answerPlain | The same as above except that newlines will not be modified. |
| entry.answer | The same as above except that URLs will not automatically be made clickable. |
| entry.score | The score given to the entry (array). |
| entry.questionHtml | The question part (array) |
| entry.questionParsed | The same as above, except that the question is run through the parser |
| entry.question | The same as `entry.questionHtml`, except that newlines and tabs are removed, and the lines are chopped at 70 characters length. In addition, the question is checked with the legal HTML tags configured in the system (other tags will be removed). |
| entry.link | The link to the entry (array) |
| entry.name | The name of the entry (array) |
| entry.id | The ID of the entry (array) |
| category.description | The description of the next level of sub-categories (array) |
| category.name | The name of the next level of sub-categories (array) |
| category.id | The ID of the next level of sub-categories (array) |
| depth | Indicates which category depth you are on, where the top category is 0 |
| categoryId | The ID of the current category |

## viewKkEntry.html

This template is displayed when viewing a FAQ entry. The following parser variables are available:

* Company (if authenticated)
* Customer (if authenticated)

| Variable | Description |
|---|---|
| noHits | Set to 1 if this entry does not contain any links or attachments |
| entry.score | The score given to the entry |
| entry.question | The question part of the entry |
| entry.questionParsed | A parsed version of the entry. This is only available if the system is configured to allow parsing of a FAQ. This is controlled in the Registry table by setting "value" to 0 where reg_id= 64. |
| entry.answer | The answer part of the entry |
| entry.answerPlain | The answer part of the entry, where all URLs are made clickable |
| entry.answerPlainBr | The same as above, except that all newlines will be converted to the HTML tag |
| entry.answerParsed | A parsed version of the entry. This is only available if the system is configured to allow parsing of the FAQ. This is controlled in the Registry table by setting "value" to 0 where reg_id= 64. |
| entry.title | The title of the entry |
| entry.id | The ID of the entry |
| ticket.id | The ID of the request **if the customer was redirected** here using the auto FAQ suggestion on email filters. This is normally used to create a button that the customer can click to close the request. |

## viewKbSearch.html

This template is used to display entries and categories that match a search done by the customer. The following parser variables are available:

| Variable | Description |
|---|---|
| searchString | The text that the customer searched for |
| category.score | A number between 0 and 100, indicating how good a match this is (array) |
| category.description | The description of the category (array) |
| category.link | The URL to the category (array) |
| category.name | The name of the category (array) |
| category.id | The ID of the category (array) |
| entry.score | A number between 0 and 100, indicating how good a match this is (array) |
| entry.question | The question part of the entry (array) |
| entry.link | The URL to the entry (array) |
| entry.name | The name of the entry (array) |
| entry.id | The ID of the entry (array) |

## Welcome.html

This template is displayed when entering the Customer Care Center.

No other than the standard parser variables are available.

<!-- Referenced links -->
[1]: ../knowledge-base/learn/reply-templates/template-variables.md
[2]: templates.md
