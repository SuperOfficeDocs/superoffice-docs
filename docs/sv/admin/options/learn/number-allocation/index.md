---
uid: help-sv-number-allocation
title: Nummertilldelning
description: Nummertilldelning
keywords: nummer, räknare
author: Bergfrid Dias
date: 02.25.2025
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Nummertilldelning

Räknaren ökar värdet i fältet med 1 varje gång en ny förekomst används. Exempel: om det första företag du skapar i databasen tilldelas värdet 10001 i fältet **Nummer** kommer det nittonde företaget att tilldelas värdet **10019**.

Räknare kan tillämpas på följande fält:

* **Nummer**-fälten i fönstren Företag, Projekt, Försäljning och Kontakt.

* Fältet **Vår ref.** i dialogrutan Dokument om det har definierats för den aktuella mallen.

* Räknare från tredjepartsleverantörer kan också användas.

Högst upp på fliken **Nummertilldelning** finns en tabell som visar alla räknare som har definierats.

## Kolumner

| Kolumn | Beskrivning |
|---|---|
| \[Icon\] | Visar var räknaren används, till exempel <i class="ph ph-buildings" aria-label="Company icon"></i> för fönstret Företag. |
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

## Vad vill du göra nu?

* [Ange nummertilldelning][2]
* [Ange standardvärden för nya dokumentmallar][3]

<!-- Referenced links -->
[2]: configure.md
[3]: document-template-defaults.md
