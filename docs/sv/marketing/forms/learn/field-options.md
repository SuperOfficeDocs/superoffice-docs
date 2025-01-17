---
uid: help-sv-form-field-options
title: Fältalternativ
description: Fältalternativ
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formulär
so.topic: reference
language: sv
---

# Fältalternativ

Detta är en översikt över specialalternativ i några av de tillgängliga fälten.

## SuperOffice-poster

* **Ersätt**: Välj det här alternativet om du vill ersätta ett befintligt värde i SuperOffice med ett värde i formuläret. Detta gäller för land, rubrik och herr/fru.

* **Kontakt – medgivande**

  * **Syfte**: Välj varför personen måste ge sitt samtycke. Godkännandetexten och beskrivning anges i Inställningar och underhåll.

  * **Visa länk till meddelande om behandling av personuppgifter**: Välj det här alternativet om du vill inkludera länken till integritetspolicyn.[!include[SM](../../../learn/includes/as-defined-sm.md)]

* **Kontakt – prenumeration**: Välj prenumerationerna som ska visas i formuläret.

* **Företagsnamn: Använd befintligt företag om du hittar det**.

  * Om alternativet är aktiverat: Om en person lämnar in ett formulär med ett företagsnamn som matchar ett företag i SuperOffice läggs personen till automatiskt i företaget som en ny kontakt.

  * Om alternativet är inaktiverat: Både personen och företaget läggs till i SuperOffice.

  > [!NOTE]
  > Oftast är inställningen inaktiverad för att inte slumpmässiga personer ska läggas till i företag som de inte tillhör.

## Formulärposter

* **Textfält**: Ett enda fält med en rad.

* **Textområde**: Ett stort fält med flera rader.

* **Alternativknappar**: Ett urvalsfält där du kan välja ett av flera värden.

  * **Vertikal**: Visar värdena horisontellt eller vertikalt.

  * **Data**: Här anger du värden för varje alternativknapp. Ange ett värde i fältet och klicka på knappen Lägg till ![ikon][img1]. Upprepa om du vill lägga till ytterligare värden.

* **Kryssruta**: Ett urvalsfält där du kan välja flera värden.

  * **Vertikal**: Visar värdena horisontellt eller vertikalt.

  * **Data**: Här anger du värdena för varje kryssruta. Ange ett värde i fältet och klicka på knappen Lägg till ![ikon][img1]. Upprepa om du vill lägga till ytterligare värden.

* **Listruta**: Ett urvalsfält där du kan välja ett värde i listan.

  * **Data**: Här anger du listvärdena. Ange ett värde i fältet och klicka på knappen Lägg till ![ikon][img1]. Upprepa om du vill lägga till ytterligare värden.

* **Dold**: Ett fält som inte syns i det publicerade formuläret. I fältet **Standardvärde** kan du ange en kod, ett projektnamn/nummer eller annan information som ska associeras med formuläret.

* **Datum**: Ett datumfält.

* **Överför fil**: Ett fält för att överföra filer.

  * **Tillåt flera filer**: Välj det här alternativet om du vill tillåta att flera filer överförs.

  * **Maximal filstorlek (kb)**: Ange en filstorlek i kilobyte för att förhindra att en stor fil överförs. Lämna fältet tomt om du vill tillåta alla filstorlekar.

  * **Tillåtna filtyper**: Ange de filtyper som kan överföras. Använd formaten *jpg, gif, png, bmp* (kommaseparerad, inget blandsteg). Lämna fältet tomt om du vill tillåta alla filtyper.

* **Bedömning**: Ett fält där kunderna kan betygsätta till exempel servicen med hjälp av olika klassificeringstyper (stjärnor, tärningar, 1–10-skala och liknande).

* **Google reCAPTCHA**: [ReCAPTCHA-funktionen][1] (kryssrutan "I'm not a robot" är en gratis Google-tjänst som säkerställer att endast riktiga användare kan skicka in webbformulär. Det förhindrar spam och automatiserade robotar från att sabotera din datainsamling.

## Visa poster

* **Textblock**: Ange en text som ska visas i formuläret, t.ex. en kort introduktion eller detaljerad beskrivning. Klicka på **Visa/dölj verktygsfält** ![ikon][img2] om du vill visa formateringsalternativen för texten. Klicka på **Öppna textredigerare i dialogruta** ![ikon][img3] om du vill redigera texten i en större redigerare.

* **Bild**: Lägg till en bild i formuläret. Klicka på länken om du vill välja en bild eller dra och släppa en bild i fältet **Bild**. Använd alternativknapparna **Position** och placera bilden i formuläret.

* **Avsnitt**: Lägg till ett avsnitt mellan fälten för att [skapa ett flersidigt formulär][2]. Praktiskt om ditt formulär innehåller många fält och du vill slippa rulla.

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/marketing/forms/recaptcha.html
[2]: create.md#multi-page

<!-- Referenced images -->
[img1]: ../../../../../common/icons/add-icon.png
[img2]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img3]: ../../../../../common/icons/pop-out-icon.png
