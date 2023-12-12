---
uid: help-sv-define-link-actions
title: Definiera länkningsåtgärder
description: I den här guiden lär du dig hur du använder länkar i utskick för att automatisera åtgärder.
author: SuperOffice RnD
so.date: 02.20.2023
keywords: Marknadsföring
so.topic: howto
language: sv
---

# Använd länkar för att automatisera olika åtgärder

[!include[Requirement](includes/req-marketing.md)]

Du kan snabba upp ditt arbete genom att behandla svaren du får från ett utskick med automatiska länkåtgärder.

Tänk dig att ditt utskick blir en stor framgång. Över 500 personer öppnade ditt meddelande och klickade på länkarna du inkluderade. Den uppgift som väntar är att behandla alla dessa svar från dina mottagare. Tänk dig hur lång tid det skulle ta om du var tvungen att göra det manuellt.

I SuperOffice Marknadsföring kan du lägga till åtgärder för dina länkar. Dessa åtgärder utförs när mottagaren klickar på en länk.

![Definiera dina länkningsåtgärder -screenshot][img3]

| Flik | Åtgärd |
|---|---|
| Svar | Lägg till landningssida eller återkopplingstext. |
| Konfigurera fält | Lägg till ett värde till ett extrafält för kundkontakter |
| Intressen | Uppdatera intressen. |
| Urval/projekt | Lägga till eller ta bort kontakt från urval eller projekt. |
| Uppföljning | Skapa en uppföljning (uppgift eller möte) i SuperOffice CRM. |
| Ärende | Skapa ett nytt ärende. |
| Skript | Köra ett skript. |

## Svar

* **Dirigera om till ny webbplats**: Välj detta alternativ om du vill dirigera om mottagarna till en webbplats när de klickar på länken. Ange webbadressen i fältet **URL till ny sida**.

* **Visa återkopplingstext**: Välj detta alternativ om du vill att återkopplingstexten ska visas när mottagaren klickar på länken. Ange texten i fältet nedan.

## Uppdatera din databas

Beroende på mål och vilken uppmaning du använder i ditt utskick kan du uppdatera information i din databas. När en person klickar på länken i ditt utskick gör SuperOffice CRM något av följande:

* Ger ett anpassat svar eller omdirigerar till webbsidan,
* Lägger till en kontakt till ett specifikt projekt eller ett urval,
* Uppdaterar en kontakts intresse,
* Lägger till information i ett fält i kontaktkortet,
* Skapar en uppföljningsaktivitet för en kontakt,
* Skapar ett kundtjänstärende för en kontakt,
* Köra ett skript.

En del av denna information hjälper dig att segmentera din databas på ett ännu bättre sätt, medan annan information hjälper dig att följa upp personer som har visat intresse för ditt meddelande.

## Konfigurera fält

På fliken **Konfigurera fält** kan du ange att ett värde ska läggas till i ett extrafält när mottagaren klickar på länken. Detta kan vara användbart om du vill registrera ytterligare information om de kunder som klickar på länken.

Välj ett fält i listrutan **Ange extrafält** och ange ett värde i fältet **Värde**.

## <a id="interests" />Intressen

Här kan du ange att ett länkklick ska lägga till eller ta bort intressen för kontakten. Du kan t.ex. lägga till intresset "Produktnyheter" om mottagaren klickar på länken "Ja tack! Jag vill veta mer om nya produkter". Alternativt kan du ta bort intresset "Produktnyheter" om mottagaren klickar på länken "Avregistrera sig" i ett nyhetsbrev.

* I listrutan **Ange intresse** kan du välja ett intresse som ska läggas till för kontakterna om de klickar på länken.
* I listrutan **Ta bort intresse** kan du välja ett intresse som ska tas bort för kontakterna om de klickar på länken.

Se även [Ta bort intressen i SuperOffice CRM][1].

## Urval/projekt

Här kan du ange att mottagare som klickar på länken ska läggas till i eller tas bort från urval i SuperOffice Service eller urval eller projekt i SuperOffice CRM. Skriv början av ett namn för att starta snabbsökningen.

## Uppföljning (uppgift/möte)

På fliken **Uppföljning** kan du ange att ett länkklick ska generera uppgifter eller möter i SuperOffice CRM.

1. Markera **Uppföljning** om du vill aktivera denna funktion.

2. **Uppgift/Bokning**: Välj vilken typ av händelse du vill skapa.

3. **Beskrivning**: Ange en beskrivning av händelsen. T.ex. vilket utskick det gäller, vilken länk mottagaren har klickat på och eventuellt hur händelsen ska följas upp.

4. **Projekt**: Här väljer du ett projekt som händelsen ska kopplas till. Skriv början av ett namn för att starta snabbsökningen.

5. **Uppgift**: Välj önskad typ händelse.

6. **Skapad av**: Välj vilken användare som ska vara ansvarig för händelsen eller klicka på knappen **Välj aktiv användare** ![ikon][img1] om du vill välja dig själv.

7. **Tilldela vår kontakt om tillgänglig**: Kryssa i här om händelsen ska tilldelas "vår kontakt" för mottagaren, (den person som är ansvarig för den aktuella kunden).

8. **Standardmottagare**: Välj en standardmottagare som händelsen ska tilldelas eller klicka på knappen **Välj aktiv användare** ![ikon][img1] om du vill välja dig själv.

9. **Varaktighet**: Klicka på knappen **Välj tidsperiod** ![ikon][img2] bredvid detta fält för att ange händelsens varaktighet.

## Ärende

På fliken **Ärende** kan du ange att ett ärende ska skapas i SuperOffice Service för kontakter som klickar på en länk.

1. **Skapa ett nytt ärende**: Kryssa här om du vill registrera ett nytt ärende när kunden klickar på länken.
2. **Titel**: Ange önskad titel på det nya ärendet.
3. **Prioritet**: Välj vilken prioritet ärendet ska ha.
4. **Kategori**: Välj önskad kategori.
5. **Ägare**: Ange önskad ägare för det nya ärendet. Du kan även välja **Tilldelas automatiskt** eller **Otilldelat**.

## Skript

På fliken **Skript** kan du välja ett skript eller makro som ska köras när mottagaren klickar på länken.

1. Välj **Kör skript** om du vill aktivera denna funktion.
2. Klicka på listan **Skript** och välj önskat skript i den lista som visas. Följande variabler finns tillgängliga i skriptet: custId, linkId, shipmentId, linkUrl och linkHits. Du kan också använda variabeln returnUrl om du vill åsidosätta den webbadress som anges i länken.

## Exempel

Manuell uppdatering av 500 kontaktkort tar tid och är egentligen onödigt. Vi kan istället automatisera den här processen med hjälp av automatiska länkåtgärder.

Exempel på automatiska länkåtgärder som används:

* När en mottagare klickar på din uppmaningslänk lägger SuperOffice CRM automatiskt till honom eller henne i ett urval eller projekt.

* SuperOffice CRM kan också automatiskt uppdatera relevant information, till exempel intressen, på kontaktkortet.

Genom att automatisera dessa uppgifter sparar du mycket tid som du annars skulle lägga på att hantera svar. När läsaren klickar på en länk i ditt utskick utför systemet länkåtgärderna åt dig!

Du kan använda den information du har samlat in i detta utskick på flera olika sätt:

* Automatiskt generera ett urval baserat på personer som klickade på en viss länk. Därefter skicka ett riktat uppföljningsutskick till just denna grupp med ett skräddarsytt meddelande.

* Lägga till uppföljningsaktiviteter i dina teammedlemmars kalendrar så att de personligen kan följa upp kontakter som har svarat.

* Generera serviceärenden som ditt kundtjänstteam kan plocka upp för att undersöka ärendet.

<!-- Referenced links -->
[1]: ../../mailing/learn/create/add-unsubscribe-link.md#clear-interests

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-contact.png
[img2]: ../../../../../common/icons/pref-diary.png
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
