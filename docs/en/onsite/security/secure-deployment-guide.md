---
title: Deploy SuperOffice securely onsite
uid: secure_deployment_guide
description: Guide to secure deployment of SuperOffice onsite
author: {github-id}
keywords: security
topic: guide
envir: onsite
client: web
---

# Deploy SuperOffice securely onsite

Here you will find articles to help you to securely deploy SuperOffice onsite for the Web client.

## Security features of SuperOffice

### Active Directory single sign-on

SuperOffice integrates well with existing Active Directory infrastructures allowing users to easily sign in using their existing domain credentials. This is a user-friendly and secure way to integrate SuperOffice into your environment and it does not impose new credentials for your users to remember. Another advantage is that the existing password policy is enforced making sure that users have strong passwords.

### Customizable password policy setting

If Active Directory integration is not a fit for your business, SuperOffice lets you define a strong password policy making sure the passwords used in SuperOffice comply with the information security policy of your organization.

### Customizable role-based permissions

SuperOffice comes with a highly customizable role-based CRUD permission matrix, allowing you to define granular levels of access for all your users. It is highly recommended to implement permissions with the principle of least privilege in mind as to not grant users excessive access to company data, but still allowing them to do their job effectively.

## Web application security

SuperOffice strives to follow security best practices for all of its components. A focus on the [OWASP][1] testing methodology and [OWASPs Top 10 list][2] of vulnerabilities enables SuperOffice to build secure and robust web applications. All components are regularly audited by security professionals and security testing is closely integrated with SuperOffice’s Software Development Lifecycle. This allows SuperOffice to discover and fix bugs in a timely manner, keeping the software secure.

## Encrypting traffic

SuperOffice servers communicate with each other, with clients, and potentially with outside services such as mail servers. To maintain the integrity and confidentiality of the communications, we recommend using HTTPS everywhere. Securing HTTPS correctly is not necessarily difficult, but recommendations change quickly as new vulnerabilities are discovered in encryption algorithms and protocols. We recommend using tools such as [SSL Labs’ Server Test][3] or [SSLyze][4] to test your configuration regularly.

The Norwegian National Security Authority (NSM) has published a [detailed guide][5] on how to harden encryption on Windows systems and we recommend that you follow their advice when deploying SuperOffice. The process is simple and an be done by rolling out a Group Policy from a domain controller using the tool from [NSM][6], or running a Powershell script that edits the registry on each server.

Here is a set of recommendations that represent the current setup that is considered secure.

### HTTPS: Using strong ciphers to protect your data in transit

* TLS1.2, TLS1.1 should be enabled on all servers
* SSL2 and SSL3 should be disabled on all servers.
* Encryption ciphers should be strong with key size of 128-bits or more.
* Use of MD5, RC4 and DES should be avoided.

### Certificates

The SuperOffice web application should use valid X.509 certificates. If SuperOffice is to be accessible on the internal network only, a certificate signed by an internal CA that is distributed to all clients could be used. Otherwise, if SuperOffice should be accessible from the Internet we recommend buying a certificate signed by a third-party CA. All certificates should be signed using the SHA256 algorithm and contain a full common name to make it valid and able to reassure users that they are connecting to the correct web server. This provides integrity of the data passed between your users and your CRM system.

## Hardening Windows servers

SuperOffice recommends using the latest Windows Server as your platform. Windows servers used in the SuperOffice deployment should be hardened as much as possible, and we recommend that you take the following into consideration:

* Run the Security Configuration Wizard on the servers and apply SMB signing.
* Install the Enhanced Mitigation Experience Toolkit ([EMET][7]).
* Keep servers up to date with the latest updates from Windows.
* Install a recognized and proven anti-malware solution on the server.
* Set a strong password policy for the servers.

Running the Security Configuration Wizard will help harden the servers by enabling security settings such as SMB signing and making sure that as few services as needed are running on the server, again minimizing the attack surface.

[Installing EMET][8] is recommended by both Microsoft and SuperOffice and will add protection mechanisms to installed software on the servers, making them more resilient to exploitation. EMET will add an extra layer of protection to your servers in accordance with the principle of Defense-In-Depth.

Keeping your SuperOffice servers up-to-date is crucial in keeping your data secure and maintaining a secure network. Obvious as it may be, un-patched software is still an easy and common way for attackers to take control of a server and steal valuable information. We therefore recommend keeping up with Microsoft’s monthly patch cycle and install updates soon after they are released.

Anti-malware solutions are of limited value in today’s fast-paced world of malware because of the limitations of signature technologies. However, modern anti-malware solutions contribute to detecting known malware and may have built-in heuristics making it able to detect malicious software that have made it on to the servers. We recommend installing a modern anti-malware solution on the servers, keep it updated and configure logging and alerts to notify key personnel in case of incidents.

## Patching / updating SuperOffice

Like most software, SuperOffice CRM ships updates regularly containing bug fixes or patches for security issues. This means that you should update your SuperOffice installation accordingly to be running the latest and greatest code.

## Client security

When SuperOffice is used from the Internet, it means clients are often outside of the protected environment of the business network. This means that they are more exposed to malware, they may be on insecure wireless networks, or connected to other devices with a lower threshold of security. This means that it is crucial to keep the operating system updated and that host-based security mechanisms are in place. An updated and professional anti-virus solution is a must-have to deal with known malware. To keep the network exposure of the computer to a minimum, a firewall must be in place and correctly configured.

<!-- Referenced links -->
[1]: https://www.owasp.org/
[2]: https://www.owasp.org/index.php/Category:OWASP_Top_Ten_Project
[3]: https://www.ssllabs.com/ssltest/
[4]: https://github.com/iSECPartners/sslyze
[5]: https://www.nsm.stat.no/globalassets/dokumenter/veiledninger/systemteknisk-sikkerhetu-03_sikring_av_windows_tls.pdf
[6]: https://www.nsm.stat.no/globalassets/dokumenter/veiledninger/systemteknisk-sikkerhet/u-03_sikring_av_windows_tls.zip
[7]: https://support.microsoft.com/en-us/kb/2458544
[8]: set-up-emet.md
