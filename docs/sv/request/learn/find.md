---
uid: help-sv-request-find
title: Söka efter ett ärende
description: I den här guiden förklarar vi hur du söker efter ärenden i SuperOffice
author: Bergfrid Dias
so.date: 03.14.2023
keywords: ärende, söka, sök
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: sv
---

# Söka efter ett ärende

Som handläggare inom kundsupport får du många inkommande samtal och e-postmeddelanden om väntande eller gamla kundförfrågningar. Det är därför det är viktigt att veta hur du kan söka efter ett enskilt ärenden eller grupper med ärenden så snabbt som möjligt.

Gör något av följande:

* Använda listor, som i själva verket är fördefinierade sökningar.
* Använd sökskärmen för ärenden i Sök ärende.
* Använd [fritextsökningen][3] i det övre högra hörnet.
* Använd [dashboards][9].
* Använd [urval][10] för ärenden.
* Använd [navigatorns][12] sökning på Ärenden.
* Använd [Sök][11] i det övre fältet, välj en av de typiska sökningarna eller lägg till önskade kriterier.

## <a id="list" />Använda listor

Det enklaste sättet att söka efter ärenden är att använda sökfältet som finns i menyn för den första fliken **Sök ärenden** i fönstret Ärenden.

![Söka efter ärenden -screenshot][img3]

* **Senaste ärenden**: Visar de senaste ärendena som registrerades i systemet. Denna lista innehåller endast ärenden i de kategorier som du är medlem i om så anges i dina inställningar.

* **Egna aktiva ärenden**: Visar ärenden som tillhör dig och som har status **Öppet**. Denna lista innehåller de ärenden som du är ansvarig för, och det är därför den skärm du kommer arbeta med mest.

* **Otilldelade ärenden**: En lista över ärenden som ingen har tilldelats ansvar för. För att [ta över ansvaret för ett av ärendena][6] är det viktigt att du gör det genom att klicka på **Ta över ärende**. Annars finns det risk för att andra besvarar samma ärende samtidigt.

* **Mina favoriter**: Visar de ärenden du har sparat som favoriter.

* **Hämta nästa i kön**: Om [kösystemet är skapat][5] för ditt företag kan du klicka på detta alternativ om du vill hämta nästa otilldelade ärende i kön för den kategori som du tillhör.

* **Ärendeurval**: Ditt eget urval av ärenden kommer visas i menyn.

### Visa bara egna kategorier

1. Välj ![ikon][img2] **Personliga inställningar** &gt; **Inställningar**.
1. Välj gruppen **Ärende**.
1. Ställ in **Visa bara egna kategorier** på ja.
1. Klicka på **Spara**.

### Anpassa sökkriterier

Alla dessa listor är i praktiken fördefinierade sökningar, och du kan anpassa sökkriterierna om du vill:

1. Klicka på fliken **Sök ärenden** i sidhuvudet in fönstret Ärenden.
1. [Justera kriterierna][4].
1. Klicka på **Sök** i det nedre högra hörnet för att påbörja sökningen med de nya sökkriterierna. Om du väljer ett av ärendena i listan visas dess innehåll i förhandsgranskningen till höger. Om du väljer ett av ärendena i listan visas dess innehåll i [förhandsgranskningen](#preview).
1. Om du vill behålla sökningen kan du spara sökresultatet som ett [urval][13] och gå tillbaka till listan när du vill.

> [!TIP]
> Om du vill återställa standardinställningarna väljer du **Återställ till standard**.
>
> Om du vill rensa alla dina kriterier, väljer du **Ta bort allt**.

### <a id="result" />Sökresultat

Resultatet innehåller en lista över ärenden som motsvarar de kriterier som har angetts ovan. Här kan du göra följande:

* Du kan sortera ärendena genom att klicka på önskad kolumnrubrik.
* Du kan markera en rad för att visa innehållet i det aktuella ärendet i förhandsgranskningen.
* Du kan öppna ett ärende genom att dubbelklicka på önskad rad.
* I det nedre vänstra hörnet klickar du på knappen för att **Visa/Dölja förhandsgranskning**.
* Med knappen ![ikon][img1] **Uppgift** i det nedre vänstra hörnet kan du öppna olika uppgifter att köra på valda ärenden.

> [!TIP]
> Statusen **Öppen** i kombination med kolumnen **Läst** ger en översikt över om ärendet var **Läst av ägare**, **Ny information** eller **Inte läst av ägare**.

I listans sidfot kan du klicka på knappen ![ikon][img1] **Uppgift** för att få åtkomst till följande alternativ:

* **Exportera till Excel**: Klicka här om du vill exportera listan under **Resultat** till en Excel-fil.

* **Massuppdatering**: Om du väljer en eller flera ärenden i listan kan du klicka på detta alternativ och välja en åtgärd som du vill utföra på alla valda ärenden samtidigt. Du kan t.ex. välja att [lägga till samma meddelande i flera ärenden][8], [vidarebefordra flera ärenden][7] eller ta bort flera ärenden i en enda åtgärd.

### <a id="preview" />Förhandsgranskning

På denna del av skärmen visas innehållet i det ärende som är markerat under **Sökresultat**. Du har samma alternativ som när du [behandlar ärenden][6].

Om förhandsgranskningsdelen inte visas, klickar du på **Visa förhandsgranskning** längst ned på skärmen.

## Relaterade ämnen

* [Använda taggar i ärenden][1]
* [Fönstret Sök][11]
* [Använda navigatorns sökning][12]
* [Skapa urval][13]
* [Hämta nästa i kön][5]

<!-- Referenced links -->
[1]: tags.md
[3]: ../../search-options/learn/freetext-search.md
[4]: ../../search-options/learn/search-criteria.md
[5]: next-in-queue.md
[6]: howto/accept.md
[7]: howto/forward.md
[8]: howto/reply.md
[9]: ../../dashboard/learn/index.md
[10]: ../../search-options/selection/learn/index.md
[11]: ../../search-options/learn/find-screen.md
[12]: ../../learn/getting-started/main-screen/navigator.md#navigator
[13]: ../../search-options/selection/learn/create/tutorial.yml

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/loc/en/request/find-requests.png
