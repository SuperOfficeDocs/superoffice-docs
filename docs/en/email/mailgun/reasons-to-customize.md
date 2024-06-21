---
title: Reasons to customize Mailgun
uid: reasons_to_customize_mailgun
description: Reasons to customize Mailgun
author: {github-id}
keywords:
topic:
# Optional fields. Don't forget to remove # if you need a field.
# envir:
# client:
---

<!-- markdownlint-disable-file MD013 -->

# Reasons to customize Mailgun

Feedback from customers that leads to the need for customization is related mainly to these issues:

## Some customers question that data (emails) are stored temporarily in the US

Most of our customers are located in Europe, and we use mailservers located in Europe when sending from the domain smtp.eu.mailgun.org.
The default Mailgun service for customers is located in EU.

> [!NOTE]
> If you checked the mails that are sent and noticed the IP address in the header, ie.  141.193.32.154.
> Using `https://www.iplocation.net/ip-lookup` to lookup the IP it reports it to be located in US. They expected it to be located in Germany, what is the reason for this?
>
> Our EU infrastructure is located at the AWS datacenter in Frankfurt, Germany (including the dedicated IPs). However, AWS advertises all their IPs from the same two ASNs. BYOIP process does all the registration of those IPs in the US, but the IPs themselves are advertised on border devices in Frankfurt. As a result, many lookups will only show this US registration data, leading to the false assumption that the IPs themselves are located in the EU. So, while the DNS may show the registration within the US, the actual turrets are housed within the EU.

Customers who still use Mailgun service in the US:

For a few older customers who already are set up to use Mailgun service in the US, and has not been moved automatically due to their technical setup, can change to EU by contacting support.
Data is processed and stored outside EU and even if Mailgun Inc is Privacy Shield compliant and have signed a DPA with SuperOffice, and they object on a principal basis.

> [!TIP]
> In 2020 the European Court of Justice made a ruling that says the EU-US Privacy Shield (the agreement between the EU and the US that should ensure safe transfer of personal data from the EU to the US), is now illegal. This is now known as the Schrems II ruling.
>
> The SuperOffice CRM mailing feature is using an American cloud service provider; Mailgun Inc. for distributing mass-emails and for email-correspondence related to customer service tickets. This service has been protected by the Privacy Shield agreement which, no longer is valid (after 2020).
> Mailgun Inc. however also provides a Datacenter located in EU and we have move all our customers to this location. This was done as automatic as possible and without any cost on your part. By doing this, the SuperOffice CRM Online solution is fully GDPR compliant and satisfies all requirements for privacy data protection set out by this regulation.
If you need more information about the Schrems II ruling, we suggest you search your national Data Protection authority website for additional information.
>
> For those customers who have set up a DKIM towards Mailgun's datacenter located in US, to be GDPR compliant you need to set up a new DKIM towards the datacenter located in EU as soon as possible.

## Some customers are not happy with some security risk involved in using this kind of mailing service (SPF, DKIM)

Customers do not like this because:

SPF does not provide 100% security for the authenticity of outgoing emails. It does not prevent another crooked Mailgun customer to manipulate an email-senders address. The way mailing services (in general, not only Mailgun) are designed to perform and provide scalability and economies of scale, makes it currently not possible to close this vulnerability. It might not be a big issue, but some of our professional customers are aware of this and do not accept the risk. So we have to find another solution.

What can we do to mitigate this?

Let’s look at the possible ways we can change the setup to meet the arguments.

### Outgoing emails created by the mailings module in SuperOffice can be sent to another email-server than Mailgun

In our standard configuration, the mail is sent to Mailgun using an URL registered as a setting in CRM Online Operation Center. This URL can manually be changed (by Operations) and route all outgoing emails to another email-service (customer's standard or another mass mailing service).

This change will affect where the emails are processed and stored, and if the new email-service is controlled by the customer, it removes the SPF challenge.

### The best solution for using email together with SuperOffice Online is to use the email addresses we supply as part of the mailing-service

In our product, the customer can create addresses such as info@companyname.suocrm.eu and support@companyname.suocrm.eu. If the customer accepts that replies to customer inquiries or mailings originate from these addresses, then there is no need to configure SPF and little risk of being caught by spam filters. You can still publish your own info@companyname.no address, but set it up to be forwarded to the address we supply. The end customer will experience that the reply is originating from another address than the one they sent to, but this should be of little concern.

See the option [ALTERNATIVE 1: CRM Online email service only][1].

Using any mailing service always represents some kind of trade-off. Changing to a private email-server does not necessary makes things perfect.

## Be aware

Why do we use a mass mailing service like Mailgun? What features and security does it provide? What benefits will disappear if a customer starts using his normal mail-service for mass mailing? It is important to take these qualities into considerations when discussing the issues with a customer. This is not a black and white situation with a silver bullet solution that solves everything. Both solutions have pros and cons – both related to cost, capacity, features, and security.

Let’s remind ourselves and our customers why the Mailgun – service does a good job:

* Open to the internet.
    The customer has to make their mail-server available for SuperOffice Online. This will imply making the server open to the internet. This will inevitably represent a security risk.
* Reputation.
    Sending out large amounts of email from a company email server may lead to blacklisting and/or poor reputation. This again may increase the risk of other emails from the company caught as spam.
* Mass mailing capacity and cost.
    A company mail server may have limitations related to no. of emails outgoing (typically mass emails). In addition, it might affect performance, stability, administration, and both direct and operational cost.
* Support and maintenance.
    Mailgun is an integrated part of the SuperOffice CRM Online concept. In terms of operation, upgrades, support, and knowledge. It is 100% managed by SuperOffice. Customers taking responsibility for running their own mail-server will represent a custom integrated solution that will affect the mentioned areas.

<!-- Referenced links -->
[1]: overview.md
