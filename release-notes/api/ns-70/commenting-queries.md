---
title: NewSelect
uid: whats_new_70_newselect
description: NetServer 7.0
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: reference
---

# NetServer 7.0

The code says

```SQL
Select q = S.NewSelect(”comment”);
```

The generated SQL will start with

```SQL
/* comment */
```

This can be a powerful debugging/forensic tool. "Where is this query coming from" is suddenly easier to answer.

Please use this feature!
