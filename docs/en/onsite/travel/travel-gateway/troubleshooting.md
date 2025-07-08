---
title: Troubleshooting
uid: troubleshoot_travel
description: Troubleshooting the travel gateway
author: SuperOffice Product and Engineering
keywords:
date:
content_type: concept
deployment: onsite
platform: win
---

# Troubleshooting

## Gateway service is running, but the gateway shows that it is not running?

Check the Log on as the user set up on the service. If this user does not have sufficient rights to SO_Arc the gateway will show it as not running even though the services overview shows that it's running.

## When I look at the Task Manager there are two or more SoTraGateService.exe processes running?

This means the gateway service is currently executing tasks. If there is only one process running, it's waiting for a task to come due. In SO_Arc you will find a Task_**x**.trt file, where the x shows which task is running. 0 means the first task when you open the Travel gateway to view tasks that are set up. When the task is finished, the *.trt file will be deleted from SO_Arc, and the SoTraGateService.exe process that executed the task will be gone.

## Prototype is not generated

If the Travel gateway service is running on a server that is not also the location of SO_ARC, make sure the local Sybase engine has sufficient rights to access the file in so_arc\template\travel. Try to manually start the prototype generation from the SOTrvGate.exe, you may be asked by the Windows firewall if you want to accept this traffic.
