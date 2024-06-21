---
title: Prepare to install Service
uid: prepare_service
description: From SuperOffice 8 you also need to install Service. Here's what you need to do before you start the installation.
author: {github-id}
date: 09.12.2023
keywords: install
topic: howto
envir: onsite
# client:
---

# Prepare for Service

From SuperOffice 8 you also need to install Service, which is used by mailings inside both Sales & Marketing and Service.

A typical first-time installation of SuperOffice Customer Service on Windows server using an IIS web server and Microsoft SQL server. There is no client install necessary outside of a supported web client like Internet Explorer, as this is a web-based application.

[!include[Warning legacy](../../onsite/includes/warn-web-client-https.md)]

## Domain name

A domain name like `socrm.myorganization.com` must be created and registered in the DNS for SuperOffice Customer Service and CRM Web to be able to run.

The default installation of Service does not allow you to install it in a sub-application. With SuperOffice 8.1 both Sale and Service must be installed on the same root domain. It will be easier to create Application Routing Routing rules (ARR) if you do the manual installation and place Service in a sub-application.

## Email server

SuperOffice Customer Service requires access to an email server to work, using either POP3 or IMAP to retrieve emails, and SMTP to send emails. MAPI can also be used (Exchange) but requires additional licenses. Any email account on Exchange servers can be configured to use POP3/IMAP instead of the standard MAPI protocol.

The email server **must** allow "relaying", allowing SuperOffice Service to send emails "outside" the domain. Please be sure that any firewalls must be configured to allow this type of communication.

## Network location

Where on the network should SuperOffice Service be located?

For security reasons, the SuperOffice Service solution, like all other Internet-connected servers, should be placed in a DMZ (demilitarized zone) or Secure Server Net. A DMZ is a zone in the firewall that is protected against breaches from the outside and inside of the firewall. As long as the solution is on the same LAN as the email server, no configurations in the Firewall are necessary. If there are firewalls between SuperOffice Service and the email server, the firewall must be configured as described below.

**NetServer:**

SuperOffice Service supports only HTTP connection to NetServer. If you are running all servers only on HTTPS, you need to set up an extra NetServer available on HTTP to be used by Service.

## Module: SuperOffice Customer Service Customer Centre

To provide the SuperOffice Customer Center on the internet, the server must be reached by external users by HTTP or HTTPS. The firewall must be configured to handle these requests from the "outside" to the SuperOffice Customer Service server.

### Configuration of firewalls

Applicable if the email server is on a separate LAN as SuperOffice Customer Service.

* The ports for retrieving email by the protocols POP3/IMAP must be opened

* The ports for sending emails by the protocol SMTP must be opened

* If the ports cannot be opened for security reasons, the alternative is to install a new email server on the same LAN or server as SuperOffice Customer Service, and forward incoming emails from the original email server to this one. All email accounts that are supposed to be handled by SuperOffice Customer Service must be created, and in the setup of email accounts in SuperOffice Service must be set up to add the original.

## Setup ODBC

Even though we now have a common database, there are still Service entities that NetServer is not aware of. Thus, we still need an ODBC data source to connect to the database.

In MSSQL, create a user, which has **dbowner** access (and not sysadmin access) to the database. Make sure that the **CRM7** schema or the database schema your database is set up with, is set for this user on the database.

***

[Previous][11] | [Next (Web)][12] | [Next (Win)][14] |  [Back to guide][13]

<!-- Referenced links -->
[11]: ../../onsite/install/iis/index.md
[12]: ../../onsite/install/server/index.md
[13]: ../../onsite/install/guide.md
[14]: ../../onsite/install/win-client/prepare-client.md

<!-- Referenced images -->
