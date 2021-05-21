---
title: Authentication pipeline
uid: auth_pipeline
description: Authentication pipeline
author: {github-id}
so.date: 05.08.2018
keywords: security, identity
so.topic: concept \
so.envir: onsite
# so.client:
---

# Authentication pipeline

NetServer contains several [authentication plugins][1], for as many different ways of authenticating

* SoCredentials (ticket string)
* Username+password (SuperOffice user, not AD)
* Windows/AD user, who is a person (not System, Guest, and so on)
* Impersonation identity
* Username+password, matched against Windows/AD
* Windows/AD user, who is not a person

The plugins are called in this order, and each is given all the available evidence (credentials) at the time of invocation.

Authentication plugins are useful in many scenarios. For a Web server, the IP address the request is coming from is a piece of evidence that can be taken into account. If a certain IP range is prohibited, then the check can refuse login right there. Or time of day... or whatever. You can write all sorts of funny rules into your plugins. Overdoing it is easy and leads to major frustration if your policies are too draconian.

Each plugin looks for credentials it understands.

* Such credentials are evaluated, for instance, a password is checked against stored information
* Success results in an associate ID

So-called *Expensive* plugins, time-wise, should come late in the order!

## Post validator

Each plugin can have a post-validator. The post-validators are **called after a plugin resolves an identity** and can block login if specific conditions are not met. This can be used to block based on any available knowledge.

The post-validator is interesting, for instance, where a company decided to have a policy stating that certain users are only allowed to log on during normal working hours. The plugin would then take the resolved identity, look at the clock and then return whether the user can sign in or not.

<!-- Referenced links -->
[1]: plugins.md
