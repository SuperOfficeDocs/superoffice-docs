---
uid: help-sv-currency-add
title: Valuta
description: Lägga till poster i listan Valuta
keywords: listan Allmänt – Valuta, valuta
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: sale
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /sv/admin/lists/learn/adding-items-to-currency-list
  - /sv/admin/lists/learn/currency
language: sv
---

# Valuta

På flikarna i fönstret Försäljning i SuperOffice CRM anger du försäljningsbelopp, kostnader och bruttovinst för försäljningen. Vilken valuta beloppen anges i beror på vad du har angett under [inställningarna][2], där du väljer din egen valuta och en basvaluta från en lista som definieras i fönstret Listor.

## Lägg till valuta

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.

1. Välj **Allmänt – Valuta** från rullgardinsmenyn. Fliken **Poster** visar alla befintliga valutor.

1. Klicka på **Lägg till** för att öppna dialogrutan **Redigera listpost**.

1. Skriv in det önskade namnet på posten i fältet **Namn**. *(Obligatoriskt)*

1. Ange den aktuella valutakursen genom att ange ett tal i fältet **Kurs**.

    > [!NOTE]
    > Detta är kursen mot basvalutan. Basvalutan är den valuta där kursen är inställd på 1. Om basvalutan är EUR, beräknas kursen för andra valutor mot denna valuta och den angivna enheten (se nästa punkt). GBP 1 motsvarar till exempel EUR 1,562 enligt dagens kurs, medan NOK 100 skulle motsvara EUR 12,677. Denna beräkning visas när du har angett valutakurs och enhet.

1. Ange enheten som ska användas i förhållande till basvalutan i fältet **Enhet**. Standardvärdet kan till exempel vara 100 för norska kronor och 1 för brittiska pund.

1. Skriv eventuellt en beskrivning av valutan i fältet **Beskrivning**.

1. Klicka på **Spara**. Valutan läggs nu till som en egen post i listan. Upprepa proceduren om du vill lägga till fler valutor.

## Ändra standardvaluta

Om du vill ändra standardvalutan öppnar du fönstret **Inställningar** och går till fliken **Globala inställningar** > **System** > **Ledvaluta**.

## Aktivera användning av valuta

För att tillåta att försäljning registreras i en annan valuta, öppna fönstret **Inställningar** och gå till fliken **Inställningar** > **System** > **Aktivera användning av valuta**.

<!-- Referenced links -->
[2]: ../../admin/preferences/index.md
