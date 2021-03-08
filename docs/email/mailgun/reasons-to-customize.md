---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: reasons_to_customize_mailgun       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Reasons to customize Mailgun # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Reasons to customize Mailgun

Feedback from customers that leads to the need for customization is related mainly to these issues:

## Some customers question the fact that data (emails) are stored temporarily in the US

Customers do not like this because:

Data is processed and stored outside EU and even if Mailgun Inc is Privacy Shield compliant and have signed a DPA with SuperOffice, and they object on a principal basis.

 What can we do to mitigate this? The default Mailgun service for new customers is now located in EU. For older customers who already are set up to use Mailgun service in the US, can later this year change to EU.

## Some customers are not happy with some security risk involved in using this kind of mailing service (SPF, DKIM)

Customers do not like this because:

SPF does not provide 100% security for the authenticity of outgoing emails. It does not prevent another crooked Mailgun customer to manipulate an email-senders address. The way mailing services (in general, not only Mailgun) is designed to perform and provide scalability and economies of scale, makes it currently not possible to close this vulnerability. It might not be a big issue, but some of our professional customers are aware of this and do not accept the risk. So we have to find another solution.

## What can we do to mitigate this?

Let’s look at the possible ways we can change the setup to meet the arguments.

### Outgoing emails created by the mailings module in SuperOffice can be sent to another email-server than Mailgun

In our standard configuration, the mail is sent to Mailgun using an URL registered as a setting in CRM Online Operation Center. This URL can manually be changed (by Operations) and route all outgoing email to another email-service (i.e. customers standard or another mass mailing service).

This change will affect where the emails are processed and stored, and if the new email-service in controlled by the customer, it removes the SPF challenge.

### The best solution for using email together with SuperOffice Online is to use the email addresses we supply as part of the mailing-service

In our product, the customer can create addresses such as "info@companyname.suocrm.com" and "support@companyname.suocrm.com". If the customer accepts that replies to customer inquiries or mailings originate from these addresses, then there is no need to configure SPF and little risk of being caught by spam filters. You can still publish your own info@companyname.no address, but set it up to be forwarded to the address we supply. The end customer will experience that the reply is originating from another address than the one they sent to, but this should be of little concern.

See the option "ALTERNATIVE 1: CRM Online email service only"

Using any mailing service always represents some kind of trade-off. Changing to a private email-server does not necessary makes things perfect

## Be aware

Why do we use a mass mailing service like Mailgun? What features and security does it provide? What benefits will disappear if a customer starts using his normal mail-service for mass mailing? It is important to take these qualities into considerations when discussing the issues with a customer. This is not a black and white situation with a silver bullet solution that solves everything. Both solutions have pros and cons – both related to cost, capacity, features, and security.

Let’s remind ourselves and our customers why the Mailgun – service does a good job:

* Open to the internet
    The customer has to make their mail-server available for SuperOffice Online. This will imply making the server open to the internet. This will inevitably represent a security risk.
* Reputation
    Sending out large amounts of email from a company email server may lead to blacklisting and/or poor reputation. This again may increase the risk of other emails from the company caught as spam.
* Mass mailing capacity and cost
    A company mail server may have limitations related to no. of emails outgoing (typically mass emails). In addition, it might affect performance, stability, administration, and both direct and operational cost.
* Support and maintenance
    Mailgun is an integrated part of the SuperOffice CRM Online concept. In terms of operation, upgrades, support, and knowledge. It is 100% managed by SuperOffice. Customers taking responsibility for running their own mail-server will represent a custom integrated solution that will have an effect on the mentioned areas.

### Pros

* Do not require a separate DNS entry for SPF
* Do not require a separate DNS entry for DKIM
  * registration, (administration)
* Full control of email domain and emails going out

### Cons

* You handle all your shared email accounts (locally), setup and configuration settings will (for now) be handled by Online Operations.
* You handle the volumes of sending your emails
* You handle the blacklisting of your IP address (email reputation management)
* Do require you to administer and setup of mail forwarding to Mailgun on your local mail account for incoming emails (for example, bounce) and/or maintenance of "reply to" / "from" in your outgoing emails need to match your setup of how you plan to get your customers response emails back into SuperOffice Service via Mailgun.
