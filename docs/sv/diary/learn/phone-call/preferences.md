---
uid: help-sv-phone-preferences
title: Telefoninställningar
description: Telefoninställningar
author: SuperOffice RnD
so.date: 06.29.2022
keywords: kalender, händelse, telefon, ringa upp, ringa
so.topic: howto
language: sv
---

# Telefoninställningar

Du kan ringa från SuperOffice CRM på följande sätt:

* Klicka på ett telefonnummer i fönstret Företag
* Klicka på ![ikon][img1] i en dialogruta.
* Högerklicka på en person på ett detaljkort och välj **Ring *namn***.
* [Ring till kontakter][1].

Telefoninställningarna hanteras olika i Windows- och webbklienten. Du kan läsa mer om telefoninställningar för Windows och webben nedan.

## Tekniska krav

För att använda telefonfunktionerna i SuperOffice måste du kanske installera programvaran TAPI.

### Föreslagna leverantörer

* Standardtelefonprogramvara från Windows
* Panasonic TSP
* PBX Dial

## Preferenser

Om IP-telefoni, Skype eller FaceTime är installerat kan du ringa från SuperOffice CRM. **Telefonlänkformatet** måste vara korrekt inställt, antingen under **Inställningar** > **Standardvärden** eller under Inställningar och underhåll. Under Inställningar och underhåll kan telefoninställningar anges för enskilda användare, användargrupper eller hela systemet.

### Tillgängliga parametrar

**IP-telefon**: tel:%p (standardvärde)
**Skype**: callto:%p
**FaceTime**: facetime:%p

Du kan också använda [mallvariabler][2] i telefoninställningarna.

<!-- Referenced links -->
[1]: dial.md
[2]: ../../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/phone.png
