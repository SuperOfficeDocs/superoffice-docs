---
title: auth_username
description: What's in a user name
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# What's in a user name

The username/password string pair can be one of:

* SuperOffice associate name + password

* AD Domain user name + domain password

* SuperOffice ticket string + \<don’t care>

* SuperOffice email address + password

If exactly one associate has this email address, and no (other) associate has this name

> [CAUTION]
> Your code should never assume that the user typed a user name. Go ask NetServer for the current user name.

And - just to drive the point home – the plugin architecture means that this is an open-ended system and the "username" could be anything **else** that some plugin understands (fingerprint hash? Blood type signature?). It’s just a convenient way to carry a pair of strings!
