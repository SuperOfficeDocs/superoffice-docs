---
uid: help-sv-service-screen-properties
title: Egenskaper för skärmbild
description: Egenskaper för skärmbild
author: SuperOffice RnD
date: 06.29.2022
keywords: skärm
content_type: reference
language: sv
---

# Egenskaper för skärmbild

Här kan du redigera egenskaperna för en skärm. Du kan skapa ett skript för förhandsberäkning av variabler, möjligen baserat på CGI-variabler som skärmen får via en webbadress eller på en formulärspost på den aktuella skärmen eller en annan skärm.

## Egenskaper

* **Mapp:** Om du har ordnat skärmarna i en mappstruktur klickar du på <i class="ph ph-caret-down" aria-label="Chevron"></i> och väljer en mapp.
* **Namn**: Ett beskrivande namn på skärmen.
* **ID-sträng**: En unik identifieringssträng för denna skärm som webbadresser kan använda för att referera till skärmen.
* **Autentiseringsnyckel**: Det går att visa en egendefinierad skärm utan att vara inloggad som användare. För att göra detta måste du ange en autentiseringsnyckel.
* **Ge varning vid navigering**: Varna när användaren navigerar bort från en sida med osparad information.
* **Använd automatiskt sparande**: Aktivera [autosparafunktionen][1].

## Skript

* **Inläsningsskript (före setFromCgi)**: Detta körs innan skärmobjekten tilldelas sina värden
* **Inläsningsskript (efter setFromCgi)**: Detta körs efter skärmobjekten tilldelas sina värden
* **Inläsningsskript (kört efter allt annat)**: Detta skript körs allra sist, efter att kod och skripter för knappar har körts.
* **Dold variabel**: De variabler som definieras här sparas när skärmen skickas in så att nästa skärm har åtkomst till variablerna.

<!-- Referenced links -->
[1]: ../../../request/learn/create.md
