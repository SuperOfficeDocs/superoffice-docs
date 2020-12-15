---
title: mailgun       
description:                    
author: {github-id}             # Your GitHub alias.
keywords:
---

# Mailgun

Emails coming in and going out from CRM Online can be managed in different ways, depending on your preferences and needs.

In this article, you will find information on the different alternatives for sending and receiving emails in CRM Online – SERVICE AND MAILINGS.

Each CRM Online Customer will be handed their own email account for SuperOffice Service, in the form of `customer@domain.suocrm.XX` (.eu or .com). More email accounts can be added in the SuperOffice Service admin pages. SuperOffice Service uses Mailgun for sending and receiving emails to those accounts, and SuperOffice Mailings uses Mailgun for sending emails.

Customers have several alternatives to handle emails in SuperOffice Online with these services. The default service for new customers is `suocrm.eu`, some of the existing customers use `suocrm.com`.

## Alternative 1: CRM Online email service only

Use the email address generated from SuperOffice Online and use this to directly communicate with your customers. Example: `customer@domain.suocrm.com`

### Out

Mail sent from SuperOffice Service / SuperOffice Mailings to your customer:

![1-out-hi][img1] <!-- https://community.superoffice.com/contentassets/183219b0a1434aaaad2f0dd12ec84345/1-out-hi.mp4 -->

### In

Mail sent from your customer to your SuperOffice Service:

![1-in-hi][img2] <!-- https://community.superoffice.com/contentassets/183219b0a1434aaaad2f0dd12ec84345/1-in-hi.mp4 -->

### PROS

* We handle all your shared email accounts (support@.., sales@.., …)
* We handle the volumes of sending your emails
* We handle the email reputation management
* Easy to get started, ready to use

### CONS

* Separate domain name for emails from these 'shared' accounts (x@domain.suocrm.com vs. x@domain.com)
* Other users of Mailgun (incl. CRM Online customer) can spoof this email address

## Alternative 2: CRM Online email service with own domain name and 'mail forward'

Use this alternative if you want to keep your old email addresses (your company domain address)
When creating a new mailbox in Service you automatically receive a "Forwarding address"

![Forward mail address in Service][img3]

> [!NOTE]
> **Important!** You will have to set up forwarding from address 1 >> address 2 on your local email account

When using Mailgun as the sending email service, and sending it as someone else (your own domain), it is recommended to set up both an SPF record and a DKIM record as a best practice, to avoid outgoing emails from Service to your customers ending up as spam. Read more on SPF and DKIM in section [Security and best practices][3].

### Out (no SPF/DKIM)

 Mail sent from SuperOffice Service / SuperOffice Mailings to your customer, using your own domain as sender address:

![2-out-nospf-hi][img4] <!-- https://community.superoffice.com/contentassets/183219b0a1434aaaad2f0dd12ec84345/2-out-nospf_hi.mp4 -->

### Out (with SPF)

Mail sent from SuperOffice Service / SuperOffice Mailings to your customer, using your own domain as the sender address, and have set up an SPF record:

![2-out-spf-hi][img5] <!-- https://community.superoffice.com/contentassets/183219b0a1434aaaad2f0dd12ec84345/2-out-spf_hi.mp4 -->

### Out (with DKIM)

Mail sent from SuperOffice Service / SuperOffice Mailings to your customer, using your own domain as the sender address, and have set up a DKIM record:

![2-out-dkim-hi][img6] <!-- https://community.superoffice.com/contentassets/183219b0a1434aaaad2f0dd12ec84345/2-out-dkim_hi.mp4 -->

### In

Mail sent from your customer to your SuperOffice Service:

![2-in-hi][img7] <!-- https://community.superoffice.com/contentassets/183219b0a1434aaaad2f0dd12ec84345/2-in-hi.mp4 -->

### Pros

* We handle all your shared email accounts (support@.., sales@.., …)
* We handle the volumes of sending your emails
* We handle the email reputation management (?)
* A prove that you are authorized sender for the domain
* No more “sent via Mailgun.org” message in your emails.
* Establishing a positive email reputation for your own domain.

### Cons

* Other users of Mailgun (incl. CRM Online customer) can spoof this email address, even with SPF
  * See details in section "Security and best practices".
* Require to administer and setup of mail forwarding on your local mail account for incoming emails
* Require DNS entry for SPF (cumbersome)
* Requires registration, (administration) and DNS entry for DKIM (cumbersome)
* Not setting up SPF and DKIM correctly will affect the service reputation
* Some do not want to have a mail forwarding service (?)

## Alternative 3: Customizing our Mail Service -  Own SMTP email service

Use this alternative if you want to use your own email service (your company-maintained email service) for sending emails from SuperOffice Service and Marketing.

### In

You continue to use our Mailgun service (Option 1 or 2 above) for incoming emails.

### Out - for both Service and Marketing

Use your own email server for all outgoing emails. Mail sent from SuperOffice Service / SuperOffice Mailings to your customers, using your own email server.

### Out - for Marketing only

Use your own email server for outgoing SuperOffice Mailings to your customers. You continue to use our Mailgun service (Alternative 1 or 2 above) for mail sent from SuperOffice Service.

### Out - for Service only

Use your own email server for outgoing SuperOffice Service to your customers. You continue to use our Mailgun service (Alternative 1 or 2 above) for mail sent from SuperOffice Mailings.

### How to configure your CRM Online site to use your own SMTP (outgoing) mail server?

Get in contact with our support and they will help you to get it configured.

**Access to your SMTP server from Online servers:**

It is a good idea to allow (whitelist) access to your own SMTP server from our Online environment based on IP address: 91.123.49.126, 91.123.49.180, 91.123.49.237

### How to set up SPF and DKIM?

* Read [How to set up SPF?][1]
* Read [How to order a DKIM key from SuperOffice, and how to set up DKIM?][2]

![guidelines][img8]

<!-- Referenced links -->
[1]: spf/set-up.md
[2]: dkim/order-key.md
[3]: security.md

<!-- Referenced images -->
[img1]: media/1-out-hi.gif
[img2]: media/1-in-hi.gif
[img3]: media/forwardservice.png
[img4]: media/2-out-nospf-hi.gif
[img5]: media/2-out-spf-hi.gif
[img6]: media/2-out-dkim-hi.gif
[img7]: media/2-in-hi.gif
[img8]: media/guidelines.png