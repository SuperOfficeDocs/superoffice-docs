---
uid: whats-new-70-queryexecutionhelper
title: QueryExecutionHelper
description: NetServer 7.0
keywords: API changes
author: SuperOffice AS - Product and Engineering
date: 11.05.2016
version: 7.0
content_type: release-note
category: api
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
