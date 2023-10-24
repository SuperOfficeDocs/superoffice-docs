---
uid: help-sv-video-meetings-email-setup
title: E-postinställningar för videomöten
description: E-postinställningar för videomöten
author: SuperOffice RnD
so.date: 06.29.2022
keywords: videomöte
so.topic: howto
language: sv
---

# E-postinställningar för videomöten

För att kunna skicka och ta emot e-postinbjudningar till videomöten (till/från externa användare) måste du ha konfigurerat dina e-postinställningar i SuperOffice CRM (användarklient) eller använda SuperOffice Mail Link.

## Konfiguration: Få inbjudningar via e-post från externa användare

För att kunna få inbjudningar via e-post från externa användare måste du

* konfigurera dina e-postinställningarna i SuperOffice-inkorgen eller

* (om du använder SuperOffice Mail Link) välja inställningen **Lägg till/uppdatera bokningar i SuperOffice** under **Förfrågningar**.

    > [!NOTE]
    > För närvarande stöds inte den här funktionen om du använder Synchronizer for SuperOffice.

## Konfiguration: Skicka en inbjudan via e-post till externa användare

För att kunna skicka inbjudningar via e-post till externa användare måste du

* konfigurera dina e-postinställningarna i SuperOffice-inkorgen

    > [!TIP]
    > Om du vill att webbadressen till videomötet automatiskt ska inkluderas i mötetexten uppdaterar du inbjudningsmallen med {burl}. Om fältet **Plats** är tomt läggs videomötets URL till här.

* ha konfigurerat för SuperOffice Mail Link

    > [!NOTE]
    > Videomötets URL läggs till automatiskt i mötetexten ("Anslut till möte: ..."). Om fältet **Plats** är tomt läggs videomötets URL till här.

## Relaterade ämnen

* [Så konfigurerar du e-postinbjudningar till videomöten][1]

<!-- Referenced links -->
[1]: ../../../../../en/video-meeting/howto/configure-email-invitations.md

<!-- Referenced images --