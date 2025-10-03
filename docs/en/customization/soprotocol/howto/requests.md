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

## Open new ticket filled with the person selected

```http
default.aspx?ticket.new?person_id=1
```

## Opening a Request from a trigger

```http
EventData eventData = getEventData();

// open existing ticket
eventData.setNavigateTo("soprotocol:ticket.main?ticket_id=220");

// create new empty
eventData.setNavigateTo("soprotocol:ticket.new");

// create new with specific person
eventData.setNavigateTo("soprotocol:ticket.new?person_id=1756");

```

## Showing a ticket list for a company or person

```http

// show all tickets for a company

default.aspx?contact.main.ticketarchive?contact_id=1520

// show all tickets for a person

default.aspx?person.main.ticketarchive?person_id=1756

```
