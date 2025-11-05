---
uid: help-sv-form-publish
title: Publicera formulär
description: Publicera formulär
keywords: formulär, publicera, publicera formulär, förifyllda fält, skripttagg, direktlänk, UTM-byggare, lägg till UTM-spårning
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Publicera formulär

När du har skapat formuläret och (om det är relevant) formulärsvaret kan du publicera formuläret.

> [!NOTE]
> Fliken **Publicera** är ett här-och-nu-arbetsområde. Alla värden du anger på den här sidan – till exempel förifyllda fält eller UTM-parametrar – används endast för att skapa den länk eller det skript du kopierar nu.
> SuperOffice sparar **inte** dessa värden permanent. Om en annan användare redigerar sidan senare ersätts dina tidigare värden.

## Steg

1. Gå till fliken **Formulär**.

1. Klicka på formuläret så att det öppnas i visningsläge.

1. Ställ in formuläret som **Aktivt** <i class="ph ph-toggle-right" aria-label="Toggle on"></i> i rubriken.

1. Gå till fliken **Publicera**.

1. (valfritt) Välj **Förfyll med kontaktuppgifter** om du vill lägga till fältidentifierare i länken/JavaScript. Relevant om du vill [förifylla fält i formulären][1] med befintliga kunddata från SuperOffice.

1. På den vänstra sidan av skärmen väljer du ett publiceringsalternativ för formuläret:
    * **Direktlänk**: En direktlänk till formuläret.
    * **Bädda in inline**: En skripttagg används för att lägga till formuläret på en webbsida.
    * **Bädda in som popup**: En knapp för att öppna formuläret i ett popupfönster på webbsidan.
    * **Bädda in som sidoflik**: En sidoflik med en knapp för att dölja/visa formuläret.

1. Kopiera länkarn/taggarna till ett nyhetsbrev, en webbplats eller ett kundcenter om du vill publicera den till dina kunder eller prospekt.

![Publicera formulär, direktlänk -screenshot][img3]

## <a id="utm"></a>Lägg till UTM-spårning (Marketing Premium)

Den inbyggda **UTM-byggaren** skapar en formulärlänk med [UTM-parametrar][4], så att SuperOffice kan spåra var dina leads kommer ifrån när en besökare skickar in formuläret.

### Förutsättningar och begränsningar

* Du har en **Marketing Premium**-användarplan.
* En administratör har [aktiverat överföring av UTM-data för formulärinlämningar][6].
* UTM-spårning är endast tillgänglig för alternativet **Direktlänk**. Den gäller inte för inbäddade formulär.

### Steg

1. I fliken **Publicera**, välj **Direktlänk** som publiceringsalternativ.

1. Voer in de sectie **UTM-tracking toevoegen** één of meer UTM-waarden in, zoals **bron**, **medium** en **campagne**.

    ![Fält för Lägg till UTM-spårning i publiceringsvyn för formulär – skärmbild][img4]

    Mer information om varje parameter och namnstandarder finns i [UTM-parametrar][4].

1. Kopiera den genererade länken från fältet nedan.

1. Klistra in länken i din annons, e-post eller ditt inlägg på sociala medier.

> [!TIP]
> Kopiera och spara länken direkt efter att du har skapat den. Eventuella ändringar i fälten senare kommer att skapa en ny länk.

## Vad händer nu?

Ett meddelande på fliken **Formulärinlämningar** anger att du har [tagit emot formulärinlämningar][2], som kanske behöver [hanteras manuellt][3].

Formulär kan avaktiveras manuellt eller avaktiveras automatiskt på ett specifikt datum eller när ett specifikt antal inlämningar har mottagits.

## Relaterat innehåll

* [Översikt över konverteringsspårning][5]
* [Konfigurera UTM-spårning][6] - i Inställningar och underhåll

<!-- Referenced links -->
[1]: form-prefilled.md
[2]: view-statistics.md
[3]: process-submissions.md
[4]: ../../utm/learn/parameters.md
[5]: ../../utm/learn/index.md
[6]: ../../utm/admin/set-up.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/form-publish.png
[img4]: ../../../../media/loc/en/marketing/utm-builder.png
