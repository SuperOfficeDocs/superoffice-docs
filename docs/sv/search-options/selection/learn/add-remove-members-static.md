---
uid: help-sv-selection-static-members
title: Lägga till och ta bort medlemmar i statiska urval
description: Hur man hanterar medlemmar i statiska urval.
keywords: urval, deltagare
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/search-options/selection/learn/update/add-remove-members-static
---

# Lägga till och ta bort medlemmar i statiska urval

När du har skapat ett urval, kan du alltid lägga till fler medlemmar i det urvalet. Detta kan göras från valfri lista som innehåller de relevanta posterna, t.ex. sökresultat och detaljkort.

> [!TIP]
> Du kan också [kopiera medlemmar från ett annat urval][3].

Det finns speciella regler för urvalsmedlemmar.

* Medlemmar är alltid unika, vilket innebär att samma post inte kan anges två gånger i samma urval.

* Det går inte att registrera samma företag både med och utan kontakt. Detta innebär att om ett företag är registrerat utan kontakt och du senare försöker registrera företaget med en kontakt, tas den första förekomsten bort.

## Lägg till medlemmar till ett öppet statiskt urval

1. Klicka på **Lägg till medlemmar**-knappen under medlemslistan.

2. I dialogrutan **Lägg till alla medlemmar som matchar** [redigerar du kriterierna][2].

3. Klicka på **OK**. Matchande medlemmar läggs till i urvalet.

## Lägg till medlemmar i befintligt statiskt urval

Använd det här alternativet för att lägga till de valda posterna till ett befintligt statiskt urval.

1. Gå till en lista med de poster som du vill lägga till i ett urval (sökresultat eller ett detaljkort).

2. Välj en eller flera poster på listan.

    För att lägga till flera poster, använder du **Shift** eller **Ctrl** + klick.

3. Högerklicka på posterna och välj **Lägg till i urval** i menyn som visas.

4. Välj **Lägg till i befintligt statiskt urval**. Ange önskat urval genom att klicka på pilen och välja önskat urval i listrutan som visas, genom att skriva in hela eller början på namnet på urvalet.

    > [!NOTE]
    > Listan över urval är begränsad till:
    >
    > * Befintliga *statiska* urval (inte dynamiska urval eller kombinerade urval)
    >
    > * Urval som matchar posterna du lägger till (om du väljer försäljning, visas endast urval för försäljning)
    >
    > Om listan är tom, finns det inga urval av denna typ.

5. Klicka på **OK**. Urvalet uppdateras.

## Lägg till medlemmar i ett nytt statiskt urval

1. Gå till en lista med de poster som du vill lägga till i ett urval (sökresultat eller ett detaljkort).

2. Välj en eller flera poster på listan.

    > [!NOTE]
    > För att lägga till flera poster, använder du **Shift** eller **Ctrl** + klick.

3. Högerklicka på posterna och välj **Lägg till i urval** i menyn som visas.

4. Välj **Lägg till i nytt statiskt urval**.

5. I fältet **Urvalsnamn** anger du namnet på urvalet. Det här fältet måste fyllas i.

6. Välj en urvalstyp i fältet **Kategori**. Klicka på pilen om du vill visa en lista över fördefinierade alternativ.

7. Under **Synlig för** väljer du om urvalet ska vara synligt för alla, bara för dig eller för alla i en användargrupp som ägaren tillhör.

8. För urval med företag/kontakter: Om du markerar kryssrutan **Företaget är unikt** kommer bara en post att läggas till för varje unikt företag bland de valda kontakterna. Om du markerar 10 kontakter som tillhör totalt 3 företag, kommer alltså bara de 3 företagen att läggas till i urvalet.

9. Klicka på **OK**. Urvalet uppdateras.

## <a id="remove"></a>Ta bort medlemmar med hjälp av sökkriterier

1. Öppna ett statiskt urval. Till exempel, [använd fönstret Sök][2].

1. Klicka på knappen **Ta bort medlemmar** på fliken.

1. I dialogrutan **Ta bort alla medlemmar som matchar**, ange önskade [kriterier][5].

1. Klicka på **OK**. Alla medlemmar som uppfyller sökkriterierna tas bort.

## Ta bort en specifik medlem

1. Öppna ett statiskt urval.

1. Markera en eller flera poster i medlemslistan.

1. Högerklicka och välj **ta bort**. Medlemmarna tas omedelbart bort från det aktiva urvalet.

## Relaterat innhåll

* [Kopiera till urval][3]
* [Utföra uppgifter för urval][4]

<!-- Referenced links -->
[2]: ../../learn/find-screen.md
[5]: ../../learn/search-criteria.md
[3]: copy-members-to.md
[4]: ../../../learn/getting-started/index.md

<!-- Referenced images -->
