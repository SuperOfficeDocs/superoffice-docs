---
uid: help-sv-udef-edit
title: Redigera användardefinierade fält
description: Redigera användardefinierade fält
author: Bergfrid Dias
date: 01.29.2024
version: 10
keywords: udef, anpassa fält
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
---

# Redigera användardefinierade fält

1. [!inkludera[Gå till Fält och välj flik](includes/goto-fields.md)]

1. Dubbelklicka på det nödvändiga fältet i listan **Fält**.

1. Gör de nödvändiga ändringarna i olika fält. (Se listan över [fältegenskaper][1]).

    Använd nedrullningsmenyn för **Typ** för att välja en ny typ. Du kommer bara att se kompatibla fälttyper. Det vill säga, där befintliga data kan konverteras för att passa den nya fälttypen.

1. Klicka på **Spara**.

1. Klicka på **Publicera** för att göra ändringarna tillgängliga för SuperOffice-användare.

> [!NOTE]
> Du måste publicera ändringarna för användardefinierade fält innan du [definierar sidan 1-fält][2] för de olika användargrupperna och sparar (inte publicerar).

## Konvertera fälttyp

Inte alla konverteringar är möjliga eftersom olika typer av värden för användardefinierade fält lagras i olika tabeller i databasen och använder olika grundläggande datatyper.

| Fälttyp | Nummer | Decimal | Kort text | Lång text | Datum | Obegränsat datum | Kryssruta | Lista |
|:--|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
| Nummer | x | x | x | | | | | |
| Decimal | x | x | x | | | | | |
| Kort text | x | | x | | | | | |
| Lång text | | | | x | | | | |
| Datum | | | x | | x | x | | |
| Obegränsat datum | | | x | | | x | | |
| Kryssruta | | | x | | | | x | |
| Lista | | | x | | | | | x |

**Hur man läser tabellen:**

Fälttyperna i den vänstra kolumnen är kompatibla med och kan konverteras till typerna markerade med ett x. Till exempel kan ett nummer konverteras till en decimal och en kort text. (Och det är självklart kompatibelt med sig själv.)

<!-- Referenced links -->
[1]: add-udef.md#properties
[2]: edit-udef-layout.md#page-1

<!-- Referenced images -->
