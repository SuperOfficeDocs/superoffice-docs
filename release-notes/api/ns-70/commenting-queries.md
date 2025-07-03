---
uid: whats-new-70-newselect
title: NewSelect
description: NetServer 7.0
keywords: API changes
author: SuperOffice AS - Product and Engineering
date: 11.05.2016
version: 7.0
content_type: release-note
category: api
---

# NetServer 7.0

The code says

```SQL
Select q = S.NewSelect("comment");
```

The generated SQL will start with

```SQL
/* comment */
```

This can be a powerful debugging/forensic tool. "Where is this query coming from" is suddenly easier to answer.

Please use this feature!
