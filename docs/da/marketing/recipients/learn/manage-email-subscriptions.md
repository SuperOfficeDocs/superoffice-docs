---
uid: help-da-mailing-manage-subscriptions
title: Administrere e-mail-abonnementer
description: Funktionerne til administration af abonnementer i SuperOffice CRM giver dig mulighed for at dokumentere, hvilken type indhold dine kontakter ønsker at modtage fra dig.
keywords: marketing
author: Bergfrid Dias
date: 02.09.2024
version: 10
topic: concept
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Administrere e-mail-abonnementer

SuperOffice CRM's funktioner til abonnementsstyring giver dine kontakter mulighed for at specificere det indhold, de ønsker at modtage. Dette er knyttet til Samtykkeadministration, da nogle jurisdiktioner kræver dokumenteret samtykke, før e-markedsføringsmails kan sendes.

Disse funktioner forhindrer afsendelse af e-marketingmeddelelser til dem, der ikke har givet samtykke, og sikrer, at dine kontakter bevarer kontrol over deres e-mailabonnementer. Fra det øjeblik de tilføjes din SuperOffice-database, kan kontakter specificere deres mailpræferencer. De kan også justere disse præferencer via afmeldingslinket i hver e-mail.

Ved at give kunderne mulighed for at administrere deres abonnementer kan du forbedre din e-mail åbningsrate og styrke din markedsføringssucces.

## Interesser i SuperOffice CRM

Du kan registrere interesser (f.eks. "månedligt nyhedsbrev") for dine kontakter. I stedet for at bruge afmelding kan du [oprette et link der fjerner den relevante interesse][5] hos de kunder, der ikke ønsker at modtage det. Den samme metode kan bruges til at registrere interesser.

## Din målliste

Når du [opretter din målliste][1] til din næste mailudsendelse, kan du foretage et valg baseret på den abonnementstype, du vil anvende. Dermed vil SuperOffice CRM kun tilføje kontakter, der har sagt "ja" til denne type abonnement.

## Vælge abonnementstype

Der er flere måder at oprette din målliste på ved hjælp af en udvælgelse. Det betyder, at du måske ikke altid bruger abonnementstypen som udvælgelseskriterium. Når du gør det, er det nemt at glemme, at du har tilføjet de personer, der sagde nej til at modtage dine mails, til din målliste.

For at forhindre, at du sender mails til personer, som ikke ønsker at modtage dem, vil udsendelsesguiden i trin 1 bede dig om at tilføje den abonnementstype, du ønsker at sende til: Opsætning.

![I opsætningstrinnet vælger du, hvilken type mail du vil sende ud. -screenshot][img1]

Når du har angivet typen af mailudsendelse, vil SuperOffice CRM tjekke hver enkelt kontakt, du tilføjer som modtager, for at se, om de har givet dig deres samtykke til at sende dem denne type udsendelse.

I mailudsendelsesguidens trin 4, der hedder Modtagere, kan du se præcis, hvem der har givet dig deres samtykke, og hvem der ikke har. Når funktionen Beskyttelse af personoplysninger for E-Marketing er slået til, filtrerer SuperOffice CRM automatisk alle modtagere fra, der ikke har tilmeldt sig baseret på deres samtykke til e-marketing og aktive abonnementer.

> [!TIP]
> Der er et afkrydsningsfelt til Tilsidesæt samtykke og abonnement, hvis det er meget vigtigt at få mailudsendelsen ud til alle kontakter.

![Når du har tilføjet modtagere til udsendelsen, kan du se, om de har givet samtykke til den type udsendelse. -screenshot][img2]

Hvis funktionen Beskyttelse af personoplysninger for E-Marketing er slået FRA, betyder det, at SuperOffice CRM vil se bort fra samtykker og abonnementspræferencer, når du sender dine mails. Hvis du vil aktivere funktionen Beskyttelse af personoplysninger for e-marketing, skal du have administratorrettigheder.

Hvis du vil vide mere, kan du se videoen om, hvordan du kan konfigurere privatlivsindstillingerne for GDPR i SuperOffice CRM.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/1e0ZIUwX3IY?list=PL9fefjwA0X290ZZ8bMUHWh_d6s3Y2P0Jr]

![Under Indstillinger og vedligeholdelse kan du aktivere funktionen til beskyttelse af personoplysninger for e-marketing. -screenshot][img3]

## Bruge afmeldingslinket

Nogle gange skifter folk mening om, hvilke e-mails de vil modtage. Når det sker, bør de have mulighed for at fravælge den type mail, du har sendt dem. Derfor følger der et afmeldingslink med alle mailskabeloner i SuperOffice CRM.

> [!TIP]
> Hvis du vil sende en mail om at Administrere abonnement til en kontakt, se [Sende mail om beskyttelse af personoplysninger][3].

Hvis du klikker på dette link, kommer modtagerne til siden med abonnementspræferencer, hvor de kan vælge den type mailudsendelser, de vil modtage. De ændringer, dine kontakter foretager, gemmes, så snart de bekræfter de nye indstillinger.

![Vælg de e-mails, du gerne vil modtage, på siden med abonnementspræferencer. -screenshot][img4]

Dine kunder kan selv styre, hvilke mails de modtager, og du kan sikre dig, at du kun sender mails ud til de personer, der er interesserede. Med SuperOffice CRM respekterer du dine kontakters kommunikationspræferencer og kan sikre, at du arbejder inden for reglerne i GDPR. På den måde risikerer du aldrig at få en bøde på 20.000.000 euro.

## Relateret

* [GDPR og beskyttelse af personoplysninger][2]
* [Erklæring om beskyttelse af personoplysninger for SuperOffice][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../security/privacy/learn/index.md
[3]: ../../../security/privacy/learn/send-privacy-confirmation-email.md
[4]: https://www.superoffice.com/company/privacy/
[5]: ../../tracked-links/learn/define-link-actions.md#interests

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/setup-type-drop-down.png
[img2]: ../../../../media/loc/en/marketing/recipients-content-status.png
[img3]: ../../../../media/loc/en/marketing/e-marketing-privacy-feature.png
[img4]: ../../../../media/loc/en/marketing/subscription-preferences-page.png
