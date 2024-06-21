---
title: Multiple DKIM records
uid: dkim-multiple-records
description: Multiple DKIM records in Mailgun
author: Martin Pavlas
date: 09.12.2023
keywords: Mailgun, DKIM, online, email, DMARC, SMTP, bounce, consent
topic: howto
envir: cloud
client: online
---

# Multiple DKIM records in SuperOffice Online

In SuperOffice Online using Mailgun each tenant can have only one DKIM key. This key is used to sign every email that is sent from SuperOffice Online. If a customer decides to send emails from several domains, having one DKIM only means all of them will be signed with the domain the DKIM was set up for.

[SPF][3] should be configured for all the domains a customer plans to use as a sender.

Unless they [use a strict DMARC policy](#dmarc), where both the SPF and DKIM need to correspond with the sender's domain, all will be fine. Having different DKIM domain and sender's domain doesn't stop SuperOffice nor Mailgun from sending out the emails.

We have also seen an approach where a customer decided to use a 3rd-party custom SMTP service, like Sendgrid, to overcome this limitation.

Switching away from Mailgun for outgoing emails complicates bounce and complaint handling because there is no webhook from 3rd-party SMTP to SuperOffice Online to set an email as bounced. In this case, the only option is to import bounce emails to SuperOffice via inbox.

## Mailgun vs. custom SMTP

Mailgun has better algorithms for detecting bounces and different types of bounces. First, Mailgun detects what could be a temporary issue and will try to resend the email. If that fails after several retries, Mailgun will turn it into a permanent failure and Service will get a notification about that the sending failed. Permanent failure is also caused by hard bounces.

Since Mailgun is more accurate on permanent failures, SuperOffice will mark an email address as invalid after only one bounce. If you are using a custom SMTP, we require several bounces before marking the email as invalid.

Mailgun also supports registering "complaints". Many email clients have buttons for complaining on a email. If the email being complained originated from a mailing, we will withdraw the marketing consent when such a complaint is received.

## DKIM

[DKIM][1] is mainly used to sign an outgoing mail from a mail server, creating a signature (hash code) from predefined fields in the mail. This signature can then be verified using a public key by the recipient's server to verify that these specific fields have not been changed since the origin send-out.

The DKIM signature always contains a pointer to a domain that holds the public key to be used for the verification.

The domain holding the DKIM public key does not have to be the same domain that is used as the sender-domain of the mail. From a DKIM perspective there is no dependency between these two parts. The DKIM signature ONLY states that emails signed with a specific signature should be verified against a specific domain. As the signature is created using a private key related to the public key, which is hosted in the DNS of the domain that you would like to sign the email with, you ensure the ownership of the domain in that way.

The only technical check made using DKIM to get an "OK", is that the signature hash codes in an email match the calculations made using the public key for the domain that the signature itself states to be the owning domain. Thus, the DKIM signature can be used to take ownership of an email and verify that it is sent from a specific domain. The DKIM-check does not include to verify that the sender email domain and the DKIM signing domain are the same.

A new tenant in SuperOffice Online always uses DKIM signing by default. It uses a SuperOffice related domain as signing domain. So setting up a custom DKIM for a customer just replaces this DKIM sign with the customers own domain. For a pure anti-spam reason, a custom DKIM isn't technically needed. The SuperOffice DKIM signature will technically be valid in the exact same way as using the customer's own domain. It is only if you also add DMARC that the DKIM signing domain used might affect the validity.

## DMARC

[DMARC][2] (Domain-based Message Authentication, Reporting & Conformance) can check for both valid SPF and valid DKIM. In its policies, it can also be set which domains are allowed to sign specific sender's email address domains. DMARC also uses a reporting system, so a customer is able to monitor failed mails connected to their domains.

If a customer has a strict policy that states that only DKIM signatures pointing to a domain that is also the sender's email address domain, sending emails from another sender's domains will report the email as invalid.

<!-- Referenced links -->
[1]: https://en.wikipedia.org/wiki/DomainKeys_Identified_Mail
[2]: https://dmarc.org/
[3]: https://en.wikipedia.org/wiki/Sender_Policy_Framework

<!-- Referenced images -->