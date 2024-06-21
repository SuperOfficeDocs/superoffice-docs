---
title: dkim
description:
author: {github-id}
keywords:
---

# DKIM

## What is the purpose of DKIM record?

A DKIM record is a type of [Domain Name Service][1] (DNS) record that the receiving email servers can if they like, look up your public key and verify that nothing has changed in the email, and confirm that a message came from you.

Allow this by adding an [MX record][2] in your DNS zone (public key signing process), and sign all your emails you send (private key signing process).

DKIM (Domain Keys Identified Mail) should be considered a method to verify that the messages' content is trustworthy, meaning that they were not changed from the moment the message left the initial mail server.

This involves using a private domain key to encrypt your domain's outgoing mail headers, and adding a public version of the key to the domain's DNS records.

To add a digital signature to outgoing mail, you generate a **domain key** that Mailgun uses to create signed mail headers that are unique to your domain. You add the public key to the Domain Name System (DNS) records for your domain. Recipients can then verify the source of a mail message by retrieving your public key and using it to confirm your signature.

Not all receiving mail servers support the DKIM standard.

## Why is it Important?

You can help prevent [spoofing][3] by adding a digital signature to outgoing message headers using the DKIM standard.

This additional layer of trustability is achieved by an implementation of the standard public/private key signing process. The owners of the domain add a DNS entry with the public DKIM key, which will be used by receivers to verify that the message DKIM signature is correct, while on the sender side the server will sign the entitled mail messages with the corresponding private key. Recipient servers can then retrieve the public key to decrypt incoming headers and verify that the message really comes from your domain and hasn't been changed along the way.

Not all receiving mail servers support the DKIM standard.

Read more about DKIM in  [Mail - Options and security][4].

<!-- Referenced links -->
[1]: https://en.wikipedia.org/wiki/Domain_Name_System
[2]: https://en.wikipedia.org/wiki/MX_record
[3]: https://support.google.com/a/answer/4536026
[4]: ../security.md
