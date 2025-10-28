---
uid: help-sv-flow-create
title: Skapa ett nytt flöde
description: Hur man skapar ett nytt flöde och definierar flödesinställningar i SuperOffice Marketing
keywords: flöde, Flödesredigerare, flödesfält, trigger, flödeskontroll, exkluderingslista, prenumerationstyp, tidsram, framgångskriterier, väntetid, vänta på åtgärd, flödesschem, kontaktfilter
author: Bergfrid Dias, Trude Lien Smedbråten
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

# Skapa ett nytt flöde

## Steg

1. Välj **Marknadsföring** i Navigatorn.
1. Gå till fliken **Flöden**.
1. Om det behövs, klicka på **Lägg till mapp** för att [skapa en mapp för flödet][8].
1. Klicka på knappen **Flöde** under **Skapa nytt** på höger sida av skärmen.
1. I dialogrutan **Flödesredigerare**, ange ett kort, beskrivande **Namn**.
1. [Fyll i fälten](#fields) enligt beskrivningen nedan. Kom ihåg att klicka på **Spara** regelbundet för att spara ditt arbete. Flödet sparas inte automatiskt.
1. [Definiera flödets triggers och filter.](#trigger)
1. [Lägg till steg.](#add-step)
1. Ange vad som händer när flödet avslutas.
1. Klicka på **Spara** när du är klar.

![Ange egenskaper för nytt flöde -screenshot][img1]

## <a id="fields"></a>Fylla i flödesfält

### Inställningar (för flöde)

| Inställning | Beskrivning |
|---|---|
| Namn | En beskrivande etikett. |
| Beskrivning | Förklara syftet med flödet. Denna text är endast synlig internt. |
| Tidszon | Krävs för att begränsa sändningstiden. |
| När kontakten har registrerats, ta bort denna från dessa andra flöden | Om markerat ändras deltagarens status till *Bortfall* och de lämnar de valda flödena. Exempel: ta bort från Lead nurturing när inskriven i Onboarding-flödet. |
| Ägare | Associerad som skapar flödet. |
| Synlig för | Åtkomst till flödet (ägare, ägarens grupp, alla). Åtkomstnivå kontrolleras också av funktionella rättigheter. |
| Mapp | Platsen för flödet. |

### E-post (inställningar)

Vanliga e-postinställningar för alla e-postmeddelanden i flödet. Om du inte planerar att skicka e-post från detta flöde kan du hoppa över att fylla i dessa inställningar.

| Inställning | Beskrivning |
|---|---|
| Prenumerationstyp | Ställs in på flödesnivå (istället för individuellt på varje e-poststeg). Säkerställer att alla e-postmeddelanden inom ett flöde har samma prenumerationstyp. |
| Från, från namn, från adress | Samma avsändare på alla e-poststeg inom flödet. I **Från**-listan, välj **Använd alltid** och ange avsändarens e-postadress i fältet nedan för att använda samma avsändare för alla utskick. Du kan också välja en säljkontakt eller supportkontakt som avsändare, om en sådan är definierad för denna mottagare. Ange en e-postadress som ska användas om ingen säljkontakt eller supportkontakt är tillgänglig. Om din administratör har aktiverat [den globala e-postvalideringsinställningen][12], välj den domän du vill skicka från i rullgardinsmenyn. |
| Svara till | Samma alternativ som ovan. Dessutom kan du välja **Använd "Från" som svarsadress**. Alla svar skickas då till avsändaren. |
| Skicka endast e-post och SMS inom en specifik tidsram | Begränsar sändningstiden. Deltagarna väntar i detta steg tills den tillåtna tidsramen börjar. Välj mellan Arbetsdag (Mån-Fre) och Veckodag (Mån-Sön). Ange tid. Kräver att tidszonen är inställd. |
| Använd Google Analytics | Aktiverar Google Analytics-spårning för alla e-postmeddelanden i ett flöde. När det är markerat kan du ställa in källa och kampanj. |

> [!TIP]
> Timing påverkar e-postens öppningsgrad och interaktion. Använd inställningen **tidsram** för att maximera läsarinteraktionen och för att inte störa dina prenumeranter under natten.

![Ställ in gemensamma e-postinställningar för nytt flöde -screenshot][img2]

### Framgångskriterier (valfritt)

Framgångskriterier definierar [vad framgång betyder för ett flöde][7].

1. Välj **Framgång** från vänstermenyn.
1. Klicka på **Lägg till framgångskriterier** och välj ett alternativ.
1. Välj eventuellt **Deltagare flyttas direkt till Slutfördssteget när framgångskriterierna är uppfyllda**.

    * Om markerad: Deltagarens status ändras till *Slutförd med framgång* och de lämnar alla andra åtgärder senare i flödet.

    * Om inte markerad: Deltagarens status förblir *Pågåande* och de fortsätter att följa flödet. När de når **Slutfördssteget** ändras deras status till *Slutförd med framgång*. Använd detta alternativ om framgångsgraden huvudsakligen används för statistik, och du vill att deltagaren ska slutföra alla steg även om framgång nås.

![Ställ in framgångskriterier för nytt flöde -screenshot][img3]

## <a id="trigger"></a>Definiera flödets triggers och filter

**Trigger**-steget läggs automatiskt till som startpunkt för alla flöden. Det avgör vem flödet är relevant för. Triggers aktiveras endast för körande eller pausade flöden.

> [!NOTE]
> Det är möjligt att skapa ett flöde utan någon automatiserad trigger - genom att använda kontaktuppgiftsmenyn eller en urvalsuppgift. Vi kommer att diskutera detta specialfall i ett annat ämne.

1. Välj **Steg** från vänstermenyn.
1. Klicka på **Trigger**-steget i flödesschemat.
1. I triggerinställningarna på höger sida, klicka på **Lägg till trigger** och välj ett alternativ.
1. Ange de nödvändiga inställningarna för den valda triggern.
1. Specificera eventuellt ytterligare kvalifikationskriterier.
1. Välj eventuellt **En kontaktperson kan endast starta detta flöde en gång**. Om ett flöde triggas en andra gång på samma kontakt säkerställer denna inställning att de inte återigen registreras.

![Lägg till trigger för nytt flöde -screenshot][img5]

| Trigger | Beskrivning |
|---|---|
| Kontakten har skapads | När en ny kontakt registreras, oberoende av källa (utom import). |
| Kontakt uppdaterad | När en kontakt uppdateras, oberoende av vad som uppdateras (utom import och massuppdatering). |
| Försäljning skapat | När en försäljning registreras på kontakten. |
| Försäljning sålt | När en försäljning på kontakten sätts till såld. |
| Försäljning förlorat | När en försäljning på kontakten sätts till förlorad. |
| Tillagd till projekt | När kontakt läggs till som projektmedlem. |
| Ärende skapat | När ett ärende skapas på kontakten (oberoende av källa). |
| Formulär inskickat | När ett formulär (inskickat av en kontakt) **bearbetas** (ett manuellt steg kan vara involverat innan kontakten hamnar i flödet). |
| Klickat på länk | När en kontakt klickar på en spårad länk. |

**Observera:**

* Om du väljer *formulär inskickat* eller *klickat på länk*, var uppmärksam på eventuella varningsikoner. Formulär och spårade länkar kan också ha associerade åtgärder.
* För att inkludera kontakter som skapats eller uppdaterats genom en import måste du manuellt lägga till importerade kontakter från urvalet till ett flöde.
* När du triggar på kontakt uppdaterad, har vi tillgång till de aktuella värdena för kontaktfält. Vi har dock ingen information om vilket fält som uppdaterades eller det tidigare värdet av ett fält före uppdateringen.

### Lägg till kontaktfilter (valfritt)

**Filter** är ytterligare regler som tillämpas på alla föreslagna deltagare (automatiskt och manuellt tillagda). Använd kontaktfiltret för att välja specifika kontakter för ditt flöde. Till exempel, ställ in filtret till *kontaktkategori = prospekt* för att endast tillåta prospekts in i flödet, inte befintliga kunder, som fyller i ett formulär på din webbplats. Detta gör att du kan anpassa innehållet till olika användargrupper.

> [!NOTE]
> Filter tillämpas endast när **nya flödesdeltagare identifieras**. Eventuella ändringar som görs i filtret efteråt påverkar inte redan registrerade deltagare.

1. Välj kontaktfältet du vill filtrera på.
1. [Välj värden för kriteriet][13] i de olika fälten på raden (liknande som i Sök-skärmen).
1. Klicka på **Lägg till** för att ställa in ytterligare kriterier (lägger till en ny rad).

![Lägg till kontaktfilter på trigger för nytt flöde -screenshot][img6]

### Exkluderingslista (valfritt)

Exkluderingslistan **förhindrar att utvalda kontakter läggs till i flödet**. Använd ett [statisk urval][14] för att hantera undantag, som till exempel:

* Förhindra specifika kunder från att få allmänna massutskick.
* Skicka påminnelser, men inte till dem som redan har anmält sig.

## <a id="add-step"></a>Lägg till steg

1. Välj **Steg** från vänstermenyn.
1. Välj ett steg och dra det till där du vill lägga till det i flödesschemat.
1. Stegmenyn ändras till **steginställningar**. [Tillgängliga inställningar][9] beror på stegets typ.

    * [Skicka meddelande][3]
    * Flödeskontroll
    * [Uppdatera deltagare][4]
    * [Skapa aktivitet][5]
    * [Interna åtgärder][10]

Klicka på X i steginställningarnas header för att återgå till stegmenyn.

### Det första steget

När du öppnar fliken **Steg** för första gången kommer du att se något liknande detta:

![Flödesscheman -screenshot][img4]

* Ett flödesschema med en **Trigger**, en **platshållare** för att lägga till ett steg och ett **Slutfördssteg** (i mitten).
* En lista över tillgängliga stegtyper (till höger).

## <a id="wait"></a>Flödeskontroll

De flesta steg i ett flöde representerar åtgärder relaterade till deltagaren, såsom att uppdatera kontaktintressen. Men flödeskontrollsteg är annorlunda; de involverar **timing** och **segmentering**.

Utan flödeskontroll skulle individer gå från en åtgärd till en annan tills de antingen hoppar av eller når slutet av flödet. Till exempel, de kanske får hela introduktionsprogrammet på en enda dag eller får alla nyhetsbrev samtidigt.

Dessutom, utan flödeskontroll, skulle alla registrerade följa samma sekvens av steg. Även om detta kanske är lämpligt för ett enkelt flöde, kan du genom att ställa in villkor för efterföljande åtgärder, till exempel, skicka ett nyhetsbrev på kontaktens föredragna språk eller skicka en feedbackundersökning endast till dem som deltog i webbinariet.

**Alternativ:**

* Väntetid
* Vänta på åtgärd
* [Dela][1]

> [!NOTE]
> Deltagare markeras med en **väntar till**-timestamp när de når ett väntesteg. Om nästa steg är ett e-postmeddelande eller SMS och en begränsad tidsram är angiven i e-postinställningarna, kan den totala väntetiden överstiga vad som är inställt i steget.

### Väntetid

Använd ett tidsbaserat väntesteg för att vänta ett specifikt antal dagar innan du skickar nästa e-post/SMS, eller för att vänta till ett specifikt datum för specifika tillfällen eller åtgärder. Till exempel, för att skicka påminnelser 1 vecka, 1 dag och 1 timme före ett webbinarium.

1. Dra rutan **Väntetid** från stegmenyn och släpp den i en tillgänglig plats i flödesschemat.
1. Ställ in villkoret. Gör ett av följande:

    * Välj **Antal dagar/timmar efter föregående steg** och välj sedan antal och enhet.
    * Eller, välj **Fram till specifikt datum/tid** och välj sedan ett datum från kalendern.

Aktiva flödesdeltagare stannar vid detta steg innan de går vidare till nästa steg enligt den definierade regeln.

![Flödessteg väntetid -screenshot][img7]

### Vänta på åtgärd

Använd ett åtgärdsbaserat väntesteg för att vänta på att deltagaren ska göra något (skicka in ett formulär eller klicka på en länk).

1. Dra rutan **Vänta på åtgärd** från stegmenyn och släpp den i en tillgänglig plats i flödesschemat.

2. Klicka på **Lägg till åtgärd** och välj vilken åtgärd att vänta på.

3. Från listan, välj namnet på länken eller formuläret att vänta på.

4. Ange hur länge du är villig att vänta på någon åtgärd (en timeout). Standard maximal väntetid är 7 dagar. Om du avmarkerar denna inställning, kommer deltagare som inte svarar att vara fast vid detta steg på obestämd tid.

5. Välj eventuellt **Avsluta flöde om inga åtgärder vidtas inom maximal väntetid**. Deltagare som inte svarar kommer att lämna flödet med status *Bortfall*. Du kan välja att flytta dem till ett annat flöde och/eller lägga till dem i ett statisk urval.

![Flödessteg vänta på åtgärd -screenshot][img8]

> [!TIP]
> Du kan vänta på mer än en åtgärd inom ett enda steg. Den första förekommande åtgärden (formulärinlämning, länk klick eller timeout) flyttar deltagaren vidare i flödet. Upprepa helt enkelt steg 2 och 3 ovan.

## Vad händer nu?

Efter att ha designat ett flöde och sparat det, stängs **Flödesredigeraren** och flödesschemat visas i skärmen **Visa flöde**. Det nya flödet har status **Inte körande** tills en flödesadministratör manuellt startar det genom att växla Körs = true.

## Relaterat innehåll

* [Flytta, duplicera eller ta bort steg][2]
* [Definiera flödets åtgärder][3]
* [Dela flöde][1]
* [Starta flöde][6]

<!-- Referenced links -->
[1]: split.md
[2]: update.md
[3]: define-flow-actions.md
[4]: define-flow-actions.md#update
[5]: define-flow-actions.md#create
[10]: define-flow-actions.md#internal
[6]: run-pause-end.md
[7]: index.md#success
[9]: step-settings.md
[8]: ../../learn/create-folder.md
[12]: ../../mailing/admin/add-domain.md
[13]: ../../../search-options/learn/search-criteria.md
[14]: ../../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-settings.png
[img2]: ../../../../media/loc/en/marketing/flow-email-settings.png
[img3]: ../../../../media/loc/en/marketing/flow-success-form-submission.png
[img4]: ../../../../media/loc/en/marketing/flow-steps-initial.png
[img5]: ../../../../media/loc/en/marketing/trigger-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/flow-trigger-filter-contact.png
[img7]: ../../../../media/loc/en/marketing/flow-wait-time.png
[img8]: ../../../../media/loc/en/marketing/flow-wait-action.png
