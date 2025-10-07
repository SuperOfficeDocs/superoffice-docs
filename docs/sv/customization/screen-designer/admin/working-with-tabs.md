---
uid: help-sv-screen-designer-tabs
title: Arbeta med flikar
description: Hur du lägger till, organiserar, tar bort och återställer en flik i en layout och hur du organiserar informationen i logiska grupper med hjälp av Skärmdesignern i Inställningar och underhåll.
keywords: layout, fliklayout, lägg till flik, ta bort flik, återställ flik, gruppera fält, Mer flik, lägg till rubrik, lägg till etikett, lägg till avdelare
author: Bergfrid Dias
date: 10.09.2025
version: 10.3.7
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: sv
index: true
redirect_from: /sv/customization/screen-designer/working-with-tabs
---

# Arbeta med flikar

[!include[Krav](../../../includes/req-dev-tools.md)]

Den här guiden förutsätter att du redan [redigerar layouten][2]. Följande avsnitt förklarar hur du organiserar och anpassar flikar i SuperOffice CRM för att skräddarsy gränssnittet efter din organisations behov.

## Lägg till flik

Genom att skapa anpassade flikar kan du gruppera relaterade fält på ett sätt som är meningsfullt för din organisation. Till exempel kan du skapa flikar som är dedikerade till specifika affärsområden, vilket gör informationen lättare att hitta.

**Steg:**

1. Klicka på **Lägg till**. Avsnittet **Fliklayout** öppnas till vänster.

2. Under **Tittel på fliken**, ersätt texten "Ny flik" med det nya fliknamnet.

    Du kan också klicka på <i class="ph ph-translate" aria-label="Translate"></i> för att lägga till knappnamnet på andra språk.

3. Välj antalet kolumner du vill använda i den nya fliken.

## Byt namn på flik

Om du behöver byta namn på fliken senare, välj fliken och gå till **Fliklayout**. Du **kan inte byta namn på standardflikar**.

## Ta bort flik

För att förenkla gränssnittet kan du ta bort flikar som inte längre behövs. En layout måste ha minst en flik. Om det bara finns en flik kvar kan den inte tas bort.

> [!NOTE]
> Om fliken innehåller obligatoriska fält måste du flytta dessa fält till en annan flik innan du tar bort den aktuella.

**Steg:**

1. Välj fliken.
1. Klicka på **Uppgift** och välj **Ta bort flik**.
1. Klicka på **OK** för att bekräfta och stänga dialogrutan.

## Återställ flik

Om du tar bort en flik och senare bestämmer dig för att du behöver den kan du enkelt återställa den.

1. Öppna layouten i redigeringsläge.
1. Klicka på **Uppgift** och välj **Återställ flikar**.

> [!NOTE]
> Den här åtgärden återställer **alla** tidigare borttagna flikar.

## <a id="label"></a>Lägg till rubrik eller avdelare

Etiketter och avdelare hjälper till att organisera fält inom en flik och gör informationen mer läsbar och tillgänglig. Använd etiketter för att skapa rubriker och avdelare för att separera sektioner inom en kolumn.

1. Välj fliken där du vill lägga till elementet.
2. Klicka för att välja avsnittet **Objekt**.
3. För att lägga till en rubrik drar du elementet **Etikett** till layouten.

    * I avsnittet **Inställningar**, ersätt "Ny etikett" med det nya etikettnamnet. Du kan också klicka på <i class="ph ph-translate" aria-label="Translate"></i> bredvid etiketten för att lägga till texten på andra språk.
    * Justera fontformateringen efter behov.

4. För att lägga till en horisontell avdelare, dra elementet **Avdelare** till layouten. Ändra avståndstypen om nödvändigt.

![Skärmdesigner fält och element -screenshot][img2]

## <a id="columns"></a>Gruppera fält i kolumner

Som standard har flikar två kolumner, men du kan justera detta efter behov. Varje flik kan ha 1, 2, 3 eller 4 kolumner beroende på hur mycket information du vill visa.

> [!NOTE]
> Flikar med specifika funktioner, såsom **ERP** och **Anteckning**, stöder inte kolumnanpassning. Gå till **Inställningar och underhåll** > **ERP** för att konfigurera innehållet i ERP-fliken.

**Steg:**

1. Välj fliken där du vill justera kolumnerna.
1. Gå till avsnittet **Fliklayout**.
1. Välj ett av de fyra layoutalternativen.

När du minskar antalet kolumner flyttas fälten från de borttagna kolumnerna till den sista återstående kolumnen. Om du till exempel minskar från tre till två kolumner flyttas fälten i den tredje kolumnen till botten av den andra kolumnen.

Kolumner staplas ovanpå varandra när skärmen är för liten för att visa dem horisontellt.

Om du har en bred skärm kan du använda fler kolumner för att visa mer data samtidigt. Var dock försiktig: användning av fyra kolumner kan minska synligheten för vissa fält. Att dölja etiketter kan hjälpa till att skapa mer utrymme.

> [!TIP]
> Om en flik blir för överbelastad bör du överväga att lägga till ytterligare flikar för att organisera informationen bättre.

## <a id="more"></a>Fliken Mer

Fliken **Mer** innehåller automatiskt alla [anpassade fält][3], ordnade efter rang. Du kan konfigurera dessa fält i denna flik och eventuellt lägga till dem på andra skärmar.

[Användardefinierade fält][5] (udef) och [extra fält][4] skapas på samma sätt som tidigare.

## Relaterat innehåll

* [Arbeta med fält][1]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: edit-layout.md
[3]: ../../../custom-objects/learn/index.md
[4]: ../../../custom-objects/admin/create-extra-field.md
[5]: ../../../custom-objects/admin/add-udef.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/customization/field-settings.png
