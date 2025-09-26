---
uid: help-sv-mailing-tracked-links
title: Spårade länkar
description: En länk som du inkluderar i ett utskick kan användas för att spåra svar från dina befintliga och potentiella kunder. När mottagarna av ditt utskick klickar på länken utförs en åtgärd.
keywords: Marknadsföring, sporade länker
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /sv/marketing/tracked-links/learn/examples
language: sv
---

# Spårade länkar

De länkar du använder i ditt nyhetsbrev eller e-postkampanj bestäms av dina mål. Varje mål har en unik handlingsuppmaning som utlöser en respons från mottagaren, vilken du kan spåra. Detta gör det möjligt för dig att följa upp med dina mottagare när du har samlat in alla resultat.

Till exempel kan ett klick på en länk öppna en ny webbplats eller uppdatera en mottagares kontaktinformation. Den kan också lägga till ett [serviceärende][8].

Du kan skapa ofta använda länkar även innan du skapar innehållet. Detta gör att du kan återanvända dessa länkar och spara tid. Vanligt använda länkar inkluderar:

* Sidor för avregistrering
* Kontaktformulär
* Sociala mediekanaler

![I fönstret Länkegenskaper kan du lägga till länkar som du vill spåra -screenshot][img4]

URL-adresserna måste vara unika för varje mottagare så att du kan vara säker på att det är olika mottagare som har klickat på dem och inte samma mottagare som har klickat flera gånger. Dessutom måste URL-adresserna peka mot SuperOffice-servern så att besökarna kan räknas innan de omdirigeras till den faktiska URL-adressen. Detta sköter programmet automatiskt när du väljer vilka URL-adresser i meddelandet som du vill spåra.

## Vilka länkar spårar jag?

Om du vill [visa alla länkar i ett utskick][4] kan du öppna utskicket i visningsläge och välja fliken **Spårade länkar**.

## Fliken Spårade länkar

På fliken **Spårade länkar** har du följande alternativ:

| Ikon | Alternativ | Läs mer |
|:-:|---|---|
| <i class="ph ph-plus" aria-label="Plus"></i> | Lägga till | [Skapa en ny länk][1], [Definiera länkningsåtgärder][7] |
| <i class="ph ph-folder" aria-label="Folder"></i> | Lägg till mapp | [Skapa en mapp][5] för dina länkar |
| Länk | Klicka på en länk om du vill öppna skärmen **Visa länk**. | [Jobba med spårade länkar efter utskicket][2] |
| <i class="ph ph-list" aria-label="Task menu"></i> | Meny | Klicka på menyknappen bredvid en länk för att få tillgång till fler alternativ. |

Menyalternativ:

* [**Visa**][2]
* [**Redigera**][1]
* [**Återställ**][10] (reknare för länkar)
* **Flytta till mall** (flytta länken till en annan mapp)
* **Ta bort**

## <a id="ex"></a>Use cases

Sporbara länkar kan användas på olika sätt:

* **Respons**: Registrera varje mottagares klick på en länk, som en ny produktsida, för att mäta intresset över flera utskick.

* **Prospektlista**: För en lansering av en ny produkt kan mottagare uttrycka intresse genom att klicka på länken "Ja tack, jag vill få ett erbjudande". Klickare kan läggas till i ett [statisk urval][9] för att hantera den fortsatta kontakten med dessa kunder.

* **CRM-händelse**: Istället för en prospektlista kan du generera en att-göra eller möte för varje länkklick och tilldela det till en säljare eller kundkontakt. Till exempel kan ett klick på länken "Kontakta mig" generera en uppföljning med "Telefon ut".

* **Avsluta prenumeration**: Infoga en [avslutningslänk][4] i innehållsredigeraren för att stoppa en specifik typ av utskick. Alternativt kan kunder avsluta prenumerationen från individuella mottagarlistor.

    Lägg till en länk (till exempel "Klicka här om du inte vill ha fler nyhetsbrev från oss") för att ta bort kunder från mottagarlistan. Om ett nyhetsbrev endast skickas till kontakter med intresse för "Nyhetsbrev" kan detta intresse tas bort för länkklickare.

    > [!TIP]
    > Övervaka prenumerationsavslut genom att lägga till länkklickare i ett separat urval, till exempel "Nyhetsbrev 2024 - avslutade prenumerationer". Flera åtgärder kan läggas till samma länk.

* **Boka konsult**: För en stor produktuppdatering, lägg till en länk för kunder att boka en konsult. Varje länkklick registrerar ett nytt ärende, tilldelad till kategorin "Konsult". Kunden får feedback att de kommer att bli kontaktade av en konsult.

> [!NOTE]
> Dessa exempel fungerar lika bra för vanliga länkar, men i det fallet registreras endast klick för det enskilda utskicket.

## <a id="google"></a>Google Analytics

När du konfigurerar ett utskick har du möjlighet att använda Google Analytics som spårningssystem. Med inställningen i utskick kan du definiera en mer exakt spårning av e-postmeddelanden med hjälp av de tillhandahållna fälten, vilket ger mer detaljerade Google Channel-rapporter.

Google Analytics är den mest populära programvaran för digital analys som finns tillgänglig. Genom att spåra hur webbplatsbesökare hittar och använder din webbplats ger tjänsten ditt företag användbara insikter som hjälper dig att nå ökad framgång för dina marknadsföringsstrategier online.

Som standard identifierar Google Analytics inte besökare som kommer från specifika utskick. Du måste lägga till en tagg i länkarna i ditt e-postmeddelande för att kunna:

* Identifiera vilka länkar dina mottagare har klickat på,
* Se vilka webbsidor de besökte efter att de hamnade på din webbplats.

När du lägger till en länk till din webbplats i ditt utskick utan tagg kan du se att dina besökare kommer från ett utskick, men du vet inte vilket specifikt utskick. Det gör att du inte vet hur mottagarna av specifika utskick agerar på din webbplats.

Google Analytics-funktionen i SuperOffice Marknadsföring identifierar dina utskick i rapporterna. Genom att lägga till en unik tagg till alla länkar du använder i ditt utskick kommer Google Analytics att känna igen ditt utskick som källan varifrån webbplatsbesökarna kommer. Google Analytics ger dig också insikt i besökarnas sökväg på din webbplats.

**Medel**: "E-post" det förvalda mediet i automatiserade UTM-taggar. Det innebär att spårade länkar i utskick som skickas från SuperOffice finns i Google Channel-rapporter under "E-postadresser" (i motsats till "annat").

**Källa** och **Kampanj**: Dessa fält identifierar just detta utskick som källan, och möjliggör en mer exakt spårning och rapportering i Google.

## Relaterat innehåll

* [Inkludera länkar som du vill kunna spåra][3]
* [Lägg till prenumerationslänkar][4]
* [Simple Google Analytics e-mail tracking][6]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[7]: define-link-actions.md
[6]: ga-tutorial.md
[10]: reset-counter.md
[3]: ../../editor/learn/add-tracked-link-to-msg.md
[4]: ../../editor/learn/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[8]: ../../../request/learn/index.md
[9]: ../../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/link-properties.png
