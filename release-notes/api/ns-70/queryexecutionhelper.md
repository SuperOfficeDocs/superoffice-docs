---
title: QueryExecutionHelper
uid: whats_new_70_queryexecutionhelper
description: NetServer 7.0
author: {github-id}
date: 11.05.2016
keywords:
topic: reference
---

# QueryExecutionHelper

A utility class that handles connections and commands.

* Exception-safe cleanup through using clause

* Nice clean code (saves 2 nesting levels and some try-catch noise)

* Many overloads allow customized behavior

* Can be used for executing non-query commands

  `QueryExecutionHelper.ExecuteNonQuery(myInsert)`

* Can be used for fetching scalar values

  `int i = .ExecuteTypedScalar<int>(mySql)`
