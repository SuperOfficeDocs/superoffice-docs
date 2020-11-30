---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: perpare_for_service_onsite # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Prepare for Service # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Prepare for Service

A typical first-time installation of SuperOffice Customer Service on Windows 2012 server using IIS web server and Microsoft SQL server 2014. There is no client install necessary outside of a supported web client like Internet Explorer, as this is a web-based application.

## Before you begin

We assume you have already run the general SuperOffice CRM server setup to create a database primed with necessary startup data in the language of your choice.

You need to have a working SuperOffice web services installation before you proceed with the installation of Service as *ejTermsetup.exe* requires it. Both Service and SuperOffice web services must be of the same version and run on the same domain from our [release 8.1][1].

## Domain name

A domain name like **socrm.myorganization.com** must be created and registered in the DNS for SuperOffice Customer Service and CRM Web to be able to run.

## Email server

SuperOffice Customer Service requires access to an email server to work, using either POP3 or IMAP to retrieve emails, and SMTP to send emails. MAPI can also be used (Exchange), but requires additional licenses. Any email account on Exchange servers can be configured to use POP3/IMAP instead of the standard MAPI protocol.

It is important that the email server allows “relaying”, allowing SuperOffice Service to send emails “outside” the domain. Please be sure that any firewalls must be configured to allow this type of communication.

## Network location

Where on the network should SuperOffice Service be located?

For security reasons, the SuperOffice Service solution, like all other Internet-connected servers, should be placed in a DMZ (de-militarized zone) or Secure Server Net. A DMZ is a zone in the firewall which is protected against breaches from the outside and inside of the firewall. As long as the solution is on the same LAN as the email server, no configurations in the Firewall is necessary. If there are firewalls between SuperOffice Service and the email server, the firewall must be configured as described below.

**NetServer:**

SuperOffice Service supports only HTTP connection to NetServer. If you are running all servers only on HTTPS, you need to set up an extra NetServer available on HTTP to be used by Service.

## Module: SuperOffice Customer Service Customer Centre

To provide the SuperOffice Customer Center on the internet, the server must be reached by external users by HTTP or HTTPS. The firewall must be configured to handle these requests from the “outside” to the SuperOffice Customer Service server.

### Configuration of firewalls

Applicable if the email server is on a separate LAN as SuperOffice Customer Service.

* The ports for retrieving email by the protocols POP3/IMAP must be opened

* The ports for sending emails by the protocol SMTP must be opened

* If the ports cannot be opened for security reasons, the alternative is to install a new email server on the same LAN or server as SuperOffice Customer Service, and forward incoming emails from the original email server to this one. All email accounts that are supposed to be handled by SuperOffice Customer Service must be created, and in the setup of email accounts in SuperOffice Service must be set up to add the original.

## Setup ODBC

Even though we now have a common database, there are still Service entities that NetServer is not aware of. Thus, we still need an ODBC data source to connect to the database.

In MSSQL, create a user, which has **dbowner** access (and not sysadmin access) to the database. Make sure that the **CRM7** schema or the database schema your database is set up with, is set for this user on the database.

<!-- Referenced links -->
[1]: HTTPs://community.superoffice.com/en/product-releases/