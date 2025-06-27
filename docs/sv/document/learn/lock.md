---
uid: help-sv-document-lock
title: Checka in/ut dokument
description: Checka in/ut dokument
keywords: dokument, checka in, lås dokument, redigeringsläge, läsläge, begär redigering eller läsning, återgå till sparad version
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Checka in/ut dokument

I SuperOffice CRM är det alltid många som skapar, redigerar och läser dokument. Om flera användare redigerar samma dokument samtidigt, riskerar de att skriva över varandras uppgifter. För att det inte ska hända låser SuperOffice CRM dokumentet när det redigeras av en användare. Andra användare kan fortfarande öppna dokumentet, men endast i läsläge. (Om ditt företag använder ett dokumentbibliotek som SharePoint kan flera personer redigera ett dokument samtidigt.)

## Redigeringsläge och läsläge

* Redigeringsläge: Dokumentet öppnas för redigering. Dokumentet kan inte redigeras av andra användare förrän du sparar och stänger det, vilket gör att dokumentet automatiskt checkas in.

    Om du inte vill att ett dokument ska checkas in automatiskt när du sparar och stänger det kan du aktivera inställningen **Fråga om incheckning när redigeringen är avslutad** under **Inställningar** i SuperOffice WebTools.

* Läsläge: Dokumentet öppnas för läsning. Om du gör ändringar i dokumentet sparas de inte. För att kunna [spara dokumentet med dina ändringar][1] måste du skapa ett nytt dokument SuperOffice CRM och ladda upp filen med ändringarna.

Som standard öppnas ett dokument i redigeringsläge. Om du föredrar att välja läsläge eller redigeringsläge när du öppnar ett dokument går du till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Inställningar** > **Funktioner** och sätter **Fråga om redigering eller läsning** till **Ja**.

## Hur vet jag när ett dokument är utcheckat?

I dialogrutan **Dokument** visar ett utcheckat dokument en banner som visar vem som redigerar det.

<i class="ph ph-warning-circle" aria-label="Warning icon"></i> **Du** redigerar det här dokumentet.

<i class="ph ph-warning-circle" aria-label="Warning icon"></i> Du kan inte redigera det här dokumentet eftersom det är låst av **NN**.

## Checka ut ett dokument för redigering

Öppna ett dokument och välj [redigera dokumentet][1]. Dokumentet är utcheckat för redigering av dig. Andra användare kan bara öppna dokumentet i läsläge.

## Checka in ett dokument efter redigering

I de flesta fall kan du [spara och stänga dokumentet][1] i applikationen så checkas det in automatiskt.

## Avbryta en utcheckning (hämta sparad version)

Du behöver särskilda behörigheter för att få tillgång till det här alternativet. Du måste också ha skrivrättigheter till dokumentet.

> [!CAUTION]
> Om en annan användare har checkat ut ett dokument måste du alltid kontakta denna användare innan du utför den här proceduren. Annars finns en risk att du skriver över en annan persons ändringar eller att den andra användaren skriver över dina ändringar när de checkar in dokumentet
>
> Det bästa alternativet kan vara att göra en kopia av dokumentet och redigera kopian.

Om du eller någon annan har checkat ut ett dokument och du vill redigera detta dokument kan du avbryta utcheckningen:

1. Högerklicka på dokumentet och välj **Dokument**.
2. I dialogrutan, klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Uppgift-knappen"></i> och välj **Hämta sparad version**.

<!-- Referenced links -->
[1]: edit.md
