---
uid: help-sv-form-field-options
title: Fältalternativ
description: Fältalternativ
keywords: formulär fält, formulärpost, fältalternativ, reCAPTCHA
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: reference
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Fältalternativ

Detta är en översikt över specialalternativ i några av de tillgängliga fälten.

## SuperOffice-poster

* **Ersätt:** Välj det här alternativet om du vill ersätta ett befintligt värde i SuperOffice med ett värde i formuläret. Detta gäller för land, rubrik och herr/fru.

* **Kontakt – medgivande**

  * **Syfte:** Välj varför personen måste ge sitt samtycke.

  * **Visa länk till meddelande om behandling av personuppgifter:** Välj det här alternativet om du vill inkludera länken till integritetspolicyn.

    [Integritetsinställningar][4] för GDPR är definierade i Inställningar och underhåll.

* **Kontakt – prenumeration:** Välj [prenumerationerna][3] som ska visas i formuläret.

* **Företagsnamn: Använd befintligt företag om du hittar det**.

  * Om alternativet är aktiverat: Om en person lämnar in ett formulär med ett företagsnamn som matchar ett företag i SuperOffice läggs personen till automatiskt i företaget som en ny kontakt.

  * Om alternativet är inaktiverat: Både personen och företaget läggs till i SuperOffice.

  > [!NOTE]
  > Oftast är inställningen inaktiverad för att inte slumpmässiga personer ska läggas till i företag som de inte tillhör.

## Formulärposter

* **Textfält:** Ett enda fält med en rad.

* **Textområde:** Ett stort fält med flera rader.

* **Alternativknappar:** Ett urvalsfält där du kan välja ett av flera värden.

  * **Vertikal:** Visar värdena horisontellt eller vertikalt.

  * **Data:** Här anger du värden för varje alternativknapp. Ange ett värde i fältet och klicka på **+**. Upprepa om du vill lägga till ytterligare värden.

* **Kryssruta:** Ett urvalsfält där du kan välja flera värden.

  * **Vertikal:** Visar värdena horisontellt eller vertikalt.

  * **Data:** Här anger du värdena för varje kryssruta. Ange ett värde i fältet och klicka på **+**. Upprepa om du vill lägga till ytterligare värden.

* **Listruta:** Ett urvalsfält där du kan välja ett värde i listan.

  * **Data:** Här anger du listvärdena. Ange ett värde i fältet och klicka på **+**. Upprepa om du vill lägga till ytterligare värden.

* **Dold:** Ett fält som inte syns i det publicerade formuläret. I fältet **Standardvärde** kan du ange en kod, ett projektnamn/nummer eller annan information som ska associeras med formuläret.

* **Datum:** Ett datumfält.

* **Överför fil:** Ett fält för att överföra filer.

  * **Tillåt flera filer:** Välj det här alternativet om du vill tillåta att flera filer överförs.

  * **Maximal filstorlek (kb):** Ange en filstorlek i kilobyte för att förhindra att en stor fil överförs. Lämna fältet tomt om du vill tillåta alla filstorlekar.

  * **Tillåtna filtyper:** Ange de filtyper som kan överföras. Använd formaten *jpg, gif, png, bmp* (kommaseparerad, inget blandsteg). Lämna fältet tomt om du vill tillåta alla filtyper.

* **Bedömning:** Ett fält där kunderna kan betygsätta till exempel servicen med hjälp av olika klassificeringstyper (stjärnor, tärningar, 1–10-skala och liknande).

* **Google reCAPTCHA:** [ReCAPTCHA-funktionen][1] (kryssrutan "I'm not a robot") är en gratis Google-tjänst som säkerställer att endast riktiga användare kan skicka in webbformulär. Det förhindrar spam och automatiserade robotar från att sabotera din datainsamling.

## Visa poster

* **Textblock:** Ange en text som ska visas i formuläret, t.ex. en kort introduktion eller detaljerad beskrivning.

    [!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

* **Bild:** Lägg till en bild i formuläret. Klicka på länken om du vill välja en bild eller dra och släppa en bild i fältet **Bild**. Använd alternativknapparna **Position** och placera bilden i formuläret.

* **Avsnitt:** Lägg till ett avsnitt mellan fälten för att [skapa ett flersidigt formulär][2]. Praktiskt om ditt formulär innehåller många fält och du vill slippa rulla.

<!-- Referenced links -->
[1]: recaptcha.md
[2]: create.md#multi-page
[3]: ../../recipients/learn/manage-email-subscriptions.md
[4]: ../../../security/privacy/admin/add-purpose.md
