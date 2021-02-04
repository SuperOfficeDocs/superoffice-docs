---
title: auth_terminology
description: Authentication terminology
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: concept
---

# Terminology

Authentication and authorization are crucial, and separate, concepts.

**Authentication** is about identity – who you are. We can **delegate** the identification of the user to anyone we trust to do so. How we know who the user is, doesn't matter (unless we had different levels of trust like the Norwegian tax website does).

**Authorization** is about what you can do, once we know who you are. We cannot delegate authorization. That is our own domain.

The importance of keeping authentication, identity, and authorization clearly apart in your mind cannot be over-emphasized. Mix them up and bad things will happen, such as unpleasant dependencies creeping into your system.

One important characteristic of the new system is that it tries to separate these concepts:

* Authentication is a process that resolves credentials (evidence) into an identity, and nothing else

* Identity defines who you are, and nothing else

* Authorization derives from identity, and defines what you can do, whoever you are
