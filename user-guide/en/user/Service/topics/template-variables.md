 Service

# Template variables (Service)

In the e-mail message, you can use template variables to insert customer-specific information in order to give the message a more personal touch. In this way, you can customise the content for each individual customer.

In the tables below you can find all template variables for SuperOffice Service and SuperOffice Marketing.

([Click here to see template variables for SuperOffice CRM](Template_variables.md).)

[Attachments](Template_variables.md#Attachments) | [Licence info](Template_variables.md#Licence_info) | [Links](Template_variables.md#Links) | [Maintenance](Template_variables.md#Maintenance) | [Selected contact](Template_variables.md#Variables_for_a_selected_contact) | [Requests](Template_variables.md#Variables_for_requests) | [Selected company](Template_variables.md#Variables_for_selected_company) | [Reply templates (user)](Template_variables.md#Variables_for_replytemplates) | [Conditional values](Template_variables.md#Conditional_values)

<!-- Fix reuse ID=a1 -->

When editing reply templates and mailings, you can insert template variables by typing the variable between two square brackets (\[\[ \]\] ). Example: **\[\[customer.name\]\]**. In the HTML editor, you can also select the most common variables from the **Template variable** menu.

## Attachments (only SuperOffice Marketing)

<table data-cellspacing="0">
<thead>
<tr>
<th style="border: Solid 1px #000000"><p>**Variable**</p></th>
<th style="border-top: Solid 1px #000000; border-right: Solid 1px #000000; border-bottom: Solid 1px #000000"><p>**Description**</p></th>
</tr>
</thead>
<tbody>
<tr>
<td>attachment.downloadUrl</td>
<td>Link to download the attachment</td>
</tr>
<tr>
<td>attachment.name</td>
<td>Attachment file name</td>
</tr>
<tr>
<td>attachment.openUrl</td>
<td>Link to open the attachment</td>
</tr>
<tr>
<td>InEmailClient</td>
<td>1 if the mailing message is shown inside the email client, not present when the mailing message is shown online in a browser</td>
</tr>
<tr>
<td>isWebPage</td>
<td>1 if the mailing message is shown online in a browser</td>
</tr>
</tbody>
</table>

## Licence info

<table data-cellspacing="0">
<thead>
<tr>
<th style="border: Solid 1px #000000"><p>**Variable**</p></th>
<th style="border-top: Solid 1px #000000; border-right: Solid 1px #000000; border-bottom: Solid 1px #000000"><p>**Description**</p></th>
</tr>
</thead>
<tbody>
<tr>
<td>licence.admin</td>
<td>1 if the customer has licence for Admin, otherwise 0</td>
</tr>
<tr>
<td>licence.advancedfaq</td>
<td>1 if the customer has licence for Advanced FAQ, otherwise 0</td>
</tr>
<tr>
<td>licence.ajax</td>
<td>1 if the customer has licence for Ajax, otherwise 0</td>
</tr>
<tr>
<td>licence.blogic</td>
<td>1 if the customer has licence for Blogic, otherwise 0</td>
</tr>
<tr>
<td>licence.chat</td>
<td>1 if the customer has licence for Chat, otherwise 0</td>
</tr>
<tr>
<td>licence.custlang</td>
<td>1 if the customer has licence for CustLang, otherwise 0</td>
</tr>
<tr>
<td>licence.customer</td>
<td>1 if the customer has licence for Customer, otherwise 0</td>
</tr>
<tr>
<td>licence.document</td>
<td>1 if the customer has licence for Document, otherwise 0</td>
</tr>
<tr>
<td>licence.extdb</td>
<td>1 if the customer has licence for Extdb, otherwise 0</td>
</tr>
<tr>
<td>licence.help</td>
<td>1 if the customer has licence for Help, otherwise 0</td>
</tr>
<tr>
<td>licence.knowledge</td>
<td>1 if the customer has licence for Knowledge, otherwise 0</td>
</tr>
<tr>
<td>licence.logout</td>
<td>1 if the customer has licence for Logout, otherwise 0</td>
</tr>
<tr>
<td>licence.macro</td>
<td>1 if the customer has licence for Macro, otherwise 0</td>
</tr>
<tr>
<td>licence.retail</td>
<td>1 if the customer has licence for Retail, otherwise 0</td>
</tr>
<tr>
<td>licence.rms</td>
<td>1 if the customer has licence for RMS, otherwise 0</td>
</tr>
<tr>
<td>licence.sms</td>
<td>1 if the customer has licence for SMS, otherwise 0</td>
</tr>
<tr>
<td>licence.soap</td>
<td>1 if the customer has licence for Soap, otherwise 0</td>
</tr>
<tr>
<td>licence.soapPublic</td>
<td>1 if the customer has licence for Soap Public, otherwise 0</td>
</tr>
<tr>
<td>licence.spm</td>
<td>1 if the customer has licence for SPM, otherwise 0</td>
</tr>
<tr>
<td>licence.standardEdition</td>
<td>1 if the customer has licence for Standard Edition, otherwise 0</td>
</tr>
<tr>
<td>licence.stat</td>
<td>1 if the customer has licence for Stat, otherwise 0</td>
</tr>
<tr>
<td>licence.ticket</td>
<td>1 if the customer has licence for Ticket, otherwise 0</td>
</tr>
</tbody>
</table>

## Links (only SuperOffice Marketing)

<table data-cellspacing="0">
<thead>
<tr>
<th style="border: Solid 1px #000000"><p>**Variable**</p></th>
<th style="border-top: Solid 1px #000000; border-right: Solid 1px #000000; border-bottom: Solid 1px #000000"><p>**Description**</p></th>
</tr>
</thead>
<tbody>
<tr>
<td>Link for viewing message online</td>
<td>URL for showing the mailing message online in a browser, for example 'Click here if this message looks funny'</td>
</tr>
<tr>
<td>link.subscription</td>
<td>The link to cancel your subscription</td>
</tr>
<tr>
<td>link.viewShipmentMessage</td>
<td>The link to view the mailing message online</td>
</tr>
</tbody>
</table>

## Maintenance

<table data-cellspacing="0">
<thead>
<tr>
<th style="border: Solid 1px #000000"><p>**Variable**</p></th>
<th style="border-top: Solid 1px #000000; border-right: Solid 1px #000000; border-bottom: Solid 1px #000000"><p>**Description**</p></th>
</tr>
</thead>
<tbody>
<tr>
<td>config.adminMail</td>
<td>The email address for the system administrator for this installation</td>
</tr>
<tr>
<td>config.cgiBin</td>
<td>The URL suffix for the executable program files</td>
</tr>
<tr>
<td>config.cgiUrl</td>
<td>The external base URL for the installation</td>
</tr>
<tr>
<td>config.cgiUrlInternal</td>
<td>The internal base URL for the installation</td>
</tr>
<tr>
<td>config.companyAddress</td>
<td>The address of the owner company</td>
</tr>
<tr>
<td>config.companyName</td>
<td>The name of the owner company</td>
</tr>
<tr>
<td>config.defaultMail</td>
<td>The default mail-from address for this installation</td>
</tr>
<tr>
<td>config.gfxUrl</td>
<td>The URL suffix for the GFX-files</td>
</tr>
<tr>
<td>config.mailTag</td>
<td>The "Please include the ticket id..." phrase used as first line in outbound emails</td>
</tr>
<tr>
<td>config.panicMail</td>
<td>The email address where error messages will be sent</td>
</tr>
<tr>
<td>config.smtpHost</td>
<td>The hostname for the outbound SMTP</td>
</tr>
<tr>
<td>config.smtpPort</td>
<td>The port for the outbound SMTP</td>
</tr>
<tr>
<td>config.tag</td>
<td>The prefix before the request number in the subject line for emails, e.g. “ejTag:”</td>
</tr>
<tr>
<td>config.uniqueId</td>
<td>The unique ID for this installation</td>
</tr>
<tr>
<td>config.warning</td>
<td>The path for the warning log files</td>
</tr>
<tr>
<td>config.wwwPath</td>
<td>The system path for WWW files</td>
</tr>
</tbody>
</table>

## Variables for a selected contact

<table style="margin-left: 2px;" data-cellspacing="0">
<thead>
<tr>
<th style="border: Solid 1px #000000"><p>**Variable**</p></th>
<th style="border-top: Solid 1px #000000; border-right: Solid 1px #000000; border-bottom: Solid 1px #000000"><p>**Description**</p></th>
</tr>
</thead>
<tbody>
<tr>
<td>customer.bestName</td>
<td>The best available name for this customer</td>
</tr>
<tr>
<td>customer.cellphone</td>
<td>Mobile phone number</td>
</tr>
<tr>
<td>customer.deleted</td>
<td>1 If this customer is deleted</td>
</tr>
<tr>
<td>customer.email</td>
<td>E-mail address</td>
</tr>
<tr>
<td>customer.firstname</td>
<td>First name</td>
</tr>
<tr>
<td>customer.id</td>
<td>Contact ID (hidden, unique ID)</td>
</tr>
<tr>
<td>customer.language</td>
<td>Selected language on contact</td>
</tr>
<tr>
<td>customer.lastname</td>
<td>Last name</td>
</tr>
<tr>
<td>customer.middlename</td>
<td>Middle name</td>
</tr>
<tr>
<td>customer.mrmrs</td>
<td>Mr/Ms field</td>
</tr>
<tr>
<td>customer.name</td>
<td>Full name</td>
</tr>
<tr>
<td>customer.note</td>
<td>Note</td>
</tr>
<tr>
<td>customer.ourContact</td>
<td>The id (ejuser) of the agent which is marked as the primary support contact for this customer</td>
</tr>
<tr>
<td>customer.password</td>
<td>Password in SuperOffice Customer Centre</td>
</tr>
<tr>
<td>customer.phone</td>
<td>Phone number</td>
</tr>
<tr>
<td>customer.salutation</td>
<td>Salutation - the full name if available, or the email address if no name is known</td>
</tr>
<tr>
<td>customer.title</td>
<td>Title</td>
</tr>
<tr>
<td>customer.username</td>
<td>User name in SuperOffice Customer Centre</td>
</tr>
<tr>
<td>makeSalutation(customer.id)</td>
<td>Salutation</td>
</tr>
</tbody>
</table>

## Variables for requests (only SuperOffice Service)

<table style="margin-left: 4px;" data-cellspacing="0">
<thead>
<tr>
<th style="border: Solid 1px #000000"><p>**Variable**</p></th>
<th style="border-top: Solid 1px #000000; border-right: Solid 1px #000000; border-bottom: Solid 1px #000000"><p>**Description**</p></th>
</tr>
</thead>
<tbody>
<tr>
<td>ticket.activate</td>
<td>When the request will be activated, if it is in a postponed state</td>
</tr>
<tr>
<td>ticket.alertLevel</td>
<td>Alert level</td>
</tr>
<tr>
<td>ticket.author</td>
<td>The name of the person creating the request</td>
</tr>
<tr>
<td>ticket.category</td>
<td>Same as ticket.category.id</td>
</tr>
<tr>
<td>ticket.category.externalName</td>
<td>Category, external name</td>
</tr>
<tr>
<td>ticket.category.fullname</td>
<td>Category</td>
</tr>
<tr>
<td>ticket.category.id</td>
<td>Category ID (hidden, unique ID)</td>
</tr>
<tr>
<td>ticket.category.name</td>
<td>The name of the category for the ticket</td>
</tr>
<tr>
<td>ticket.closedAt</td>
<td>When the request was closed</td>
</tr>
<tr>
<td>ticket.closedAtRaw</td>
<td>The datetime when the request was closed in YYYY-MM-DD HH</td>
</tr>
<tr>
<td>ticket.createdAt</td>
<td>The datetime when the request was created in the user's default format</td>
</tr>
<tr>
<td>ticket.createdAtRaw</td>
<td>The datetime when the request was created in YYYY-MM-DD HH</td>
</tr>
<tr>
<td>ticket.customer</td>
<td>The ID of the customer for the request</td>
</tr>
<tr>
<td>ticket.customerName</td>
<td>The request's contact, name</td>
</tr>
<tr>
<td>ticket.customerUrl</td>
<td>The URL for accessing the request for the customer</td>
</tr>
<tr>
<td>ticket.customerUrlEnc</td>
<td>The URL for accessing the request for the customer, URL-encoded</td>
</tr>
<tr>
<td>ticket.customerUrlOld</td>
<td>The URL for accessing the request for the customer, not encoded. Kept for backwards compatibility.</td>
</tr>
<tr>
<td>ticket.dbiAgentId</td>
<td>The ID of the DBI agent if this request has been synced using DBI</td>
</tr>
<tr>
<td>ticket.dbiKey</td>
<td>The external primary key if this request has been synced using DBI</td>
</tr>
<tr>
<td>ticket.deadline</td>
<td>The deadline of the request</td>
</tr>
<tr>
<td>ticket.id</td>
<td>Request ID (hidden, unique ID)</td>
</tr>
<tr>
<td>ticket.lastChanged</td>
<td>The datetime when the request was last changed in the user's default format</td>
</tr>
<tr>
<td>ticket.lastChangedRaw</td>
<td>The datetime when the request was last changed in YYYY-MM-DD HH</td>
</tr>
<tr>
<td>ticket.ownerCellphone</td>
<td>The request's owner, mobile phone number</td>
</tr>
<tr>
<td>ticket.ownerFullName</td>
<td>The request's owner, full name</td>
</tr>
<tr>
<td>ticket.ownerUsername</td>
<td>The request's owner, user name</td>
</tr>
<tr>
<td>ticket.priority</td>
<td>Priority</td>
</tr>
<tr>
<td>ticket.readByCustomer</td>
<td>The date/time when the request was read by the customer in the user's default format</td>
</tr>
<tr>
<td>ticket.readByCustomerRaw</td>
<td>The date/time when the request was read by the customer in YYYY-MM-DD HH</td>
</tr>
<tr>
<td>ticket.readByOwner</td>
<td>The date/time when the request was read by the owner in the user's default format</td>
</tr>
<tr>
<td>ticket.readByOwnerRaw</td>
<td>The date/time when the request was read by the owner in YYYY-MM-DD HH</td>
</tr>
<tr>
<td>ticket.slevel</td>
<td>The access level of the ticket (1 = Internal, 2 = External)</td>
</tr>
<tr>
<td>ticket.status</td>
<td>The name of the status (Open, Closed, Postponed)</td>
</tr>
<tr>
<td>ticket.ticketStatus</td>
<td>The name of the user defined status</td>
</tr>
<tr>
<td>ticket.title</td>
<td>Request title</td>
</tr>
<tr>
<td>ticket.url</td>
<td>The URL for accessing the request for user agents</td>
</tr>
<tr>
<td>ticket.urlWithSession</td>
<td>The URL for accessing the request for user agents containing the current user session</td>
</tr>
<tr>
<td>ticket.userUrl</td>
<td>The URL for accessing the request for user agents</td>
</tr>
</tbody>
</table>

## Variables for selected company

<table data-cellspacing="0">
<thead>
<tr>
<th style="border: Solid 1px #000000"><p>**Variable**</p></th>
<th style="border-top: Solid 1px #000000; border-right: Solid 1px #000000; border-bottom: Solid 1px #000000"><p>**Description**</p></th>
</tr>
</thead>
<tbody>
<tr>
<td>company.adr</td>
<td>Address</td>
</tr>
<tr>
<td>company.department</td>
<td>Department</td>
</tr>
<tr>
<td>company.domain</td>
<td>Domain</td>
</tr>
<tr>
<td>company.fax</td>
<td>Fax number</td>
</tr>
<tr>
<td>company.id</td>
<td>Company ID (hidden, unique ID)</td>
</tr>
<tr>
<td>company.name</td>
<td>Company name</td>
</tr>
<tr>
<td>company.note</td>
<td>Note</td>
</tr>
<tr>
<td>company.ourContact</td>
<td>Same as company.primaryContact.id</td>
</tr>
<tr>
<td>company.ourContact.cellphone</td>
<td>Our contact, cell phone number</td>
</tr>
<tr>
<td>company.ourContact.email</td>
<td>Our contact, e-mail address</td>
</tr>
<tr>
<td>company.ourContact.name</td>
<td>Our contact, name</td>
</tr>
<tr>
<td>company.ourContact.phone</td>
<td>Our contact, phone number</td>
</tr>
<tr>
<td>company.ourSalesContact</td>
<td>The id (associate) of the company's KAM</td>
</tr>
<tr>
<td>company.ourSalesContact.cellphone</td>
<td>Our sales contact, cell phone number</td>
</tr>
<tr>
<td>company.ourSalesContact.email</td>
<td>Our sales contact, e-mail address</td>
</tr>
<tr>
<td>company.ourSalesContact.name</td>
<td>Our sales contact, name</td>
</tr>
<tr>
<td>company.ourSalesContact.phone</td>
<td>Our sales contact, phone number</td>
</tr>
<tr>
<td>company.phone</td>
<td>Phone number</td>
</tr>
<tr>
<td>company.primaryContact.email</td>
<td>Main contact, e-mail address</td>
</tr>
<tr>
<td>company.primaryContact.id</td>
<td>The id (ejuser) of the agent which is marked as the primary support contact for this company</td>
</tr>
<tr>
<td>ourContact.email</td>
<td>Our contacts e-mail address</td>
</tr>
<tr>
<td>ourContact.name</td>
<td>Our contact</td>
</tr>
</tbody>
</table>

## Variables for reply templates (user) (only SuperOffice Service)

Please note that these variables will not work for automated replies sent by the system, since such replies are not linked to a user.

<table data-cellspacing="0">
<thead>
<tr>
<th style="border: Solid 1px #000000"><p>**Variable**</p></th>
<th style="border-top: Solid 1px #000000; border-right: Solid 1px #000000; border-bottom: Solid 1px #000000"><p>**Description**</p></th>
</tr>
</thead>
<tbody>
<tr>
<td>user.access</td>
<td>The sender's functional access as a bitmask</td>
</tr>
<tr>
<td>user.dictionary</td>
<td>The users default dictionary language</td>
</tr>
<tr>
<td>user.email</td>
<td>E-mail address</td>
</tr>
<tr>
<td>user.firstname</td>
<td>First name</td>
</tr>
<tr>
<td>user.id</td>
<td>The primary key of the sender in the ejuser table</td>
</tr>
<tr>
<td>user.language</td>
<td>Sender's selected language</td>
</tr>
<tr>
<td>user.lastname</td>
<td>Last name</td>
</tr>
<tr>
<td>user.loginname</td>
<td>Login name</td>
</tr>
<tr>
<td>user.middlename</td>
<td>Middle name</td>
</tr>
<tr>
<td>user.name</td>
<td>The full name of the user agent</td>
</tr>
<tr>
<td>user.signature</td>
<td>Sender's signature from Settings</td>
</tr>
<tr>
<td>user.status</td>
<td>The sender's status (1 = normal, 2 = not available, 3 = deleted)</td>
</tr>
<tr>
<td>user.username</td>
<td>The sender's username, not necessarily same as loginname</td>
</tr>
</tbody>
</table>

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

\[\[FORMAT\_DATE:"date","YY4 MM2 DD2 HH24:MI2:SS2"\]\]

Format time:

\[\[SEC\_TO\_TIME:"seconds","h:m:s"\]\]
