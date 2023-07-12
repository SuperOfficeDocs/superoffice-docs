---
uid: help-sv-mailing-add-unsubscribe-link
title: Lägga in länk för avregistrering
description: När du skickar ett utskick måste mottagarna ges möjlighet att avregistrera sig. Lär dig hur du kan lägga till en länk för avregistrering i ditt utskick i den här guiden.
author: SuperOffice RnD
so.date: 02.16.2023
keywords: marknadsföring
so.topic: howto
language: sv
---

# Lägg till prenumerationslänkar

När du t.ex. skickar ut ett nyhetsbrev måste du ge mottagarna en möjlighet att avregistrera sig eller att ändra på sina prenumerationsinställningar. Det gör du genom att lägga in en länk som mottagaren kan klicka på. Sådana länkar placeras vanligen längst ned i ett meddelande (i sidfoten).

Avregistreringslänken placeras vanligen längst ned i ett meddelande. Om du använder en av våra utskicksmallar är den här länken redan tillagd.

Du bestämmer var den här avregistreringslänken visas och hur den är formulerad samt vad som händer när man klickar på den. Till exempel kan du helt enkelt ta läsaren till deras "avregistrerings"-sida där de kan hantera sina preferenser eller de kan automatiskt välja bort alla dina utskick.

![Från symbolen Infoga/redigera länk klickar du på Speciallänkar och lägger till avregistreringslänken -screenshot][img4]

## I dra och släpp-redigeraren

1. Gå till meddelandets innehåll och klicka på avsnittet där du vill infoga länken.
    eller
    Gå till avsnittet **Block** och klicka och dra en sidfot till slutet på meddelandet.

2. Skriv och markera texten som mottagaren måste klicka på, t.ex. till "Klicka här om du vill avregistrera dig" eller "Klicka här om du vill hantera dina prenumerationer".

3. Klicka på knappen **infoga/redigera länk** (![ikon][img3]) i verktygsfältet.

4. Klicka på **Speciallänkar** och välj ett av alternativen nedan:
    * **Hantera prenumerationer**: Infogar en länk till en webbsida där mottagarna kan välja vilka utskickstyper de vill ta emot. Länken är giltig i 21 dagar som standard.
    * **Avsluta prenumeration från denna typ av e-post**: Infogar en länk till en sida där du kan avsluta prenumeration av denna utskickstyp. Mottagaren kan fortfarande ta emot utskick av andra typer. Utskickstyp väljer du i Steg 1: Konfiguration.

5. Klicka på **Spara**. Länken läggs in i meddelandet.

## I den gamla redigeraren

1. Gå till innehållet i meddelandet och [redigera ett avsnitt][1] för att öppna redigeringsfönstret.
    Du kan också klicka på ![ikon][img1] knappen **Lägg till ett nytt avsnitt** om du vill lägga till ett avsnitt längst ned.
2. Välj fliken **Brödtext**.
3. Placera muspekaren på det ställe där du vill infoga länken.
4. Klicka på ![ikon][img2] knappen **Registreringslänkar** i verktygsfältet.
5. I dialogrutan **Ställ in avregistrerings-/registreringslänk** ändrar du texten i fältet **Länktext** vid behov: t.ex. till "Klicka här om du vill avregistrera dig" eller "Klicka här om du vill hantera dina prenumerationer".
6. Välj ett av följande alternativ i fältet **Ställ in avregistrerings-/registreringslänk**:
    * **Hantera prenumerationer**: Infogar en länk till en webbsida där mottagarna kan välja vilka utskickstyper de vill ta emot. Länken är giltig i 21 dagar som standard.
    * **Avsluta prenumeration från denna typ av e-post**: Infogar en länk till en sida där du kan avsluta prenumeration av denna utskickstyp. Mottagaren kan fortfarande ta emot utskick av andra typer. Utskickstyp väljer du i Steg 1: Konfiguration.
7. Klicka på **OK**. Länken läggs in i meddelandet.

## Vad händer nu?

Baserad på feedback från mottagarna uppdateras prenumerationsinställningarna på fliken **Intressen** på kontaktkortet i SuperOffice CRM.

> [!NOTE]
> Det innebär att kunden inte längre kommer att få denna utskickstyp från SuperOffice Marknadsföring, oavsett vilken mottagarlista som används för utskicket. Det kanske inte är så du vill ha det med tanke på dina framtida marknadsföring. [Vilka alternativ har jag?][2].
>
> Du kan dock åsidosätta inställningarna "inget samtycke/ingen prenumeration" från **Alternativ** i den nedre delen av fönstret **Mottagare** (se Steg 4: Mottagare).

## <a id="clear-interests" />Ta bort intressen i SuperOffice CRM

I SuperOffice CRM kan du registrera intressen (t.ex. "Månatligt nyhetsbrev") för kontakterna. Dessa intressen kan användas som utgångspunkt för olika typer av utskick. I stället för att använda avregistrering kan du enkelt ta bort ett visst intresse, t.ex. månatligt nyhetsbrev, för kunder som inte vill ha nyhetsbrevet.

Du gör det genom att [skapa en länk som tar bort det aktuella intresset][4] för de mottagare som klickar på länken. Samma metod kan användas för att registrera intressen.

<!-- Referenced links -->
[1]: ../../../learn/edit-paragraph.md
[2]: ../../../tracked-links/learn/examples.md
[4]: ../../../tracked-links/learn/define-link-actions.md#interests

<!-- Referenced images -->
[img3]: ../../../../../media/icons/marketing-and-forms/link.png
[img1]: ../../../../../media/icons/marketing-and-forms/new-para.jpg
[img2]: ../../../../../media/icons/marketing-and-forms/link.png
[img4]: ../../../../../media/loc/en/marketing/insert-edit-link-unsubscribe-mailing.png
