---
uid: help-da-screen-chooser
title: ScreenChoosers
description: ScreenChoosers
keywords: UI, screen_chooser
author: digitaldiina
date: 05.11.2026
version: 11.11
content_type: concept
tier: core
language: da
---

# ScreenChoosers

[!include[Requirement](../../../includes/req-dev-tools-transition.md)]

En skærmvælger er et script, der kan foretage omdirigering til et andet skærmbillede end standardskærmbilledet. Scriptet kan køre CRMScript-funktionen "setVariable("url", myUrl)" for at vise en anden webadresse, end den der er standard. Det er f.eks. muligt at foretage omdirigering fra skærmbilledet Vis sag til et eget udviklet skærmbillede, og/eller der kan foretages beregninger i scriptet, før skærmbilledet vises. Skærmvælgerne er organiseret i en mappestruktur, der er baseret på, hvor i systemet de køres fra.

## Egenskaber for skærmvælger

Her kan du tilføje et script, der kan foretage omdirigering til et andet skærmbillede ved at køre CRMScript-funktionen "setVariable("url", myUrl)".
