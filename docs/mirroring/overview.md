---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: mirroring_intro # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Database Mirroring Service for SuperOffice CRM Online # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud             # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Database Mirroring Service for SuperOffice CRM Online

*This document will provide technical documentation about a specific area (Database Mirroring Service) of the SuperOffice CRM concept. The document is public and serves the purpose of documenting technology, architecture, security, and privacy matters.*

*SuperOffice AS*

## Description of the service

SuperOffice CRM Online offers an internet-based service that will allow a copy of the Customer’s Database to be created outside the SuperOffice CRM Online environment – i.e. to an external location not controlled by SuperOffice AS. The Database Mirroring service is available to the Customer either as a separate, payable service or as a service included in a certified Application in the SuperOffice App Store.

## Technical description of the service

Database Mirroring is an optional property of a registered App in the SuperOffice App Store. Each such app is entered in the OC systems (SuperOffice Online Operations Center – “OC”) with a unique **application identifier** (issued by SuperOffice) and a **public key** obtained from the App author (“Partner”). The corresponding **private key** of the pair is kept strictly secret by the Partner. The **URL** at which the Partner has the service that receives data is also entered. None of this information is present in the Customer database, nor in any user interface accessible to Customers.

At the start of each mirroring cycle, the initial call to the Partner URL is a **mutual authentication**. SuperOffice calls the registered URL, sending a **signed token**; this is a standard security mechanism where the transmitting party bundles several pieces of information and adds a signature. The token contains:

* The Customer context id, which uniquely identifies the Customer whose data will be mirrored
* The application id, which uniquely identifies the intended recipient
* A random number (“nonce”) unique to each token
* A timestamp

This token is signed using a private key that belongs to SuperOffice and is only installed on the specific computers that are intended to be originators of Database Mirroring calls. The private key is different for the Development, Stage, and Production environment.

The corresponding **public key** together with its signing chain is published to partners and installed on the computer intended to handle incoming mirroring calls. Using code published by SuperOffice, the partner

* Verifies that the incoming token has the correct signature (by SuperOffice)
* Verifies that it is freshly generated (clocks must not be more than 5 minutes apart)
* Verifies that the application id in the token is the same as the system receiving it

Having done so, the Customer context id can be extracted. Note that SuperOffice does not transmit any user id or access token that enables the Partner to call back to SuperOffice; mirroring is **strictly initiated by SuperOffice** and is always a request-response pattern where SuperOffice is the requestor.

To complete the authentication handshake, the partner code creates a response that contains

* The nonce from the incoming request, to prove that this is a response to that request
* A timestamp

This response is signed using the partner’s secret key and transmitted back to SuperOffice. At SuperOffice, the signature is verified using the registered public key (unique to the Partner and Environment), as well as verifying the nonce and the timestamp.

At this point the **mutual authentication** is considered complete, where the SuperOffice server and the Partner site are confident that the opposite party is the correct one. From here the actual mirroring process proceeds; SuperOffice initiates all calls (first to update the database schema, then to transmit data changed since the last update). Each call identifies itself using the same signed token mechanism so that the Partner can know which Customer the data belongs to.

All communication uses SSL / HTTPS. Non-HTTPS URLs are not acceptable, and the certificate behind the HTTPS URL needs to be valid and from a known issuer (self-issued certificates are never valid, including in development/test environments).

## Partner database security

Once the mirroring process is established, data flows to the Partner in a secure manner. Further security against unauthorized access to the data then falls on the Partner. SuperOffice requires Partners to undergo a security audit before they are authorized to implement Database Mirroring. The audit is performed by an accredited specialist company.

## Data filtering and blacklisting

A SuperOffice database contains, in addition to Customer data, various system tables that are used (among other things) to regulate access to the installation. The database mirroring mechanism contains an internal “blacklist” of tables that are never mirrored; these are either irrelevant (transient data related to a particular UI) or sensitive.

In particular, the blacklist contains tables related to the configuration of other synchronization products (ERP Sync), session keys, credentials (password hashes, credentials for email), preferences, and other information considered private and sensitive.

## Security & Privacy Aspects

The  Customers’ database reside inside of the Online environment, where security is provided and guaranteed by SuperOffice and the vendors/partners that SuperOffice relies on to supply the infrastructure and services upon which CRM Online actually runs. The legal relationship between the Customer, SuperOffice and such third parties is set out and regulated by the contract between SuperOffice and the Customer.

The purpose of Database Mirroring is to **transfer Customer data to an external site**, either a Partner or the Customer. This raises issues about the legality and security of such a transfer, as well as the data security at its destination.

The Customer is required to digitally sign (consent to) an Addendum to the standard contract, authorizing SuperOffice to transfer Customer’s data to the named third party. Responsibility for data security at the destination falls on the third party, while the transfer itself is secured by SuperOffice.

A Data Processing Agreement (Sub-Processor) is signed between SuperOffice and the named third party using the Mirroring Service securing Data Privacy aspects.

SuperOffice certifies all software applications who uses the Database Mirroring Service in their Apps; the process includes a security audit by a qualified company chosen by SuperOffice. Only selected employees at SuperOffice Online Operations are authorized to register keys and other significant values, that set up and enable the transfer process.
