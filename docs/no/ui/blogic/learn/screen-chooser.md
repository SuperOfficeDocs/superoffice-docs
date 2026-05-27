---
uid: help-no-screen-chooser
title: Skjermvelgere
description: Skjermvelgere
keywords: UI, skjermvelger
author: digitaldiina
date: 05.11.2026
version: 11.11
content_type: concept
tier: core
language: no
---

# Skjermvelgere

[!include[Requirement](../../../includes/req-dev-tools-transition.md)]

En skjermvelger er et skript som kan utføre en omdirigering til et annet bilde fra standardbildet. Skriptet kan kjøre funksjonen CRMScript "setVariable("url", myUrl)" for å vise en URL som er forskjellig fra standard-URL-en. Dette kan f.eks. brukes til å omdirigere fra bildet Vis sak til et egendefinert bilde og/eller utføre beregninger i skriptet før bildet vises. Skjermvelgerne er organisert i en mappestruktur basert på hvor i systemet de kjøres fra.

## Egenskaper for skjermvelger

Her kan du legge til et skript som vil forårsake en omdirigering til et annet bilde ved å kjøre funksjonen CRMScript "setVariable("url", myUrl)".
