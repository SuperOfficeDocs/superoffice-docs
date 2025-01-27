---
uid: help-en-template-variables-service
title: Template variables
description: Template variables
keywords: request
author: SuperOffice RnD
date: 06.29.2022
topic: reference
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Reply template variables (Service)

In the email message, you can use template variables to insert customer-specific information to give the message a more personal touch. In this way, you can customize the content for each individual customer.

In the tables below you can find all template variables for SuperOffice Service and SuperOffice Marketing.

When editing reply templates and mailings, you can insert template variables by typing the variable between two square brackets (\[\[ \]\] ). Example: **\[\[customer.name\]\]**. In the HTML editor, you can also select the most common variables from the **Template variable** menu.

## Attachments (only SuperOffice Marketing)

| Variable | Description|
|---|---|
| attachment.downloadUrl | Link to download the attachment |
| attachment.name | Attachment file name |
| attachment.openUrl | Link to open the attachment |
| InEmailClient | 1 if the mailing message is shown inside the email client, not present when the mailing message is shown online in a browser |
| isWebPage | 1 if the mailing message is shown online in a browser |

## License info

| Variable | Description|
|---|---|
| licence.admin | 1 if the customer has licence for Admin, otherwise 0 |
| licence.advancedfaq | 1 if the customer has licence for Advanced FAQ, otherwise 0 |
| licence.ajax | 1 if the customer has licence for Ajax, otherwise 0 |
| licence.blogic | 1 if the customer has licence for bLogic, otherwise 0 |
| licence.chat | 1 if the customer has licence for Chat, otherwise 0 |
| licence.custlang | 1 if the customer has licence for CustLang, otherwise 0 |
| licence.customer | 1 if the customer has licence for Customer, otherwise 0 |
| licence.document | 1 if the customer has licence for Document, otherwise 0 |
| licence.extdb | 1 if the customer has licence for Extdb, otherwise 0 |
| licence.help | 1 if the customer has licence for Help, otherwise 0 |
| licence.knowledge | 1 if the customer has licence for Knowledge, otherwise 0 |
| licence.logout | 1 if the customer has licence for Logout, otherwise 0 |
| licence.macro | 1 if the customer has licence for Macro, otherwise 0 |
| licence.retail | 1 if the customer has licence for Retail, otherwise 0 |
| licence.rms | 1 if the customer has licence for RMS, otherwise 0 |
| licence.sms | 1 if the customer has licence for SMS, otherwise 0 |
| licence.soap | 1 if the customer has licence for Soap, otherwise 0 |
| licence.soapPublic | 1 if the customer has licence for Soap Public, otherwise 0 |
| licence.spm | 1 if the customer has licence for SPM, otherwise 0 |
| licence.standardEdition | 1 if the customer has licence for Standard Edition, otherwise 0 |
| licence.stat | 1 if the customer has licence for Stat, otherwise 0 |
| licence.ticket | 1 if the customer has licence for Ticket, otherwise 0 |

## Links (only SuperOffice Marketing)

| Variable | Description|
|---|---|
| Link for viewing message online | URL for showing the mailing message online in a browser, for example 'Click here if this message looks funny' |
| link.subscription | The link to cancel your subscription |
| link.viewShipmentMessage | The link to view the mailing message online |

## <a id="config"></a>Maintenance

| Variable | Description|
|---|---|
| config.adminMail | The email address for the system administrator for this installation |
| config.cgiBin | The URL suffix for the executable program files |
| config.cgiUrl | The external base URL for the installation |
| config.cgiUrlInternal | The internal base URL for the installation |
| config.companyAddress | The address of the owner company |
| config.companyName | The name of the owner company |
| config.defaultMail | The default mail-from address for this installation |
| config.gfxUrl | The URL suffix for the GFX-files |
| config.mailTag | The "Please include the ticket ID..." phrase used as first line in outbound emails |
| config.panicMail | The email address to send error messages to |
| config.smtpHost | The hostname for the outbound SMTP |
| config.smtpPort | The port for the outbound SMTP |
| config.tag | The prefix before the request number in the subject line for emails. For example, "ejTag:" |
| config.uniqueId | The unique ID for this installation |
| config.warning | The path for the warning log files |
| config.wwwPath | The system path for WWW files |

## <a id="customer"></a>Variables for a selected contact

| Variable | Description|
|---|---|
| customer.bestName | The best available name for this customer |
| customer.cellphone | Mobile phone number |
| customer.deleted | 1 If this customer is deleted |
| customer.email | Email address |
| customer.firstname | First name |
| customer.id | Contact ID (hidden, unique ID) |
| customer.language | Selected language on contact |
| customer.lastname | Last name |
| customer.middlename | Middle name |
| customer.mrmrs | Mr/Ms field |
| customer.name | Full name |
| customer.note | Note |
| customer.ourContact | The id (ejuser) of the agent which is marked as the primary support contact for this customer |
| customer.password | Password in SuperOffice Customer Centre |
| customer.phone | Phone number |
| customer.salutation | Salutation - the full name if available, or the email address if no name is known |
| customer.title | Title |
| customer.username | User name in SuperOffice Customer Centre |
| makeSalutation(customer.id) | Salutation |

## <a id="ticket"></a>Variables for requests (only SuperOffice Service)

| Variable | Description|
|---|---|
| ticket.activate | When to activate the request, if it is in a postponed state |
| ticket.alertLevel | Alert level |
| ticket.author | The name of the person creating the request |
| ticket.category | Same as ticket.category.id |
| ticket.category.externalName | Category, external name |
| ticket.category.fullname | Category |
| ticket.category.id | Category ID (hidden, unique ID) |
| ticket.category.name | The name of the category for the ticket |
| ticket.closedAt | When the request was closed |
| ticket.closedAtRaw | The datetime when the request was closed in YYYY-MM-DD HH |
| ticket.createdAt | The datetime when the request was created in the user's default format |
| ticket.createdAtRaw | The datetime when the request was created in YYYY-MM-DD HH |
| ticket.customer | The ID of the customer for the request |
| ticket.customerName | The request's contact, name |
| ticket.customerUrl | The URL for accessing the request for the customer |
| ticket.customerUrlEnc | The URL for accessing the request for the customer, URL-encoded |
| ticket.customerUrlOld | The URL for accessing the request for the customer, not encoded. Kept for backwards compatibility. |
| ticket.dbiAgentId | The ID of the DBI agent if this request was synced using DBI |
| ticket.dbiKey | The external primary key if this request was synced using DBI |
| ticket.deadline | The deadline of the request |
| ticket.id | Request ID (hidden, unique ID) |
| ticket.lastChanged | The datetime when the request was last changed in the user's default format |
| ticket.lastChangedRaw | The datetime when the request was last changed in YYYY-MM-DD HH |
| ticket.ownerCellphone | The request's owner, mobile phone number |
| ticket.ownerFullName | The request's owner, full name |
| ticket.ownerUsername | The request's owner, user name |
| ticket.priority | Priority |
| ticket.readByCustomer | The date/time when the request was read by the customer in the user's default format |
| ticket.readByCustomerRaw | The date/time when the request was read by the customer in YYYY-MM-DD HH |
| ticket.readByOwner | The date/time when the request was read by the owner in the user's default format |
| ticket.readByOwnerRaw | The date/time when the request was read by the owner in YYYY-MM-DD HH |
| ticket.slevel | The access level of the ticket (1 = Internal, 2 = External) |
| ticket.status | The name of the status (Open, Closed, Postponed) |
| ticket.ticketStatus | The name of the user defined status |
| ticket.title | Request title |
| ticket.url | The URL for accessing the request for user agents |
| ticket.urlWithSession | The URL for accessing the request for user agents containing the current user session |
| ticket.userUrl | The URL for accessing the request for user agents |

## <a id="company"></a>Variables for selected company

| Variable | Description|
|---|---|
| company.adr | Address |
| company.department | Department |
| company.domain | Domain |
| company.fax | Fax number |
| company.id | Company ID (hidden, unique ID) |
| company.name | Company name |
| company.note | Note |
| company.ourContact | Same as company.primaryContact.id |
| company.ourContact.cellphone | Our contact, cell phone number |
| company.ourContact.email | Our contact, email address |
| company.ourContact.name | Our contact, name |
| company.ourContact.phone | Our contact, phone number |
| company.ourSalesContact | The id (associate) of the company's KAM |
| company.ourSalesContact.cellphone | Our sales contact, cell phone number |
| company.ourSalesContact.email | Our sales contact, email address |
| company.ourSalesContact.name | Our sales contact, name |
| company.ourSalesContact.phone | Our sales contact, phone number |
| company.phone | Phone number |
| company.primaryContact.email | Main contact, email address |
| company.primaryContact.id | The id (ejuser) of the agent which is marked as the primary support contact for this company |
| ourContact.email | Our contacts email address |
| ourContact.name | Our contact |

## <a id="user"></a>Variables for reply templates (user) (only SuperOffice Service)

Please note that these variables will not work for automated replies sent by the system, because such replies are not linked to a user.

| Variable | Description|
|---|---|
| user.access | The sender's functional access as a bitmask |
| user.dictionary | The users default dictionary language |
| user.email | Email address |
| user.firstname | First name |
| user.id | The primary key of the sender in the ejuser table |
| user.language | Sender's selected language |
| user.lastname | Last name |
| user.loginname | Login name |
| user.middlename | Middle name |
| user.name | The full name of the user agent |
| user.signature | Sender's signature from Settings |
| user.status | The sender's status (1 = normal, 2 = not available, 3 = deleted) |
| user.username | The sender's username, not necessarily same as loginname |

## Conditional values

\[\[IF:condition="1"\]\]

Condition is one

\[\[ELSEIF:condition="2"\]\]

Condition is two

\[\[ELSE\]\]

Condition is something else

\[\[ENDIF\]\]

Choose from values:

\[\[DECODE:expr,"value1","return1","value2","return2","default"\]\]

Set variable:

\[\[SET:name="value"\]\]

Increment variable:

\[\[INC:variable\]\]

Decrement variable:

\[\[DEC:variable\]\]

Format date:

\[\[FORMAT-DATE:"date","YY4 MM2 DD2 HH24:MI2:SS2"\]\]

Format time:

\[\[SEC-TO-TIME:"seconds","h:m:s"\]\]

<!-- Referenced links -->

<!-- Referenced images -->
