---
title: blogic_form_elements_per_entity
description: Form elements - entity-specific
author:
so.date:
keywords:
so.topic:
---

# Form elements - entity-specific

Some form elements are specific to SuperOffice entities.

## Select entity fields

There's a wide range of elements that add a drop-down to select an entity of a specific type. For example, [select company][1] and [select sale][2].

![Screen capture of select entity drop-downs][img1]

## Edit entity menu element

Adds an [entity menu][3].

### Default menu for customer

**Simple values:**

```crmscript
entity = customer
entityMenu = customer
label = Entitymenu
```

![Screen capture of entity menu element][img2]

### Custom menu

**Creation script:**

```crmscript
HtmlElement em;
Map m;

m.insert("label", "VG");
m.insert("iconUrl", "");
m.insert("url", "http://www.vg.no");
m.insert("target", "");
em.setFieldValue("addMenu", m);
m.clear();

m.insert("label", "DN");
m.insert("iconUrl", "");
m.insert("url", "http://www.dn.no");
m.insert("target", "");
em.setFieldValue("addAnchor", m);
m.clear();

m.insert("label", "SuperOffice");
m.insert("iconUrl", "");
m.insert("url", "https://www.superoffice.com");
m.insert("target", "");
em.setFieldValue("addMenu", m);
m.clear();
```

![Screen capture of custom entity menu][img3]

## Persons and organizations

**Selection drop-downs:**

* [Select agent][4]
* [Select company][1]
* [Select contact business][5]
* [Select contact category][6]
* [Select contact][7] and [Select contacts][8]
* [Select user][9]

### Category membership element (for user)

Used to visualize (and change) [which category a user belongs to][10].

```crmscript
categoryId = 2
label = Category
noWeights = false
```

![Screen capture of category membership element][img4]

> [!TIP]
> Read more about [working with users][11].

## Follow-ups, dates, and time

**Selection drop-downs:**

* [Select appointment][12]
* [Select date][13]
* [Select datetime][14]
* [Select time][15]
* [Select timespan][16]

## Requests

**Selection drop-downs:**

* [Select category][17] (for ticket)
* [Select priority][18] (for ticket)
* [Select message][19] (from ticket)
* [Select request status][20]
* [Select FAQ][21]
* [Select reply template][22]
* [Select insert text][23]

### Message grid

A [message grid][24] displays the messages of a ticket in a grid. Each message has a check-box.

```crmscript
label = Messages
ticketId = 3
```

![Screen capture of message grid element][img5]

### Contact and recipient

Represent [customers connected to a request][25].

**Creation script to set the ticket ID dynamically:**

```crmscript
Map config = getScreenElementConfig(screenElementIndex);
config.insert("ticketId", getVariable("entryId"));

addHtmlElement(getScreenElementId(screenElementIndex), getScreenElementName(screenElementIndex),
  getScreenElementType(screenElementIndex), config);
```

**Creation script to override the default columns:**

This removes the pre-defined columns (noDefaultFields) and adds columns for first name, last name, email, and phone.

```crmscript
HtmlElement recipients = addHtmlElement(getScreenElementId(screenElementIndex),
  getScreenElementName(screenElementIndex),
  getScreenElementType(screenElementIndex),
  "ticketId = " + getCgiVariable("ticketId") + "\nlabel = Recipients\nnoDefaultFields = true\n");

Map colMap;

colMap.insert("displayField", "person.firstname");
colMap.insert("searchField", "person.firstname");
colMap.insert("operator", "OperatorBeginsWith");
colMap.insert("label", "Firstname");
recipients.setFieldValue("addColumn", colMap);

colMap.clear();
colMap.insert("displayField", "person.lastname");
colMap.insert("searchField", "person.lastname");
colMap.insert("operator", "OperatorBeginsWith");
colMap.insert("label", "Lastname");
recipients.setFieldValue("addColumn", colMap);
colMap.clear();

colMap.insert("displayField", "Email.email_address");
colMap.insert("searchField", "Email.email_address");
colMap.insert("operator", "OperatorBeginsWith");
colMap.insert("label", "Email");
recipients.setFieldValue("addColumn", colMap);
colMap.clear();

colMap.insert("displayField", "phone.phone");
colMap.insert("searchField", "phone.phone");
colMap.insert("operator", "OperatorBeginsWith");
colMap.insert("label", "Phone");
recipients.setFieldValue("addColumn", colMap)
```

![Screen capture of contact and recipients element][img8]

### Request status element

[Request status][27] element

### Recipients element

[Recipients][28] element

```crmscript
copyToAll = false
copyToCreatedBy = true
copyToCustomer = false
copyToEab = false
copyToOther = false
copyToOwner = true
copyToSelf = true
label = Recipients 3
ticketId = 1
```

![Screen capture of recipients element][img6]

### Address book element

[Address book][29] organizes addresses in a tree view

### Attachment element

Adds an [attachment field][30] to the screen.

```crmscript
label = Attachments
multiple = true
noHardDelete = true
```

![Screen capture of attachment element][img7]

## Sales and projects

**Selection drop-downs:**

* [Select sale][2]
* [Select project][31]

### Invoice rows element

[Invoice rows][32]
## Security and database

**Selection drop-downs:**

* [Select slevel][33]
* [Select CRM selection][34]
* [Select extra field][35]
* [Select table][36]
* [Select relation][37]
* [Select relations][38]

<!-- Referenced links -->
[1]: ../blogic-screen-elements/select-company.md
[2]: ../blogic-screen-elements/select-sale.md
[3]: ../blogic-screen-elements/edit-entity-menu.md
[4]: ../blogic-screen-elements/select-agent.md
[5]: ../blogic-screen-elements/select-contact-business.md
[6]: ../blogic-screen-elements/select-contact-category.md
[7]: ../blogic-screen-elements/select-customer.md
[8]: ../blogic-screen-elements/select-customers.md
[9]: ../blogic-screen-elements/select-user.md
[10]: ../blogic-screen-elements/category-membership.md
[11]: ../CRMScript/working-with/persons-and-organizations/user.md
[12]: ../blogic-screen-elements/select-appointment.md
[13]: ../blogic-screen-elements/select-date.md
[14]: ../blogic-screen-elements/select-datetime.md
[15]: ../blogic-screen-elements/select-time.md
[16]: ../blogic-screen-elements/select-timespan.md
[17]: ../blogic-screen-elements/select-category.md
[18]: ../blogic-screen-elements/select-priority.md
[19]: ../blogic-screen-elements/select-message.md
[20]: ../blogic-screen-elements/select-request-status.md
[21]: ../blogic-screen-elements/select-faq.md
[22]: ../blogic-screen-elements/select-reply-template.md
[23]: ../blogic-screen-elements/select-insert-text.md
[24]: ../blogic-screen-elements/message-grid.md
[25]: ../blogic-screen-elements/contact-and-recipient.md
[27]: ../blogic-screen-elements/select-ticket-status.md
[28]: ../blogic-screen-elements/recipients.md
[29]: ../blogic-screen-elements/address-book.md
[30]: ../blogic-screen-elements/attachment.md
[31]: ../blogic-screen-elements/select-project.md
[32]: ../blogic-screen-elements/invoice.md
[33]: ../blogic-screen-elements/select-slevel.md
[34]: ../blogic-screen-elements/select-crm-selection.md
[35]: ../blogic-screen-elements/select-extra-field.md
[36]: ../blogic-screen-elements/select-table.md
[37]: ../blogic-screen-elements/select-relation.md
[38]: ../blogic-screen-elements/select-multiple-relations.md

<!-- Referenced images -->
[img1]: media/select-entity-dropdown.png
[img2]: media/entity-menu-element.png
[img3]: media/entity-menu-custom.png
[img4]: media/category-membership.png
[img5]: media/message-grid.png
[img6]: media/recipients-element.png
[img7]: media/attachment-element.png
[img8]: media/contact-and-recipients-element.png
