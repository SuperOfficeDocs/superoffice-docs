---
uid: help-sv-quote-alternatives
title: Lägga till alternativ i en offert
description: Lär dig hur du skapar och hanterar offertalternativ i SuperOffice CRM för att erbjuda flera förslag till kunden.
keywords: offert, offertalternativ
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/quote/learn/add-alternative
---

# Lägga till alternativ i en offert

Använd alternativ för att erbjuda olika kombinationer av produkter, kvantiteter eller prissättning i samma offert. Varje alternativ visas som en separat flik i dialogrutan **Redigera offert**.

Du kan skapa ett nytt alternativ från grunden eller kopiera ett befintligt.

> [!NOTE]
> [Alternativ måste vara aktiverade][3] för försäljningstypen i Inställningar och underhåll. Om fliken **+** inte visas, välj en annan försäljningstyp eller aktivera inställningen. Du kan också bara inkludera ett alternativ i offerten.

## Skapa eller kopiera ett alternativ

1. Gå till detaljkortet **Offert** i försäljningen och klicka på **Öppna** för att redigera offerten.

    Offerten måste ha statusen **Utkast**. Om den redan har skickats, [skapa en ny version][1].

1. Klicka på fliken **+** bredvid det sista alternativet.

1. Välj ett av följande:

    * **Skapa nytt alternativ:** Börja från början (utan produkter)
    * **Kopiera alternativ:** Kopierar ett befintligt alternativ, inklusive dess produkter

1. Ange ett namn på det nya alternativet i fältet **Namn**. Detta blir fliknamnet.

1. Klicka på **Lägg till**. Det nya alternativet visas som en egen flik.

1. [Lägg till produkter i det nya alternativet][2].

1. Valfritt: Klicka på <i class="ph ph-star" aria-label="Star icon"></i> **Favoritalternativ** längst ner för att markera detta alternativ som favorit.

    Uppskattade försäljningsbelopp för försäljningen (prognos) hämtas från det totala beloppet för favoritalternativet.

## Byta namn på eller ta bort ett alternativ

1. Välj fliken för det alternativ du vill ändra.

1. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> i det nedre vänstra hörnet för att öppna åtgärdsmenyn.

1. Välj ett av följande:

    * **Byt namn på alternativ**: Skriv in ett nytt namn och tryck på **Enter**
    * **Ta bort \[alternativnamn\]**: Bekräfta borttagningen i dialogrutan

> [!NOTE]
> Ikonen <i class="ph ph-trash" aria-hidden="true"></i> under produktlistan tar endast bort markerade **produktrader**, inte hela alternativ.

<!-- Referenced links -->
[1]: send.md#versions
[2]: create.md#add-products
[3]: ../../admin/sale-type.md#quote-fields
