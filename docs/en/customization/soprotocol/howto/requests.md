---
uid: sop-request-management
title: How to work with Requests
description: How to work with Requests with SoProtocol
keywords: soprotocol, requests
author: Tony Yates
date: 9.4.2023
content_type: howto
category: customization
topic: soprotocol
platform: web
deployment: online, onsite
redirect_from:
  - /en/ui/soprotocol/requests
  - /en/ui/soprotocol/howto/requests
language: en
---

# How to work with Requests using SoProtocol

The soprotocol should be on the format: ```soprotocol:ticket.new?<optional list of arguments>```

Refer to the [request arguments](#request-arguments) for full list of available properties/args.

## Open new ticket filled with the person selected

```
default.aspx?ticket.new?person_id=1
```

## Opening a Request from a trigger

```
EventData eventData = getEventData();

// open existing ticket
eventData.setNavigateTo("soprotocol:ticket.main?ticket_id=220");

// create new empty
eventData.setNavigateTo("soprotocol:ticket.new");

// create new with specific person
eventData.setNavigateTo("soprotocol:ticket.new?person_id=1756");

```

## Showing a ticket list for a company or person

```

// show all tickets for a company

default.aspx?contact.main.ticketarchive?contact_id=1520

// show all tickets for a person

default.aspx?person.main.ticketarchive?person_id=1756

```

## Request arguments

The following arguments are supported when creating a new request

| Property              | Description                                                                                     |
|-----------------------|-------------------------------------------------------------------------------------------------|
| `title`               | Request title                                                                                   |
| `person_id`           | ID of a main contact person                                                                     |
| `x_...`               | Value of a custom field. Simple values (number, text, etc.) and links to other entities supported. Any number of custom field values can be added.  |
