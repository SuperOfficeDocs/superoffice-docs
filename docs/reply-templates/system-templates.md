---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: system_templates       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System reply templates # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# System templates

## System templates – Reply template for notification of open requests

The following parser variables are available:

* Company
* Customer
* Ticket
* Config

In addition you have a parser variable called "ticket.lastMessage" which will contain the last message on the request.

## System template – Reply template for notification of new message

The following parser variables are available:

* Message
* Company
* Customer
* Ticket
* Config

## System template – Reply template for notification of activated request

The following parser variables are available:

* Company
* Customer
* Ticket
* Config

## System template – Reply template for notification of escalated request

The following parser variables are available:

* Company
* Customer
* Ticket
* Config

## System template – Reply template for new request notification

The following parser variables are available:

* Message
* Company
* Customer
* Ticket
* Config

In addition you have a parser variable called "ticket.lastMessage" which will contain the last message on the request.

## System template – Reply template for request reassignment

The following parser variables are available:

* Company
* Customer
* Ticket
* Config

## System template – Reply template for notifying a new message in the hotlist

The following parser variables are available:

* Message
* Company
* Customer
* Ticket
* Config

## System template – Reply template for notifying an activated request in the hotlist

The following parser variables are available:

* Company
* Customer
* Ticket
* Config

## System template – Reply template for notifying an escalated request in the hotlist

The following parser variables are available:

* Company
* Customer
* Ticket
* Config

## System template – Reply template for notifying reassignment of a request in the hotlist

The following parser variables are available:

* Company
* Customer
* Ticket
* Config

## System template – Reply template for new customer contacts

The following parser variables are available:

* Customer
* Config

The parser variable "custPassword" will contain the unencrypted version of the password only if this customer was generated at the same time as the "new customer" email was sent and encryption is turned on.

"from" contains the sender email address

"to" contains the recipient address

## System template – Reply template for autoreply

The following parser variables are available:

* Company
* Customer
* Ticket
* Config

## System template – Reply template for sending password to customer contacts

The following parser variables are available:

* Customer
* Config

"to" contains the recipient email address

"from" contains the sender email address

## System template – Reply template for formatting FAQ questions

The following parser variables are available:

* Company
* Customer
* Ticket

"faq.question" contains the first message in the request which "publish" was called from

"faq.answer" contains the last message in the request which "publish" was called from
