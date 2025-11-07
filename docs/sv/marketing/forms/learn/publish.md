---
uid: help-sv-form-publish
title: Publicera formulär
description: Publicera formulär
keywords: formulär, publicera, publicera formulär, förifyllda fält, fältidentifierare, skripttagg, direktlänk, UTM-byggare, lägg till UTM-spårning
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
redirect_from: /sv/marketing/forms/learn/form-prefilled
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

1. På den vänstra sidan av skärmen väljer du ett publiceringsalternativ för formuläret:
    * **Direktlänk**: En direktlänk till formuläret.
    * **Bädda in inline**: En skripttagg används för att lägga till formuläret på en webbsida.
    * **Bädda in som popup**: En knapp för att öppna formuläret i ett popupfönster på webbsidan.
    * **Bädda in som sidoflik**: En sidoflik med en knapp för att dölja/visa formuläret.

1. (valfritt) I avsnittet **Förfyll med kontaktuppgifter** väljer du ett eller flera fält som ska fyllas i automatiskt med befintliga kunddata från SuperOffice.

1. Kopiera länkarn/taggarna till ett nyhetsbrev, en webbplats eller ett kundcenter om du vill publicera den till dina kunder eller prospekt.

![Fliken Publicera i SuperOffice Marketing som visar hur du väljer ett publiceringsalternativ och förifyller formulärfält med kontaktdata. -screenshot][img3]

## <a id="prefill"></a>Förifyllning av fält i formulär

Du kan förifyllda valda formulärfält med befintliga kunddata från SuperOffice för att spara besökare tid när de skickar in ett formulär.

När du väljer ett eller flera fält i avsnittet **Förfyll med kontaktuppgifter**, lägger SuperOffice till motsvarande fältidentifierare och [mallvariabler][7] i länken eller skripttaggen.

När formuläret öppnas fylls dessa fält automatiskt i med kundens lagrade information.

En **fältidentifierare** är ett unikt ID för ett specifikt fält. Den ändras inte även om fältnamnet, etiketten eller språket ändras.

Till exempel:

```text
...form&id=F-Rg2nDAQI
```

blir:

```text
...form&id=F-Rg2nDAQI&field_Email%3A=[[urlEncode(customer.email)]]
```

Detta säkerställer att formuläret dynamiskt infogar varje kontakts e-postadress när det öppnas via en personlig länk.

> [!TIP]
> Fältidentifierare är stabila över språk och uppdateringar, så dina länkar kommer att fortsätta fungera även om formuläret redigeras senare.

## <a id="utm"></a>Lägg till UTM-spårning (Marketing Premium)

Den inbyggda **UTM-byggaren** skapar en formulärlänk med [UTM-parametrar][4], så att SuperOffice kan spåra var dina leads kommer ifrån när en besökare skickar in formuläret.

### Förutsättningar och begränsningar

* Du har en **Marketing Premium**-användarplan.
* En administratör har [aktiverat överföring av UTM-data för formulärinlämningar][6].
* UTM-spårning är endast tillgänglig för alternativet **Direktlänk**. Den gäller inte för inbäddade formulär.

### Steg

1. I fliken **Publicera**, välj **Direktlänk** som publiceringsalternativ.

1. Voer in de sectie **UTM-tracking toevoegen** één of meer UTM-waarden in, zoals **bron**, **medium** en **campagne**.

    Till exempel:

    ```text
    ...form&id=F-Rg2nDAQI
    ```

    blir:

    ```text
    ...formId=F-Rg2nDAQI&utm_source=linkedin&utm_campaign=rebranding
    ```

    ![Fält för Lägg till UTM-spårning i publiceringsvyn för formulär -screenshot][img4]

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
[2]: view-statistics.md
[3]: process-submissions.md
[4]: ../../utm/learn/parameters.md
[5]: ../../utm/learn/index.md
[6]: ../../utm/admin/set-up.md
[7]: ../../../knowledge-base/learn/reply-templates/template-variables.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/form-publish.png
[img4]: ../../../../media/loc/en/marketing/utm-builder.png
