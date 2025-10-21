---
uid: help-sv-number-allocation-configure
title: Ange nummertilldelning
description: Ange nummertilldelning
keywords: nummertilldelning, räknare, företagsnummer
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: Settings and maintenance
topic: options
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /sv/admin/options/learn/number-allocation/index
  - /sv/admin/options/learn/number-allocation/configure
language: sv
---

# Ange nummertilldelning

Räknaren ökar värdet i fältet med 1 varje gång en ny förekomst används. Exempel: om det första företag du skapar i databasen tilldelas värdet 10001 i fältet **Nummer** kommer det nittonde företaget att tilldelas värdet **10019**.

Räknare kan tillämpas på följande fält:

* **Nummer**-fälten i fönstren Företag, Projekt, Försäljning och Kontakt.
* Fältet **Vår ref.** i dialogrutan Dokument om det har definierats för den aktuella mallen.
* Räknare från tredjepartsleverantörer kan också användas.

Högst upp på fliken **Nummertilldelning** finns en tabell som visar alla räknare som har definierats.

## Ange nummertilldelning för fält

1. Gå till Inställningar och underhåll och klicka på <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Systemval**.

1. Välj fliken **Nummertilldelning**.

1. Dubbelklicka på önskad räknare i tabellen. En dialogruta för den valda räknaren öppnas.

1. Markera **Unik** om du vill att värdena i fältet **Nummer** ska vara unika. Det är praktiskt när SuperOffice CRM-användarna tilldelar värden själva.

1. Markera **Tillåt tomma** om du vill tillåta tomma räknarfält. Det är praktiskt om räknarvärdena måste vara unika. Om **Tillåt tomma** markeras betyder det att kravet på unika värden inte tillämpas på tomma fält.

1. Markera **Endast läsbart** om du inte vill att SuperOffice CRM-användarna ska kunna skriva in värden själva i fältet **Nummer**.

1. Markera **Tilldela** om du vill använda den automatiska räknarfunktionen. Systemet matar då in värdena i fältet **Nummer** automatiskt.

1. Fältet **Nästa nummer** visar det nummer som kommer att användas härnäst. Du kan ändra detta värde om det behövs.

1. Klicka på **Spara**.

## Kolumner

| Kolumn | Beskrivning |
|---|---|
| [Icon] | Visar var räknaren används, till exempel <i class="ph ph-buildings" aria-label="Company icon"></i> för fönstret Företag. |
| Räknare | Visar räknarens namn, till exempel **Företagsnummer**, som tillämpas på fältet **Nummer** i fönstret Företag. |
| Nästa | Visar nästa värde för räknaren. |
| Tilldela | Anger om den automatiska räknarfunktionen används så att systemet matar in värden åt dig. |
| Unik | Anger om räknarvärdena måste vara unika. Det är praktiskt när användarna tilldelar värden själva. |
| Endast läsbart | Anger om användarna kan skriva in värden i räknarfälten själva. |
| Tillåt tomma | Anger om ett tomt räknarfält är ett tillåtet värde. Det är praktiskt om räknarvärdena måste vara unika. Om **Tillåt tomma** markeras betyder det att kravet på unika värden inte tillämpas på tomma fält. |
| Senast använd | Visar när räknarfältet senast användes. |
| Av – Användar-ID | Visar vem som använde räknarfältet senast. |
| Av – Porträtt | Visar en miniatyrbild av den användare som senast använde räknarfältet. |

## Resultat av nummertilldelning

Tabellen nedan visar resultaten av olika kombinationer av värdena **Tilldela** (A), **Unik** (U), **Endast läsbart** (R) och **Tillåt tomma** (B) i praktiken:

| A | U | R | B | Resultat |
|:-:|:-:|:-:|:-:|---|
| | | | | Användarna kan ange vad de vill. |
| x | | | | Ett nummer tilldelas som användaren kan ändra. |
| x | x | | | Ett nummer tilldelas som användaren kan ändra till ett unikt värde. Databasen kan bara innehålla ett tomt fält. |
| x | x | x | | Ett nummer tilldelas som användaren inte kan ändra. |
| x | x | x | x | Ett nummer tilldelas som användaren inte kan ändra. |
| x | x | | x | Ett nummer tilldelas som användaren kan ändra till ett unikt värde eller ta bort. Databasen kan innehålla ett obegränsat antal tomma fält. |
| x | | x | | Ett nummer tilldelas som användaren inte kan ändra. Om en extern process ändrar numret kontrolleras inte dess unicitet. |
| | x | | | Inget nummer tilldelas. Användaren kan ange ett nummer, men det måste vara unikt. Databasen kan bara innehålla ett tomt fält. |
| | x | | x | Inget nummer tilldelas. Användaren kan ange ett nummer, men det måste vara unikt. Databasen kan innehålla ett obegränsat antal tomma fält. |
| | | x | x | Inget nummer tilldelas och användaren får inte ange ett nummer. Det är praktiskt när räknare från tredjepartsleverantörer används. |
| | | x | | Inget nummer tilldelas och användaren får inte ange ett nummer. Databasen kan bara innehålla ett tomt fält. (Rekommenderas inte.) |

## Relaterat innehåll

* [Ange standardvärden för nya dokumentmallar][3]

<!-- Referenced links -->
[3]: ../../document/templates/admin/document-template-defaults.md
