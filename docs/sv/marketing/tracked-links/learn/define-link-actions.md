---
uid: help-sv-define-link-actions
title: Definiera länkningsåtgärder
description: I den här guiden lär du dig hur du använder länkar i utskick för att automatisera åtgärder.
keywords: utskikt, länkåtgärd, automatisera
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Använd länkar för att automatisera olika åtgärder

Uppdatering av 500 kontaktkort manuellt är tidskrävande och onödigt. Automatiserade länkåtgärder kan effektivisera denna process.

Så här fungerar automatiserade länkåtgärder:

* En mottagares klick på en CTA-länk kan automatiskt lägga till dem i ett urval eller ett projekt i SuperOffice CRM.
* SuperOffice CRM kan automatiskt uppdatera relevant information, som intressen, på kontaktkortet.

Automatisering sparar tid som annars skulle spenderas på att hantera svar. När en läsare klickar på en länk i din utskick, utför systemet länkåtgärder åt dig!

Du kan dra nytta av den insamlade informationen på flera sätt:

* Generera ett urval baserat på vem som klickade på en specifik länk och skicka ett riktat svar till denna grupp med ett anpassat meddelande.
* Planera uppföljningsaktiviteter för dina teammedlemmar att personligen engagera sig med respondenter.
* Skapa serviceärenden till ditt kundtjänstteam för att plocka upp och undersöka.

![Definiera dina länkåtgärder -screenshot][img3]

## Tillgängliga åtgärder

Baserat på din utskicks mål och CTAkan du uppdatera din databas. Denna information kan förbättra segmenteringen eller hjälpa till att följa upp med intresserade individer. Du kan välja mer än en åtgärd för en spårad länk.

| Flik | Åtgärd |
|---|---|
| [Svar](#response) | Lägg till landningssida eller återkopplingstext, eller öppna ett formulär. |
| [Konfigurera fält](#set-field) | Lägg till ett värde till ett [extrafält][5] för kundkontakter |
| [Intressen](#interests) | Uppdatera intressen. |
| [Urval/projekt](#selection) | Lägga till eller ta bort kontakt från urval eller projekt. |
| [Uppföljning](#follow-up) | Skapa en uppföljning (uppgift eller möte) i SuperOffice CRM. |
| [Ärende](#request) | Skapa ett nytt ärende. |
| [Skript](#script) | Köra ett skript. |

> [!TIP]
> När du uppdaterar en spårad länk, kom ihåg att den kan användas av flera e-postmeddelanden och/eller automatiserade flöden. Du bör säkerställa att det inte finns några duplicerade eller motstridiga åtgärder.

## <a id="response"></a>Svar

Välj vad som ska hända när mottagaren klickar på länken.

* **Dirigera om till ny webbplatsa**: Ange URL:en i det angivna fältet.
* Eller, **Visa återkopplingstext**: Ange texten som ska visas. Klicka på <i class="ph ph-text-a-underline" aria-hidden="true"></i> för att visa verktygsfältet för rik text.
* Eller, **Öppna formulär**: Välj namnet på formuläret. Välj eventuellt vilka fält som ska förifyllas med kända kontaktuppgifter.

## <a id="set-field"></a>Konfigurera fält

På fliken **Konfigurera fält** kan du ange ett värde som ska läggas till i ett extrafält när mottagaren klickar på länken. Detta registrerar ytterligare kundinformation.

Välj ett fält och ange ett värde.

## <a id="interests"></a>Intressen

Ange att ett länkklick ska ändra kontaktens intressen. Till exempel, lägg till intresset "Produktnyheter" om länken "Ja tack! Jag vill veta mer om nya produkter" klickas, eller ta bort det om länken "Avsluta prenumeration" klickas.

* **Ange intresse**: välj ett intresse som ska läggas till för kontakterna när de klickar på länken.
* **Ta bort intresse**: välj ett intresse som ska tas bort för kontakterna när de klickar på länken.

[Hur du skapar ett anmälningsformulär för nyhetsbrev][1]

## <a id="selection"></a>Urval/Projekt

Ange att mottagare som klickar på länken kommer att läggas till eller tas bort från urval eller projekt. Börja skriva ett namn för att starta en snabbsökning.

## <a id="follow-up"></a>Uppföljning (möte/uppgift)

På fliken **Uppföljning** kan du ställa in att ett länkklick ska generera möten eller uppgifter i SuperOffice CRM. Välj uppföljningstyp, ange en beskrivning, länka den till ett projekt, välj uppgiftstyp, tilldela ansvar och ställ in varaktigheten.

Aktivera denna funktion genom att välja **Uppföljning**.

[Hur du skapar en uppföljning][4]

> [!TIP]
> Som beskrivning, ange vilken utskick den avser, vilken länk mottagaren klickade på och eventuellt hur uppgiften eller mötet ska följas upp.
>
> När du ställer in **Skapad av** eller **Standardmottagare** kan du klicka på knappen **Välj aktiv användare** (<i class="ph ph-user-circle" aria-hidden="true"></i>) för att välja dig själv.

## <a id="request"></a>Ärende

På fliken **Ärende** kan du ställa in att ett länkklick ska skapa ett ärende. Markera rutan för att registrera ett nytt ärende, ange en titel, välj prioritet och kategori, och välj ägaren. Du kan även välja **Tilldelas automatiskt** eller **Otilldelat**.

[Hur du skapar ett ärende][3]

## <a id="script"></a>Skript

På fliken **Skript** kan du välja ett CRMSkript eller makro som ska köras när länken klickas på. Aktivera denna funktion genom att välja **Kör skript**, och välj sedan det önskade skriptet från listan.

Variabler tillgängliga i skriptet inkluderar custId, linkId, shipmentId, linkUrl, linkHits, och returnUrl.

[Hur du skapar eller redigerar ett CRMScript][6]

<!-- Referenced links -->
[1]: ../../forms/learn/tutorial-sign-up.md
[3]: ../../../request/learn/create.md
[4]: ../../../diary/learn/create-follow-up.md
[5]: ../../../custom-objects/learn/extra-field.md
[6]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
