---
title: Deployment scenarios
uid: deployment_scenarios
description: Deployment scenarios SuperOffice onsite
author: {github-id}
keywords: security
topic: guide
envir: onsite
client: web
---

# Deployment scenarios

SuperOffice can be set up in several ways to suit your business needs and security requirements. The three most common scenarios are described below in increasing order of security.

## Scenario 1: Directly accessible from the internet

In this scenario, SuperOffice is available from any location when connected to the Internet. The Web / NetServer is placed in the DMZ and is accessible from the Internet. This is the least secure setup as it exposes the Web / NetServer to attacks from any other server in your DMZ that may become compromised.

![Click to enlarge image -screenshot][img1]

## <a name="scenario2"></a>Scenario 2: Directly accessible from the internet through a proxy

Instead of making the NetServer directly accessible from the Internet we recommend placing a reverse proxy in the DMZ to forward traffic to and from the Web Server. This proxy server isolates the Web Server from the Internet and allows us to inspect and filter web traffic to and from the Web Server using a web application firewall.

> [!NOTE]
> The main advantage of this setup compared to scenario 1 is that we can avoid exposing the database and other services on the NetServer server (such as RDP or SMB) to the DMZ. If an attacker can compromise another server in the DMZ, the possibility that Web / NetServer or the database is compromised as a result of this is greatly reduced since
 the inner firewall should only accept HTTP connections from the reverse proxy to the Web Server.

![Click to enlarge image -screenshot][img2]

## Scenario 3: Internal only

In this scenario, SuperOffice is only accessible from IP addresses inside your business network. This is the most secure way to deploy, as it does not expose SuperOffice to the public internet, minimizing your company’s attack surface. It would still be possible for employees on travel to access the system using a VPN connection.

> [!NOTE]
> The main advantage of this setup compared to scenario 2 is that a compromise of a user account password will not give an internet-based adversary access to the SuperOffice installation. Data breaches happen from time to time, and users often use the same password on multiple services. This setup will protect against an adversary gaining access to the SuperOffice installation by acquiring a user’s password from a third-party data breach, social engineering, or simply guessing a weak password.

![Click to enlarge image -screenshot][img3]

We do not recommend using the Windows client without a VPN connection as this exposes SMB-traffic over the internet and requires an insecure firewall configuration. Instead, we recommend using the web client with a secure HTTPS connection to the webserver.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/superoffice_network_diagram_direct_internet_access.jpg
[img2]: media/superoffice_network_diagram.jpg
[img3]: media/superoffice_network_diagram_internal_only.jpg
