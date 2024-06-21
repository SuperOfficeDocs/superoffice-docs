---
title: Network and firewall configuration
uid: network_and_firewall_config
description: Network and firewall configuration for SuperOffice onsite
author: {github-id}
keywords: security
topic:
envir: onsite
client: web
---

# Network and firewall configuration

Most companies today employ firewalls to filter traffic, separate networks into logic sections, and as a deterrent to stop attackers from egressing network boundaries.

No matter what deployment scenario your company is facing, there is some general advice on firewall configuration that holds true. Traditional network segmentation often splits a network into logically separated network blocks as follows:

* Client computers
* Internal servers
* DMZ for internet-accessible servers
* Management network for administrative tasks

This is a simplified view and suits our purpose for this document. The point of this segmentation is to limit the attack surface of the company’s network and isolate internal servers where valuable company information resides. The border between each of these networks is a potential attack surface, and there is a security reward in minimizing the exposed services across each border.

SuperOffice consists of several components, which need to be fitted into your company’s network infrastructure. A list of the most central components follows:

* SuperOffice NetServer
* Database server
* File Server
* Web server
* SuperOffice client (Windows or web)

We recommend placing all the servers (Database server, file server, NetServer/webserver) into a block of the network, which is segregated from the clients and the DMZ and only used for internal servers. This allows us to implement firewall rules that only allow necessary traffic between clients and servers, minimizing the potential attack surface.

The Web client is the most secure option, as it limits the connections between the client network and the server network by communicating over HTTP(S) only.

Some of the server components need to make outbound connections depending on which components are in use and what functionality is needed. For instance, the NetServer needs to be able to communicate out through the firewall on ports 80 (HTTP) and 443 (HTTPS). To ensure that only web traffic is communicated using these ports, an application protocol-aware firewall between the internal server network and the Internet may be used to detect suspicious traffic leaving the NetServer and is recommended to be able to detect attacks, and in the worst case, compromises.

We also recommend placing a Web Application Firewall (WAF) such as the open-source [ModSecurity][1] on a proxy server in front of the NetServer. The role of this server is to detect and/or stop any incoming web attacks. This provides your organization with another layer of protection and a source of information should you become subject to a cyber attack.

Keep in mind that this does introduce a single point of failure, which can be remediated by setting up multiple of these Web Application Firewalls in a cluster. There are also commercial WAFs that can do the same job and may require less work to set up.

<!-- Referenced links -->
[1]: set-up-modsecurity.md
