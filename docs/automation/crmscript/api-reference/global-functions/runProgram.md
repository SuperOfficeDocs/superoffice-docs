---
uid: crmscript_global_runprogram
title: String runProgram()
description: CRMScript function that executes a command and returns the output (stdout)
intellisense: Void.runProgram
langref: 1
keywords: runProgram(String), runProgram(String,String)
so.topic: reference
---

# String runProgram()

Executes the program (given command) and returns what was sent to stdout. You can optionally pass the codepage used.

> [!NOTE]
> The owner of the process running the CRMScript needs permissions to execute the program.

## Functions

* String runProgram(String command)
* String runProgram(String command, String codepage)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| command | String | Command line - path to program and parameters |
| codepage | String | Optional. The codepage used |
