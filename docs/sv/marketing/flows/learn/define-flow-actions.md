---
uid: help-sv-flow-actions
title: Definiera flödesåtgärder
description: Definiera flödesåtgärder
keywords: flöde, automatisering, flödesåtgärd, kör skript, fördela till ägare
author: Bergfrid Dias
date: 09.26.2025
version: 11.3
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Definiera flödesåtgärder

## Tillgängliga åtgärder

* [Skicka meddelande](#send)
* [Uppdatera deltagare](#update)
* [Skapa aktivitet](#create)
* [Intern handling](#internal)

> [!NOTE]
> När du lägger till eller uppdaterar flödesåtgärder, kom ihåg att formulär och spårade länkar också har åtgärder. Se till att det inte finns några dubbla eller motsägande åtgärder. Vi rekommenderar att du sammanfogar alla åtgärder på ett ställe, antingen i formuläret eller i flödet.

## <a id="send"></a>Skicka meddelande

Saker att tänka på:

* Hur ofta ska vi skicka ny information?
* Ska nästa e-post vara baserad på kontakters engagemang, när en kontakt fyller i ett formulär eller klickar på en spårad länk?
* Ska alla kontakter få samma innehåll?

### Skicka e-post (utskick)

Ett e-poststeg används för att skicka ett e-postmeddelande till en aktiv flödesdeltagare. Du kan välja en redan förberedd e-post eller lägga till en ny.

1. Dra **Skicka e-post**-rutan från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.

    > [!NOTE]
    > När du lägger till ett e-poststeg måste du ange e-postinställningar innan du startar flödet. Du ser en varningsikon (som i skärmdumpen nedan) om dessa inställningar saknas. Du kan fortfarande spara flödet! Fortsätt utforma flödet och återkom till e-postinställningarna senare.

1. Välj ett av alternativen:

    * Skapa ny e-post för detta steg. Ange en namn och klicka på **Skapa**. Detta öppnar arbetsflödet for utskikt på **Mall**-steget.
    * Välj befintlig e-post för detta steg. Klicka för att välja flödesinnehåll.

1. Ange ämnet för e-posten. Kontaktvariabler (kopplingsfält) är tillgängliga.

1. Välj eventuellt att lägga till en eller flera bilagor (max 25MB totalt).

![Lägg till e-poststeg i flöde -screenshot][img1]

> [!NOTE]
> Att skapa en ny e-post som flödesinnehåll är endast möjligt från flödets användargränssnitt.

### Skicka SMS

Ett SMS-steg används för att skicka ett SMS till en aktiv flödesdeltagare.

Deltagare i flödet utan ett registrerat telefonnummer kan antingen hoppa över steget (fortsätt till nästa steg) eller lämna flödet, beroende på steginställningarna.

1. Dra **Skicka SMS**-rutan från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.

1. Ange avsändaren och SMS-texten. Kontaktvariabler (kopplingsfält) är tillgängliga.

1. Välj eventuellt **Avsluta flöde om inget mobilnummer är registrerat** och välj hur du vill hantera kontakter som inte kan ta emot SMS.

> [!TIP]
> Om du vill skicka endast ett SMS, håll koll på räknaren i det nedre högra hörnet. Om antalet tecken överstiger 160 skickas meddelandet som flera SMS-segment och ytterligare avgifter kan tillkomma. Vi rekommenderar att du håller meddelandet kort och informativt.

## <a id="update"></a>Uppdatera deltagare

* Uppdatera kontakt
* Lägg till i urval/projekt
* Ta bort från urval/projekt

### Uppdatera kontakt

Använd detta steg för att uppdatera eller komplettera relevant data om en kontakt eller deras företag innan deltagaren flyttas till nästa steg i flödet.

1. Dra **Uppdatera kontakt**-rutan från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.
1. Välj ett fält att uppdatera i **Fält**-kolumnen. Du kan också skriva namnet på fältet. När du skriver varje bokstav visas relevanta matchningar nedan.
1. Välj en åtgärd i **Åtgärd**-kolumnen. De [tillgängliga åtgärderna][11] beror på vilken typ av fält du valde i föregående steg.
1. Ange nya värden om det är tillämpligt.
1. För att uppdatera ytterligare fält, klicka på **Lägg till** och upprepa steg 2-4.
1. Se till att alla fält du vill uppdatera—och bara dessa—har en bock. Du kan klicka på den röda X:et för att ta bort överflödiga rader.

![Uppdatera kontaktuppgifter i flöde -screenshot][img2]

Detta fungerar på liknande sätt som [massuppdatering][11].

### Lägg till i urval/projekt

Håll koll på de som anmälde sig eller var engagerade, eller för att hålla koll och följa upp senare. Kontakten läggs till som medlem i det angivna urvalet och/eller projektet.

1. Dra **Lägg till i urval/projekt**-rutan från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.
1. Lägg till kontakt i statiskt urval: välj ett statiskt kontakturval från listan eller klicka på **Nytt** för att skapa ett nytt.

1. Lägg till kontakt som projektmedlem: välj ett projekt från listan.

> [!TIP]
> Börja skriv för att söka i listan.

### Ta bort från urval/projekt

Kontakten tas bort som medlem från det angivna urvalet och/eller projektet.

Detta steg är liknande **Lägg till i urval/projekt**.

### <a id="distribute"></a>Distribuera till ägare

Fördela kontakter jämnt mellan valda medarbetare eller medlemmar i en angiven grupp. Används för att automatiskt tilldela nya kontakter till ett team.

1. Dra rutan **Distribuera till ägare** från stegalternativen och släpp den på en ledig plats i flödesschemat.
1. Välj en eller flera medarbetare eller en primärgrupp som ska ta emot kontakterna.
1. Valfritt: Avmarkera **Lägg bara till ny ägare om kontakten för närvarande inte är tilldelad** för att skriva över befintliga kontaktägare.
1. Valfritt: Ange en reserv under **Om ingen är tillgänglig, tilldela kontakter till**.

Den nya ägaren [får ett meddelande][10] för varje tilldelad kontakt.

## <a id="create"></a>Skapa aktivitet

Flödet kan automatiskt skapa uppföljningar, ärenden och/eller försäljning för kontakten enligt inställningarna. Genom att ansluta CRM-aktiviteter och meddelanden kan din organisation överbrygga gapet mellan marknadsföring och försäljning. Att skapa aktiviteter låter dig också fokusera på kontakter som är engagerade.

### Skapa uppföljning

Exempel: Ställ in en gratis konsultation vid första tillgängliga tid i vår kontakts dagbok. De kommer att meddelas i **Meddelanden**-panelen.

1. Dra **Skapa uppföljning**-rutan från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.
1. Ange en rubrik.
1. Välj en uppföljningstyp.
1. Ange ett förfallodatum för en att-göra-uppgift eller reservera första tillgängliga tid för ett möte.
1. Överför till: välj vem som ska följa upp deltagaren: "vår kontaktperson," "vår supportansvarige," eller en specifik namngiven kollega.
1. Ange eventuellt annan information. För detaljer, se [listan över steginställningar][1] och [hur man skapar en uppföljning][12].

### Skapa ärende

1. Dra **Skapa ärende**-rutan från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.
1. Ange en beskrivande **rubrik**.
1. Välj en [ärendestyp][14], vilket kommer att påverka standardvärden och tillgängliga statusar och prioriteringar.
1. Välj [status][15], [kategori][16], och [prioritet][17].
1. **Ägare:**
    * För att tilldela ärendet till en specifik person, välj det namn du behöver.
    * **Automatiskt tilldelad:** Om du väljer det här alternativet tilldelar systemet ärendet enligt gällande tilldelningsregler.
    * **Ej tilldelad:** Du kan också välja att inte tilldela ärendet. Medlemmarna i den relevanta kategorin blir då ansvariga för att hantera ärendet.
1. Skriv det faktiska meddelandet du vill lägga till i ärendet.

För mer information, se [listan över steginställningar][1] och [hur man skapar ett ärende][13].

### Skapa försäljning

När en kontakt når detta steg är kontakten mogen och har visat tecken på att vara en försäljningsmöjlighet.

1. Dra **Skapa försäljning**-rutan från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.
1. Ange en beskrivande **rubrik**.
1. Välj en försäljningstyp, vilket kommer att påverka standardvärden och tillgängliga faser.
1. Ange den nödvändiga informationen i de andra fälten.
1. Ägare: Välj vem som ska följa upp denna lead: "vår kontaktperson," "vår supportansvarige," eller en specifik namngiven kollega.

    > [!NOTE]
    > Lägg till en uppföljning också, för att meddela försäljningens ägare om denna nya möjlighet.

För mer information, se [listan över steginställningar][1] och [hur man skapar en försäljning][18].

## <a id="internal"></a>Intern handling

### Kör skript

Kör anpassad affärslogik genom att aktivera ett CRM-skript som en del av flödet.

1. Dra **Kör skript**-rutan från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.
1. Välj ett [CRMSkript][20] från listan.

> [!NOTE]
> Deltagaren kommer att gå vidare till nästa steg omedelbart efter att skriptet har aktiverats, utan att vänta på resultatet.

### Meddela via e-post

Skicka ett meddelande via e-post till en specifik person som en del av flödet.

1. Dra rutan **Meddela via e-post** från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.
1. Ange mottagaren (**Till:**).
1. Ange **ämnet** för e-posten.
1. Ange meddelandet du vill skicka.

Kontaktvariabler (kopplingsfält) är tillgängliga.

### Meddela via SMS

Skicka ett meddelande till en specifik person som en del av flödet.

1. Dra rutan **Meddela via SMS** från stegmenyn och släpp den i ett tillgängligt fält i flödesschemat.
2. Ange mottagaren (**Till:**).
3. Ange meddelandet du vill skicka. Kontaktvariabler (kopplingsfält) är tillgängliga.

Om inget mobilnummer är angett för de valda kontakterna kommer inget SMS att tas emot i andra änden.

## Flödesåtgärd vs. formuläråtgärd

Flera åtgärdstyper är möjliga både som formuläråtgärd och som flödesteg​.

En [formuläråtgärd][6] kan:

* Lägg till kontakt i urval och/eller projekt
* Lägg till intresse för kontakt
* Ange standardkategori och affär för nya kontakter och företag
* Skapa en ärende
* Skicka ett svarsbrev på formulär till kontakten

## Flödesåtgärd vs. länkåtgärd

En [länkåtgärd][7] kan:

* Lägg till kontakt i urval och/eller projekt
* Uppdatera intressen
* Lägg till ett värde i ett [extrafält][19] på kontakt
* Skapa en ärende
* Skapa en uppföljning

<!-- Referenced links -->
[1]: step-settings.md
[6]: ../../forms/learn/define-form-actions.md
[7]: ../../tracked-links/learn/define-link-actions.md
[10]: ../../../learn/basics/notifications.md
[11]: ../../../learn/basics/bulk-update.md
[12]: ../../../diary/learn/create-follow-up.md
[13]: ../../../request/learn/create.md
[14]: ../../../request/admin/type/index.md
[15]: ../../../request/admin/status/index.md
[16]: ../../../request/admin/category/index.md
[17]: ../../../request/admin/priority/index.md
[18]: ../../../sale/learn/create.md
[19]: ../../../custom-objects/learn/extra-field.md
[20]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-send-email-new.png
[img2]: ../../../../media/loc/en/marketing/flow-update-contact.png
