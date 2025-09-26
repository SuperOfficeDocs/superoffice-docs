---
uid: help-sv-flow-split
title: Flödeskontroll - delning
description: Flödeskontroll - delning
keywords: flöde, flödeskontroll, dela flöde, dela, delning, delningssteg, gren, grenvillkor, segmentera, alla andra, utträdesvillkor, differentiera
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Flödeskontroll - delning

Ett delningssteg delar flödets deltagare i 2 eller flera grenar baserat på en eller flera villkor. Detta gör att du kan använda alternativa vägar och behandla deltagare olika baserat på kontaktdata eller engagemang.

Du kan differentiera baserat på:

* Företags/kontaktdatan
* Formulärinskick
* Formulärdata
* Länkklick (spårad)
* Medlemskap i projekt
* Medlemskap i statisk urval

## Hur det fungerar

När deltagaren når delningen, utvärderas villkoren för **vänstersta** grenen först. De kan endast följa en väg. Om det finns en matchning, fortsätter de till nästa steg i den grenen. Sedan kontrolleras nästa grenvillkor, och så vidare. Alla delningar har en gren för alla som inte uppfyller något av villkoren.

## Steg

1. Dra **Dela**-rutan från stegmenyn och släpp den i en tillgänglig plats i flödesschemat.
2. Ange en beskrivande **titel**.

    > [!TIP]
    > En beskrivande rubrik och grennamn gör flödet lättare att läsa.

3. Välj vad delningen ska baseras på. Vissa alternativ kräver att du anger ytterligare detaljer här.
4. Namnge den nya grenen.
5. Ange grenspecifika kriterier. Alternativen beror på vad du baserade delningen på.
6. Lägg till fler grenar efter behov och upprepa steg 4-5.
7. Välj om deltagare som inte matchar något kriterium ska lämna flödet.
8. Fortsätt att lägga till steg för varje gren.

Alla andra fortsätter:

![Marknadsföringsautomatisering: dela flödet baserat på kontaktdata -screenshot][img1]

Alla andra lämnar:

![Marknadsföringsautomatisering: dela flödet baserat på kontaktdata -screenshot][img2]

> [!NOTE]
> Du kan inte ta bort "alla andra" grenen.

### Dela baserad på kontaktdata

När du väljer att dela deltagare baserat på kontaktdata kan du välja från kriterierna för kontakt och företag som finns tillgängliga i **Sök kontakt**.

* För varje gren, [välj värden för kriterierna][11] i olika fält på raden (liknande i Sök-skärmen). Klicka på **Lägg till** för att lägga till fler kriterier.

![Marknadsföringsautomatisering: dela flödet baserat på företagsdata -screenshot][img3]

### Dela baserad på klickad länk

När du väljer detta, visas ett fält för att ange vilket e-postmeddelande som ska användas.

* E-post: Välj **Vilket som helst e-postmeddelande** eller ett specifikt utskick.
* För varje gren, välj vilken [spårningslänk][7] deltagaren måste klicka på för att komma in i den grenen.

![Marknadsföringsautomatisering: dela flödet baserat på klickad länk -screenshot][img4]

### Dela baserad på formulär inskickad ja/nej

När du väljer detta, visas ett fält för att ange vilket formulär som ska användas.

* Formulär: Välj ett specifikt formulär.

![Marknadsföringsautomatisering: dela flödet baserat på inskickat formulär -screenshot][img5]

> [!NOTE]
> Denna delning är oberoende av vilka formulärdata som skickades in. Det finns inga grenspecifika inställningar. Eftersom detta är ett ja/nej-test kan du inte lägga till fler grenar.

### Dela baserad på formulärdata

Denna villkor är en variant av inskickningsbaserad delning med ytterligare datakriterier som tillämpas på grenen.

När du väljer detta, visas ett fält för att ange vilket formulär som ska användas.

* Formulär: Välj ett specifikt formulär.
* För varje gren, välj värden för kriterierna i olika fält på raden (liknande i Sök skärmen). Tillgängliga kriterier beror på de valda formulärfälten. Klicka på **Lägg till** för att lägga till fler kriterier.

![Marknadsföringsautomatisering: dela flödet baserat på formulärdata (kontakta mig) -screenshot][img6]

> [!NOTE]
> I detta scenario betyder "alla andra" både deltagare som inte skickade in formuläret *och* de som skickade in formuläret men inte uppfyller ytterligare kriterier på någon av de andra grenarna.

### Dela baserad på projektmedlemskap

* För varje gren, välj vilket projekt deltagaren måste vara medlem i.

![Marknadsföringsautomatisering: dela flödet baserat på projektmedlemskap -screenshot][img7]

### Dela baserat på statisk urval

Liknande delning baserat på projektmedlemskap.

## Framgångskriterier som används som tidig utträdesvillkor

Framgångskriterier kan också användas som ett tidigt utträdesvillkor i flödet, vilket eliminerar behovet av delning. Innan någon åtgärd utförs på en deltagare i ett flödesteg, omvärderas deltagarens status. Denna omvärdering beaktar framgångskriterierna. Om en deltagare uppfyller framgångskriterierna, uppdateras deras status till *Slutförd med framgång*, eller de fortsätter som *Pågåande* om de ska slutföra flödet. Vid slutförsteg kommer deltagare som har uppfyllt framgångskriterierna att ha status *Slutförd med framgång*.

<!-- Referenced links -->
[7]: ../../tracked-links/learn/index.md
[11]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/split-flow-contact-data-no-exit.png
[img2]: ../../../../media/loc/en/marketing/split-flow-contact-data-yes-exit.png
[img3]: ../../../../media/loc/en/marketing/split-flow-company-data-dropdown.png
[img4]: ../../../../media/loc/en/marketing/split-flow-link-clicked.png
[img5]: ../../../../media/loc/en/marketing/split-flow-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/split-flow-form-data-contact-me.png
[img7]: ../../../../media/loc/en/marketing/split-flow-project-member.png
