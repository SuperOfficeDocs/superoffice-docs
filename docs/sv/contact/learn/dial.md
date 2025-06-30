---
uid: help-sv-contact-dial
title: Ringa till kontakter
description: Ringa till kontakter; Telefoninställningar
keywords: kalender, händelse, telefon, ringa upp, ringa
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Ringa till kontakter

Om IP-telefonin har konfigurerats korrekt kan du ringa en kontakt direkt från SuperOffice CRM på följande sätt:

* Klicka på ett telefonnummer i fönstret Företag
* Klicka på <i class="ph ph-phone" aria-label="Phone icon"></i> i en dialogruta.
* Högerklicka på en person på ett detaljkort och välj **Ring *namn***.
* Ring till kontakter.

## Ringa en kontakt från dialogrutorna Händelse och Dokument

Du använder telefonknappen som finns i bland annat dialogrutorna **Händelse** och **Dokument**:

1. Öppna en händelse eller ett dokument.
2. Välj önskad kontakt i fältet **Kontakt** i dialogrutan.
3. Klicka på telefonknappen bredvid kontaktfältet. En lista över nummer till den aktuella kontakten visas.
4. Välj det telefonnummer du vill ringa upp. Kontakten rings då upp.

## Ringa från detaljkort (till kontakter, urvalsmedlemmar, intressenter och deltagare)

1. Gå till ett detaljkort som innehåller kontakter.
2. Klicka på ett telefonnummer i en kolumn som innehåller telefonnummer. Kontakten rings då upp.

## Tekniska krav

För att använda telefonfunktionerna i SuperOffice måste du kanske installera programvaran TAPI.

### Föreslagna leverantörer

* Standardtelefonprogramvara från Windows
* Panasonic TSP
* PBX Dial

## Preferenser

Om IP-telefoni, Skype eller FaceTime är installerat kan du ringa från SuperOffice CRM. **Telefonlänkformatet** måste vara korrekt inställt, antingen under **Inställningar** > **Standardvärden** eller under Inställningar och underhåll. Under Inställningar och underhåll kan telefoninställningar anges för enskilda användare, användargrupper eller hela systemet.

### Tillgängliga parametrar

* **IP-telefon**: `tel:%p` (standardvärde)
* **Skype**: `callto:%p`
* **FaceTime**: `facetime:%p`

Du kan också använda [mallvariabler][2] i telefoninställningarna.

<!-- Referenced links -->
[2]: ../../document/templates/learn/template-variables.md
