---
title: Security and best practices
uid: mailgun_security
description: Security and best practices for Mailgun
author: {github-id}
keywords: email
topic: reference
# Optional fields. Don't forget to remove # if you need a field.
# envir:
# client:
---

# Security and best practices

Spam mail messages have been a plague since the Internet became popular and they kept growing more and more as the number of devices and people connected grew. Despite the numerous attempts of creation of anti-spam tools, there is still a high number of unwanted messages sent every day.

Luckily, lately, it seems that something is changing with the adoption of three (relatively) new tools, which are starting to be widely used: SPF, DKIM, and DMARC.
Prevent address forgery (spoofing) spammers can forge, or "spoof," your domain's 'From address' to make their spam look like it came from someone in your domain. To help prevent this, we recommend authenticating mail sent from your domain in two ways: by creating SPF records, and by adding a digital signature to your messages that conform to the Domain Keys Identified Mail (DKIM) standard.

## SPF

SPF (Sender Policy Framework) is a DNS text entry, which shows a list of servers that should be considered, allowed to send mail for a specific domain. Incidentally, the fact that SPF is a DNS entry can also be considered as a way to enforce the fact that the list is authoritative for the domain since the owners/administrators are the only people allowed to add/change that main domain zone.

Today, nearly all abusive email messages carry fake sender addresses. Spammers send email from their mail servers but with your ‘domain’ as the sending email. The victims whose addresses are being abused often suffer from the consequences, because their reputation gets diminished and they have to disclaim liability for the abuse or waste their time sorting out misdirected bounce messages.

The purpose of an SPF record is to prevent spammers from sending messages with forged From addresses at your domain. Recipients can refer to the SPF record to determine whether a message purporting to be from your domain comes from an authorized mail server. If your domain does not have an SPF record, some recipient domains may reject messages from your users because they cannot validate that the messages come from an authorized mail server.

You should only have one SPF record for your domain. If you use more than one outgoing email provider, you need to combine their include directives.

The important thing to remember is that SPF records are just a whitelist and/or blacklist of IPs that can or can't send on behalf of your domain.

Read more about SPF in [How to set up SPF?][1]

## DKIM

DKIM (Domain Keys Identified Mail) should be considered a method to verify that the messages' content is trustworthy, meaning that they were not changed from the moment the message left the initial mail server. This additional layer of trustability is achieved by an implementation of the standard public/private key signing process. The owners of the domain adds a DNS entry with the public DKIM key, which will be used by receivers to verify that the message DKIM signature is correct, while on the sender side the server will sign the entitled mail messages with the corresponding private key. Receiving email servers look up your public key and verify that nothing has changed in the email.

Not all receiving mail servers support the DKIM standard.

Read more about DKIM in [How to order a DKIM key from SuperOffice, and how to set up DKIM?][2]

## DMARC

Domain-based Message Authentication, Reporting & Conformance is an email authentication protocol. It builds on the widely deployed SPF and DKIM protocols, adding a reporting function that allows senders and receivers to improve and monitor the protection of the domain from fraudulent email. DMARC acts as a policy statement that declares what to do with emails that fail on SPF, DKIM, or both.

There are a few different modes that you can use with DMARC, but the most basic one is to receive reports from receiving email servers on 'pass' or 'fail' status, and receivers are given a simple way to check the legitimacy of the email.

Monitoring on DMARC:

Mailgun is not able to act upon the DMARC reports out of the box but the reports can be used with a 3.party DMARC aggregation service.

Postmark runs a [free DMARC aggregation service][3], which will aggregate all of the reports from DMARC-supporting services and send you a report every Monday morning with details. The first step in implementing DMARC is to sign up with Postmark's service, set up the DMARC record that they give you in your DNS, and wait a week. You'll probably have to go through this cycle every week for at least a few weeks, to catch all of the services that send email as you.

Upon reception, the receiving mail server checks if there is any existing DMARC policy published in the domain used by the SPF and/or DKIM checks. If one or both the SPF and DKIM checks succeed while still being aligned with the policy set by DMARC, then the check is considered successful, otherwise, it's set as failed. If the check fails, based on the action published by the DMARC policy, different actions are taken:

![x -screenshot][img1]

**Read more about DMARC:**

* [Fix Your Email Deliverability with DMARC][5]
* [DMARC for Email Service Providers][6]

## Email reputation

Sender Reputation is used by email providers and filters to determine whether to accept or reject an email by knowing whether a sender is a good sender or a spammer. Sender reputation is based on factors like email volume, complaint rates, user unknown rates, blacklistings, filtering rates, spam trap hits, and bounce rates.

## Blacklist

Commonly called Realtime blacklist, DNSBL, or RBL. An email blacklist is a real-time database that uses set criteria to determine if an IP is sending emails that could be considered spam. There are over 300 publicly available blacklists. Public blacklists are created by large, trustworthy companies, as well as small, independent networks. Since anyone can create a blacklist, they don’t all have the same impact on deliverability. Mailbox providers and filtering companies do not leverage inbox placement on every blacklist. They typically combine data from various public blacklists, as well as data from their own networks, to determine your credibility as a sender. This allows other mail servers to check if an email is from a server's IP address that might have possibly been flagged for sending spam in the past.

It’s important to note that blacklist providers are not the ones blocking your mail—it’s the mailbox provider leveraging your blacklist status that blocks your mail. If a blacklist resulted in a block, focus on the potential causes for the listing. Blacklisting is most often caused by poor list quality and end-user complaints, but they all have their own criteria for accepting inbound mail and all can have a negative effect on your delivery rate.

There are two types of blacklists: IP address-based and domain-based.

Mailgun will try their best to react to blacklisting by requesting removal immediately from any publicly available blacklist. Any non-publicly available blacklist is not easy to monitor, and must, therefore, be handled case by case.

In order not to face the blacklisting problem we recommend to **follow suggestions** in these articles:

* [5 Killer Email Marketing Mistakes to Avoid][7]

* [15 Tips to Avoid Email Blacklisting][8]

Read more about blacklisting at [sendgrid.com][9].

## Blocklist

A 'Blocklist' is a list the mail server owners have. A blocklist is a custom database of email addresses and domains from which server owners never want to receive emails from. To create this list, they may use their own blacklist (non-public), a public blacklist, and/or several blacklists as a source. It’s important to note that blacklist providers are not the ones blocking your mail—it’s the mailbox provider leveraging your blacklist status that blocks your mail. All blocking of mail is done on some server somewhere, and the blacklist doesn't control those servers. It is mail server owners blocking your email after all, not the blacklist. (even though many uses the term 'blacklist' and 'blocklist' interchangeably)

Large freemail providers such as Gmail, Hotmail, and Yahoo maintain their own blocklists, and the process for getting delisted is not always clearly stated.

## SPAM

The distinction between spam and nonspam is to a large extent a matter of personal preference. For example, a bulk email message containing product offers may be actively wanted by some recipients, while others regard it as spam.

Typically this depends on whether the recipient has actively requested to be added to a distribution list or not, but the email server has no access to information about opt-ins and so cannot use it to determine if an email is spam.

Because there is no hard definition of "spam" it is also relatively easy to end up on a blocklist by mistake. A classic example is an email user who subscribes to a mailing list, forgets about it, and then hits the "spam" button instead of unsubscribing from the list. It is also easy to become listed if dumb autoresponders send out-of-office replies in response to spam messages with forged "from" addresses.

In many cases, this can be caused by the fact that the recipient’s mail server sees your email address as spam, because the Sender domain is different from the actual domain being received from.

Creating a mailing in SuperOffice Online, you define a sender address ('from:'). You can use any email address for this, as there are no restrictions. Let's say you are using a sender email address, which has the domain (email ending)"@yourdomain.com". When the mailing reaches the recipient mail server it sees that the mailing is sent from `customer.suocrm.com` domain. This can cause your newsletter to be identified as Spam.

Read more about spam at [Wikipedia][10].

### Spamtrap

 Spam traps are email addresses that may or may not exist and are used to judge your sender's reputation. The term "trap" refers to how these types of addresses are scattered throughout the internet to catch people either not using proper list building practices, harvesting emails, purchasing lists from a third party, or marketers who have poor list hygiene (whether they know it or not). "Honeypot" or "Planted" Traps email addresses have been intentionally created to trap spammers searching the millions of websites on the Internet for any address they can find. These traps are never published and do not belong to a real person thus could never "opt-in" to any list since it is impossible for the address to initiate, respond or give consent to having received an email of any kind. They are used by anti-spam groups to catch spammers, monitor and collect spam. If you send an email to one of these traps, you will get exposed for using illegal marketing practices and you will get blacklisted, which will seriously harm both your delivery and your reputation.

Read more about spam traps at [Wikipedia][11].

### Spam complaint

Spam complaints are reports made by email recipients against emails they consider to be unsolicited. Most ISPs offer to report facilities that allow their customers to mark emails they do not remember opting in for, or did not opt-in for, as spam. When an email recipient clicks this button, ISP lets the senders' email server (in our scenario, Mailgun) know that one of our customers is potentially sending spam. This kind of tool enables email recipients to report anything they consider to be unsolicited "junk mail". Through a direct feedback loop with major ISPs, as well as email providers like Gmail and Outlook.com (Hotmail), Mailgun can automatically detect if a significant number of a customer's recipients flag the customer's email campaign as spam. Some spam complaints may be false. Perhaps the recipient was lazy or just forgot about giving their permission in the first place.

If one of the customer's email campaigns gets more than a typical number of complaints, which is calculated as a percentage of the sending size, could result in their Mailgun account being suspended. You can minimize the chances of your campaigns being reported as spam by following best practice email marketing guidelines.

Most of the spam complaints coming from Gmail and Outlook.com (Hotmail) because they are both the world's biggest email providers, and also the main providers using feedback loops.

If an email service or ISP does not have a feedback loop set up, then any complaints by your subscribers are not passed back to Mailgun. ISPs still consider every spam complaint as an official complaint from their customers. This means that if enough recipients mark a campaign as spam, the ISP will punish the offending sender by adding them to their blacklist or negatively adjusting their sender reputation score.

#### Mail classifications

Mail classifications depend heavily on reports from users. Most users of the mail hosters, can mark and unmark messages as spam, and can move non-spam messages between inbox tabs. In both cases, mail vendors learn from user corrections and overtime automatically adjusts the classification to match users’ preferences.

#### Bounce rate

Your bounce rate is the percentage of email addresses that your campaign could not be delivered to. Email providers and anti-spam networks monitor bounce rates for every campaign you send and use that information to decide if they'll accept mail from you in the future. Besides affecting an individual sender's reputation, high bounce rates can land our sending IPs on blacklists, and potentially affect others who use the Mailgun service. While Mailgun does a lot of work behind the scenes to protect the customer from potential problems, there are certain best practices you can follow to keep things running as smoothly as possible. As a guideline, a well-maintained, permission-based list should typically see bounce rates of 2% or less for each email campaign (mailing) sent.

## Spoofing

Spammers can forge, or "spoof," your domain's From address to make their spam look like it came from someone in your domain.

There isn't a way to stop email addresses from being spoofed. Anyone can spoof an email address. The trick is to identify spoofed emails when they are received, adjusting your spam filters and security on the incoming mail server. It also depends on how email is being spoofed.

To help prevent this, we recommend authenticating mail sent from your domain in two ways: by adding a digital signature to your messages that conform to the DomainKeys Identified Mail (DKIM) standard, and by creating SPF records.

Read more about spoofing on [Wikipedia][12].

## Phishing attacks

Phishing attacks depend on sending an email that pretends to be from a trusted brand or individual. For the first decade or more of their existence, these attacks took a mass-mailing approach, hitting large numbers of email accounts in hopes of extracting a relatively small amount of value from each victim duped into giving up information.

Spear Phishing: Spear phishing is a specific type of phishing attack targeted at a single individual inside an organization where the payoff for a successful breach is particularly high.

Read more about Phishing attacks on [Valimail.com][13].

## DDOS attacks

DDOS (denial-of-service) attacks are in the category of an email bomb, which is a form of net abuse consisting of sending huge volumes of email to an address in an attempt to overflow the mailbox or overwhelm the server where the email address is hosted in a denial-of-service attack.

Read more about DDOS in [Wikipedia][14].

## Limits and best practices

### Generally

Unfortunately, even by having a perfectly functional mail system with all the above tools enforced you will not be 100% safe from the bad guys out there. Not all servers are using all three tools shown above. It is enough to look at the table shown in Wikipedia to see how that is possible: `http://en.wikipedia.org/wiki/Comparison_of_mail_servers`.

Furthermore, there are some limits that you should always consider when dealing with SPF and DKIM:

As already said above DKIM alone does not grant in any way that the sender server is allowed to send outgoing mail for the specific domain.
SPF is powerless with messages forged in a shared hosting scenario, as all the mail will appear as the same coming IP.

### For CRM Online

Adding an SPF record to use CRM Online’s email service (com: mailgun.org, eu: eu.mailgun.org), will the policy only to all non-Mailgun email servers since there is at this point not possible to distinguish between users of this email service on IP address (they all users the same one). Do note, combining SPF with DKIM will be adequate to distinguish your domain, due to the fact each customer uses its own domain key.
Again, this technology relies upon the receiver's email server to use the tools…

## Read more

* FAQ: [How to avoid being categorized as spam when sending Mailings from SuperOffice Online?][15]
* FAQ: [How can we avoid being blacklisted after sending out our newsletters?][16]
* FAQ: [Why does Customer Service stop sending emails to a specific address?][17]

<!-- Referenced links -->
[1]: spf/set-up.md
[2]: dkim/order-key.md
[3]: https://dmarc.postmarkapp.com/
[5]: https://www.petekeen.net/fix-your-email-deliverability-with-dmarc
[6]: https://www.valimail.com/blog/faq-dmarc-for-email-service-providers/
[7]: http://www.superoffice.com/blog/5-killer-email-marketing-mistakes-to-avoid/
[8]: https://www.simplycast.com/blog/15-tips-to-avoid-email-blacklisting/
[9]: https://sendgrid.com/blog/email-blacklist/
[10]: https://en.wikipedia.org/wiki/Email_spam
[11]: https://en.wikipedia.org/wiki/Spamtrap
[12]: https://en.wikipedia.org/wiki/Email_spoofing
[13]: https://www.valimail.com/dmarc/spear-phishing
[14]: https://en.wikipedia.org/wiki/Email_bomb
[15]: http://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=112899
[16]: http://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=112768
[17]: http://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=298

<!-- Referenced images -->
[img1]: media/dmarkpolicy.png
